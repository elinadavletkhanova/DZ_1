using System;
using System.Threading;

namespace _1_DZ_s_faila
{
    internal class Program
    {
        static void Main()
        {
            //Зад. 1
            Console.WriteLine("Зад. 1");
            double e = Math.E;
            Console.WriteLine("Число e с точностью до десятых: {0:F1}", e);
            //F - это фиксированная точка, а цифра 1 означает 1 знак после запятой

            //Зад. 2
            Console.WriteLine("Зад. 2");
            Console.WriteLine(50);
            Console.WriteLine(10);

            //Зад. 3
            Console.WriteLine("Зад. 3");
            Random rand = new Random(); //Используем класс Random и создаём экземпляр для всего проекта
            Console.WriteLine($"{rand.Next()}");
            Console.WriteLine($"{rand.Next()}");
            Console.WriteLine($"{rand.Next()}");
            Console.WriteLine($"{rand.Next()}"); //Метод Next возвращает случайное целое число

            //Зад. 4
            Console.WriteLine("Зад. 4");
            Console.WriteLine("Введите число: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число на 10 большeе введённого: {num1 + 10}");

            //Зад. 5
            Console.WriteLine("Зад. 5");
            Console.WriteLine("Введите аргумент x (в градусах): ");
            int ugol = int.Parse(Console.ReadLine());
            double radian = ugol * (Math.PI / 180); //Перевод в радианы, т.к. Math.Cos работает только с ними
            Console.WriteLine($"cos(x) равен: {Math.Round(Math.Cos(radian), 2)}"); //Округлим до 2 знаков,
                                                                                   //чтобы получать ровные числа, например, при 90 градусах

            //Зад. 6
            Console.WriteLine("Зад. 6");
            Console.WriteLine("Введите первое число (большее основание трапеции): ");
            int osnovanie1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число (меньшее основание трапеции): ");
            int osnovanie2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число (высота трапеции): ");
            int height = int.Parse(Console.ReadLine());
            double x = (double)(osnovanie1 - osnovanie2) / 2;
            double bok_storona = Math.Sqrt((x * x) + (height * height)); //Sqrt - вычисляет кв. корень
            double perimetr = (bok_storona * 2) + osnovanie1 + osnovanie2;
            Console.WriteLine($"Периметр равнобедренной трапеции равен: {perimetr}");

            //Зад. 7
            Console.WriteLine("Зад. 7");
            Console.WriteLine("Мир " + "Труд " + "Май");
            Console.WriteLine("Мир");
            Console.WriteLine("\tТруд");
            Console.WriteLine("\t\tМай");

            //Зад. 8
            Console.WriteLine("Зад. 8");
            Console.WriteLine("Введите первое число: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number2}, {number1}");

            //Зад. 9
            Console.WriteLine("Зад. 9");
            Console.WriteLine("Введите число: ");
            int chislo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели число: {chislo}");

            //Зад. 10
            Console.WriteLine("Зад. 10");
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
                double x1 = (double) -b / (2 * a);
                Console.WriteLine($"Корень уравнения равен: {x1}");
            }
            else
            {
                double x1 = (-b - Math.Sqrt(diskr)) / (2 * a);
                double x2 = (-b + Math.Sqrt(diskr)) / (2 * a);
                Console.WriteLine($"Корни уравнения равны: {x1}, {x2}");
            }

            //Зад. 11
            Console.WriteLine("Зад. 11");
            Console.WriteLine("Введите первое число: ");
            int num_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int num_2 = int.Parse(Console.ReadLine());
            double sr_arifm = (double)(num_1 + num_2) / 2;
            double sr_geom = Math.Sqrt(num_1 * num_2);
            Console.WriteLine($"Среднее арифметическое чисел: {sr_arifm}");
            Console.WriteLine($"Среднее геометрическое чисел: {sr_geom}");

            //Зад. 12
            Console.WriteLine("Зад. 12");
            Console.WriteLine("Введите x первой точки: ");
            int x_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y первой точки: ");
            int y_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x второй точки: ");
            int x_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y второй точки: ");
            int y_2 = int.Parse(Console.ReadLine());
            double dist = Math.Sqrt((x_2 - x_1)*(x_2 - x_1) + (y_2 - y_1)*(y_2 - y_1));
            Console.WriteLine($"Расстояние между точками равно: {dist}");

            //Зад. 13
            Console.WriteLine("Зад. 13");
            Console.WriteLine("Введите первое число: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            int c1 = int.Parse(Console.ReadLine());
            int a0 = a1;
            int b0 = b1;
            int c0 = c1;
            int x_a = a0;
            a1 = b0;
            b1 = c0;
            c1 = x_a;
            Console.WriteLine($"а) a : {a1}, b : {b1}, c : {c1}");
            a1 = c0;
            b1 = a0;
            c1 = b0;
            Console.WriteLine($"б) a : {a1}, b : {b1}, c : {c1}");

            //Зад. 14
            Console.WriteLine("Зад. 14");
            Console.WriteLine("Введите, сколько секунд прошло с начала суток: ");
            int sec = int.Parse(Console.ReadLine());
            int hours = sec / 3600;
            int minutes = (sec % 3600) / 60;
            int sec1 = sec % 60;
            Console.WriteLine($"а) {hours}ч\nб) {minutes}мин\nв) {sec1}сек");

            //Зад. 15
            Console.WriteLine("Зад. 15");
            int side1 = 543;
            int side2 = 130;
            Console.WriteLine($"От прямоугольника можно отрезать {side1 / side2} квадрата со стороной {side2}мм");

            //Зад. 16
            Console.WriteLine("Зад. 16");
            Console.WriteLine("Введите трёхзначное число: ");
            int trehzn = int.Parse(Console.ReadLine());
            int sot_des = trehzn / 10;
            int trehzn1 = (trehzn % 10) * 100 + sot_des;
            Console.WriteLine($"Полученное число равно: {trehzn1}");

            //Зад. 17
            Console.WriteLine("Зад. 17");
            Console.WriteLine("Введите число большее 999: ");
            int numb1 = int.Parse(Console.ReadLine());
            int tys = numb1 / 1000;
            int sot = numb1 / 100; //В решении данной задачи нахожу количество полных сотен и тысяч в числе
            Console.WriteLine($"а) сотни: {sot}\nб) тысячи: {tys}");

            //Зад. 18
            Console.WriteLine("Зад. 18");
            Console.WriteLine("Введите своё имя: ");
            Console.WriteLine($"а) {Console.ReadLine()}");
            Console.WriteLine("Введите своё имя: ");
            Console.WriteLine($"б) Привет, {Console.ReadLine()}!");

            //Зад. 19
            Console.WriteLine("Зад. 19");
            Console.WriteLine("Привет, Консоль!");
            Console.WriteLine("Как вас зовут?");
            Console.WriteLine($"Привет, {Console.ReadLine()}");
            Console.WriteLine("Знаешь ли ты что-то о тайной комнате?");
            Console.WriteLine("Да");
            Console.WriteLine("Можешь рассказать?");
            Console.WriteLine("Нет");
            Thread.Sleep(5000); //Приостанавливает текущий поток, 5000 в миллисекундах = 5с
            Console.WriteLine("Но могу показать");
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor)); //Создаем массив всех
                                                                                                  //возможных цветов консоли
            int index = rand.Next(colors.Length); // Length - число элементов в массиве
                                                          // colors, выбираем случайный цвет
            Console.BackgroundColor = colors[index];
            Console.Clear(); //очищаем экран консоли, чтобы новый фон применился
                             //ко всей консоли, не только к одному заданию
            Thread.Sleep(2000);
            Console.BackgroundColor = ConsoleColor.Black; //Возвратим черный цвет консоли для зад. 20 и очистим экран
            Console.Clear();

            //Зад. 20
            Console.WriteLine("Зад. 20");
            int sumodd = 0;
            int sumeven = 0;
            string nums12 = $"{rand.Next(0, 10)}{rand.Next(0, 10)}{rand.Next(0, 10)}{rand.Next(0, 10)}" +
                $"{rand.Next(0, 10)}{rand.Next(0, 10)}{rand.Next(0, 10)}{rand.Next(0, 10)}" +
                $"{rand.Next(0, 10)}{rand.Next(0, 10)}{rand.Next(0, 10)}{rand.Next(0, 10)}";
            Console.WriteLine($"Введено: {nums12}");
            for (int i = 0; i < 12; i ++)
            {
                if (i % 2 == 0)
                {
                    sumodd += int.Parse(nums12[i].ToString()); //nums12[i] - это char, един. символ, который надо
                                                               //сначала перевести в string с помощью ToString, а после
                                                               //перевести в int, чтобы добавить число
                }
                else
                {
                    sumeven += int.Parse(nums12[i].ToString());
                }
            }
            int summ = (sumeven * 3) + sumodd;
            Console.WriteLine($"a) Контрольная цифра: {(10 - (summ % 10)) % 10}"); //Последняя операция остатка нужна для того,
                                                                                   //чтобы в случае контр. цифры в виде 0
                                                                                   //консоль вывела не 10, а 0
            Console.WriteLine("Введите 12 цифр подряд в строчку: ");
            string numbers = Console.ReadLine();
            Console.WriteLine($"Введено: {numbers}");
            sumodd = 0;
            sumeven = 0;
            for (int i = 0; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    sumodd += int.Parse(numbers[i].ToString());
                }
                else
                {
                    sumeven += int.Parse(numbers[i].ToString());
                }
            }
            int summ1 = (sumeven * 3) + sumodd;
            Console.WriteLine($"б) Контрольная цифра: {(10 - (summ1 % 10)) % 10}");
        }
    }
}
