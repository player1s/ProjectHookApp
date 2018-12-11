using System;

namespace Logic
{
    class Commands 
    {
        public Commands()
        {}

        public String login(int phonenumber)
        {
            String toReturn = "Commands: nothing arrived";
            Client client = new Client();
            Login login = new Login(phonenumber: phonenumber);
            toReturn =Client.Listen("Login - " + phonenumber + "\n");  
            Console.WriteLine("api will see this value {0}",toReturn);
            return toReturn;

        }
    }
}
