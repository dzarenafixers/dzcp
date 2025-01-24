using DZCP.API;
using DZCP.Logging;

namespace DZCP.Commands
{
    public class RoomCommand : Command
    {
        public override string Name => "room";
        public override string Description => "Manage rooms.";

        public override void Execute(string[] args)
        {
            if (args.Length < 2)
            {
                Logger.Info("RoomCommand", "Usage: room <teleport|lock|unlock> <roomName> [playerName]");
                return;
            }

            var action = args[0].ToLower();
            var roomName = args[1];

            switch (action)
            {
                case "teleport":
                    if (args.Length < 3)
                    {
                        Logger.Info("RoomCommand", "Usage: room teleport <roomName> <playerName>");
                        return;
                    }
                    RoomAPI.TeleportPlayerToRoom(args[2], roomName);
                    break;
                case "lock":
                    RoomAPI.LockRoom(roomName);
                    break;
                case "unlock":
                    RoomAPI.UnlockRoom(roomName);
                    break;
                default:
                    Logger.Warn("RoomCommand", $"Unknown action: {action}");
                    break;
            }
        }
    }
}