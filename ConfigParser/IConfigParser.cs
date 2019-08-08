using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigParser
{
    interface IConfigParser
    {
        T GetItemValue<T>(string path);
    }
}
