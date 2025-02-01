using System.Collections.Generic;
using SCPSL_Framework.Managers;

namespace SCPSL_Framework.Items.SCPItems
{
    public class SCPItem : Item
    {
        public string SCPNumber { get; set; }

        public SCPItem(string name, string scpNumber, Dictionary<string, int> attributes)
            : base(name, "SCPItem", attributes)
        {
            SCPNumber = scpNumber;
        }
    }
}