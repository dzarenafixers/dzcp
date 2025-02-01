using System;
using SCPSL_Framework.GameRoles;
using SCPSL_Framework.GameRoles.Humans;
using SCPSL_Framework.GameRoles.SCPs;

namespace SCPSL_Framework.Documentation.Examples
{
    internal partial class Program
    {
        static void Main( ) 
        {
            // Creating human roles
            Guard guard = new Guard();
            MTF mtf = new MTF();
            ClassD classD = new ClassD();
            Scientist scientist = new Scientist();

            // Creating SCP roles
            SCP173 scp173 = new SCP173();
            SCP049 scp049 = new SCP049();
            SCP106 scp106 = new SCP106();
            SCP079 scp079 = new SCP079();
            SCP096 scp096 = new SCP096();
            SCP999 scp999 = new SCP999();

            // Displaying roles information
            DisplayRoleInfo(guard);
            DisplayRoleInfo(mtf);
            DisplayRoleInfo(classD);
            DisplayRoleInfo(scientist);

            DisplayRoleInfo(scp173);
            DisplayRoleInfo(scp049);
            DisplayRoleInfo(scp106);
            DisplayRoleInfo(scp079);
            DisplayRoleInfo(scp096);
            DisplayRoleInfo(scp999);
        }

        static void DisplayRoleInfo(HumanRole humanRole)
        {
            Console.WriteLine($"Role: {humanRole.RoleName}, Health: {humanRole.Health}, Armor: {humanRole.Armor}, Weapons: {string.Join(", ", humanRole.Weapons)}");
        }

        static void DisplayRoleInfo(SCPRole scpRole)
        {
            Console.WriteLine($"SCP Number: {scpRole.SCPNumber}, Health: {scpRole.Health}, Abilities: {string.Join(", ", scpRole.Abilities)}");
        }
    }
}