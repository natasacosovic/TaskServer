using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : Controller
    {
        private readonly IHandleTextService handleTextService;

        public TextController(IHandleTextService handleTextService)
        {
            this.handleTextService = handleTextService;
        }

        [HttpPost]
        public int Post([FromBody] string text)
        {
            var test = handleTextService.CauntWords(text);
            return test;
        }
    }
}
