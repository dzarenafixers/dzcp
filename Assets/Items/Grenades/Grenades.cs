using System.Collections.Generic;
using SCPSL_Framework.Managers;

namespace SCPSL_Framework.Items.Grenades
{
    public class Grenade : Item
    {
        public int BlastRadius { get; set; }
        public int Damage { get; set; }

        public Grenade(string name, int blastRadius, int damage, Dictionary<string, int> attributes)
            : base(name, "Grenade", attributes)
        {
            BlastRadius = blastRadius;
            Damage = damage;
        }
    }
}