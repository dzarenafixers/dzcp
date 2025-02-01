using System.Collections.Generic;

namespace SCPSL_Framework.Managers
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