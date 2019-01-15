using DotNetApp.Resources;
using System;
using System.Collections.Generic;

namespace DotNetApp
{
    class AppConst
    {
        private const string Tab = "\t";
        private const string Newline = "\n";

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
            {$"{Tab}Wersja aplikacji:{Tab}{AppResources.ver}",ConsoleColor.Yellow },
            {$"{Tab}Project Owner:{Tab}{Tab}{AppResources.owner}",ConsoleColor.Blue },
            {$"{Tab}UX & UI:{Tab}{Tab}{AppResources.design}",ConsoleColor.Green },
            {$"{Newline}* * * Kliknij dowolny przycisk aby kontynuować * * *{Newline}",ConsoleColor.Yellow }
        };
    }
}
