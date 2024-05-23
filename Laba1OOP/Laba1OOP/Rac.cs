using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1OOP
{
    public class Rac
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }
        public Rac(int numerator, int denominator) 
        {
            FoundNOD(this);
            Numerator = numerator / FoundNOD(this);
            Denominator = denominator / FoundNOD(this);
            if(denominator == 0)
                Console.WriteLine("Знаменатель не должен быть == 0");
        }
        new public void ToString()
        {
            Console.WriteLine($"{Numerator}/{Denominator}");
        }
        public static Rac operator +(Rac a, Rac b)
        {
            if (a.Denominator == b.Denominator)
            {
                return new Rac(a.Numerator + b.Numerator, b.Denominator);
            }
            return new(a.Numerator* b.Denominator + b.Numerator* a.Denominator, b.Denominator* a.Denominator);
        }
        public static Rac operator -(Rac a, Rac b)
        {
            if (a.Denominator == b.Denominator)
            {
                return new Rac(a.Numerator - b.Numerator, b.Denominator);
            }
            return new(a.Numerator * b.Denominator - b.Numerator * a.Denominator, b.Denominator * a.Denominator);
        }
        public static Rac operator -(Rac a)
        {
            return new(-a.Numerator, a.Denominator);
        }
        public static bool operator !=(Rac a, Rac b)
        {
            return !(a == b);
        }
        public static bool operator ==(Rac a, Rac b)
        {
            return a.Denominator == b.Denominator && a.Numerator == b.Numerator ? true : false;
        }
        public int FoundNOD(Rac a)
        {
            for (int i = a.Numerator; i > 2; --i)
            {
                if(a.Denominator % i != 0 && a.Numerator % i != 0)
                    return i;
            }
            return 1;
        }
        public static bool operator <(Rac a, Rac b)
        {
            Rac temp1 = new(a.Numerator * b.Denominator, b.Denominator * a.Denominator);
            Rac temp2 = new(b.Numerator * a.Denominator, b.Denominator * a.Denominator);
            return temp1.Numerator < temp2.Numerator;
        }
        public static bool operator >(Rac a, Rac b)
        {
            Rac temp1 = new(a.Numerator * b.Denominator, b.Denominator * a.Denominator);
            Rac temp2 = new(b.Numerator * a.Denominator, b.Denominator * a.Denominator);
            return temp1.Numerator > temp2.Numerator;
        }
    }
}
