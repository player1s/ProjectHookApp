using System;
using Newtonsoft.Json;

namespace Logic
{   
    class Command 
    {
        public String Order { get; set; }
        public int PhoneNumber { get; set; }

       public Command()
       {}

       public String getJson(String command, int phonenumber)
       {

           Command order = new Command{Order=command, PhoneNumber=phonenumber};
            var str = JsonConvert.SerializeObject(order);
            System.Console.WriteLine(str);
            return str;
       }
    }
}
