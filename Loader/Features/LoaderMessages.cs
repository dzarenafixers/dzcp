using System;
using DZCP.Core;

namespace DZCP.Loader
{
    public static partial class LoaderMessages
    {
        public static string Default => string.Join(Environment.NewLine, new[]
        {
            @"██████╗ ███████╗ ██████╗██████╗",
            @"██╔══██╗╚══███╔╝██╔════╝██╔══██╗",
            @"██║  ██║  ███╔╝ ██║     ██████╔╝",
            @"██║  ██║ ███╔╝  ██║     ██╔═══╝",
            @"██████╔╝███████╗╚██████╗██║",
            @"╚═════╝ ╚══════╝ ╚═════╝╚═╝",
            "DayZ Combat Plugin Framework",
            $"Version: {PluginManager.Version}",
            "Created by MONCEF50G",
            "Loading..."
        });

        public static string Special => string.Join(Environment.NewLine, new[]
        {
            @"███████╗██████╗  █████╗ ███╗   ███╗ █████╗ ███╗   ██╗",
            @"██╔════╝██╔══██╗██╔══██╗████╗ ████║██╔══██╗████╗  ██║",
            @"███████╗██████╔╝███████║██╔████╔██║███████║██╔██╗ ██║",
            @"╚════██║██╔═══╝ ██╔══██║██║╚██╔╝██║██╔══██║██║╚██╗██║",
            @"███████║██║     ██║  ██║██║ ╚═╝ ██║██║  ██║██║ ╚████║",
            @"╚══════╝╚═╝     ╚═╝  ╚═╝╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝",
            "Special Edition",
            $"Version: {PluginManager.Version}",
            "Created by MONCEF50G",
            "Loading..."
        });

        public static string WelcomeMessage { get; set; }

        public static string GetMessage()
        {
            if (DateTime.Now.Month == 3 && DateTime.Now.Day == 27) // رمضان
                return Special;

            if (DateTime.Now.Month == 6 && DateTime.Now.Day == 5) // عيد الأضحى
                return Special;

            return Default;
        }
    }
}