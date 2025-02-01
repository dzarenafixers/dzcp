using System.Collections.Generic;
using SCPSL_Framework.Managers;

namespace SCPSL_Framework.Items.Tools
{
    public class Tool : Item
    {
        public string Function { get; set; }

        public Tool(string name, string function, Dictionary<string, int> attributes)
            : base(name, "Tool", attributes)
        {
            Function = function;
        }
    }
}