using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Data.EFCore;
using Server.Models;
using Server.ReadTextStrategy;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DBController : DBTextController<TextExample, EfCoreTextExampleRepository>
    {
        private readonly ServerContext _context;

        public DBController(EfCoreTextExampleRepository repository) : base(repository)
        {
        }
    }
}
