﻿using System;

namespace Logic
{
    class Commands 
    {
        public Commands()
        {}

        public String login()
        {
            String toReturn = "Commands: nothing arrived";

            Client client = new Client();
            Login login = new Login();

            String toSend = login.getJson();

            toReturn =Client.Listen(toSend);  
            Console.WriteLine("api will see this value {0}",toReturn);

            return toReturn;

        }
    }
}
