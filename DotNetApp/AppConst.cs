using DotNetApp.Resources;
using System;
using System.Collections.Generic;

namespace DotNetApp
{
    class AppConst
    {
        private const string Tab = "\t";

        public static readonly Dictionary<string, ConsoleColor> AppAboutInfo = new Dictionary<string, ConsoleColor>
        {
            {$"{Tab}Wersja aplikacji: {AppResources.ver}",ConsoleColor.Yellow }
        };
    }
}
