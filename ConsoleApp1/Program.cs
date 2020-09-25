using System;

namespace ConsoleApp1
{
    class Program
    {
        private static string[] textStrings = new string[]
        {
            "make choose that kind of coffee do you need with arrows on keyboard press ENTER to confirm\n",
            "1: Latte\n",
            "2: cappuccino\n",
            "3: Americano\n"
        };

        static void Text(int i)
        {
            Console.Clear();
            for (int n = 0; n < textStrings.Length; n++)
            {
                if (n == i)
                    PrintColored(textStrings[n], ConsoleColor.DarkRed, ConsoleColor.Green);
                else
                    Console.WriteLine(textStrings[n]);
            }
        }

        static void PrintColored(string text, ConsoleColor foreground, ConsoleColor background)
        {
            Console.BackgroundColor = background;
            Console.ForegroundColor = foreground;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        static int Keys()
        {
            int num = 0;
            bool flag = false;
            do
            {
                ConsoleKeyInfo keyPushed = Console.ReadKey();
                if (keyPushed.Key == ConsoleKey.DownArrow)
                {
                    num++;
                    Text(num);
                }

                if (keyPushed.Key == ConsoleKey.UpArrow)
                {
                    num--;
                    Text(num);
                }

                if (keyPushed.Key == ConsoleKey.Enter)
                {
                    flag = true;
                }

                if (num == 0)
                {
                    num = 4;
                    Text(4);
                }

                if (num == 5)
                {
                    num = 1;
                    Text(1);
                }
            } while (!flag);

            return num;
        }

        static void HiOut()
        {
            Console.WriteLine("  ####   ####  ###### ###### ###### ");
            Console.WriteLine(" #    # #    # #      #      #      ");
            Console.WriteLine(" #      #    # #####  #####  #####  ");
            Console.WriteLine(" #      #    # #      #      #      ");
            Console.WriteLine(" #    # #    # #      #      #      ");
            Console.WriteLine("  ####   ####  #      #      ###### ");
            Console.WriteLine("");

        }
        
        // _____________________________Program Main Body _______________________________________
        static void Main(string[] args)
        {
            HiOut();
            System.Threading.Thread.Sleep(2000);
            foreach (string text in textStrings)
                Console.WriteLine(text);
            int num = Keys();//вызов менюшки 
            switch (num)
            {
                case 1: { Console.WriteLine("выбор №1"); Console.ReadKey(); } break;
                case 2: { Console.WriteLine("выбор №2"); Console.ReadKey(); } break;
                case 3: { Console.WriteLine("выбор №3"); Console.ReadKey(); } break;
                case 4: { }; break;
            }
        }
    }
}