using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutonRoot.Task1.Library
{
    public class NutonCalc
    {
        /// <summary>
        ///  This method calculates the value of the n-th root of the  argument arg to within e by Newton method.
        /// </summary>
        public double RootOf(double arg, double n, double delta)
        {
            if ((arg<0) && (n%2!=0))
            {
                return Double.NaN;
            }
            else
            {
                double x = arg;
                double next = x;
                do
                {
                    x = next;
                    next = (((n - 1) * x) + (arg / Math.Pow(x,(n-1)))) / n;
                } while (Math.Abs(x - next) > delta);

                return x;
            }
            
        }
    }
}
