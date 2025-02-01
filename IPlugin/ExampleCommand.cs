using System;

namespace ExamplePlugin
{
    public class ExampleCommand : PluginFramework.ICommand
    {
        public string Command => "hello";
        public string Description => "يُرسل رسالة ترحيب";

        public void Execute(string[] args)
        {
            Console.WriteLine("[ExampleCommand] مرحبًا بك في نظام الأوامر!");
        }
    }
}