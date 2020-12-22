using Server.Controllers;
using Server.Data;
using Server.Data.EFCore;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.ReadTextStrategy
{
    public class AccessFakeDatabase : IAccessText
    {
        SourceType IAccessText.typeOfSource =>  SourceType.db;

        public string ReadText()
        {
            string text = "Fokus zadatka jeste na aritekturi i pattern-ima, i primeni tog znanja na zadatak - n-tier, SOA, Dependency Injection, Factory, Repository i slično. Koriscenje third party biblioteka je dozvoljeno.";
            return text;
        }
    }
}