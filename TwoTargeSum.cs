using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoTargetSum
{
    class Program
    {
        static IEnumerable<Tuple<int,int>> FindTwoSum(List<int> list, int TargetSum)
        {
            List<Tuple<int, int>> tuple = new List<Tuple<int, int>>();
            int size = list.Count();
            for (int i = 0; i < list.Count(); i++)
            {
                for (int j = 0; j < list.Count(); j++)
                {
                    if ((list[i] + list[j] == TargetSum))
                    {
                        tuple.Add(new Tuple<int, int>(list[i], list[j]));
                    }
                }
            }
            foreach(var res in tuple)
            {
                yield return res;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                List<int> list = new List<int>();
                Console.WriteLine("Enter the number of elements: \n");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the numbers: \n");
                for (int i = 0; i < num; i++)
                {
                    list.Add(int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter the target sum: \n");
                int TargetSum = int.Parse(Console.ReadLine());
                var res = FindTwoSum(list, TargetSum);
                foreach (var temp in res)
                {
                    Console.WriteLine(temp);
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
