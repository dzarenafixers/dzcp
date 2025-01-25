using System;
using System.Collections.Generic;
using DZCP.Logging;
using سست.Commands;

namespace DZCP.Commands
{
    public static class CommandManager
    {
        private static readonly Dictionary<string, Command> Commands = new Dictionary<string, Command>();

        public static void RegisterCommand(Command command)
        {
            Commands[command.Name.ToLower()] = command;
            Logger.Info("CommandManager", $"Command '{command.Name}' registered.");
        }

        public static void ExecuteCommand(string input, string[] strings)
        {
            var parts = input.Split(' ');
            var cmd = parts[0].ToLower();
            var args = new string[parts.Length - 1];
            if (parts.Length > 1)
            {
                Array.Copy(parts, 1, args, 0, parts.Length - 1);
            }

            if (Commands.TryGetValue(cmd, out var command))
            {
                try
                {
                    command.Execute(args);
                }
                catch (Exception ex)
                {
                    Logger.Error("CommandManager", $"Error executing command '{command.Name}': {ex.Message}");
                }
            }
            else
            {
                Logger.Warn("CommandManager", $"Unknown command: {cmd}");
            }
        }

        public static void ListCommands()
        {
            Logger.Info("CommandManager", "Available commands:");
            foreach (var cmd in Commands.Values)
            {
                Logger.Info("CommandManager", $"{cmd.Name}: {cmd.Description}");
            }
        }

        public static void RegisterCommand(string command, Action<string[]> onAddTagCommand)
        {
            throw new NotImplementedException();
        }

        public static void ExecuteCommand(string input)
        {
            throw new NotImplementedException();
        }

        public static void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}