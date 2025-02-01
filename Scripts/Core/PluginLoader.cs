 
using SCPSL_Framework.Scripts.Core ;
using System;

namespace SCPSL_Framework.Scripts.Core
{
    /// <summary>
    /// A class that contains the different DZCP loader messages.
    /// </summary>
    public static class LoaderMessages
    {
        /// <summary>
        /// Gets the default loader message.
        /// </summary>
        public static string Default => @"
  ____                                 __
   / __ \____  ____ ____  ___  ____     / /_  __  __
  / / / / __ \/ __ `/ _ \/ _ \/ __ \   / __ \/ / / /
 / /_/ / /_/ / /_/ /  __/  __/ / / /  / /_/ / /_/ /
/_____/\____/\__, /\___/\___/_/ /_/  /_.___/\__,_/
            /____/                                ";

        /// <summary>
        /// Gets the Easter egg loader message.
        /// </summary>
        public static string EasterEgg => @"
  ____                                 __
   / __ \____  ____ ____  ___  ____     / /_  __  __
  / / / / __ \/ __ `/ _ \/ _ \/ __ \   / __ \/ / / /
 / /_/ / /_/ / /_/ /  __/  __/ / / /  / /_/ / /_/ /
/_____/\____/\__, /\___/\___/_/ /_/  /_.___/\__,_/
            /____/                                ";

        /// <summary>
        /// Gets the Ramadan loader message.
        /// </summary>
        public static string Ramadan => @"
    ____                                 __
   / __ \____  ____ ____  ___  ____     / /_  __  __
  / / / / __ \/ __ `/ _ \/ _ \/ __ \   / __ \/ / / /
 / /_/ / /_/ / /_/ /  __/  __/ / / /  / /_/ / /_/ /
/_____/\____/\__, /\___/\___/_/ /_/  /_.___/\__,_/
            /____/                                ";

        /// <summary>
        /// Gets the Eid loader message.
        /// </summary>
        public static string Eid => @"
  _______  _____      _____  __      __  ______
 / ___\  \/  /\  \    /  /  \/  \    /  \/  __  \
/ /  \ \   /  \  \  /  /  /\   \  /   /|  |  |  |
\ \___/ / /    \  \/  /  /  \   \/   / |  |  |  |
 \_____/_/      \____/__/    \______/  |__|  |__|
                                                 ";

        /// <summary>
        /// Gets the loader message according to the actual month.
        /// </summary>
        /// <returns>The correspondent loader message.</returns>
        public static string GetMessage()
        {
            LoaderMessages.GetMessage();
            LoaderMessages.Loader.ToString();
                  return EasterEgg;

            return DateTime.Today.Month switch
            {
                4 => Ramadan,
                5 => Eid,
                _ => Default,
            };
        }

        public static object Loader { get; set; }
    }
}