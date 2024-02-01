using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_and_CLR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName;
            MyName = "Dmitry";
            Console.WriteLine(MyName);

            const string myName = "Dima";
            Console.WriteLine(myName);
            Console.ReadKey();
        }
    }
}
