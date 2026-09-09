using System;

namespace _1_tumakov
{
    internal class Program
    {
        static void Main()
        {
            //Упражнение 2.1
            Console.WriteLine("Упр. 2.1");
            Console.WriteLine("Введите своё имя:");
            Console.WriteLine($"Привет, {Console.ReadLine()}!");

            //Упражнение 2.2
            Console.WriteLine("Упр. 2.2");
            Console.WriteLine("Введите первое целое число:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе целое число:");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
            }
            else
            {
                double result = (double)num1 / num2;
                Console.WriteLine($"Результат деления первого числа на второе: {result}");
            }



            //Домашнее задание 2.1
            Console.WriteLine("Домашнее задание 2.1");
            Console.WriteLine("Введите букву из латинского алфавита:");
            string char1 = Console.ReadLine();
            char new_char = char.Parse(char1); //Переведем из string в char,
                                             //чтобы сравнить с 'z'(это один символ), "z"(уже строка)
                                             //и чтобы дальше работать с числами
            if (new_char == 'Z' || new_char == 'z')
            {
                Console.WriteLine("После буквы Z/z нет следующей буквы");
            }
            else
            {
                int index = Convert.ToInt32(new_char); //С помощью таблицы Unicode(ASCII)
                                                     //находим код буквы
                int next_index = index + 1;
                char result1 = Convert.ToChar(next_index); //Обратно переводим из кода буквы в её значение
                Console.WriteLine($"Следующая буква после {char1}: {result1}");
            }


            //Домашнее задание 2.2
            Console.WriteLine("Домашнее задание 2.2");
            Console.WriteLine("Введите первый коэффициент: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй коэффициент: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третий коэффициент: ");
            int c = int.Parse(Console.ReadLine());
            int diskr = (b * b) - (4 * a * c);
            if (diskr < 0)
            {
                Console.WriteLine("Корни у уравнения отсутствуют");
            }
            else if (diskr == 0)
            {
                double x1 = (double)-b / (2 * a);
                Console.WriteLine($"Корень уравнения равен: {x1}");
            }
            else
            {
                double x1 = (-b - Math.Sqrt(diskr)) / (2 * a);
                double x2 = (-b + Math.Sqrt(diskr)) / (2 * a);
                Console.WriteLine($"Корни уравнения равны: {x1} и {x2}");
            }
        }
    }
}
