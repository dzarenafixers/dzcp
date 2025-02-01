namespace PluginFramework
{
    public interface ICommand
    {
        string Command { get; } // اسم الأمر
        string Description { get; } // وصف الأمر
        void Execute(string[] args); // تنفيذ الأمر
    }
}