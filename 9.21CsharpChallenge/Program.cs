using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._21CsharpChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Supercalifragilisticexpialidocious";
            char[] arr = str.ToCharArray();

            foreach(char c in arr)
            {
                Console.WriteLine(c);
            }
            foreach(char c in arr)
            {
                if(c != 'i')
                {
                    Console.WriteLine("Not an i");
                }
                else if(c != 'l')
                {
                    Console.WriteLine("l");
                }
                else
                {
                    Console.WriteLine(c);
                }
                                                                                                  
            }
            int len = arr.Length;
            Console.WriteLine(len);

            Console.ReadLine();
        }
    }
}
