using System;
using System.Collections.Generic;
using System.Threading;

namespace ObjectPool
{
    public static class Pool
    {
        private static readonly IList<PooledObject> Available = new List<PooledObject>();
        private static readonly IList<PooledObject> InUse = new List<PooledObject>();

        public static void CleanUp(PooledObject obj)
        {
            obj.TempData = null;
        }

        public static PooledObject GetObject()
        {
            lock (Available)
            {
                PooledObject obj;
                if (Available.Count == 0)
                {
                    obj = new PooledObject();
                    InUse.Add(obj);
                    return obj;
                }
                obj = Available[0];
                InUse.Add(obj);
                Available.RemoveAt(0);
                return obj;
            }
        }

        public static void ReleaseObject(PooledObject obj)
        {
            CleanUp(obj);
            lock (Available)
            {
                InUse.Remove(obj);
                Available.Add(obj);
            }
        }
    }
}