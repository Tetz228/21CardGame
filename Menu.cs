using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
    class Menu
    {
        public Menu()
        {
        }

        public Menu(int item)
        {
            NumberItem = item;
        }

        public int NumberItem { get; set; }

        #region Вывод пунктов меню и выделение выбранной строки
        internal void DisplayingMenuItems(Array menu, int MenuItemNumber)
        {
            Console.Clear();
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("21");
            Console.ResetColor();

            if (MenuItemNumber == 1)
            {
                Console.Write("\t\t\t\t\t\t\t");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.White;

                Console.WriteLine(menu.GetValue(0));
                Console.ResetColor();

                Console.WriteLine($"\t\t\t\t\t\t\t{menu.GetValue(1)}");
                Console.WriteLine($"\t\t\t\t\t\t\t{menu.GetValue(2)}");
                Console.WriteLine($"\t\t\t\t\t\t\t{menu.GetValue(3)}");
                Console.WriteLine($"\t\t\t\t\t\t\t{menu.GetValue(4)}");
            }
            else if (MenuItemNumber == 2)
            {
                Console.Write($"\t\t\t\t\t\t\t{menu.GetValue(0)}\n\t\t\t\t\t\t\t");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.White;

                Console.WriteLine(menu.GetValue(1));
                Console.ResetColor();

                Console.WriteLine($"\t\t\t\t\t\t\t{menu.GetValue(2)}");
                Console.WriteLine($"\t\t\t\t\t\t\t{menu.GetValue(3)}");
                Console.WriteLine($"\t\t\t\t\t\t\t{menu.GetValue(4)}");
            }
            else if (MenuItemNumber == 3)
            {
                Console.WriteLine($"\t\t\t\t\t\t\t{menu.GetValue(0)}");
                Console.Write($"\t\t\t\t\t\t\t{menu.GetValue(1)}\n\t\t\t\t\t\t\t");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.White;

                Console.WriteLine(menu.GetValue(2));
                Console.ResetColor();

                Console.WriteLine($"\t\t\t\t\t\t\t{menu.GetValue(3)}");
                Console.WriteLine($"\t\t\t\t\t\t\t{menu.GetValue(4)}");

            }
            else if (MenuItemNumber == 4)
            {
                Console.WriteLine($"\t\t\t\t\t\t\t{menu.GetValue(0)}");
                Console.WriteLine($"\t\t\t\t\t\t\t{menu.GetValue(1)}");
                Console.Write($"\t\t\t\t\t\t\t{menu.GetValue(2)}\n\t\t\t\t\t\t\t");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.White;

                Console.WriteLine(menu.GetValue(3));
                Console.ResetColor();

                Console.WriteLine($"\t\t\t\t\t\t\t{menu.GetValue(4)}");
            }
            else
            {
                Console.WriteLine($"\t\t\t\t\t\t\t{menu.GetValue(0)}");
                Console.WriteLine($"\t\t\t\t\t\t\t{menu.GetValue(1)}");
                Console.WriteLine($"\t\t\t\t\t\t\t{menu.GetValue(2)}");
                Console.Write($"\t\t\t\t\t\t\t{menu.GetValue(3)}\n\t\t\t\t\t\t\t");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.White;

                Console.WriteLine(menu.GetValue(4));
                Console.ResetColor();
            }
        }
        #endregion
    }
}
