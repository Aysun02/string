using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string soz = "Nurlan Faiq Yusif";
           
            
            char[] array;
            array = soz.ToCharArray();
            

            {
                for (int i =array.Length-1; i>=0; i--)
                { 
                    Console.WriteLine(array[i]); ;

                }

            }
        }
    }
}
