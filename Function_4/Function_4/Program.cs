using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("begin");
            Function fun;
            fun = new sin();
            Console.WriteLine(fun.str);

            Console.ReadKey();
        }
    }
}
