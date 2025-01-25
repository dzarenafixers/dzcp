 
using System;
using System.Collections.Generic;
using System.Linq;

namespace سست.Loader.Features
{
    /// <summary>
    /// This class implements all possible DZCP features.
    /// </summary>
    public static class DzcpFeatures
    {
        /// <summary>
        /// Represents the types of events supported by DZCP.
        /// </summary>
        public enum EventType
        {
            ROUND_END,
            WAITING_FOR_PLAYERS,
            ROUND_START,
            SERVER_START,
            SERVER_FULL,
        }

        /// <summary>
        /// Represents the types of actions supported by DZCP.
        /// </summary>
        public enum ActionType
        {
            SET_SUPPORTED_FEATURES,
        }

        /// <summary>
        /// Represents the features supported by DZCP.
        /// </summary>
        [Flags]
        public enum DZCPFeaturesEnum
        {
            None = 0,
            CustomEvents = 1 << 0,
            All = CustomEvents,
        }

        /// <summary>
        /// The prefix used for DZCP commands.
        /// </summary>
        public const string DZCP_PREFIX = "dzcp";

        /// <summary>
        /// The console prefix used for DZCP commands.
        /// </summary>
        public const string DZCP_CONSOLE_PREFIX = "-" + DZCP_PREFIX;

        /// <summary>
        /// The suffix used for DZCP events.
        /// </summary>
        public const string DZCP_EVENT_SUFFIX = "event";

        /// <summary>
        /// The separator used for DZCP values.
        /// </summary>
        public static readonly char[] DZCPValueSeparator = { ':' };

        /// <summary>
        /// The separator used for DZCP keys.
        /// </summary>
        public static readonly char[] DZCPKeySeparator = { '-' };

        /// <summary>
        /// The string representation of the value separator.
        /// </summary>
        public static readonly string DZCPValueSeparatorStr = new(DZCPValueSeparator);

        /// <summary>
        /// The string representation of the key separator.
        /// </summary>
        public static readonly string DZCPKeySeparatorStr = new(DZCPKeySeparator);

        /// <summary>
        /// Indicates whether DZCP is being used.
        /// </summary>
        public static readonly bool DZCPUsed;

        /// <summary>
        /// The version of DZCP being used.
        /// </summary>
        public static readonly string DZCPVersion;

        /// <summary>
        /// The features supported by DZCP.
        /// </summary>
        public static readonly DZCPFeaturesEnum DZCPModFeatures;

        static DzcpFeatures()
        {
            // Check command line arguments for DZCP usage
            foreach (string startArg in Environment.GetCommandLineArgs())
            {
                if (startArg.StartsWith(DZCP_CONSOLE_PREFIX, StringComparison.OrdinalIgnoreCase))
                {
                    DZCPUsed = true;

                    // Parse version and features from the argument
                    IEnumerable<string> separatedInfo = startArg.Split(DZCPValueSeparator).Skip(1);
                    DZCPVersion = separatedInfo.ElementAtOrDefault(0);
                    string features = separatedInfo.ElementAtOrDefault(1);

                    if (!string.IsNullOrEmpty(features) && int.TryParse(features, out int modFeatures))
                    {
                        DZCPModFeatures = (DZCPFeaturesEnum)modFeatures;
                        return;
                    }

                    // Log an error if parsing fails
                    Console.WriteLine($"Failed to parse DZCP ModFeatures! Source: {features}", ConsoleColor.Red);
                    break;
                }
            }
        }

        /// <summary>
        /// Calls a DZCP event.
        /// </summary>
        /// <param name="eventType">The type of event to call.</param>
        /// <returns>True if the event was called successfully; otherwise, false.</returns>
        public static bool CallEvent(EventType eventType)
        {
            if (!DZCPUsed)
                return false;

            // Ensure the server output is available
            if (ServerStatic.ServerOutput is null)
                return false;

            // Convert the event to a DZCP-compatible format and log it
            ServerStatic.ServerOutput.AddLog(ConvertToDZCPAvailable(eventType), ConsoleColor.White);
            return true;
        }

        /// <summary>
        /// Calls a DZCP action.
        /// </summary>
        /// <param name="actionType">The type of action to call.</param>
        /// <param name="value">The value to pass with the action.</param>
        /// <returns>True if the action was called successfully; otherwise, false.</returns>
        public static bool CallAction(ActionType actionType, object value = null)
        {
            if (!DZCPUsed)
                return false;

            // Ensure the server output is available
            if (ServerStatic.ServerOutput is null)
                return false;

            // Convert the action to a DZCP-compatible format and log it
            string dzcpAvailable = ConvertToDZCPAvailable(actionType);
            if (value != null)
                dzcpAvailable = string.Concat(dzcpAvailable, DZCPValueSeparatorStr, value);

            ServerStatic.ServerOutput.AddLog(dzcpAvailable, ConsoleColor.White);
            return true;
        }

        /// <summary>
        /// Converts an event type to a DZCP-compatible string.
        /// </summary>
        /// <param name="eventType">The event type to convert.</param>
        /// <returns>The DZCP-compatible string.</returns>
        public static string ConvertToDZCPAvailable(EventType eventType)
        {
            string eventName = PrepareStr(eventType.ToString());
            return string.Concat(DZCP_PREFIX, DZCPValueSeparatorStr, eventName, DZCPKeySeparatorStr, DZCP_EVENT_SUFFIX);
        }

        /// <summary>
        /// Converts an action type to a DZCP-compatible string.
        /// </summary>
        /// <param name="actionType">The action type to convert.</param>
        /// <returns>The DZCP-compatible string.</returns>
        public static string ConvertToDZCPAvailable(ActionType actionType)
        {
            string actionName = PrepareStr(actionType.ToString());
            return string.Concat(DZCP_PREFIX, DZCPValueSeparatorStr, actionName);
        }

        /// <summary>
        /// Prepares a string for use in DZCP commands.
        /// </summary>
        /// <param name="value">The string to prepare.</param>
        /// <returns>The prepared string.</returns>
        public static string PrepareStr(string value) => value.Replace("_", DZCPKeySeparatorStr).ToLowerInvariant();
    }
}