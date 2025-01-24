using DZCP.API;
using DZCP.Logging;
using سست.API;

namespace DZCP.Commands
{
    public class ItemCommand : Command
    {
        public override string Name => "item";
        public override string Description => "Manage items.";

        public override void Execute(string[] args)
        {
            if (args.Length < 2)
            {
                Logger.Info("ItemCommand", "Usage: item <spawn|remove|list> <itemName> [location]");
                return;
            }

            var action = args[0].ToLower();
            var itemName = args[1];

            switch (action)
            {
                case "spawn":
                    if (args.Length < 3)
                    {
                        Logger.Info("ItemCommand", "Usage: item spawn <itemName> <location>");
                        return;
                    }
                    ItemAPI.SpawnItem(itemName, args[2]);
                    break;
                case "remove":
                    ItemAPI.RemoveItem(itemName);
                    break;
                case "list":
                    ItemAPI.ListItems();
                    break;
                default:
                    Logger.Warn("ItemCommand", $"Unknown action: {action}");
                    break;
            }
        }
    }
}