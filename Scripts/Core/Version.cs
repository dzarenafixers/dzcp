using System;

namespace SCPSL_Framework.Scripts.Core
{
    public static class Version
    {
        // إصدار التطبيق الرئيسي والثانوي
        public static readonly int Major = 1;
        public static readonly int Minor = 0;
        public static readonly int Patch = 0;
        public static readonly int Build = 0;

        // تاريخ إصدار التطبيق
        public static readonly DateTime ReleaseDate = new DateTime(2025, 1, 30);

        // طريقة للحصول على الإصدار الكامل كـ string
        public static string GetFullVersion()
        {
            return $"v{Major}.{Minor}.{Patch}.{Build}";
        }

        // طريقة للحصول على معلومات الإصدار الكامل
        public static string GetVersionInfo()
        {
            return $"Version: {GetFullVersion()} (Released on {ReleaseDate.ToShortDateString()})";
        }
    }
}