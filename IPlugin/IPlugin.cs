namespace PluginFramework
{
    public interface IPlugin
    {
        string Name { get; }
        string Version { get; }
        void OnLoad();
        void OnUnload();
    }
}