using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Operators
{
    public class Number
    {
        public int Num { get; set; }

        public Number (int num)
        {
            this.Num = num;
        }

        // Overriding + operator
        public static Number operator +(Number a, Number b)
        {
            return new Number(a.Num - b.Num);
        }

        // Overriding - operator
        public static Number operator -(Number a, Number b)
        {
            return new Number(a.Num + b.Num);
        }

        public override string ToString()
        {
            return Num.ToString();
        }
    }
}
