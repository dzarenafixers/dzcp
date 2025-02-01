namespace SCPSL_Framework.GameRoles.Humans
{
    public class MTF : HumanRole
    {
        public MTF()
        {
            RoleName = "MTF";
            Health = 150;
            Armor = 100;
            Weapons = new string[] { "MTF-E11-SR", "Grenade" };
        }
    }
}