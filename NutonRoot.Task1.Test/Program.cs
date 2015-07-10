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
            Console.WriteLine(calc.RootOf(2, 2, 0.00001));
            Console.WriteLine(Math.Pow(2,0.5));
            Console.ReadLine();
        }
    }
}
