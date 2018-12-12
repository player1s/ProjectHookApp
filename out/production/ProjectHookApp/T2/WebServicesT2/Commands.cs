using System;

namespace Logic
{
    class Commands 
    {
        public Commands()
        {}

        public String command(String command, int phonenumber)
        {
            String toReturn = "Commands: nothing arrived";

            Client client = new Client();
            Command login = new Command();

            String toSend = login.getJson(command, phonenumber);

            toReturn =Client.Listen(toSend);  
            Console.WriteLine("api will see this value {0}",toReturn);

            return toReturn;

        }
    }
}
