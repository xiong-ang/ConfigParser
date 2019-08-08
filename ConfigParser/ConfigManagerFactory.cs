namespace ConfigParser
{
    public class ConfigManagerFactory
    {
        #region singleton
        private static ConfigManagerFactory _instance;
        private static object singleton_lock = new object();
        public static ConfigManagerFactory Instance
        {
            get
            {
                lock (singleton_lock)
                {
                    return _instance ?? (_instance = new ConfigManagerFactory());
                }
            }
        }
        private ConfigManagerFactory(){}
        #endregion


        #region public method
        public ConfigManager CreateConfigManager(string filePath)
        {
            return new ConfigManager(filePath);
        }
        #endregion
    }
}
