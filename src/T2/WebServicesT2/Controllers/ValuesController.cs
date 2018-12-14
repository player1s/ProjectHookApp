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
        [HttpPost("{id}")]
        public String Post([FromBody] string value)
        {
            MLogin mLogin = JsonConvert.DeserializeObject<MLogin>(value);
            Commands commands = new Commands();

            if(mLogin.Command.Equals("Login"))
            {
            System.Console.WriteLine("got dis: {0}", value);
            System.Console.WriteLine("as for pn: {0}",mLogin.PhoneNumber);
            System.Console.WriteLine("as for pw: {0}",mLogin.Password);
            return commands.command("Login", mLogin.PhoneNumber, mLogin.Password);
            }

            if(mLogin.Command.Equals("CreateAcc"))
            {
            MCreateAcc mCreateAcc = JsonConvert.DeserializeObject<MLogin>(value);

            System.Console.WriteLine("got dis: {0}", value);
            System.Console.WriteLine("as for pn: {0}",mCreateAcc.PhoneNumber);
            System.Console.WriteLine("as for first: {0}",mCreateAcc.FirstName);
            System.Console.WriteLine("as for last: {0}",mCreateAcc.LastName);
            System.Console.WriteLine("as for desc: {0}",mCreateAcc.Description);
            System.Console.WriteLine("as for age: {0}",mCreateAcc.Age);
            return commands.command("Login", mLogin.PhoneNumber, mLogin.Password);
            }
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
