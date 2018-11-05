using System;
using System.Collections.Generic;
using System.Threading;

namespace ObjectPool
{
    /// <summary>
    /// The Pool containing Objects
    /// </summary>
    public static class Pool
    {
        private static readonly IList<PooledObject> Available = new List<PooledObject>();
        private static readonly IList<PooledObject> InUse = new List<PooledObject>();

        public static void CleanUp(PooledObject pooledObject)
        {
            pooledObject.TempData = null;
        }

        public static PooledObject GetObject()
        {
            lock (Available)
            {
                PooledObject pooledObject;
                if (Available.Count == 0)
                {
                    pooledObject = new PooledObject();
                    InUse.Add(pooledObject);
                    Console.WriteLine("Pool Object Created.");
                }
                else
                {
                    pooledObject = Available[0];
                    InUse.Add(pooledObject);
                    Available.RemoveAt(0);
                    Console.WriteLine("Pool Object Reused.");
                }
                return pooledObject;
            }
        }

        public static void ReleaseObject(PooledObject pooledObject)
        {
            CleanUp(pooledObject);
            lock (Available)
            {
                InUse.Remove(pooledObject);
                Available.Add(pooledObject);
                Console.WriteLine("Pool Object Released.");
            }
        }
    }
}