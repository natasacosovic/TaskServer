using Microsoft.AspNetCore.Mvc;
using Server.ReadTextStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        // GET: api/<FileController>
        [HttpGet]
        public string Get()
        {
            AccessTextFactory strat = new AccessTextFactory(Startup.strategiesList);
            IAccessText getText = strat.GetStrategy(SourceType.file.ToString());
            return getText.ReadText();
        }
    }
}
