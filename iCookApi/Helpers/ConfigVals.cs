using System;
namespace iCookApi.Helpers
{
    public class ConfigVals
    {
        public static string DatabaseServer { get; set; }
        public static string DatabaseUser { get; set; }
        public static string DatabasePassword { get; set; }

        public ConfigVals()
        {
            DatabaseServer = LookForConfigValue("", "");
            DatabaseUser = LookForConfigValue("", "");
            DatabasePassword = LookForConfigValue("", ""); //TODO Need to base64 decode this for security
        }

        public static string LookForConfigValue(string appSetting, string valueIfNullOrEmpty)
        {
            throw new NotImplementedException();
        }
    }
}
