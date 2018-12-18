using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Logic;
using Newtonsoft.Json;

namespace WebServicesT2.Controllers
{
    // controller for endpoint ~/api/CreateAcc in the webAPI
    [Route("api/[controller]")]
    [ApiController]
    public class CreateAccController : ControllerBase
    {
      
        // POST api/values
        //If a request arrives for this endpoint, this method will run.
        //intentionally having a single post request, as other functions are located in other requests 
        [HttpPost]
        public String Post([FromBody] string value)
        {
            MCreateAcc mCreateAcc = JsonConvert.DeserializeObject<MCreateAcc>(value);
            Commands commands = new Commands();
            System.Console.WriteLine("got here");

            if(mCreateAcc.Command.Equals("CreateAcc"))
            {
           // MCreateAcc mCreateAcc = JsonConvert.DeserializeObject<MCreateAcc>(value);

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

            return "nothing here";
        }        
    } 
}
