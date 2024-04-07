/*
using System;

namespace HelloWorlds
{
    internal class Program
    {
        static int AccessibleInt = 7;
        static void Main(String[] args)
        {
            
            int accessibleInt = 5;
            Console.WriteLine(accessibleInt);
            Console.WriteLine(AccessibleInt);
            int[] intsToCompress = new int[] {10, 15, 20, 25, 30, 12, 34};
            

            // ____________________ Method 1st ____________________

            // int totalValue = 0;

            // foreach(int intForCompression in intsToCompress)
            // {
            //     if (intForCompression > 20)
            //     {
            //      totalValue += intForCompression;
            //     }
            // }

            // Console.WriteLine(totalValue);

            DateTime startTime = DateTime.Now;

            int totalValue = intsToCompress[0] + intsToCompress[1] 
            + intsToCompress[2] + intsToCompress[3]
            + intsToCompress[4] + intsToCompress[5]
            + intsToCompress[6];

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

            Console.WriteLine("no. 1 -> " + totalValue);

            // ____________________ Method 2nd ____________________
            totalValue = 0;

            startTime = DateTime.Now;

            for (int i = 0; i < intsToCompress.Length; i++)
            {
                totalValue += intsToCompress[i];
            }

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

            Console.WriteLine("no. 2 -> " + totalValue);

            //  ____________________ Method 3rd ____________________

            totalValue = 0;
            startTime = DateTime.Now;

            foreach(int intForCompression in intsToCompress)
            {
                totalValue += intForCompression;
            }

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

            Console.WriteLine("no. 3 -> " + totalValue);

            // ____________________ Method 4th ____________________

            totalValue = 0;
            startTime = DateTime.Now;

            int index = 0;
            while(index < intsToCompress.Length)
            {
                totalValue += intsToCompress[index];
                index++;
            }

            // int i = 0;
            // while(i < intsToCompress.Length)
            // {
            //     totalValue += intsToCompress[i];
            //     i++;
            // }

            // while -> ถ้า true มันจะรันเรื่อย ๆ จนกว่าจะเจอ false แล้วถงหลุดออกจากวงจร

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

            Console.WriteLine("no. 4 -> " + totalValue);

            // ____________________ Method 5th ____________________

            totalValue = 0;
            startTime = DateTime.Now;

            // index = 0;

            do
            {
                index++;
            } while(index < intsToCompress.Length);

            // do -> ถ้า false มันจะรันเรื่อย ๆ จนกว่าจะเจอ true (while) แล้วถึงหลุดออกจากวงจร

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

            Console.WriteLine("no. 5 -> " + totalValue);

            startTime = DateTime.Now;

            totalValue = 0;

            totalValue = intsToCompress.Sum();

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

            Console.WriteLine("no. 5 -> " + totalValue);


        // method inner class
            startTime = DateTime.Now;

            totalValue = 0;

            totalValue = GetSum(intsToCompress);

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

            Console.WriteLine("no. 5 -> " + totalValue);

            int[] intsToCompress2 = new int[] {23, 23, 53, 56, 83, 92};

            totalValue = GetSum(intsToCompress2);
        
            Console.WriteLine(totalValue);

        }

        static private int GetSum(int[] compressableIntArray)
        {
            // int[] intsToCompress = new int[] {10, 15, 20, 25, 30, 12, 34};
            int totalValue = 0;
            foreach(int intForCompression in compressableIntArray)
            {
                totalValue += intForCompression;
            }

            return totalValue;

        }

    }
}
*/