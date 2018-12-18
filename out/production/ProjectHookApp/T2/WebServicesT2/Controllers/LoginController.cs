using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Logic;
using Newtonsoft.Json;

namespace WebServicesT2.Controllers
{
        // controller for endpoint ~/api/Login in the webAPI

    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
    /*
    *    If a request arrives for this endpoint, this method will run. Every writeline is to better understand the program while running
    *    intentionally having a single post request, as other functions are located in other endpoints 
    *    1, create an object that the incoming object will be stored in
    *    2, deserialize the incoming Json to the specified object
    *    3, if the command (intention of presentation layer) matches a possible function, call that function.
    */
        // POST api/values
        [HttpPost]
        public String Post([FromBody] string value)
        {
            MLogin mLogin = JsonConvert.DeserializeObject<MLogin>(value);
            Commands commands = new Commands();
            System.Console.WriteLine("LoginController Called");

            if(mLogin.Command.Equals("Login"))
            {
            System.Console.WriteLine("got dis: {0}", value);
            System.Console.WriteLine("as for pn: {0}",mLogin.PhoneNumber);
            System.Console.WriteLine("as for pw: {0}",mLogin.Password);
            return commands.toLogIn("Login", mLogin.PhoneNumber, mLogin.Password);
            }

            return "nothing here";
        }        
    } 
}
