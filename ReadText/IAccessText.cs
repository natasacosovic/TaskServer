using Server.Data;
using Server.Data.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ReadTextStrategy
{
    public interface IAccessText
    {
        string ReadText();
        SourceType typeOfSource { get; }
    }
}
