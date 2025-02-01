using System;
using System.Collections.Generic;
using System.Linq;

namespace PluginFramework
{
    public class CommandManager
    {
        private readonly Dictionary<string, ICommand> RegisteredCommands = new Dictionary<string, ICommand>();

        public void RegisterCommand(ICommand command)
        {
            if (!RegisteredCommands.ContainsKey(command.Command))
            {
                RegisteredCommands[command.Command] = command;
                Console.WriteLine($"[CommandManager] تم تسجيل الأمر: {command.Command} - {command.Description}");
            }
        }

        public void ExecuteCommand(string input)
        {
            var args = input.Split(' ');
            if (args.Length == 0) return;

            string commandName = args[0];
            if (RegisteredCommands.ContainsKey(commandName))
            {
                RegisteredCommands[commandName].Execute(args.Skip(1).ToArray());
            }
            else
            {
                Console.WriteLine("[CommandManager] الأمر غير معروف.");
            }
        }
    }
}