using System.Collections.Generic;

namespace SCPSL_Framework.Items.SCPItems
{
    public class SCP_500 : SCPItem
    {
        public SCP_500()
            : base("SCP-500", "500", new Dictionary<string, int> { { "healingAmount", 100 } })
        {
        }
    }
}