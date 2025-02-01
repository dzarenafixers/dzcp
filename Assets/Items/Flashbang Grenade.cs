using System.Collections.Generic;

namespace SCPSL_Framework.Items.Grenades
{
    public class FlashbangGrenade : Grenade
    {
        public FlashbangGrenade()
            : base("Flashbang Grenade", 5, 0, new Dictionary<string, int> { { "duration", 10 } })
        {
        }
    }
}