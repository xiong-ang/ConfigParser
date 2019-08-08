using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigParser
{
    class JSONConfigParser : IConfigParser
    {
        public T GetItemValue<T>(string path)
        {
            return default(T);
        }

        public JSONConfigParser(string filepath)
        {

        }
    }
}
