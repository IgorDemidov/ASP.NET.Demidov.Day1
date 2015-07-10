using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutonRoot.Task1.Library;


namespace NutonRoot.Task1.Test
{
    
    class Program
    {   
        static void Main(string[] args)
        {
            NutonCalc calc = new NutonCalc();
            double arg;
            double n;
            double e;

            Console.WriteLine("Your argument:");
            double.TryParse(Console.ReadLine(), out arg);
            Console.WriteLine("Your root power:");
            double.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Сalculation accuracy:");
            double.TryParse(Console.ReadLine(), out e);

            Console.WriteLine();
            double nutonValue = calc.RootOf(arg, n, e);
            Console.WriteLine("Calculating by Nuton method:"+nutonValue);
            double powValue = Math.Pow(arg,(1/n));
            Console.WriteLine("Calculating by Math.Pow metod:" + powValue);
            Console.WriteLine();
            Console.WriteLine("Сomputing difference: " + (powValue - nutonValue));

            Console.ReadLine();
        }
    }
}
