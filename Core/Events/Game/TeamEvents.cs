using System;

namespace سست.Core.Event.Game
{
    public static class TeamEvents
    {
        public static void OnTeamWin(string teamName)
        {
            Console.WriteLine($"{teamName} has won the round!");
        }

        public static void OnTeamLose(string teamName)
        {
            Console.WriteLine($"{teamName} has lost the round!");
        }
    }
}