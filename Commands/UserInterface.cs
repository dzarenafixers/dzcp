using System;
using DZCP.Commands;

namespace سست.Commands
{
    public static class UserInterface
    {
        public static void ShowMainMenu()
        {
            Console.WriteLine("=== القائمة الرئيسية ===");
            Console.WriteLine("1. عرض اللاعبين");
            Console.WriteLine("2. إضافة لاعب");
            Console.WriteLine("3. تنفيذ أمر");
            Console.WriteLine("4. الخروج");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowPlayers();
                    break;
                case "2":
                    AddPlayer();
                    break;
                case "3":
                    ExecuteCommand();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("اختيار غير صحيح.");
                    ShowMainMenu();
                    break;
            }
        }

        private static void ShowPlayers()
        {
            Console.WriteLine("=== اللاعبين ===");
            // عرض اللاعبين هنا
            ShowMainMenu();
        }

        private static void AddPlayer()
        {
            Console.Write("ادخل اسم اللاعب: ");
            string name = Console.ReadLine();
            Console.Write("ادخل SteamID: ");
            string steamID = Console.ReadLine();

            PlayerManager.AddPlayer(new Player(name, steamID));
            ShowMainMenu();
        }

        private static void ExecuteCommand()
        {
            Console.Write("ادخل الأمر: ");
            string command = Console.ReadLine();
            CommandManager.ExecuteCommand(command, new string[] { });
            ShowMainMenu();
        }
    }
}