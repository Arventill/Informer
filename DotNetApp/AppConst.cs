using DotNetApp.Resources;
using System;
using System.Collections.Generic;

namespace DotNetApp
{
    class AppConst
    {
        public const string AuthorizationApiKey = "RGAPI-2958ec04-0412-63bf-1ddc-2aba3fe0bfbe";
        public const string InternetCheckoutString = "http://clients3.google.com/generate_204";
        private const string Tab = "\t";
        private static string w1, w2;

        public static void Welcome()
        {
            w1 = "Witaj w aplikacji!";
            w2 = "Wybierz jedna z dostepnych opcji:\n\n";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition((Console.WindowWidth / 2) - (w1.Length / 2), Console.CursorTop);
            Console.WriteLine(w1);
            Console.SetCursorPosition(Console.WindowWidth / 2 - w2.Length / 2, Console.CursorTop);
            Console.WriteLine(w2);
            foreach (var item in AppConst.WelcomeWords)
            {
                Console.ForegroundColor = item.Value;
                Console.WriteLine(item.Key);
            }
            Console.Write(Tab + "Twój wybór: ");
            Console.ResetColor();
        }

        public static readonly Dictionary<string, ConsoleColor> WelcomeWords = new Dictionary<string, ConsoleColor>
        {
            {$"{Tab}[1] Opcja nr 1",ConsoleColor.Yellow },
            {$"{Tab}[2] Informacje o aplikacji",ConsoleColor.Yellow },
            {$"{Tab}[3] Wyjscie\n",ConsoleColor.Yellow }
        };

        public static readonly Dictionary<string, ConsoleColor> AppAboutInfo = new Dictionary<string, ConsoleColor>
        {
            {$"Wersja aplikacji:{Tab}{AppResources.ver}",ConsoleColor.Yellow },
            {$"Project Owner:{Tab}{Tab}{AppResources.owner}",ConsoleColor.Blue },
            {$"UX & UI:{Tab}{Tab}{AppResources.design}",ConsoleColor.Green }
        };
    }
}
