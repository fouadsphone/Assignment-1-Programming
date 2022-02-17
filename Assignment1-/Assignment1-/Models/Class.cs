using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Models{
    public class Rational
    {
        public int Denominator { get; private set; }
        public int Numerator { get; private set; }
        public Rational(int numerator = 0, int denominator = 1)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }
        public override string ToString()
        {
            return Numerator + "/" + Denominator;
        }
        public void IncreaseBy(Rational other)
        {
            Numerator = (other.Numerator * this.Denominator) + (other.Denominator * this.Numerator);
            Denominator = other.Denominator * this.Denominator;
        }
        public void DecreaseBy(Rational other)
        {
            Numerator = (other.Denominator * this.Numerator)-(other.Numerator * this.Denominator);
            Denominator = other.Denominator * this.Denominator;
        }
    }
}