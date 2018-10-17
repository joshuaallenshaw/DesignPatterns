using System;

namespace Prototype
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Prototype[,] protoArray = new Prototype[10, 2];

            protoArray[0, 0] = new ShallowCopyClone();
            protoArray[0, 1] = new DeepCopyClone();
            // Print the initial values X and Y will be equal

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    protoArray[0, 0] = new ShallowCopyClone();
                    protoArray[0, 1] = new DeepCopyClone();
                }
                else
                {
                    protoArray[i, 0] = (Prototype)protoArray[i - 1, 0].Clone();
                    protoArray[i, 1] = (Prototype)protoArray[i - 1, 1].Clone();
                }
                protoArray[i, 0].SetXY(i);
                protoArray[i, 1].SetXY(i);
                Console.WriteLine("----------------- {0} -----------------", i + 1);
                protoArray[i, 0].PrintValues();
                protoArray[i, 1].PrintValues();
            }
            Console.WriteLine("\nJust in case you didn't notice the hash valus, let's see those values again.");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("----------------- Just printing row {0} -----------------", i + 1);
                protoArray[i, 0].PrintValues();
                protoArray[i, 1].PrintValues();
            }
            Console.WriteLine("\nDid you notice the Y Value in that Shallow Copy?");
            Console.ReadKey();
        }
    }
}