using System;

namespace Fraction_calc
{
    struct Fraction
    {
        private double numerator;
        private double denominator;
        private double sub;

        public Fraction (double numerator,double denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
            this.sub = numerator / denominator;
        }

        public double Numerator
        {
            get
            {
                return this.numerator;
            }
            set
            {
                try
                {
                    this.numerator = value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong input format.");
                }
            }
        }

        public double Denominator
        {
            get
            {   
                return this.denominator;
            }
            set
            {
                try
                {
                    if (value == 0)
                    {
                        throw new DivideByZeroException();
                    }

                    this.denominator = value;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("The Denominator can't be 0.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong input format.");
                }
            }
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            checked
            {
                double numerator = f1.numerator * f2.denominator - f2.numerator * f1.denominator;
                double denominator = f1.denominator * f2.denominator;
                return new Fraction(numerator, denominator);
            }
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            checked
            {
                double numerator = f1.numerator * f2.denominator + f2.numerator * f1.denominator;
                double denominator = f1.denominator * f2.denominator;
                return new Fraction(numerator, denominator);
            }
        }

        public override string ToString()
        {
            return ""+this.sub;
        }
    }
}
