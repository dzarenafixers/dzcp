using System.Collections.Generic;
using SCPSL_Framework.Managers;

namespace SCPSL_Framework.Items.Meds
{
    public class Med : Item
    {
        public int HealingAmount { get; set; }

        public Med(string name, int healingAmount, Dictionary<string, int> attributes)
            : base(name, "Med", attributes)
        {
            HealingAmount = healingAmount;
        }
    }
}