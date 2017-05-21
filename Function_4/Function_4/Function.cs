using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_4
{
    abstract class Function
    {
        public double arg; // number
        public string str; // name
        public bool plus { get; protected set; } // test on sign
        public bool constanta; // test on constanta or function
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
     //   public bool plus { get; protected set; } // add tast on sub

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
    public override string ToString() { return str;} // add tast on sub
    public override Function Diff() {
            Function x;
            if (constanta) x = new Func(0);
            else x = new Func(1);
            return x; }// reset function
}
    class sin : Function
    {
        public sin(Func x)
        {
            plus = x.plus;
            arg = x.arg;
            str = x.str;
        }
        public override double Culc()
        {
            if (plus) return Math.Sin(arg);
            else return Math.Sin(-arg);
        }
        public override string ToString(){return "sin(" + str + ")";}
        public override Function Diff()
        {
            Func f = new Func(1); // add diff!!!
            return f;
        }
    }
    class cos : Function
    {
        public cos(Func x)
        {
            plus = x.plus;
            arg = x.arg;
            str = x.str;
        }
        public override double Culc()
        {
            if (plus) return Math.Cos(arg);
            else return Math.Cos(-arg);
        }
        public override string ToString() { return "cos(" + str + ")"; }
        public override Function Diff()
        {
            Func f = new Func(1); // add diff!!!
            return f;
        }
    }
    class tan : Function
    {
        public tan(Func x)
        {
            plus = x.plus;
            arg = x.arg;
            str = x.str;
        }
        public override double Culc()
        {
            if (plus) return Math.Tan(arg);
            else return Math.Tan(-arg);
        }
        public override string ToString() { return "sin(" + str + ")"; }
        public override Function Diff()
        {
            Func f = new Func(1); // add diff!!!
            return f;
        }
    }
    class ctan : Function
    {
        public ctan(Func x)
        {
            plus = x.plus;
            arg = x.arg;
            str = x.str;
        }
        public override double Culc()
        {
            if (plus) return 1/Math.Tan(arg);
            else return 1/Math.Tan(-arg);
        }
        public override string ToString() { return "ctan (" + str + ")"; }
        public override Function Diff()
        {
            Func f = new Func(1); // add diff!!!
            return f;
        }
    }
    class exp : Function
    {
        public exp(Func x)
        {
            plus = x.plus;
            arg = x.arg;
            str = x.str;
        }
        public override double Culc()
        {
            if (plus) return Math.Exp(arg);
            else return Math.Exp(-arg);
        }
        public override string ToString() { return "exp(" + str + ")"; }
        public override Function Diff()
        {
            Func f = new Func(1); // add diff!!!
            return f;
        }
    }
    class ln : Function
    {
        public ln(Func x)
        {
            plus = x.plus;
            arg = x.arg;
            str = x.str;
        }
        public override double Culc()
        {
            if (plus) return Math.Log(arg);
            else return Math.Log(-arg);
        }
        public override string ToString() { return "ln(" + str + ")"; }
        public override Function Diff()
        {
            Func f = new Func(1); // add diff!!!
            return f;
        }
    }
    class pow : Function
    {
        bool pow_plus;
        double pow_arg;
        string pow_str;
        public pow(Func x, Func y)
        {
            plus = x.plus;
            arg = x.arg;
            str = x.str;

            pow_plus = y.plus;
            pow_arg = y.arg;
            pow_str = y.str;
        }
        public override double Culc()
        {
            if (!plus) arg = -arg;
            if (!pow_plus) pow_arg = -pow_arg;
            return Math.Pow(arg,pow_arg);
        }
        public override string ToString() {
            return "("+str+"^"+pow_str+")";

        }
        public override Function Diff()
        {
            Func f = new Func(1); // add diff!!!
            return f;
        }
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
