using System;

namespace Logic
{
    interface IJsonCreator
    {
         String Order { get; set; }
         String PhoneNumber { get; set; }
         String FirstName { get; set; }
         String LastName { get; set; }
         String Gender { get; set; }
         String Age { get; set; }
         String Description { get; set; }
         String Password { get; set; }
         String MinAge { get; set; }
         String MaxAge { get; set; }
        String getLoginJson(String command, String phonenumber);
        String getCreateAccJson(String command, String phonenumber, String firstName, String lastName, String description, String age, String gender, String password);
        String getAllPplJson(String command, String phonenumber, String minAge, String maxAge, String gender);
    }
}
