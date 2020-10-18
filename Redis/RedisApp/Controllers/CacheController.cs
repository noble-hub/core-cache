using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;

namespace RedisApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CacheController : ControllerBase
    {
        private readonly IDatabase database;

        public CacheController(IDatabase database)
        {
            this.database = database;
        }

        [HttpGet]
        public string Get([FromQuery] string key)
        {
            return database.StringGet(key);
        }

        // POST: api/Cache
        [HttpPost]
        public void Post([FromBody] KeyValuePair<string, string> keyValue)
        {
            database.StringSet(keyValue.Key, keyValue.Value);
        }
    }
}
