using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Prototype
{
    [Serializable]
    internal class DeepCopyClone : Prototype
    {
        private int x;

        public DeepCopyClone()
        {
            Descendant = new Descendant();
        }

        public override Descendant Descendant { get; set; }
        public override int X { get => x; set => x = value; }

        /// <summary>
        /// Full Deep Copy by serializing then deserializing.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T DeepCopy<T>(T obj)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new Exception("The source object must be serializable.");
            }
            if (Object.ReferenceEquals(obj, null))
            {
                throw new Exception("The source object must not be null.");
            }
            T result = default(T);
            using (var memoryStream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(memoryStream, obj);
                memoryStream.Seek(0, SeekOrigin.Begin);
                result = (T)formatter.Deserialize(memoryStream);
                memoryStream.Close();
            }
            return result;
        }

        public override object Clone()
        {
            return DeepCopy<DeepCopyClone>(this);
        }

        public override void PrintValues()
        {
            Console.WriteLine("X Value: {0}\tY Value: {1}\tDeepCopyClone Hash: {2}\tDescendant Hash: {3}", X, Descendant.Y, this.GetHashCode(), Descendant.GetHashCode());
        }
    }
}