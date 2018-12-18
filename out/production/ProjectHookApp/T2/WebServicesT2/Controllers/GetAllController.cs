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
    public class GetAllController : ControllerBase
    {
      
        // POST api/values
        [HttpPost]
        public String Post([FromBody] string value)
        {
            MLogin mLogin = JsonConvert.DeserializeObject<MLogin>(value);
            Commands commands = new Commands();
            System.Console.WriteLine("get all here");

            if(mLogin.Command.Equals("GetAll"))
            {

            MAllPeople mAllPeople = JsonConvert.DeserializeObject<MAllPeople>(value);


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