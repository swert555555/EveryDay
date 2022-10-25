using System.Security.Cryptography.X509Certificates;

namespace Ежедневник
{
    internal class Program
    {
        //# include <studio.h> это я нашла в с++...
        //string DataStr;

        static void Main()
        {
            
            var date = DateTime.Now;
            Console.WriteLine(date.ToShortDateString() + ", " + date.DayOfWeek);
            Date(date);
        }
        static void Date(DateTime VvodDate)
        {
            string DataStr;
            int i = 0;
            ConsoleKeyInfo key = Console.ReadKey();
            for (; key.Key != ConsoleKey.Escape; key = Console.ReadKey())
            {
                if (key.Key == ConsoleKey.RightArrow)
                    i++;
                else if (key.Key == ConsoleKey.LeftArrow)
                    i--;
                var NewDate = VvodDate.AddDays(i);
                Console.Clear();
                DataStr = NewDate.ToShortDateString() + ", " + NewDate.DayOfWeek;
                Console.WriteLine(DataStr);
            }
            Strelka(DataStr);
        }
        static void Strelka(string DataVivod)
        {
            int position = 1;
            Menu();
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.UpArrow)
            {
                if (key.Key == ConsoleKey.UpArrow)
                    position--;
                else
                    position++;
                Console.Clear();
                Menu();
                Console.WriteLine(DataVivod);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                key = Console.ReadKey();
            }
            Console.Clear();
            Main();
        }

        static void Menu()
        {

            Console.WriteLine("  Планы на день:");
            Console.WriteLine("  1. Встать");
            Console.WriteLine("  2. Прити на пары");
            Console.WriteLine("  3. Поесть на парах");
            Console.WriteLine("  4. Отправиться домой");
            Console.WriteLine("  5. Лечь спать 'пораньше'");
        }
        static void Zadachi()
        {
            Планы nom1 = new Планы();
            nom1.Name = "Проснуться утром";
            nom1.Opisanie = "Не проспать будильник, открыть глаза, вылезти из-под одеяла и пойти готовиться к колледжу...";
            //nom1.date = DateTime(2022, 10, 26);
            
        }
    }
}