using System;

namespace PluginFramework
{
    public static class ConsoleBanner
    {
        public static void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
 ██████╗ ██╗      ██████╗  ██████╗ ███████╗
██╔═══██╗██║      ██╔══██╗██╔═══██╗██╔════╝
██║   ██║██║      ██████╔╝██║   ██║███████╗
██║   ██║██║      ██╔══██╗██║   ██║╚════██║
╚██████╔╝███████╗██║  ██║╚██████╔╝███████║
 ╚═════╝ ╚══════╝╚═╝  ╚═╝ ╚═════╝ ╚══════╝
        ");
            Console.ResetColor();
        }
    }
}