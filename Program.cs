using System;

namespace Program
{
    class MyClass
    {
        static void Main()
        {
            Console.Write("Введіть Ім'я : ");
            string a = Convert.ToString(Console.ReadLine());
            Console.Write("Введіть Прізвище : ");
            string b = Convert.ToString(Console.ReadLine());
            if (a == "Vova" && b == "Mihailenko")
            {
                Console.WriteLine("Зачекайте...................");
                Console.Write("Successful");
            }
            else
            {
                Console.Write("FAILED");
            }
        }
    }
}