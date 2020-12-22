using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.ReadTextStrategy
{
    public class AccessTextFactory : IAccessTextFactory
    {
        private readonly IEnumerable<IAccessText> availableStrategies;

        public AccessTextFactory(IEnumerable<IAccessText> strategies)
        {
            this.availableStrategies = strategies;
        }

        public IAccessText GetStrategy(string type)
        {
            var strategy = this.availableStrategies.FirstOrDefault(x => x.typeOfSource.ToString() == type);
            return strategy;
        }
    }
}