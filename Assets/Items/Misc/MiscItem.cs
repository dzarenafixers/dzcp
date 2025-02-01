using System.Collections.Generic;
using SCPSL_Framework.Managers;

namespace SCPSL_Framework.Items.Misc
{
    public class MiscItem : Item
    {
        public string Description { get; set; }

        public MiscItem(string name, string description, Dictionary<string, int> attributes)
            : base(name, "Misc", attributes)
        {
            Description = description;
        }
    }
}