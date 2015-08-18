using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace tringle
{
    public class Triangle
    {

        public static double S { get; set; }

        public bool IsValid(Model mod)
        {
            if ((mod.A + mod.B > mod.C) && (mod.A + mod.C > mod.B) && (mod.C + mod.B > mod.A))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Wrong size sides. Received figure is not a triangle");
            }
            return false;
        }

        private double SemiPerimetr(Model mod)
        {
            double p = (mod.A + mod.B + mod.C) / 2;
            return p;
        }

        public double Squre(Model mod)
        {

            double p = SemiPerimetr(mod);
            return S = Math.Sqrt(p * (p - mod.A) * (p - mod.B) * (p - mod.C));

        }
    }
}
