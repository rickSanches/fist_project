using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace tringle
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Model M = new Model();
            Triangle Trian = new Triangle();
            while (true)
            {
                Console.Clear();
                bool gonext = false;
                while (!gonext)
                {
                    //          
                    Console.WriteLine("Enter A side in cm:");
                    var a = Console.ReadLine();
                    while (!a.HasNumberOnly())  //  
                    {
                        Console.WriteLine("Wrong A. One more...");
                        a = Console.ReadLine();
                    }
                    double A = double.Parse(a);
                    //
                    Console.WriteLine("Enter B side in cm:");
                    var b = Console.ReadLine();
                    while (!b.HasNumberOnly())  // 
                    {
                        Console.WriteLine("Wrong B. One more...");
                        b = Console.ReadLine();
                    }
                    double B = double.Parse(b); // 
                    //
                    Console.WriteLine("Enter C side in cm:");
                    var c = Console.ReadLine();
                    while (!c.HasNumberOnly())
                    {
                        Console.WriteLine("Wrong C. One more...");
                        c = Console.ReadLine();
                    }
                    double C = double.Parse(c);

                    M.A = A; M.B = B; M.C = C;

                    gonext = Trian.IsValid(M);
                }

                // Calculate S triangle

                var square = Trian.Squre(M);
                Console.WriteLine("Square of triangle is {0} cm^2", square);
                Console.WriteLine("If You want calculate squre again with new sides enter \"Yes\", another - exit.");
                var ye = Console.ReadLine();
                if (!(ye == "Yes" || ye == "yes"))
                {
                    return;
                }

            }
        }
    }
}
