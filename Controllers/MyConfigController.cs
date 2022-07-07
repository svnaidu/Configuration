using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyConfigController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public MyConfigController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public Dictionary<string,string> Get()
        {
           return _configuration.GetSection("Demo")
                .GetChildren()
                .ToDictionary(a => a.Key, a => a.Value);
        }
    }
}
