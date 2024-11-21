using System;

namespace tumakov_lab_3
{
    internal class Program
    {
        static void Main()
        {
            //Написать программу, которая читает с экрана число от 1 до 365 (номер дня
            //в году), переводит этот число в месяц и день месяца.Например, число 40 соответствует 9
            //февраля(високосный год не учитывать).
            Console.WriteLine("Упражнение 4.1");
            int[] DaysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] MonthNames = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };

            Console.Write("Введите номер дня в году (число 1 до 365): ");
            int DayOfYear = int.Parse(Console.ReadLine());
            int month = 0;
            while (DayOfYear > DaysInMonth[month])
            {
                DayOfYear -= DaysInMonth[month];
                month++;
            }
            Console.WriteLine($"{DayOfYear} {MonthNames[month]}");

            //Добавить к задаче из предыдущего упражнения проверку числа введенного
            //пользователем.Если число меньше 1 или больше 365, программа должна вырабатывать
            //исключение, и выдавать на экран сообщение.
            Console.WriteLine("\nУпражнение 4.2");
            int[] DaysInMonth2 = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] MonthNames2 = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };

            Console.Write("Введите номер дня в году (число 1 до 365): ");
            int DayOfYear2 = int.Parse(Console.ReadLine());
            if (DayOfYear2 < 1 || DayOfYear2 > 365)
            {
                Console.WriteLine("Вы неккоректно ввели номер дня");
            }
            else
            {
                int month2 = 0;
                while (DayOfYear2 > DaysInMonth2[month2])
                {
                    DayOfYear2 -= DaysInMonth2[month2];
                    month2++;
                }
                Console.WriteLine($"{DayOfYear2} {MonthNames2[month2]}");
            }
            //Изменить программу из упражнений 4.1 и 4.2 так, чтобы она
            //учитывала год(високосный или нет). Год вводится с экрана. (Год високосный, если он
            //делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный
            //год.Однако, если он делится без остатка на 400, это високосный год.)

            Console.WriteLine("\nДомашнее задание 4.1");

            Console.Write("Введите год: ");
            string[] MonthNames3 = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
            int Year = int.Parse(Console.ReadLine());
            bool isLeap = (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
            Console.Write("Введите номер дня в году (от 1 до " + (isLeap ? 366 : 365) + "): ");
            int DayOfYear3 = int.Parse(Console.ReadLine());
            if (DayOfYear3 < 1 || DayOfYear3 > (isLeap ? 366 : 365))
            {
                Console.WriteLine("Некорректный номер дня.");
            }
            else
            {
                int[] daysInMonth3 = { 31, isLeap ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                int month3 = 0;
                while (DayOfYear3 > daysInMonth3[month3])
                {
                    DayOfYear3 -= daysInMonth3[month3++];
                }
                Console.WriteLine($"{DayOfYear3} {MonthNames3[month3]} {Year} года");
            }
        }
    }
}
