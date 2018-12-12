using System;
using Newtonsoft.Json;

namespace Logic
{   
    class Login 
    {
        public String Command { get; set; }
        public int PhoneNumber { get; set; }

       public Login()
       {}

       public String getJson()
       {
           Login login = new Login{Command="Login", PhoneNumber=123456789};
            var str = JsonConvert.SerializeObject(login);
            System.Console.WriteLine(str);
            return str;
       }
    }
}
