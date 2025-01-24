using System;
using DZCP;
using DZCP.Commands;
using سست.Commands;

namespace سست.Zones
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("مرحبًا بك في مشروع DZCP!");

            // تفعيل الوحدات
            ZoneManager.Initialize();
            CommandManager.Initialize();
            PlayerManager.Initialize();

            // تشغيل الواجهة الرئيسية
            UserInterface.ShowMainMenu();
        }
    }
}