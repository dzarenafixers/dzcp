namespace SCPSL_Framework.GameRoles
{
    public abstract class SCPRole
    {
        public string SCPNumber { get; set; }
        public int Health { get; set; }
        public string[] Abilities { get; set; }
    }
}