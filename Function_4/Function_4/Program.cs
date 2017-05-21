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
            var sinx = new sin(FuncX);

            ///consta
            Console.WriteLine("===================================================");
            Console.WriteLine("FuncX:");
            Console.WriteLine("str = {0}", FuncX.str);
            Console.WriteLine("arg = {0}", FuncX.arg);
            Console.WriteLine("plus = {0}", FuncX.plus);
            Console.WriteLine("culc = {0}", FuncX.Culc());
            Console.WriteLine("ToString = {0}", FuncX.ToString());
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("FuncY:");
            Console.WriteLine("str = {0}", FuncY.str);
            Console.WriteLine("arg = {0}", FuncY.arg);
            Console.WriteLine("plus = {0}", FuncY.plus);
            Console.WriteLine("culc = {0}", FuncY.Culc());
            Console.WriteLine("ToString = {0}", FuncY.ToString());
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Constanta:");
            Console.WriteLine("str = {0}", Constanta.str);
            Console.WriteLine("arg = {0}", Constanta.arg);
            Console.WriteLine("plus = {0}", Constanta.plus);
            Console.WriteLine("culc = {0}", Constanta.Culc());
            Console.WriteLine("ToString = {0}", Constanta.ToString());
            Console.WriteLine("===================================================");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Sin:");
            Console.WriteLine("str = {0}", sinx.str);
            Console.WriteLine("arg = {0}", sinx.arg);
            Console.WriteLine("plus = {0}", sinx.plus);
            Console.WriteLine("culc = {0}", sinx.Culc());
            Console.WriteLine("ToString = {0}", sinx.ToString());
            Console.WriteLine("===================================================");

            var Constanta1 = new Func("y",-2);
            var Constanta2 = new Func(-1);
            var Power = new pow(Constanta1,Constanta2);
            Console.WriteLine("Pow:");
            Console.WriteLine("str = {0}", Power.str);
            Console.WriteLine("arg = {0}", Power.arg);
            Console.WriteLine("plus = {0}", Power.plus);
            Console.WriteLine("culc = {0}", Power.Culc());
            Console.WriteLine("ToString = {0}", Power.ToString());
            Console.WriteLine("----------------------------------------------------");
            var ADD = new add(Constanta1, Constanta2);
            Console.WriteLine("add:");
            Console.WriteLine("str = {0}", ADD.str);
            Console.WriteLine("arg = {0}", ADD.arg);
            Console.WriteLine("plus = {0}", ADD.plus);
            Console.WriteLine("culc = {0}", ADD.Culc());
            Console.WriteLine("ToString = {0}", ADD.ToString());
            Console.WriteLine("----------------------------------------------------");
            var SUB = new sub(Constanta1, Constanta2);
            Console.WriteLine("sub:");
            Console.WriteLine("str = {0}", SUB.str);
            Console.WriteLine("arg = {0}", SUB.arg);
            Console.WriteLine("plus = {0}", SUB.plus);
            Console.WriteLine("culc = {0}", SUB.Culc());
            Console.WriteLine("ToString = {0}", SUB.ToString());
            Console.WriteLine("----------------------------------------------------");
            var MUL = new mul(Constanta1, Constanta2);
            Console.WriteLine("mul:");
            Console.WriteLine("str = {0}", MUL.str);
            Console.WriteLine("arg = {0}", MUL.arg);
            Console.WriteLine("plus = {0}", MUL.plus);
            Console.WriteLine("culc = {0}", MUL.Culc());
            Console.WriteLine("ToString = {0}", MUL.ToString());
            Console.WriteLine("----------------------------------------------------");
            var DIV = new div(Constanta1, Constanta2);
            Console.WriteLine("mul:");
            Console.WriteLine("str = {0}", DIV.str);
            Console.WriteLine("arg = {0}", DIV.arg);
            Console.WriteLine("plus = {0}", DIV.plus);
            Console.WriteLine("culc = {0}", DIV.Culc());
            Console.WriteLine("ToString = {0}", DIV.ToString());
            Console.WriteLine("----------------------------------------------------");
            ///

            Console.WriteLine("===================================================");
            Console.WriteLine("===================================================");
            Console.WriteLine("ALL SRING:");
            
            Console.WriteLine("===================================================");
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
