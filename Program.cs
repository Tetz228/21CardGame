using System;
using System.Media;
using System.Threading;
using System.Threading.Tasks;

namespace Game21
{
    enum Menu
    {
        StartGame,
        Settings,
        Records,
        About,
        Exit
    }

    class Program
    {
        #region Окно "Settings"
        static void MenuSettings(out bool enableMusic)
        {
            enableMusic = false;

            ConsoleKeyInfo key;

            do
            {
                if (enableMusic == true)
                {
                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t    ");
                    Console.Write("Music - ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("enable");
                    Console.ResetColor();
                }
                else
                {
                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t    ");
                    Console.Write("Music - ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("disable");
                    Console.ResetColor();
                }

                key = Console.ReadKey(false);

                if (key.Key == ConsoleKey.Enter)
                {
                    if (enableMusic == false)
                    {
                        enableMusic = true;
                    }
                    else
                    {
                        enableMusic = false;
                    }
                }

            } while (key.Key != ConsoleKey.Backspace);
        }
        #endregion

        #region О авторе
        static void rainbow()
        {
            for (int i = 0; i < 6; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Thread.Sleep(50);
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Thread.Sleep(50);
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Thread.Sleep(50);
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Thread.Sleep(50);
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Thread.Sleep(50);
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Thread.Sleep(50);
                        break;
                }
                Console.Clear();
                Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t");
                Console.Write("Author: Bereberdin Mikhail\n\t\t\t\t\t\t\t    ");
            }
        }
        #endregion

        #region Окно "About"
        static void SecretShop(string[] menu, int Item)
        {
            Task rain = new Task(rainbow);
            ConsoleKeyInfo Key;
            int secStart = DateTime.Now.Second;
            int secEnd = secStart + 20;


            Console.Clear();
            SoundPlayer player = new SoundPlayer(_21CardGame.Properties.Resources.bit);
            player.Stop();
            player.Play();
            do
            {
                rain.Start();
                Key = Console.ReadKey();
            } while (Key.Key != ConsoleKey.Backspace);

            player.Stop();
            OutputMenuScreen(menu, Item = 1);
        }
        #endregion

        #region Вывод интерфейса меню в зависимости от Item
        static void OutputMenuScreen(string[] menu, int Item)
        {
            if (Item == 1)
            {
                Console.Clear();
                Console.CursorVisible = false;
                Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t    ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("21\n");
                Console.Write("\t\t\t\t\t\t\t");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(menu[0] + "\n");
                Console.ResetColor();
                Console.Write("\t\t\t\t\t\t\t" + menu[1] + "\n");
                Console.Write("\t\t\t\t\t\t\t" + menu[2] + "\n");
                Console.Write("\t\t\t\t\t\t\t" + menu[3] + "\n");
                Console.Write("\t\t\t\t\t\t\t" + menu[4] + "\n");
            }
            else if (Item == 2)
            {
                Console.Clear();
                Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t    ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("21\n");
                Console.ResetColor();
                Console.Write("\t\t\t\t\t\t\t" + menu[0] + "\n");
                Console.Write("\t\t\t\t\t\t\t");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(menu[1] + "\n");
                Console.ResetColor();
                Console.Write("\t\t\t\t\t\t\t" + menu[2] + "\n");
                Console.Write("\t\t\t\t\t\t\t" + menu[3] + "\n");
                Console.Write("\t\t\t\t\t\t\t" + menu[4] + "\n");
            }
            else if (Item == 3)
            {
                Console.Clear();
                Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t    ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("21\n");
                Console.ResetColor();
                Console.Write("\t\t\t\t\t\t\t" + menu[0] + "\n");
                Console.Write("\t\t\t\t\t\t\t" + menu[1] + "\n");
                Console.Write("\t\t\t\t\t\t\t");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(menu[2] + "\n");
                Console.ResetColor();
                Console.Write("\t\t\t\t\t\t\t" + menu[3] + "\n");
                Console.Write("\t\t\t\t\t\t\t" + menu[4] + "\n");

            }
            else if (Item == 4)
            {
                Console.Clear();
                Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t    ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("21\n");
                Console.ResetColor();
                Console.Write("\t\t\t\t\t\t\t" + menu[0] + "\n");
                Console.Write("\t\t\t\t\t\t\t" + menu[1] + "\n");
                Console.Write("\t\t\t\t\t\t\t" + menu[2] + "\n");
                Console.Write("\t\t\t\t\t\t\t");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(menu[3] + "\n");
                Console.ResetColor();
                Console.Write("\t\t\t\t\t\t\t" + menu[4] + "\n");
            }
            else if (Item == 5)
            {
                Console.Clear();
                Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t    ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("21\n");
                Console.ResetColor();
                Console.Write("\t\t\t\t\t\t\t" + menu[0] + "\n");
                Console.Write("\t\t\t\t\t\t\t" + menu[1] + "\n");
                Console.Write("\t\t\t\t\t\t\t" + menu[2] + "\n");
                Console.Write("\t\t\t\t\t\t\t" + menu[3] + "\n");
                Console.Write("\t\t\t\t\t\t\t");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(menu[4] + "\n");
                Console.ResetColor();
            }

        }
        #endregion

        #region Окно меню
        static bool MenuScreen(bool enableMusic)
        {
            SoundPlayer player = new SoundPlayer(_21CardGame.Properties.Resources.mainMusic);

            int Item = 1;

            ConsoleKeyInfo key;

            bool item = false;

            string[] menu = new string[5] { "Start game", " Settings ", " Records  ", "   About  ", "   Exit   " };

            OutputMenuScreen(menu, Item);
            while (item != true)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                key = Console.ReadKey(false);
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (Item == 1)
                        Item = 5;
                    else
                        Item--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (Item == 5)
                    {
                        Item = 1;
                    }
                    else
                    {
                        Item++;
                    }
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    Console.ResetColor();
                    if (Item == 1)
                    {
                        return true;
                    }
                    else if (Item == 2)
                    {
                        MenuSettings(out enableMusic);
                        if (enableMusic == true)
                        {
                            player.PlayLooping();
                        }
                        else
                        {
                            player.Stop();
                        }
                    }
                    else if (Item == 3)
                    {
                        //MenuRecords(dir);
                    }
                    else if (Item == 4)
                    {
                        SecretShop(menu, Item);
                    }
                    else Environment.Exit(0);
                }
                Console.ResetColor();
                //Меню
                OutputMenuScreen(menu, Item);
            }
            if (item == false)
            {
                return false;
            }
            else return true;
        }
        #endregion

        #region Сумма карт игрока
        static int SumPlayerFunc(int[] CardsInHand, int card)
        {
            int SumPlayer = 0;
            for (int i = 0; i <= card; i++)
            {
                SumPlayer += CardsInHand[i];
            }
            return SumPlayer;
        }
        #endregion

        #region Сумма карт банкира
        static int SumBotFunc(int[] CardsBot, int positionCard, ref int[] Deck, int card, int[] CardsInHand)
        {
            int SumBot = 0;
            int i = 0;
            if (SumPlayerFunc(CardsInHand, card) < 21)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n[Bankir]");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(":[");
                Console.ResetColor();
            }
            while (SumBot < 17)
            {
                CardsBot[i] = Deck[positionCard];
                SumBot += CardsBot[i];
                positionCard++;
                if (SumPlayerFunc(CardsInHand, card) < 21)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (CardsBot[i] == 2)
                    {
                        Console.Write("J ");
                    }
                    else if (CardsBot[i] == 3)
                    {
                        Console.Write("Q ");
                    }
                    else if (CardsBot[i] == 4)
                    {
                        Console.Write("K ");
                    }
                    else if (CardsBot[i] == 11)
                    {
                        Console.Write("A ");
                    }
                    else { Console.Write(CardsBot[i] + " "); }
                    Console.ResetColor();
                    i++;
                    Thread.Sleep(1000);
                }
                else i++;
            }
            if (SumPlayerFunc(CardsInHand, card) < 21)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("] = ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", SumBot);
                Console.ResetColor();
                Thread.Sleep(2000);
            }
            i = 0;
            return SumBot;
        }
        #endregion

        #region Вывод карт в руке
        static void OutputWindowGame(int money, string NamePlayer, int card, int[] CardsInHand, int[] Deck, int positionCard)
        {
            int sum = 0;
            Hud(NamePlayer, money);
            CardsInHand[card] = Deck[positionCard];
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\nCards:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            for (int i = 0; i < 10; i++)
            {
                if (CardsInHand[i] == 0)
                {
                }
                else
                if (CardsInHand[i] == 2)
                {
                    Console.Write("J ");
                }
                else if (CardsInHand[i] == 3)
                {
                    Console.Write("Q ");
                }
                else if (CardsInHand[i] == 4)
                {
                    Console.Write("K ");
                }
                else if (CardsInHand[i] == 11)
                {
                    Console.Write("A ");
                }
                else Console.Write(CardsInHand[i] + " ");
                sum += CardsInHand[i];
            }
            Console.WriteLine("= {0}", sum);
            Console.ResetColor();
        }
        #endregion

        #region Вывод информации о победе банкира
        static void BankirWin(int card, int[] CardsBot, int[] CardsInHand, int ScoreBankir, int money, int cost)
        {
            if (SumPlayerFunc(CardsInHand, card) > 21)
            {
                Thread.Sleep(2000);
                Console.Clear();
                Console.Write("\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t    ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Bankir WiN!!!");
                Console.ResetColor();
                Console.WriteLine("\n\n\t\t\t\t\t\t    Your score:{0}", SumPlayerFunc(CardsInHand, card));
                Console.Write("\n\t\t\t\t\t       Money:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}", money + cost);
                Console.ResetColor();
                Console.Write(" - ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}", cost);
                Console.ResetColor();
                Console.Write(" = ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}$", money);
                Console.ResetColor();
                Console.Write("\n\n\t\t\t\t\t    ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Press any key for next game...");
                Console.ResetColor();
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.Write("\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t    ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Bankir WiN!!!");
                Console.ResetColor();
                Console.WriteLine("\n\n\t\t\t\t\t\t   Score Bankir:{0}", ScoreBankir);
                Console.WriteLine("\n\t\t\t\t\t\t    Your score:{0}", SumPlayerFunc(CardsInHand, card));
                Console.Write("\n\t\t\t\t\t        Money:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}", money + cost);
                Console.ResetColor();
                Console.Write(" - ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}", cost);
                Console.ResetColor();
                Console.Write(" = ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}$", money);
                Console.ResetColor();
                Console.Write("\n\n\t\t\t\t\t    ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Press any key for next game...");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
        #endregion

        #region Ничья
        static void Draw(int[] CardsInHand, int card, int ScoreBankir, int cost, int money)
        {
            Console.Clear();
            Console.Write("\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("DRAW!!!");
            Console.ResetColor();
            Console.WriteLine("\n\n\t\t\t\t\t\t  Your score:{0}", SumPlayerFunc(CardsInHand, card));
            Console.WriteLine("\n\t\t\t\t\t\t Score Bankir:{0}", ScoreBankir);
            Console.Write("\n\t\t\t\t\t\t  Money:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("{0}$", money + cost);
            Console.ResetColor();
            Console.Write("\n\n\t\t\t\t\t  ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Press any key for next game...");
            Console.ResetColor();
            Console.ReadKey();
        }
        #endregion

        #region Вывод информации о победе игрока
        static void PlayerWin(int card, int[] CardsBot, int[] CardsInHand, int ScoreBankir, int money, int cost)
        {
            if (money + cost * 2 < 0)
            {
                Console.Clear();
                Console.WriteLine("You win!");
                Thread.Sleep(5000);
            }
            else
            {
                Console.Clear();
                Console.Write("\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t    ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("You WiN!!!");
                Console.ResetColor();
                Console.WriteLine("\n\n\t\t\t\t\t\t  Your score:{0}", SumPlayerFunc(CardsInHand, card));
                if (SumPlayerFunc(CardsInHand, card) < 21)
                {
                    Console.WriteLine("\n\t\t\t\t\t\t Score Bankir:{0}", ScoreBankir);
                }
                Console.Write("\n\t\t\t\t\t      Money:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}", money + cost);
                Console.ResetColor();
                Console.Write(" + ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}", cost);
                Console.ResetColor();
                Console.Write(" = ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}$", money + cost * 2);
                Console.ResetColor();
                Console.Write("\n\n\t\t\t\t\t  ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Press any key for next game...");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
        #endregion

        #region Результат игры
        static bool ResultGame(int ScoreBankir, int[] CardsInHand, int card, bool win, out string Winner, int[] CardsBot, int money, int cost)
        {
            if (SumPlayerFunc(CardsInHand, card) > 21)
            {
                BankirWin(card, CardsBot, CardsInHand, ScoreBankir, money, cost);
                Winner = "Bot";
                return true;
            }
            else if (SumPlayerFunc(CardsInHand, card) == 21)
            {
                PlayerWin(card, CardsBot, CardsInHand, ScoreBankir, money, cost);
                Winner = "Player";
                return true;
            }
            else if (ScoreBankir == SumPlayerFunc(CardsInHand, card))
            {
                Draw(CardsInHand, card, ScoreBankir, cost, money);
                Winner = "Draw";
                return true;
            }
            else if (ScoreBankir >= SumPlayerFunc(CardsInHand, card) && ScoreBankir <= 21)
            {
                BankirWin(card, CardsBot, CardsInHand, ScoreBankir, money, cost);
                Winner = "Bot";
                return true;
            }
            else
            {
                PlayerWin(card, CardsBot, CardsInHand, ScoreBankir, money, cost);
                Winner = "Player";
                return true;
            }
        }
        #endregion

        #region Сброс переменных на стандартные
        static void DefaultSettings(out int[] CardsBot, out int[] CardsInHand, out int cost, out int card, out string Winner, out bool win, out int[] Deck, out int positionCard)
        {
            positionCard = 0;
            CardsBot = new int[20];
            CardsInHand = new int[20];
            Deck = new int[36];
            win = false;
            cost = 0; card = 0;
            Winner = "";
        }
        #endregion

        #region Вывод интерфейса
        static void Hud(string NamePlayer, int money)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[{0}] ", NamePlayer);
            Console.ResetColor();
            Console.Write("-");
            Console.Write(" money:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("{0}$", money);
            Console.ResetColor();
        }
        #endregion

        #region Приглашение в игру
        static bool NamePl(out string NamePlayer)
        {
            string passwordForMikle;
        EnterName:
            Console.Clear();
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t        Your name?\n\n\t\t\t\t\t\t\t");
            Console.ForegroundColor = ConsoleColor.Cyan;
            NamePlayer = Console.ReadLine();
            Console.ResetColor();
            if (NamePlayer == "TvorecAvtor")
            {
                Console.Write("Error: please,enter another name!");
                Thread.Sleep(2000);
                goto EnterName;
            }
            if (NamePlayer == "mikle")
            {
                Console.Write("\nEnter pass:");
                Console.ForegroundColor = ConsoleColor.Black;
                passwordForMikle = Console.ReadLine();
                Console.ResetColor();
                if (passwordForMikle == "dadaya")
                {
                    NamePlayer = "TvorecAvtor";
                }
                else goto EnterName;
            }
            if (NamePlayer == "name" || NamePlayer == "Name")
            {
                NamePlayer = "Ochen' original'no,ksta!";
            }
            Console.ResetColor();
            if (NamePlayer == "")
            {
                Console.WriteLine("Error:Name cant be empty");
                Thread.Sleep(2000);
                goto EnterName;
            }
            return true;
        }
        #endregion 

        #region Рандом колоды
        static int[] GenerateDeck(out int[] Deck)
        {
            Random rand = new Random();
            int count = 0;
            int card = rand.Next(2, 12);
            while (card == 5)
            {
                card = rand.Next(2, 12);
            }
            Deck = new int[36];
            for (int j = 2; j < 12; j++)
            {
                if (j == 5)
                {
                    //nothing
                }
                else
                {
                    while (count < 4)
                    {
                        int i = rand.Next(0, 36);
                        if (Deck[i] == 0)
                        {
                            Deck[i] = j;
                            count++;
                        }
                    }

                }
                count = 0;
            }
            return Deck;
        }
        #endregion

        #region Старт программы
        static void Main()
        {
        Newgame:
            bool enableMusic = false;
            if (MenuScreen(enableMusic) == true)
            {
                int[] Deck = new int[36];
                ConsoleKeyInfo key;
                int[] CardsInHand = new int[20];
                int[] CardsBot = new int[20];
                string NamePlayer, Winner, costErr;
                bool win = false;
                GenerateDeck(out Deck);
                int money = 1000, positionCard = 0, cost = 0, card = 0;
                if (NamePl(out NamePlayer) == true)
                {
                    goto Game;
                }
                else Environment.Exit(0);
                Game:
                while (money > 0)
                {
                    DefaultSettings(out CardsBot, out CardsInHand, out cost, out card, out Winner, out win, out Deck, out positionCard);
                    Deck = GenerateDeck(out Deck);
                    while (win != true)
                    {
                    entermoney:
                        do
                        {
                            Console.Clear();
                            Hud(NamePlayer, money);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n\n'menu'");
                            Console.ResetColor();
                            Console.Write(" ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("'exit'");
                            Console.ResetColor();
                            if (NamePlayer == "TvorecAvtor")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(" 'gold'");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(" 'name'");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write(" 'draw'");
                                Console.Write(" 'win'");
                                Console.Write(" 'lose'");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(" 'deck'");
                                Console.Write(" 'f5'");
                                Console.ResetColor();
                            }
                            Console.Write("\n\nYour bet: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            costErr = Console.ReadLine();
                            Console.ResetColor();
                            if (costErr == "exit" || costErr == "Exit")
                            {
                                Environment.Exit(0);
                            }
                            else if (costErr == "menu" || costErr == "Menu")
                            {
                                if (MenuScreen(enableMusic) == false)
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    goto Game;
                                }
                            }
                            else if (costErr == "max")
                            {
                                costErr = Convert.ToString(money);
                            }
                            else if ((NamePlayer == "TvorecAvtor") & (costErr == "gold" || costErr == "Gold"))
                            {
                                string moneyErr;
                                do
                                {
                                    Console.Write("Enter money (1-2,147,483,647):");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    moneyErr = Console.ReadLine();
                                    if (moneyErr == "max")
                                    {
                                        moneyErr = "2147483647";
                                    }
                                    Console.ResetColor();
                                } while (!int.TryParse(moneyErr, out money));
                            }
                            else if ((NamePlayer == "TvorecAvtor") & costErr == "name")
                            {
                                Console.Write("Enter new Name:");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                NamePlayer = Console.ReadLine();
                                Console.ResetColor();
                            }
                            else if ((NamePlayer == "TvorecAvtor") & costErr == "draw")
                            {
                                int ScoreBankir = 0;
                                Draw(CardsInHand, card, ScoreBankir, cost, money);
                            }
                            else if ((NamePlayer == "TvorecAvtor") & costErr == "win")
                            {
                                int ScoreBankir = 0;
                                PlayerWin(card, CardsBot, CardsInHand, ScoreBankir, money, cost);
                            }
                            else if ((NamePlayer == "TvorecAvtor") & costErr == "lose")
                            {
                                int ScoreBankir = 0;
                                BankirWin(card, CardsBot, CardsInHand, ScoreBankir, money, cost);
                            }
                            else if ((NamePlayer == "TvorecAvtor") & costErr == "deck")
                            {
                                for (int i = 0; i < 36; i++)
                                {

                                    Console.Write(Deck[i] + " ");
                                }
                                Console.Write("\nPress any button...");
                                Console.ReadKey(false);
                            }
                            else if ((NamePlayer == "TvorecAvtor") & costErr == "f5")
                            {

                                GenerateDeck(out Deck);
                            }

                        } while (!int.TryParse(costErr, out cost));
                        if (cost > money || cost <= 0)
                        {
                            Console.Write("\n\nError:min bet - ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("1$");
                            Console.ResetColor();
                            Console.Write("\nmax bet - ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("{0}$", money);
                            Console.ResetColor();
                            Thread.Sleep(2000);
                            goto entermoney;
                        }
                        else
                        {
                            money -= cost;
                        }
                        OutputWindowGame(money, NamePlayer, card, CardsInHand, Deck, positionCard);
                        positionCard++;
                        if (SumPlayerFunc(CardsInHand, card) < 21)
                        {
                        GiveCard:
                            if (NamePlayer == "TvorecAvtor")
                            {
                                Console.Write("\n\n\nMore?(Y/N/C)\n");
                            }
                            else
                            {
                                Console.Write("\n\n\nMore?(Y/N)\n");
                            }
                        Repeat:
                            Console.ForegroundColor = ConsoleColor.Black;
                            key = Console.ReadKey(false);
                            Console.ResetColor();
                            if (key.Key == ConsoleKey.N)
                            {
                                int ScoreBankir = SumBotFunc(CardsBot, positionCard, ref Deck, card, CardsInHand);
                                win = ResultGame(ScoreBankir, CardsInHand, card, win, out Winner, CardsBot, money, cost);
                            }
                            else if (key.Key == ConsoleKey.Y)
                            {
                                card++;
                                OutputWindowGame(money, NamePlayer, card, CardsInHand, Deck, positionCard);
                                positionCard++;
                                if (SumPlayerFunc(CardsInHand, card) < 21)
                                {
                                    goto GiveCard;
                                }
                                else
                                {
                                    int ScoreBankir = SumBotFunc(CardsBot, positionCard, ref Deck, card, CardsInHand);
                                    win = ResultGame(ScoreBankir, CardsInHand, card, win, out Winner, CardsBot, money, cost);
                                }
                            }
                            else if (key.Key == ConsoleKey.C && NamePlayer == "TvorecAvtor")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("\nNext card: ");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                if (Deck[card + 1] == 2)
                                {
                                    Console.Write("J");
                                }
                                else if (Deck[card + 1] == 3)
                                {
                                    Console.Write("Q");
                                }
                                else if (Deck[card + 1] == 4)
                                {
                                    Console.Write("K");
                                }
                                else if (Deck[card + 1] == 11)
                                {
                                    Console.Write("A");
                                }
                                else
                                {
                                    Console.Write(Deck[card + 1]);
                                }
                                Console.WriteLine(" + cards in hand -> " + (SumPlayerFunc(CardsInHand, card) + Deck[card + 1]));
                                Console.ResetColor();
                                goto Repeat;
                            }
                            else
                            {
                                goto Repeat;
                            }
                        }
                    }
                    if (Winner == "Player")
                    {
                        money += cost * 2;
                    }
                    else if (Winner == "Draw")
                    {
                        money += cost;
                    }
                    else continue;
                }
            }
            goto Newgame;
        }
        #endregion
    }
}