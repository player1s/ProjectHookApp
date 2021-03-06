﻿using System;
using Newtonsoft.Json;

namespace Logic
{
    class Commands : ICommands
    {
        public Commands()
        {}

        
        // these methods are being called from the WebAPI controllers.
        //they all have the same pattern (except for the lofin method, 
        //password is being compared to the on ein the database in this method, 
        //whereas other methods leave the necessary comparisons to the database tier.):
        //1, initialize necessary object, variables
        //2, through the arguments of the method variables of an object was passed, 
        //now that will be serialized to Json format using newtonsoft.
        //3, pass on this Json string containing our object to the socket communications handler
        //4, get a response Json
        //5, deserialize the response Json using newtonsoft
        //6, (as mentioned,  only login: received object from database tier is being compared to the value received from presentation tier)
        //7, return the response, that was received from database tier
        public String toLogIn(String command, String phonenumber, String password)
        {
            String toReturn = "Commands: nothing arrived";
            String OTP = "nothing came";

            Client client = new Client();
            JsonCreator login = new JsonCreator();
            LoginResponse loginResponse = new LoginResponse();

            String toSend = login.getLoginJson(command, phonenumber);

            System.Console.WriteLine("sending Login");
            toReturn =client.Listen(toSend); 
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
        
        //1, initialize necessary object, variables
        //2, through the arguments of the method variables of an object was passed, 
        //now that will be serialized to Json format using newtonsoft.
        //3, pass on this Json string containing our object to the socket communications handler
        //4, get a response Json
        //5, deserialize the response Json using newtonsoft
        //6, (as mentioned,  only login: received object from database tier is being compared to the value received from presentation tier)
        //7, return the response, that was received from database tier
        public String toCreateAccount(String command, String phonenumber, String firstName, String lastName, String description, String age, String gender, String password)
        {
            String toReturn = "Commands: nothing arrived";
            String response = "nothing came";

            Client client = new Client();
            JsonCreator login = new JsonCreator();
            LoginResponse loginResponse = new LoginResponse();

            String toSend = login.getCreateAccJson(command, phonenumber, firstName, lastName, description, age, gender, password);

            System.Console.WriteLine("sending createaccJson");
            toReturn =client.Listen(toSend); 
            loginResponse = JsonConvert.DeserializeObject<LoginResponse>(toReturn);
 
            Console.WriteLine("this was returned {0}",toReturn);

            response = loginResponse.OTP;

            Console.WriteLine("this gets compared from the db {0}",response);

            return response;
        }

        //1, initialize necessary object, variables
        //2, through the arguments of the method variables of an object was passed, 
        //now that will be serialized to Json format using newtonsoft. And check values that would possibly cause an exception, give safe values
        //3, pass on this Json string containing our object to the socket communications handler
        //4, get a response Json
        //5, deserialize the response Json using newtonsoft
        //6, (as mentioned,  only login: received object from database tier is being compared to the value received from presentation tier)
        //7, return the response, that was received from database tier
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
            toReturn =client.Listen(toSend); 
            loginResponse = JsonConvert.DeserializeObject<LoginResponse>(toReturn);
 
            Console.WriteLine("this was returned {0}",toReturn);

            OTP = loginResponse.OTP;

            return OTP;

        }

        //makes sure a value is exception safe
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
