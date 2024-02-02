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
            /*string MyName;
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

            // 3.5 ВВОД И ВЫВОД НА КОНСОЛЬ
            Console.WriteLine("\tПривет,\n мир!");
            Console.WriteLine();

            string eName = "Евгения";
            Console.WriteLine("Привет, мир");
            Console.WriteLine();
            Console.WriteLine("Меня зовут " + eName);
            Console.WriteLine();
            Console.WriteLine("Меня зовут {0}", eName);
            Console.WriteLine();

            var myAge = 55;
            var myWeight = 100;
            Console.WriteLine("Возраст {0} \nВес {1}", myAge, myWeight);
            Console.WriteLine();
            Console.WriteLine("{0} \n  {1} \n {2}", "Jane", 27, "black");
            Console.WriteLine("===========================================");*/


            // ОСНОВНЫЕ ОПЕРАЦИИ С#
            /*Console.WriteLine();
            Console.WriteLine("ОСНОВНЫЕ ОПЕРАЦИИ C#");
            Console.WriteLine();

            double a = 5;
            double b = 2;
            double result = a / b;
            Console.WriteLine(result);
            Console.WriteLine();

            int counter = 10;
            Console.WriteLine("Value: {0} PrefixIncrement: {1}", counter, ++counter);
            counter = 10;
            Console.WriteLine("Value: {0} PostfixIncrement: {1}", counter, counter++);
            Console.WriteLine("Value: {0}", counter);

            double result2 = 5 / 2 * 3;
            Console.WriteLine($"Result = {result2}");

            double result3 = 10 % 3;
            Console.WriteLine(result3);*/

            // Преобразование типов
            /*Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = (byte) int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1}.", name, age);
            Console.WriteLine();*/

            // Задание 3.7.4
            string name;
            int age;
            DaysOfWeek favDay;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your name is {name} and age is {age}.");
            Console.Write("What is your favorite day of week? ");
            favDay = (DaysOfWeek) int.Parse(Console.ReadLine());
            Console.WriteLine($"Your favorite day is {favDay}.");

        }

        enum DaysOfWeek : byte
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        enum ProgramData : int
        {
            ProgramId = 123,
            AuthorId = 567
        }
        // Перечисление Semaphore
        enum Semaphore : int
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }
    }
}
