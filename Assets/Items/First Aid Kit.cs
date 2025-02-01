using System.Collections.Generic;

namespace SCPSL_Framework.Items.Meds
{
    public class FirstAidKit : Med
    {
        public FirstAidKit()
            : base("First Aid Kit", 100, new Dictionary<string, int> { { "uses", 3 } })
        {
        }
    }
}