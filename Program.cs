using System;
using System.Threading;

namespace PluginFramework
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleBanner.Show();
            Console.WriteLine("[PluginFramework] بدء تشغيل محمل الإضافات...");

            var pluginLoader = new PluginLoader();
            var commandManager = new CommandManager();

            // تسجيل أمر الاختبار
            var testCommand = new ExamplePlugin.ExampleCommand();
            commandManager.RegisterCommand(testCommand);

 
            // تشغيل وضع الأوامر
            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (input == "reload")
                {
                 }
                else
                {
                    commandManager.ExecuteCommand(input);
                }
            }
        }
    }
}