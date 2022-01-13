using System;
using System.Collections.Generic;

namespace kwadratowe
{
    public class Program
    {
        public List<double> rownanie(double a, double b, double c)
        {
            List<double> list = new List<double>();
            if (a == 0)
            {
                Console.WriteLine("Wspolczynnik a nie moze byc rowny 0!");
                return list;
            }
            double delta,x1,x2;
            delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Brak rozwiązań");
                return list;
            }

            if (delta == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Jedno rozwiazanie: "+x1);
                list.Add(x1);
                return list;
            }

            //Ponizej musi juz byc delta wieksza od zera
                x1 = (double)((-b - Math.Sqrt(delta)) / (2 * a));
                x2 = (double)((-b + Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("Dwa rozwiazania: " + x1+" oraz "+x2);
                list.Add(x1);
                list.Add(x2);
                return list;
            



        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.rownanie(1,1,1);
            Console.WriteLine("------------------------");
            p.rownanie(0,1,1);
            Console.WriteLine("------------------------");
            p.rownanie(1,2,1);
            Console.WriteLine("------------------------");
            p.rownanie(1,5,6);
            Console.WriteLine("------------------------");
        }
    }
}
