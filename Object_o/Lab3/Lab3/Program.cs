using System;

namespace Lab3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            RationalNumber RatNum1 = new RationalNumber();
            RationalNumber RatNum2 = new RationalNumber(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

            RationalNumber RatNum;

            RatNum = RatNum1 + RatNum2;

            Console.WriteLine(RatNum.GetNumerator());
            Console.WriteLine(RatNum.GetDenominator());

            Console.WriteLine(RatNum1 > RatNum2);

            Console.WriteLine(RatNum1 != RatNum2);
        }
    }
    class RationalNumber
    {
        private int numerator;
        private int denominator;

        public int GetNumerator() { return numerator;}
        public int GetDenominator() { return denominator;}

        public void SetNumerator(int numerator) { this.numerator = numerator; }
        public void SetDenominator(int denominator) { this.denominator = denominator; }

        public RationalNumber () {
            numerator = 15;
            denominator = 20;
        }
        public RationalNumber(int numerator, int denominator) {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public static RationalNumber operator +(RationalNumber RatNum1, RationalNumber RatNum2)
        {
            RationalNumber RatNum = new RationalNumber();
            RatNum.SetNumerator((RatNum1.GetNumerator()*RatNum2.GetDenominator()) + (RatNum2.GetNumerator()*RatNum1.GetDenominator()));
            RatNum.SetDenominator(RatNum1.GetDenominator() * RatNum2.GetDenominator());
            return RatNum;
        }
        public static RationalNumber operator -(RationalNumber RatNum1, RationalNumber RatNum2)
        {
            RationalNumber RatNum = new RationalNumber();
            RatNum.SetNumerator((RatNum1.GetNumerator() * RatNum2.GetDenominator()) - (RatNum2.GetNumerator() * RatNum1.GetDenominator()));
            RatNum.SetDenominator(RatNum1.GetDenominator() * RatNum2.GetDenominator());
            return RatNum;;
        }
        public static RationalNumber operator /(RationalNumber RatNum1, RationalNumber RatNum2)
        {
            RationalNumber RatNum = new RationalNumber();
            RatNum.SetNumerator(RatNum1.GetNumerator() * RatNum2.GetDenominator());
            RatNum.SetDenominator(RatNum1.GetDenominator() * RatNum2.GetNumerator());
            return RatNum;
        }
        public static RationalNumber operator *(RationalNumber RatNum1, RationalNumber RatNum2)
        {
            RationalNumber RatNum = new RationalNumber();
            RatNum.SetNumerator(RatNum1.GetNumerator()  * RatNum2.GetNumerator());
            RatNum.SetDenominator(RatNum1.GetDenominator() * RatNum2.GetDenominator());
            return RatNum;
        }

        public static bool operator > (RationalNumber RatNum1, RationalNumber RatNum2)
        {
            return ((RatNum1.GetNumerator()/RatNum1.GetDenominator()) > (RatNum2.GetNumerator()/ RatNum2.GetDenominator()));
        }
        public static bool operator <(RationalNumber RatNum1, RationalNumber RatNum2)
        {
            return ((RatNum1.GetNumerator() / RatNum1.GetDenominator()) < (RatNum2.GetNumerator() / RatNum2.GetDenominator()));
        }
        public static bool operator >=(RationalNumber RatNum1, RationalNumber RatNum2)
        {
            return ((RatNum1.GetNumerator() / RatNum1.GetDenominator()) >= (RatNum2.GetNumerator() / RatNum2.GetDenominator()));
        }
        public static bool operator <=(RationalNumber RatNum1, RationalNumber RatNum2)
        {
            return ((RatNum1.GetNumerator() / RatNum1.GetDenominator()) <= (RatNum2.GetNumerator() / RatNum2.GetDenominator()));
        }

        public static bool operator ==(RationalNumber RatNum1, RationalNumber RatNum2)
        {
            return ((RatNum1.GetNumerator() / RatNum1.GetDenominator()) == (RatNum2.GetNumerator() / RatNum2.GetDenominator()));
        }
        public static bool operator !=(RationalNumber RatNum1, RationalNumber RatNum2)
        {
            return ((RatNum1.GetNumerator() / RatNum1.GetDenominator()) != (RatNum2.GetNumerator() / RatNum2.GetDenominator()));
        }
    }
}
