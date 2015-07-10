using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhones;


namespace MobilePhone.Task1.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple obj1 = new Apple();
            obj1.OS();

            Nokia obj2 = new Nokia();
            obj2.OS();

            Samsung obj3 = new Samsung();
            obj3.OS();

            Console.ReadLine();
            Console.ReadLine(); 

        }
    }
}
