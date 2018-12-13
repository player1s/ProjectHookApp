using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Logic;
using Newtonsoft.Json;

namespace WebServicesT2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            
                    Commands commands = new Commands();


            return new string[] { "commands.command(\"Login\", 123456789)", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            Commands commands = new Commands();
            return "commands.command(\"Login\", 123456789)";
        }

        // POST api/values
        [HttpPost]
        public String Post([FromBody] string value)
        {
            Commands commands = new Commands();
            System.Console.WriteLine("got dis: {0}", value);
            MLogin mLogin = JsonConvert.DeserializeObject<MLogin>(value);
            System.Console.WriteLine("as for pn: {0}",mLogin.PhoneNumber);
            System.Console.WriteLine("as for pw: {0}",mLogin.Password);
            return commands.command("Login", mLogin.PhoneNumber, mLogin.Password);


        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
