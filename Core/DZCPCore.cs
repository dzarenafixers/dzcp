using DZCP.Loader;
using DZCP.Logging;

namespace سست.Core
{
    public class DzcpCore
    {
        public void Start()
        {
            Logger.Info("DZCP.Core", LoaderMessages.WelcomeMessage);
            Logger.Info("DZCP.Core", LoaderMessages.Default);

            PluginLoader.LoadPlugins();
        }

        public void Stop()
        {
            Logger.Info("DZCP.Core", "DZCP System Stopped!");
            PluginLoader.UnloadPlugins();
        }
    }
}