using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENETClasses.Miscellaneous
{
    public struct AustralianDollar
    {
        public decimal Amount;

        public override string ToString()
        {
            return String.Format("${0}", Amount.ToString());
        }

        public AustralianDollar(decimal value)
        { Amount = value; }

        public static AustralianDollar operator +(AustralianDollar left, AustralianDollar right) { return new AustralianDollar(left.Amount + right.Amount); }
        public static AustralianDollar operator -(AustralianDollar left, AustralianDollar right) { return new AustralianDollar(left.Amount - right.Amount); }
        public static AustralianDollar operator *(AustralianDollar left, double scalar) { return new AustralianDollar(left.Amount * (decimal)scalar); }
        public static AustralianDollar operator *(AustralianDollar left, decimal scalar) { return new AustralianDollar(left.Amount * scalar); }
        public static AustralianDollar operator *(AustralianDollar left, int scalar) { return new AustralianDollar(left.Amount * scalar); }
        public static AustralianDollar operator /(AustralianDollar left, double scalar) { return new AustralianDollar(left.Amount / (decimal)scalar); }
        public static AustralianDollar operator /(AustralianDollar left, decimal scalar) { return new AustralianDollar(left.Amount / scalar); }

        public static bool operator ==(AustralianDollar left, AustralianDollar right) { return left.Amount == right.Amount; }
        public static bool operator !=(AustralianDollar left, AustralianDollar right) { return !(left.Amount == right.Amount); }
        public static bool operator >(AustralianDollar left, AustralianDollar right) { return left.Amount > right.Amount; }
        public static bool operator <(AustralianDollar left, AustralianDollar right) { return left.Amount < right.Amount; }
        public static bool operator >=(AustralianDollar left, AustralianDollar right) { return left.Amount >= right.Amount; }
        public static bool operator <=(AustralianDollar left, AustralianDollar right) { return left.Amount <= right.Amount; }

        public static implicit operator AustralianDollar(int number) { return new AustralianDollar((decimal)number);}
        public static implicit operator AustralianDollar(double number) { return new AustralianDollar((decimal)number); }

        public override bool Equals(object obj) { return base.Equals(obj); }
    }
}
