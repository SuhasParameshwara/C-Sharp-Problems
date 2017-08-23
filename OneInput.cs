using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneInput
{ 
    class TextInput
    {
        public StringBuilder strBd = new StringBuilder();
        public void Add(char c)
        {
            if (Char.IsDigit(c))
            {
                strBd.Append(c);
            }
        }
        public string GetValue()
        {
            return strBd.ToString();
        }
    }
    class NumericInput : TextInput
    {
        public new void Add(char c)
        {
            if (Char.IsDigit(c))
            {
                strBd.Append(c);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
            Console.ReadLine();
        }
    }
}
