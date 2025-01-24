using System;

namespace DZCP.API
{
    public static class RoomAPI
    {
        public static void TeleportPlayerToRoom(string playerName, string roomName)
        {
            Console.WriteLine($"[RoomAPI] Teleporting {playerName} to {roomName}");
            // نقل اللاعب إلى غرفة معينة
        }

        public static void LockRoom(string roomName)
        {
            Console.WriteLine($"[RoomAPI] Locking {roomName}");
            // قفل غرفة
        }

        public static void UnlockRoom(string roomName)
        {
            Console.WriteLine($"[RoomAPI] Unlocking {roomName}");
            // فتح غرفة
        }
    }
}