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
            var FuncX = new Func("x",5);
            var FuncY = new Func("y", -1);
            var Constanta = new Func(17);
            FuncY.equally(-9);

            ///consta
            Console.WriteLine("===================================================");
            Console.WriteLine("FuncX:");
            Console.WriteLine("str = {0}", FuncX.str);
            Console.WriteLine("arg = {0}", FuncX.arg);
            Console.WriteLine("plus = {0}", FuncX.plus);
            Console.WriteLine("culc = {0}", FuncX.Culc());
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("FuncY:");
            Console.WriteLine("str = {0}", FuncY.str);
            Console.WriteLine("arg = {0}", FuncY.arg);
            Console.WriteLine("plus = {0}", FuncY.plus);
            Console.WriteLine("culc = {0}", FuncY.Culc());
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Constanta:");
            Console.WriteLine("str = {0}", Constanta.str);
            Console.WriteLine("arg = {0}", Constanta.arg);
            Console.WriteLine("plus = {0}", Constanta.plus);
            Console.WriteLine("culc = {0}", Constanta.Culc());
            Console.WriteLine("===================================================");
            ///

            /*
            Console.WriteLine(fun.ToString());
            Function d = fun.Diff();
            Console.WriteLine(d.ToString());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(funcos.ToString());
            Function d1 = funcos.Diff();
            Console.WriteLine(d1.ToString());
            //Console.WriteLine(fun.str);
            */
            Console.ReadKey();
        }
    }
}
