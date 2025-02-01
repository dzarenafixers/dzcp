namespace SCPSL_Framework.GameRoles.SCPs
{
    public class SCP999 : SCPRole
    {
        public SCP999()
        {
            SCPNumber = "999";
            Health = 500;
            Abilities = new string[] { "Heal", "Calm" };
        }
    }
}