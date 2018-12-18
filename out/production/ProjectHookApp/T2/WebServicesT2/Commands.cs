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

            System.Console.WriteLine("sending Login");
            toReturn =Client.Listen(toSend); 
            loginResponse = JsonConvert.DeserializeObject<LoginResponse>(toReturn);
 
            Console.WriteLine("this was returned {0}",toReturn);

            OTP = loginResponse.OTP;

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

        public String toCreateAccount(String command, String phonenumber, String firstName, String lastName, String description, String age, String gender, String password)
        {
            String toReturn = "Commands: nothing arrived";
            String response = "nothing came";

            Client client = new Client();
            JsonCreator login = new JsonCreator();
            LoginResponse loginResponse = new LoginResponse();

            String toSend = login.getCreateAccJson(command, phonenumber, firstName, lastName, description, age, gender, password);

            System.Console.WriteLine("sending createaccJson");
            toReturn =Client.Listen(toSend); 
            loginResponse = JsonConvert.DeserializeObject<LoginResponse>(toReturn);
 
            Console.WriteLine("this was returned {0}",toReturn);

            response = loginResponse.OTP;

            Console.WriteLine("this gets compared from the db {0}",response);

            return response;
        }

        public String toGetAllPeople(String command, String phonenumber, String minAge, String maxAge, String gender)
        {
            String toReturn = "Commands: nothing arrived";
            String OTP = "nothing came";

            if(!(IsDigitsOnly(minAge)))
            {
                minAge = "0";
            }

            if(!(IsDigitsOnly(maxAge)))
            {
                maxAge = "9999";
            }

            Client client = new Client();
            JsonCreator login = new JsonCreator();
            LoginResponse loginResponse = new LoginResponse();

            String toSend = login.getAllPplJson(command, phonenumber, minAge, maxAge, gender);

            System.Console.WriteLine("sending getAllPpl");
            toReturn =Client.Listen(toSend); 
            loginResponse = JsonConvert.DeserializeObject<LoginResponse>(toReturn);
 
            Console.WriteLine("this was returned {0}",toReturn);

            OTP = loginResponse.OTP;

            return OTP;

        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

    }
}
