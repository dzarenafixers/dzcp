using System;

namespace سست.Core.Event.Game
{
    public static class RoundEvents
    {
        public static void OnRoundStart()
        {
            Console.WriteLine("Round has started!");
        }

        public static void OnRoundEnd()
        {
            Console.WriteLine("Round has ended!");
        }
    }
}