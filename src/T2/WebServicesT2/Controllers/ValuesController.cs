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


            return new string[] { "commands.command(\"Login\", 123456789)", "value212" };
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
            MLogin mLogin = JsonConvert.DeserializeObject<MLogin>(value);
            Commands commands = new Commands();
            System.Console.WriteLine("got here");

            if(mLogin.Command.Equals("Login"))
            {
            System.Console.WriteLine("got dis: {0}", value);
            System.Console.WriteLine("as for pn: {0}",mLogin.PhoneNumber);
            System.Console.WriteLine("as for pw: {0}",mLogin.Password);
            return commands.toLogIn("Login", mLogin.PhoneNumber, mLogin.Password);
            }

            if(mLogin.Command.Equals("CreateAcc"))
            {
            MCreateAcc mCreateAcc = JsonConvert.DeserializeObject<MCreateAcc>(value);

            System.Console.WriteLine("got dis: {0}", value);
            System.Console.WriteLine("as for cmd: {0}",mCreateAcc.Command);
            System.Console.WriteLine("as for pn: {0}",mCreateAcc.PhoneNumber);
            System.Console.WriteLine("as for first: {0}",mCreateAcc.FirstName);
            System.Console.WriteLine("as for last: {0}",mCreateAcc.LastName);
            System.Console.WriteLine("as for desc: {0}",mCreateAcc.Description);
            System.Console.WriteLine("as for age: {0}",mCreateAcc.Age);
            System.Console.WriteLine("as for pw: {0}",mCreateAcc.Password);

            return commands.toCreateAccount(mCreateAcc.Command, mCreateAcc.PhoneNumber, mCreateAcc.FirstName, mCreateAcc.LastName, mCreateAcc.Description, mCreateAcc.Age, mCreateAcc.Gender, mCreateAcc.Password);
            }

            if(mLogin.Command.Equals("GetAll"))
            {

            MAllPeople mAllPeople = JsonConvert.DeserializeObject<MAllPeople>(value);


            System.Console.WriteLine("got dis: {0}", value);
            System.Console.WriteLine("as for pn: {0}",mAllPeople.PhoneNumber);
            return commands.toGetAllPeople("GetAll", mAllPeople.PhoneNumber);
            }

            return "nothing here";
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
    /*
    [Route("api/[controller]")]
    [ApiController]
    public class QwertzController : ControllerBase
    {
       
        // GET api/qwertz
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            
                    Commands commands = new Commands();


            return new string[] { "commands.command(\"Login\", 123456789)", "value212" };
        }
    }*/
}
