namespace SCPSL_Framework.GameRoles.Humans
{
    public class Scientist : HumanRole
    {
        public Scientist()
        {
            RoleName = "Scientist";
            Health = 100;
            Armor = 25;
            Weapons = new string[] { "Flashlight" };
        }
    }
}