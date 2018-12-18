using System;
using Newtonsoft.Json;

namespace Logic
{   
    // a class with the responsibility to serialize objects into Json strings
    class JsonCreator : IJsonCreator
    {
        public String Order { get; set; }
        public String PhoneNumber { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }
        public String Age { get; set; }
        public String Description { get; set; }
        public String Password { get; set; }
        public String MinAge { get; set; }
        public String MaxAge { get; set; }


       public JsonCreator()
       {}
        //Every method working in a same manner, 
        //1, get all possible values of an object
        //2, serialize it using newtonsoft
        //3, return it
       public String getLoginJson(String command, String phonenumber)
       {

           JsonCreator order = new JsonCreator{Order=command, PhoneNumber=phonenumber};
            var str = JsonConvert.SerializeObject(order);
            System.Console.WriteLine(str);
            return str;
       }

       public String getCreateAccJson(String command, String phonenumber, String firstName, String lastName, String description, String age, String gender, String password)
       {

           JsonCreator order = new JsonCreator{Order=command, PhoneNumber=phonenumber, FirstName = firstName, LastName = lastName, Description = description, Age = age, Gender = gender, Password = password};
            var str = JsonConvert.SerializeObject(order);
            System.Console.WriteLine(str);
            return str;
       }

       public String getAllPplJson(String command, String phonenumber, String minAge, String maxAge, String gender)
       {

           JsonCreator order = new JsonCreator{Order=command, PhoneNumber=phonenumber, MinAge = minAge, MaxAge = maxAge, Gender = gender };
            var str = JsonConvert.SerializeObject(order);
            System.Console.WriteLine(str);
            return str;
       }
    }
}
