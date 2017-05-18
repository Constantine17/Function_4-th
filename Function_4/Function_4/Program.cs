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
            fun = new sin(5);
            Function funcos = new cos(5);

            Console.WriteLine(fun.ToString());
            Function d = fun.Diff();
            Console.WriteLine(d.ToString());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(funcos.ToString());
            Function d1 = funcos.Diff();
            Console.WriteLine(d1.ToString());
            //Console.WriteLine(fun.str);

            Console.ReadKey();
        }
    }
}
