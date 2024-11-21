using System;

namespace file_dz_3
{
    class Program
    {
        /// <summary>
        /// перечислимый тип данных, отображающий масти карт
        /// </summary>
        enum СardNumbers
        {
            Шестерка = 6,
            Семерка = 7,
            Восьмерка = 8,
            Девятка = 9,
            Десятка = 10,
            Валет = 11,
            Дама = 12,
            Король = 13,
            Туза = 14
        }
        /// <summary>
        /// перечислимый тип данных, отображающий дни недели
        /// </summary>
        enum DayOfWeak
        {
            понедельник = 1,
            вторник,
            среда,
            четверг,
            пятница,
            суббота,
            воскресенье,
        }
        static void Main()
        {
            Console.WriteLine("Задание 1");
            //Дана последовательность из 10 чисел.Определить, является ли эта последовательность
            //упорядоченной по возрастанию.В случае отрицательного ответа определить
            //порядковый номер первого числа, которое нарушает данную последовательность.
            //Использовать break.
            int[] numbers = new int[10];
            Console.WriteLine("Введите 10 чисел:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 9; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    Console.WriteLine($"Последовательность не упорядочена. Первое нарушение на позиции: {i + 2}.");
                    break;
                }
            }
            Console.WriteLine("Последовательность упорядочена по возрастанию.");

            Console.WriteLine("\nЗадание 2");
            //Игральным картам условно присвоены следующие порядковые номера в зависимости от
            //их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
            //Порядковые номера остальных карт соответствуют их названиям(«шестерка»,
            //«девятка» и т.п.).По заданному номеру карты k(6 <= k <= 14) определить достоинство
            //соответствующей карты. Использовать try-catch-finally.

            Console.WriteLine("Введите номер карты (число от 6 до 14): ");
            string input = Console.ReadLine();
            int number;
            try
            {

                if (int.TryParse(input, out number) && (number < 6 || number > 14))
                {
                    Console.WriteLine("Ошибка: номер карты должен быть в диапазоне от 6 до 14.");
                }
                else
                {
                    СardNumbers rank = (СardNumbers)number;
                    Console.WriteLine($"Ваша карта: {rank}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Ошибка: номер карты должен быть в диапазоне от 6 до 14.");
            }
            finally
            {
                Console.WriteLine("Программа завершила свою работу.");
            }

            Console.WriteLine("\nЗадание 3");
            //программа, которая принимает на входе строку и производит выходные
            //данные в соответствии со таблицей
            Console.WriteLine("Введите строку");
            string line = Console.ReadLine();
            switch (line.ToLower())
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "Politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }

            Console.WriteLine("\nЗадание 4");
            //Составить программу, которая в зависимости от порядкового номера дня недели(1, 2,
            //..., 7) выводит на экран его название(понедельник, вторник, ..., воскресенье).
            //Использовать enum.
            Console.Write("Введите номер дня недели (от 1 до 7): ");
            int i2 = int.Parse(Console.ReadLine());
            if (i2 >= 1 && i2 <= 7)
            {
                DayOfWeak day = (DayOfWeak)i2;
                Console.WriteLine($"День недели: {day}");
            }
            else
            {
                Console.WriteLine("Вы ошиблись при вводе номера дня недели");
            }

            Console.WriteLine("\nЗадание 5");
            //Создать массив строк.При помощи foreach обойти весь массив.При встрече элемента
            //"Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е.прибавить к
            //результату.Вывести на экран сколько кукол в “сумке”.
            string[] toys = { "Soft toy", "Bunny", "Barbie doll", "Hello Kitty", "Kinder Toy", "LEGO", "Unicorn", "Hello Kitty", "Bear" };
            int BagCount = 0;
            foreach (string doll in toys)
            {
                if (doll == "Barbie doll" || doll == "Hello Kitty")
                {
                    BagCount++;
                }
            }
            Console.WriteLine($"Кукол в сумке: {BagCount}");
        }
    }
}
