using System;
using System.Collections.Generic;
using DZCP.Logging;

namespace DZCP.API
{
    public static class ModelAPI
    {
        private static readonly Dictionary<string, string> CustomModels = new Dictionary<string, string>();

        public static void RegisterCustomModel(string modelName, string description)
        {
            CustomModels[modelName] = description;
            Logger.Info("ModelAPI", $"Registered custom model: {modelName}");
        }

        public static void ApplyCustomModel(string playerName, string modelName)
        {
            if (CustomModels.ContainsKey(modelName))
            {
                Logger.Info("ModelAPI", $"Applied custom model '{modelName}' to {playerName}");
            }
            else
            {
                Logger.Warn("ModelAPI", $"Custom model '{modelName}' not found.");
            }
        }
    }
}