using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDuplicateCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the string: \n");
                string str = Console.ReadLine();
                char[] strArray = str.ToCharArray();
                HashSet<char> hashSet = new HashSet<char>();
                for (int i = 0; i < str.Length; i++)
                {
                    hashSet.Add(strArray[i]);
                }
                foreach (char temp in hashSet)
                {
                    Console.Write(temp);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
