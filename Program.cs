using System;
using DZCP.Commands;
using DZCP.Core;
using سست.Core;

namespace DZCP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var core = new DzcpCore();
            core.Start();

            // تسجيل الأوامر
            CommandManager.RegisterCommand(new ExampleCommand());
            CommandManager.RegisterCommand(new RoleCommand());
            CommandManager.RegisterCommand(new RoomCommand());
            CommandManager.RegisterCommand(new ItemCommand());

            Console.WriteLine("Type 'help' for a list of commands.");
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "stop")
                {
                    core.Stop();
                    break;
                }
                CommandManager.ExecuteCommand(input);
            }
        }
    }
}