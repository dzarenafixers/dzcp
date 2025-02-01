using System.Collections.Generic;

namespace SCPSL_Framework.Items.Misc
{
    public class Keycard : MiscItem
    {
        public int AccessLevel { get; set; }

        public Keycard(int accessLevel)
            : base("Keycard", $"Access Level: {accessLevel}", new Dictionary<string, int> { { "accessLevel", accessLevel } })
        {
            AccessLevel = accessLevel;
        }
    }
}