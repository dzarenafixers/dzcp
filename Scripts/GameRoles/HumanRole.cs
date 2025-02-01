namespace SCPSL_Framework.GameRoles
{
    public abstract class HumanRole
    {
        public string RoleName { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public string[] Weapons { get; set; }
    }
}