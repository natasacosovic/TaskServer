using Server.Data;
using Server.Data.EFCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Server.ReadTextStrategy
{
    public class AccessFile : IAccessText
    {
        const string FILE_LOCATION = @"TextExample.txt";

        public SourceType typeOfSource => SourceType.file;

        public string ReadText()
        {
            string text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + FILE_LOCATION);
            return text;
        }
    }
}