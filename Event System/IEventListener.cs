namespace PluginFramework
{
    public interface IEventListener
    {
        void OnEventTriggered(string eventName, object eventData);
    }
}