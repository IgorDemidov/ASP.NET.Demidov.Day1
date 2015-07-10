using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            JaggedArray ja = new JaggedArray(new int[5][]{
                new int[5] { 1, 3, 5, 7, 9 },
                new int[4] { 2, 4, 6, 8 },
                new int[5] { 3, 16, 1, 7, 3 },
                new int[6] { 1, 3, 6, 11, 5, 10 },
                new int[3] { 8, 13, 6}});
          

            //ja.Print();
            

            



            

            Console.ReadKey();

        }
    }
}
