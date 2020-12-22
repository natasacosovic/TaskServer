using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ReadTextStrategy
{
    interface IAccessTextFactory
    {
        IAccessText GetStrategy(string type);
    }
}
