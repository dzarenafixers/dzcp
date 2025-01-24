using DZCP.API;
using DZCP.Logging;

namespace DZCP.Commands
{
    public class RoleCommand : Command
    {
        public override string Name => "role";
        public override string Description => "Manage player roles.";

        public override void Execute(string[] args)
        {
            if (args.Length < 2)
            {
                Logger.Info("RoleCommand", "Usage: role <assign|remove|list> <playerName> [role]");
                return;
            }

            var action = args[0].ToLower();
            var playerName = args[1];

            switch (action)
            {
                case "assign":
                    if (args.Length < 3)
                    {
                        Logger.Info("RoleCommand", "Usage: role assign <playerName> <role>");
                        return;
                    }
                    RoleAPI.AssignRole(playerName, args[2]);
                    break;
                case "remove":
                    RoleAPI.RemoveRole(playerName);
                    break;
                case "list":
                    RoleAPI.ListRoles();
                    break;
                default:
                    Logger.Warn("RoleCommand", $"Unknown action: {action}");
                    break;
            }
        }
    }
}