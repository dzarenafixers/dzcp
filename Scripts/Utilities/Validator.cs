namespace SCPSL_Framework.Utilities
{
    public static class Validator
    {
        public static bool ValidateStringIsNotEmpty(string input, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Logger.LogError($"{fieldName} should not be empty.");
                return false;
            }
            return true;
        }

        public static bool ValidateNumberIsPositive(int number, string fieldName)
        {
            if (number <= 0)
            {
                Logger.LogError($"{fieldName} should be positive.");
                return false;
            }
            return true;
        }
    }
}