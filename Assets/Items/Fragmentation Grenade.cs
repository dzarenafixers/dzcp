using System.Collections.Generic;

namespace SCPSL_Framework.Items.Grenades
{
    public class FragmentationGrenade : Grenade
    {
        public FragmentationGrenade()
            : base("Fragmentation Grenade", 20, 100, new Dictionary<string, int> { { "fragments", 15 } })
        {
        }
    }
}