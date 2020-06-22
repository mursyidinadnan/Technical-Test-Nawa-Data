using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biggest_Factor_Nawa_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan jumlah input: ");
            int Input = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[Input];

            for (int i = 0; i < Input; i++)
                array[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan Output: ");
            int Output = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Output factor: ");
            FungsiCariFactor(array, Output);
            Console.ReadKey();
        }

        private static void FungsiCariFactor(int[] Array1, int Output)
        {
            int[] sub = new int[Array1.Length];
            int temp = 0;
            for (int i = 0; i < Array1.Length; i++)
            {
                for (int j = i, col = 0; j < Array1.Length; j++, col++)
                {
                    temp += Array1[j];
                    sub[col] = Array1[j];
                    if (temp == Output)
                    {
                        int total = 0;
                        for (int k = 0; k < sub.Length; k++)
                        {
                            total += sub[k];
                            Console.Write(sub[k].ToString() + " ");

                            if (total == Output)
                            {
                                Console.Write("\n");
                                break;
                            }
                        }
                    }
                    if (temp > Output)
                    {
                        Array.Clear(sub, 0, sub.Length);
                        temp = 0;
                        break;
                    }
                }
            }
        }
    }
}
