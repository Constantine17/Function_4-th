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
        public string str; // name arg
        public string _string; // name function
        public double _culc; // function response
        public bool plus { get;  set; } // test on sign
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
            _string = str;
            constanta = true;
        }

        public Func(string strArg)
        {
            arg = 0;
            str = strArg;
            _string = str;
            plus = true;
            constanta = false;
        }
        public Func(string strArg, double Arg)
        {
            arg = Arg;
            if (arg < 0) { arg *= -1; plus = false; } //test on sign
            else plus = true;
            str = strArg;
            _string = str;
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
        Function sinx;
        public sin(Function x)
        {
            sinx = x;
            plus = x.plus;
            arg = x.arg;
            str = x.str;

            _string = "sin(" + str + ")";
        }
        public override double Culc()
        {
            if (plus) return Math.Sin(arg);
            else return Math.Sin(-arg);
        }
        public override string ToString(){return _string;}
        public override Function Diff()
        {
            Function f = new cos(sinx); 
            return f;
        }
    }
    class cos : Function
    {
        Function cosx;
        public cos(Function x)
        {
            cosx = x;
            plus = x.plus;
            arg = x.arg;
            str = x.str;

            _string = "cos(" + str + ")";
        }
        public override double Culc()
        {
            if (plus) return Math.Cos(arg);
            else return Math.Cos(-arg);
        }
        public override string ToString() { return _string; }
        public override Function Diff()
        {
            Function f = new sin(cosx);
            f.plus = !f.plus; // invert sign
            return f;
        }
    }
    class tan : Function
    {
        Function tanx;
        public tan(Function x)
        {
            tanx = x;
            plus = x.plus;
            arg = x.arg;
            str = x.str;

            _string = "tan(" + str + ")";
        }
        public override double Culc()
        {
            if (plus) return Math.Tan(arg);
            else return Math.Tan(-arg);
        }
        public override string ToString() { return _string; }
        public override Function Diff()
        {
            Function c = new Func(2);
            Function x = new cos(tanx);
            
            Function f = new pow(x,c);
            c = new Func(1);
            f = new div(c, f);
            return f;
        }
    }
    class ctan : Function
    {
        public ctan(Function x)
        {
            plus = x.plus;
            arg = x.arg;
            str = x.str;
            // toString
            _string = "ctan (" + str + ")";

            // culc

        }
        public override double Culc()
        {
            if (plus) return 1/Math.Tan(arg);
            else return 1/Math.Tan(-arg);
        }
        public override string ToString() { return _string; }
        public override Function Diff()
        {

            Function f = new Func(1); // add diff!!!
            return f;
        }
    }
    class exp : Function
    {
        public exp(Function x)
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
            Function f = new Func(1); // add diff!!!
            return f;
        }
    }
    class ln : Function
    {
        public ln(Function x)
        {
            plus = x.plus;
            arg = x.arg;
            str = x.str;

            _string = "ln(" + str + ")";
        }
        public override double Culc()
        {
            if (plus) return Math.Log(arg);
            else return Math.Log(-arg);
        }
        public override string ToString() { return _string; }
        public override Function Diff()
        {
            Function f = new Func(1); // add diff!!!
            return f;
        }
    }
    class pow : Function
    {
        bool pow_plus;
        double pow_arg;
        string pow_str;
        public pow(Function x, Function y)
        {
            plus = x.plus;
            arg = x.arg;
            str = x.str;

            pow_plus = y.plus;
            pow_arg = y.arg;
            pow_str = y.str;

            _string = x._string + "^" + y._string;
        }
        public override double Culc()
        {
            double L, R;
            if (plus) L = arg; else L = -arg;
            if (pow_plus) R = pow_arg; else R = -pow_arg;
            return Math.Pow(L,R);
        }
        public override string ToString() {return _string; }
        public override Function Diff()
        {
            Function f = new Func(1); // add diff!!!
            return f;
        }
    }
    class add : Function
    {
        bool R_plus;
        double R_arg;
        string R_str;
        bool L_constnta, R_constanta;
        public add(Function L, Function R)
        {
            plus = L.plus;
            arg = L.arg;
            str = L.str;

            R_plus = R.plus;
            R_arg = R.arg;
            R_str = R.str;

            L_constnta = L.constanta;
            R_constanta = R.constanta;


            _string = "";
            if (L_constnta)
            {
                if (plus) _string += str; else _string += "-" + str;
            }
            else _string += str;
            if (R_constanta)
            {
                if (R_plus) _string += "+" + R_str; else _string += "-" + R_str;
            }
            else _string += "+" + R_str;
        }
        public override double Culc()
        {
            double L, R;
            if (plus) L = arg; else L = -arg;
            if (R_plus) R = R_arg; else R = -R_arg;
            return L+R;
        }
        public override string ToString() { return _string; }
        public override Function Diff()
        {
            Function f = new Func(1); // add diff!!!
            return f;
        }
    }
    class sub : Function
    {
        bool R_plus;
        double R_arg;
        string R_str;
        bool L_constnta, R_constanta;
        public sub(Function L, Function R)
        {
            plus = L.plus;
            arg = L.arg;
            str = L.str;

            R_plus = R.plus;
            R_arg = R.arg;
            R_str = R.str;

            L_constnta = L.constanta;
            R_constanta = R.constanta;

            _string = "";
            if (L_constnta)
            {
                if (plus) _string += L._string; else _string += "-" + L._string;
            }
            else _string += L._string;
            if (R_constanta)
            {
                if (R_plus) _string += "-" + R._string; else _string += "+" + R._string;
            }
            else _string += "-" + R._string;
        }
        public override double Culc()
        {
            double L, R;
            if (plus) L = arg; else L = -arg;
            if (R_plus) R = R_arg; else R = -R_arg;
            return L - (R);
        }
        public override string ToString() {return _string;}
        public override Function Diff()
        {
            Function f = new Func(1); // add diff!!!
            return f;
        }
    }
    class mul: Function
    {
        bool R_plus;
        double R_arg;
        string R_str;
        bool L_constnta, R_constanta;

        public mul(Function L, Function R)
        {
            plus = L.plus;
            arg = L.arg;
            str = L.str;

            R_plus = R.plus;
            R_arg = R.arg;
            R_str = R.str;


            L_constnta = L.constanta;
            R_constanta = R.constanta;

            _string = "";
            if (L_constnta && R_constanta)
            {
                if (plus) _string += L._string; else _string += "-" + L._string;
                _string += "*";
                if (R_plus) _string += R._string; else _string += "(-" + R._string + ")";
            }
            else if (R_constanta)
            {
                _string += L._string + "*";
                if (R_plus) _string += R._string; else _string += "(-" + R._string + ")";
            }
            else _string = L._string + R._string;
        }
        public override double Culc()
        {
            double L, R;
            if (plus) L = arg; else L = -arg;
            if (R_plus) R = R_arg; else R = -R_arg;
            return L * R;
        }
        public override string ToString() {return _string; }
        public override Function Diff()
        {
            Function f = new Func(1); // add diff!!!
            return f;
        }
    }
    class div : Function
    {
        bool R_plus;
        double R_arg;
        string R_str;
        bool L_constnta, R_constanta;

        public div(Function L, Function R)
        {
            plus = L.plus;
            arg = L.arg;
            str = L.str;

            R_plus = R.plus;
            R_arg = R.arg;
            R_str = R.str;


            L_constnta = L.constanta;
            R_constanta = R.constanta;

            _string = "";
            if (L_constnta && R_constanta)
            {
                _string = "(";
                if (plus) _string += L._string; else _string += "-" + L._string;
                _string += "/";
                if (R_plus) _string += R._string; else _string += "-" + R._string;
                _string += ")";
            }
            else if (R_constanta)
            {
                _string += L._string + "/";
                if (R_plus) _string += R._string; else _string += "-" + R._string;
            }
            else _string = L._string + "/" + R._string;

        }
        public override double Culc()
        {
            double L, R;
            if (plus) L = arg; else L = -arg;
            if (R_plus) R = R_arg; else R = -R_arg;
            return L / R;
        }
        public override string ToString() {return _string;}
        public override Function Diff()
        {
            Function f = new Func(1); // add diff!!!
            return f;
        }
    }
    class double_Func : Function
    {
        Function L, R;
        string _srting;
        public double_Func(Function Left, Function Right)
        {
            
            L = Left;
            R = Right;
        }
        protected void set_strig()
        {
            _srting = L.ToString() + R.ToString();
        }
        protected void set_culc()
        {

        }
        public override string ToString()
        {
            return _srting;
        }
        public override double Culc()
        {
            return 0;
        }
        public override Function Diff()
        {
            return L;
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

}
