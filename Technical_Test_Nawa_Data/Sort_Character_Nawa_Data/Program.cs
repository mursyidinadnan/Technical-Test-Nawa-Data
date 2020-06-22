using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Character_Nawa_Data
{
    class Program
    {
                
        public static void Main()
        {
            int vCount = 0, cCount = 0;
            Console.WriteLine("tulis: ");            
            string str = Console.ReadLine();
            str = str.ToLower();

            string[] vowelsarray = new string[100];
            string[] consonantarray = new string[100];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    vowelsarray[vCount] = str[i].ToString();
                    Array.Sort(vowelsarray);
                    vCount++;
                }
                else if (str[i] >= 'a' && str[i] <= 'z')
                {
                    consonantarray[cCount] = str[i].ToString();
                    Array.Sort(consonantarray);
                    cCount++;
                }
            }
            
            Console.WriteLine("Vowel Characters :");
            Console.WriteLine("{0}", string.Join("", vowelsarray));            
            Console.WriteLine("Consonant Characters :");
            Console.WriteLine("{0}", string.Join("", consonantarray));
            Console.ReadLine();
        }

    }
}
