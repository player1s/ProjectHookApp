using System;
using Newtonsoft.Json;

namespace Logic
{
    class Commands 
    {
        public Commands()
        {}

        public String toLogIn(String command, String phonenumber, String password)
        {
            String toReturn = "Commands: nothing arrived";
            String OTP = "nothing came";

            Client client = new Client();
            JsonCreator login = new JsonCreator();
            LoginResponse loginResponse = new LoginResponse();

            String toSend = login.getLoginJson(command, phonenumber);

            toReturn =Client.Listen(toSend); 
            loginResponse = JsonConvert.DeserializeObject<LoginResponse>(toReturn);
 
            Console.WriteLine("this was returned {0}",toReturn);

            OTP = loginResponse.Responded;

            Console.WriteLine("this gets compared from the db {0}",OTP);

            if(OTP == null)
            {
                System.Console.WriteLine("returned acc doesnt exist");
                return "Account does not exist";
            }

            if (OTP.Equals(password))
            {
                System.Console.WriteLine("returned true");
                return "Logging in!";
            }
            else
            {
                System.Console.WriteLine("returned false");
                return "Incorrect password";
            }
            

        }

        public String toCreateAccount(String command, String phonenumber, String firstName, String lastName, String description, String age, String gender)
        {
            String toReturn = "Commands: nothing arrived";
            String response = "nothing came";

            Client client = new Client();
            JsonCreator login = new JsonCreator();
            LoginResponse loginResponse = new LoginResponse();

            String toSend = login.getCreateAccJson(command, phonenumber, firstName, lastName, description, age, gender);

            toReturn =Client.Listen(toSend); 
            loginResponse = JsonConvert.DeserializeObject<LoginResponse>(toReturn);
 
            Console.WriteLine("this was returned {0}",toReturn);

            response = loginResponse.Responded;

            Console.WriteLine("this gets compared from the db {0}",response);

            return response;
        }

    }
}
