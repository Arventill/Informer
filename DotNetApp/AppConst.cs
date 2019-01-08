using DotNetApp.Resources;
using System;
using System.Collections.Generic;

namespace DotNetApp
{
    class AppConst
    {
        private const string Tab = "\t";

        public static void Welcome()
        {
            Console.WriteLine("Witaj w aplikacji!\n");
            Console.WriteLine("Wybierz jedna z dostepnych opcji:");
            Console.WriteLine("[1] Opcja nr 1");
            Console.WriteLine("[2] Informacje o aplikacji");
            Console.WriteLine("[3] Wyjscie\n");
            Console.Write("Twoj wybor: ");
        }

        public static readonly Dictionary<string, ConsoleColor> AppAboutInfo = new Dictionary<string, ConsoleColor>
        {
            {$"{Tab}Wersja aplikacji: {AppResources.ver}",ConsoleColor.Yellow }
        };
    }
}
