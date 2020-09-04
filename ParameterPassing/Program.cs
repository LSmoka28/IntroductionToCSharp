using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterPassing
{
    public class IntHolder
    {
        public int number;
    }

    class Program
    {
        static void Foo( IntHolder x)
        {
            x = new IntHolder();
        }
        static void Main(string[] args)
        {
            IntHolder holder = new IntHolder();
            holder.number = 5;

            Foo(holder);

            Console.WriteLine(holder.number);

            Console.ReadLine();
        }
    }
}
