using Android.Icu.Util;
using ApptentiveKit.Android;
using Java.Util.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using ApptentiveCore;
using Apptentive.Com.Android.Util;

namespace ApptentiveKit
{
    [Serializable]
    public class ApptentiveConfiguration
    {
        public LogLevel LogLevel { get; set; } = LogLevel.Info;
        public string ApptentiveKey { get; set; }
        public string ApptentiveSignature { get; set; }
        public bool ShouldInheritAppTheme { get; set; } = true;
        public bool ShouldSanitizeLogMessages { get; set; } = true;  
        public string CustomAppStoreURL { get; set; } = null;
        public string DistributionName { get; set; } = "";
        public string DistributionVersion { get; set; } = "";
    }


    public enum LogLevel
    {
        Verbose,
        Info,
        Debug,
        Error,
        Warning
    }
}