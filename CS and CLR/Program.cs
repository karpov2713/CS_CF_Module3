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

            Console.WriteLine("\u0023"); // Символ # Unicode

            // Логические литералы
            Console.WriteLine("Логические литералы");
            Console.WriteLine(true);
            Console.WriteLine(false);

            // Числовые литералы
            Console.WriteLine("Числовые литералы");
            Console.WriteLine(5);

            // Небольшая анкета
            string jName = "Jane";
            byte age = 27;
            bool HaveIApet = true;
            double MyShoeSize = 37.5;

            Console.WriteLine("My name is " + jName);
            Console.WriteLine("My age is " + age);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);

            // Диапазоны значений некоторых типов данных.
            Console.WriteLine($"IntMin: {int.MinValue}");
            Console.WriteLine($"IntMax: {int.MaxValue}");
            Console.WriteLine($"sbyte: от {sbyte.MinValue} до {sbyte.MaxValue}");

            // 3.4 ПЕРЕЧИСЛЕНИЯ
            // Определено за пределами метода Main
            DaysOfWeek MyFavoriteDay;
            MyFavoriteDay = DaysOfWeek.Friday;
            Console.WriteLine(MyFavoriteDay);

        }

        enum DaysOfWeek : byte
        {
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }
    }
}
