using System;
using System.Threading;

namespace Neal_Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            SplashScreen();

            int _selection = -1;
            decimal _amount;
            ExchangeMonitor monitor = new ExchangeMonitor();

            do
            {
                Console.Clear();
                Console.Write(ExchangeChoices());
                string selectionInput = Console.ReadLine();

                if (ParseINT(selectionInput))
                {
                    _selection = int.Parse(selectionInput);

                    if (_selection == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(monitor.PrintOut());
                        Console.Write("\n\n\tPress any key to end the program. . .\n\t");
                        Console.ReadKey();
                        break;
                    }

                    bool parseSuccess = false;
                    do
                    {
                        Console.Write("\n\tEnter the amount you wish to exchange: $");
                        string amountInput = Console.ReadLine();

                        if (ParseDEC(amountInput) == true)
                        {
                            _amount = decimal.Parse(amountInput);

                            Console.Write($"\t. . ." +
                                $"\n\n\tSUCCESS! {monitor.Run(_selection, _amount)}" +
                                $"\n\n\tSaving data and resetting the page...");
                            Thread.Sleep(7000);

                            parseSuccess = true;
                        }
                        else
                        {
                            Console.Write("\n\tINVALID INPUT! TRY AGAIN" +
                                "\n\t. . .");
                            Thread.Sleep(1500);
                            Console.Clear();
                            Console.Write(ExchangeChoices());
                            Console.WriteLine(_selection);
                        }
                    } while (parseSuccess == false);
                }
                else
                {
                    Console.Write("\n\tINVALID INPUT! TRY AGAIN" +
                        "\n\t. . .");
                    Thread.Sleep(1500);
                }
            } while (_selection != 0);
        }
        static void SplashScreen()
        {
            Console.WriteLine("\n\n\n\n\n\n\n\t\t88888b.d88b.  .d88b. 88888b.  .d88b. 888  888");
            Console.WriteLine("\t\t888 \"888 \"88bd88\"\"88b888 \"88bd8P  Y8b888  888");
            Console.WriteLine("\t\t888  888  888888  888888  88888888888888  888");
            Console.WriteLine("\t\t888  888  888Y88..88P888  888Y8b.    Y88b 888");
            Console.WriteLine("\t\t888  888  888 \"Y88P\" 888  888 \"Y8888  \"Y88888");
            Console.WriteLine("\t\t                                          888");
            Console.WriteLine("\t\t                                     Y8b d88P");
            Console.Write("\t\t                                      \"Y88P\"");
            Thread.Sleep(3000);
        }
        static string ExchangeChoices()
        {
            return "\n\n\t-- Currency Exchange Calculator --" +
                "\n\n\t0:  End the program and display session print out." +
                "\n\t1:  US Dollar to British Pound" +
                "\n\t2:  US Dollar to Canadian Dollar" +
                "\n\t3:  US Dollar to Euro" +
                "\n\t4:  British Pound to US Dollar" +
                "\n\t5:  British Pound to Canadian Dollar" +
                "\n\t6:  British Pound to Euro" +
                "\n\t7:  Canadian Dollar to US Dollar" +
                "\n\t8:  Canadian Dollar to British Pound" +
                "\n\t9:  Canadian Dollar to Euro" +
                "\n\t10: Euro to US Dollar" +
                "\n\t11: Euro to British Pound" +
                "\n\t12: Euro to Canadian Dollar" +
                "\n\t. . .\n" +
                "\n\tEnter an above selection (0-12) followed by the \"enter\" key: ";
        }
        static bool ParseINT(string input)
        {
            if (int.TryParse(input, out int output))
            {
                if (output >= 0 && output < 13)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        static bool ParseDEC(string input)
        {
            if (decimal.TryParse(input, out decimal output))
            {
                if (output > 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}