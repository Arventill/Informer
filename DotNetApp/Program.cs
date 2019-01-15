using DotNetApp.Resources;
using System;

namespace DotNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                AppConst.Welcome();
                var answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        {
                            Console.WriteLine("In progeress");
                            break;
                        }
                    case "2":
                        {
                            About();
                            break;
                        }
                    case "3":
                        {
                            ExitApp();
                            break;
                        }
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(AppResources.error_doesntExist);
                            Console.ResetColor();
                            break;
                        }
                }
            }
        }

        private static void ExitApp()
        {
            try
            {
                System.Environment.Exit(0);
            }
            catch (Exception)
            {
                return;
            }
        }

        private static void About()
        {
            foreach (var item in AppConst.AppAboutInfo)
            {
                Console.ForegroundColor = item.Value;
                Console.WriteLine(item.Key);
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}