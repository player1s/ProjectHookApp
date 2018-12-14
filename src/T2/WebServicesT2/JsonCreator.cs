using System;
using Newtonsoft.Json;

namespace Logic
{   
    class JsonCreator 
    {
        public String Order { get; set; }
        public String PhoneNumber { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }
        public String Age { get; set; }
        public String Description { get; set; }


       public JsonCreator()
       {}

       public String getLoginJson(String command, String phonenumber)
       {

           JsonCreator order = new JsonCreator{Order=command, PhoneNumber=phonenumber};
            var str = JsonConvert.SerializeObject(order);
            System.Console.WriteLine(str);
            return str;
       }

       public String getCreateAccJson(String command, String phonenumber, String firstName, String lastName, String description, String age, String gender)
       {

           JsonCreator order = new JsonCreator{Order=command, PhoneNumber=phonenumber, FirstName = firstName, LastName = lastName, Description = description, Age = age, Gender = gender};
            var str = JsonConvert.SerializeObject(order);
            System.Console.WriteLine(str);
            return str;
       }
    }
}
