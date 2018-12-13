using System;
using Newtonsoft.Json;

namespace Logic
{
    class Commands 
    {
        public Commands()
        {}

        public String command(String command, int phonenumber)
        {
            String toReturn = "Commands: nothing arrived";
            String OTP = "nothing came";

            Client client = new Client();
            Command login = new Command();
            LoginResponse loginResponse = new LoginResponse();

            String toSend = login.getJson(command, phonenumber);

            toReturn =Client.Listen(toSend); 
            loginResponse = JsonConvert.DeserializeObject<LoginResponse>(toReturn);
 
            Console.WriteLine("this was returned {0}",toReturn);

            OTP = loginResponse.OTP;

            Console.WriteLine("api will see this value {0}",OTP);

            return OTP;

        }
    }
}
