using DotNetApp.Resources;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Autofac;
using DotNetApp.Utils;

namespace DotNetApp
{
    class Program
    {
        private static Utils.Interfaces.IConnection _connection;
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            Container = SetDependencies();
            ResolveDependencies();
            if (_connection.hasInternetConnection())
            {
                while (true)
                {
                    MaximizeConsoleWindow();
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
                                Console.SetCursorPosition((Console.WindowWidth / 2) - 
                                    (AppResources.error_doesntExist.Length / 2), Console.CursorTop);
                                Console.WriteLine(AppResources.error_doesntExist);
                                Console.ResetColor();
                                break;
                            }
                    }
                    WaitToContinue();
                }
            }
            else
            {
                Console.SetCursorPosition((Console.WindowWidth / 2) -
                (AppResources.error_noInternetConnection.Length / 2), Console.CursorTop);
                Console.WriteLine(AppResources.error_noInternetConnection);
                Console.WriteLine();
                WaitToContinue();
            }
        }

        private static void WaitToContinue()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition((Console.WindowWidth / 2) - 
                (AppResources.messageContinue.Length / 2), Console.CursorTop);
            Console.WriteLine(AppResources.messageContinue);
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
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
                Console.SetCursorPosition((Console.WindowWidth / 2) - 
                    (item.Key.Length / 2) - 5, Console.CursorTop);
                Console.ForegroundColor = item.Value;
                Console.WriteLine(item.Key);
            }
            Console.ResetColor();
        }

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int cmdShow);
        private static void MaximizeConsoleWindow()
        {
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3);
        }

        #region Autofac
        private static IContainer SetDependencies()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<IsOnline>().As<Utils.Interfaces.IConnection>();
            return builder.Build();
        }
        private static void ResolveDependencies()
        {
            _connection = Container.Resolve<Utils.Interfaces.IConnection>();
        }
        #endregion
    }
}