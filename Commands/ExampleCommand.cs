using DZCP.Logging;

namespace DZCP.Commands
{
    public class ExampleCommand : Command
    {
        public override string Name => "example";
        public override string Description => "An example command.";

        public override void Execute(string[] args)
        {
            Logger.Info("ExampleCommand", $"Executing example command with args: {string.Join(", ", args)}");
        }
    }
}