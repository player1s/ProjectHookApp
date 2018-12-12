using System;
using Newtonsoft.Json;

namespace Logic
{   [Serializable]
    class Login 
    {
        String command;
        int phonenumber;

        public Login (int phonenumber)
        {
            command = "Login";
            this.phonenumber = phonenumber;
        }
        public String getCommand() => command;
        public int getPhoneNumber() => phonenumber;
        public void setCommand(String command) => this.command = command;
        public void setPhoneNumber(int phonenumber) => this.phonenumber = phonenumber;

        public string getJson()
        {
                    string toSend = JsonConvert.SerializeObject(this);
                    Console.WriteLine("the json is: " + toSend);
                    return toSend;

        }
    }
}
