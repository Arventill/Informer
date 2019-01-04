using DotNetApp.Resources;
using System;

namespace DotNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            About();

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