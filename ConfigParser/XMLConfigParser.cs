using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConfigParser
{
    public class XMLConfigParser : IConfigParser
    {
        public T GetItemValue<T>(string path)
        {
            return default(T);
        }

        public XMLConfigParser(string filePath)
        {

        }
    }
}
