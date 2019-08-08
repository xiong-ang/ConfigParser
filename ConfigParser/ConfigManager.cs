using System.Collections.Generic;

namespace ConfigParser
{
    public class ConfigManager
    {
        #region Constructor
        public ConfigManager(string filePath)
        {
            ParserConfigFile(filePath);
        }
        #endregion


        #region private props
        private int itemValue1;
        private string itemValue2;
        private List<string> itemValue3;
        #endregion


        #region public props
        public int ItemValue1 => itemValue1;
        public string ItemValue2 => itemValue2;
        public List<string> ItemValue3 => itemValue3;
        #endregion


        #region private method
        private void ParserConfigFile(string filePath)
        {
            IConfigParser configParser = ConfigParserFactory.Instance.CreateConfigParser(filePath);

            itemValue1 = configParser.GetItemValue<int>("key1");
            itemValue2 = configParser.GetItemValue<string>("key2");
            itemValue3 = configParser.GetItemValue<List<string>>("key3");
        }
        #endregion

    }
}
