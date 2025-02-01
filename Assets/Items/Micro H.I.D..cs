using System.Collections.Generic;

namespace SCPSL_Framework.Items.Weapons
{
    public class MicroHID : Weapon
    {
        public MicroHID()
            : base("Micro H.I.D.", 500, 1, new Dictionary<string, int> { { "chargeTime", 5 } })
        {
        }
    }
}