using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            //  Пример 5.10 (**)
            // Ввести n чисел. Значение n вводится с консоли.
            // Определить наибольшее из введенных чисел.
            Console.WriteLine("Введите количество чисел");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int temp = 0;
            Console.WriteLine("Введите целые числа:");
            do
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > temp)
                    temp = number;
                i++;
            } while (number2 >= i);
            Console.WriteLine("наибольшее из введенных чисел = " + temp);
            Console.ReadLine();
            //Ответ:наибольшее из введенных чисел = 5629.

        }
    }
}

