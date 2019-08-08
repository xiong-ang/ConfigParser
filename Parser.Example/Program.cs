using ConfigParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigManager configManager = ConfigManagerFactory.Instance.CreateConfigManager("1.xml");

            var port = configManager.ItemValue1;
            var logRouter = configManager.ItemValue2;
            var uiRouterList = configManager.ItemValue3;

        }
    }
}
