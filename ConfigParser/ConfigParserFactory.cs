using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigParser
{
    class ConfigParserFactory
    {
        #region singleton
        private static ConfigParserFactory _instance;
        private static object singleton_lock = new object();
        public static ConfigParserFactory Instance
        {
            get
            {
                lock (singleton_lock)
                {
                    return _instance ?? (_instance = new ConfigParserFactory());
                }
            }
        }
        private ConfigParserFactory() { }
        #endregion


        #region public method
        public IConfigParser CreateConfigParser(string filePath)
        {
            switch (Path.GetExtension(filePath).ToLower())
            {
                case ".xml":
                    return new XMLConfigParser(filePath);
                case ".json":
                    return new JSONConfigParser(filePath);
                default:
                    return null;
            }
        }
        #endregion
    }
}
