using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_4
{
    abstract class Function
    {
        public double arg;
        public string str;
        public bool constanta;
      //  public bool plus { get; set; }

        public Function()
        {
        }
        public abstract double Culc();
        public abstract string ToString();
        public abstract Function Diff();       
    }

    class Func : Function
    {
        public bool plus { get; protected set; } // add tast on sub

        public Func(double Arg)
        {
            if (Arg < 0) { plus = false; arg = Arg * -1; }
            else { plus = true; arg = Arg; }
            str = Convert.ToString(arg);
            constanta = true;
        }

        public Func(string strArg)
        {
            arg = 0;
            str = strArg;
            plus = true;
            constanta = false;
        }
        public Func(string strArg, double Arg)
        {
            arg = Arg;
            if (arg < 0) { arg *= -1; plus = false; } //test on sign
            else plus = true;
            str = strArg;
            constanta = false;
        }
        public void equally(double x)
        { if (x < 0) { plus = false; arg = x * -1; } // test on sign
            else { arg = x; arg = x; }
        }

    public override double Culc() { if (plus) return arg; else return arg*=-1; }
    public override string ToString() {return str; } // add tast on sub
    public override Function Diff() { Function x = new Func("1",1); return x; }// reset function
}
    /*
    class constanta : Func
    {
        public constanta(double x)
        {
            if (x < 0) { plus = false; arg = x * -1; }
            else { plus = true; arg = x; }
            str = Convert.ToString(arg);
        }
    }
    */
    /*
    class sin : Function
    {
        public sin(string strArg)
        {
            plus = true;
            arg = 0;
            str = strArg;
        }
        public sin(double Arg)
        {
            if (arg >= 0) plus = true;
            else { plus = false; arg *= -1; }
            arg = Arg;
            str = Convert.ToString(Arg);
        }

        public override double Culc(double x)
        {
            if (plus) return Math.Sin(x);
            else return -Math.Sin(x);
        }
        public override string ToString()
        {   
            if(plus) return "sin(" + str + ")";
            else return "-sin("+str+")";
        }
        public override Function Diff()
        {
            Function diff = new cos(str);
            diff.plus = plus;
            return diff;
        }
    }
    class cos : Function
    {
        public cos(string strArg)
        {
            plus = true;
            arg = 0;
            str = strArg;
        }
        public cos(double Arg)
        {
            if (arg >= 0) plus = true;
            else { plus = false; arg *= -1; }
            arg = Arg;
            str = Convert.ToString(Arg);
        }

        public override double Culc(double x)
        {
            if (plus) return Math.Cos(x);
            else return -Math.Cos(x);
        }
        public override string ToString()
        {
            if (plus) return "cos(" + str + ")";
            else return "-cos(" + str + ")";
        }
        public override Function Diff()
        {
            Function diff = new sin(arg);
            if (plus) diff.plus = false;
            else diff.plus = true;
            return diff;
        }
    }
    */
    /*
    class cos : Function
    {
        bool plus;
        public cos()
        {
            arg = Math.Sin(this.arg);
            str = "cos(" + this.arg + ")";
        }
        public override string ToString()
        {
            return "";
        }
        public override Function Diff()
        {
            Function diff = new sin();
            return diff;
        }
    }
    */
}
