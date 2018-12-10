using System;

namespace Logic
{
    class Commands 
    {
        public Commands()
        {}

        public void login(int phonenumber)
        {
            T2T3SocketClient.Client client = new T2T3SocketClient.Client();
            Model.Login login = new ModelLogin(phonenumber: phonenumber);
            Client.StartClient("Login - " + phonenumber + "\n");  

        }
    }
}
