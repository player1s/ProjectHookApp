using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Logic;
using Newtonsoft.Json;

namespace WebServicesT2.Controllers
{
        // controller for endpoint ~/api/GetAll in the webAPI
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllController : ControllerBase
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
            MAllPeople mAllPeople = JsonConvert.DeserializeObject<MAllPeople>(value);
            Commands commands = new Commands();
            System.Console.WriteLine("get all here");

            if(mAllPeople.Command.Equals("GetAll"))
            {

           // MAllPeople mAllPeople = JsonConvert.DeserializeObject<MAllPeople>(value);


            System.Console.WriteLine("got dis: {0}", value);
            System.Console.WriteLine("as for pn: {0}",mAllPeople.PhoneNumber);
            System.Console.WriteLine("as for gender: {0}",mAllPeople.Gender);
            System.Console.WriteLine("as for minage: {0}",mAllPeople.MinAge);
            System.Console.WriteLine("as for maxage: {0}",mAllPeople.MaxAge);
            return commands.toGetAllPeople("GetAll", mAllPeople.PhoneNumber,mAllPeople.Gender,mAllPeople.MinAge,mAllPeople.MaxAge);
            }

            return "nothing here";
        }        
    } 
}
