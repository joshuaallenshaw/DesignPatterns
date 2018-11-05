using System;
using System.Collections.Generic;
using System.Threading;

namespace ObjectPool
{
    /// <summary>
    /// The object to be pooled.
    /// </summary>
    public class PooledObject
    {
        public DateTime CreatedAt { get; } = DateTime.Now;

        public string TempData { get; set; }
    }
}