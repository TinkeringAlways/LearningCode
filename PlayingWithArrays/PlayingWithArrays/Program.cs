using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ch = new[] {3, 4, 2, 8};
            int[] c = new[] {6, 1, 7, 9};

            int length = (ch.Length + c.Length);

            int[] empty = new int[length];


            for (int i = 0; i < ch.Length; i++)
            {
                empty[i] = ch[i];
                Console.WriteLine(empty[i]);
            }

            for (int i = 0; i < c.Length; i++)
            {
                empty[i + ch.Length] = c[i];
                Console.WriteLine(empty[i + ch.Length]);
            }

            bool swapped = false;
            int start = 0;
            int end = empty.Length - 1;

            do
            {

                swapped = false;

                for (int i = 0; i < end; i++)
                {
                    if (empty[i] > empty[i + 1])
                    {
                        Swap(ref empty[i], ref empty[i + 1]);
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }

                --end;

                for (int i = end - 1; i >= start; --i)
                {
                    if (empty[i] > empty[i + 1])
                    {
                        Swap(ref empty[i], ref empty[i + 1]);
                        swapped = true;
                    }
                }

                ++start;

            } while (swapped);

            //foreach (int i in empty)
            //{
            //    Console.WriteLine(empty[i]);
            //}

            Console.ReadLine();
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
