using System;

namespace DZCP.API
{
    public static class RoleAPI
    {
        public static void AssignRole(string playerName, string role)
        {
            Console.WriteLine($"[RoleAPI] Assigning {role} to {playerName}");
            // تعيين دور للاعب
        }

        public static void RemoveRole(string playerName)
        {
            Console.WriteLine($"[RoleAPI] Removing role from {playerName}");
            // إزالة دور من اللاعب
        }

        public static void ListRoles()
        {
            Console.WriteLine("[RoleAPI] Available roles: SCP-173, SCP-096, Class-D, Scientist, Guard, etc.");
            // عرض الأدوار المتاحة
        }
    }
}