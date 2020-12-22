using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Data.EFCore
{
    public class EfCoreTextExampleRepository : EfCoreRepository<TextExample, ServerContext>
    {
        public EfCoreTextExampleRepository(ServerContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
