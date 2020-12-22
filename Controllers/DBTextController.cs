using Microsoft.AspNetCore.Mvc;
using Server.Data;
using Server.Models;
using Server.ReadTextStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class DBTextController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        private readonly Random _random = new Random();

        public DBTextController(TRepository repository)
        {
            this.repository = repository;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<string> Get()
        {
            var res = await repository.GetAll(); 
            int i = _random.Next(0, res.Count-1);
            return res.Cast<TextExample>().ToList()[i].Text;
        }

    }
}
