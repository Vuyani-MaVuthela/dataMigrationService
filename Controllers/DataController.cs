using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dataMigrationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        public string Get()
        {
            return "post connection string in body";
        }


        // POST api/values
        [HttpPost("{connString}")]
        public void Post([FromBody] string connString)
        {

        }
    }
}
