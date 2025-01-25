using System;
using PluginManager = DZCP.PluginManager;

namespace سست.Loader.Features
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
            $"Version: {PluginManager.DZCP_BUILD}",
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
            $"Version: {PluginManager.DZCP_BUILD}",
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