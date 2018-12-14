using System;
using Newtonsoft.Json;

namespace Logic
{   
    class Command 
    {
        public String Order { get; set; }
        public String PhoneNumber { get; set; }

       public Command()
       {}

       public String getJson(String command, String phonenumber)
       {

           Command order = new Command{Order=command, PhoneNumber=phonenumber};
            var str = JsonConvert.SerializeObject(order);
            System.Console.WriteLine(str);
            return str;
       }
    }
}
