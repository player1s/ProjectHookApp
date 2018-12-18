using System;

namespace Model
{   
    //A model class implementing IReqModel, 
    //can be instantiated to contain the necessary information for creating a new user in the system
    class MCreateAcc : IReqModel
    {
        public String Command { get; set; }
        public String PhoneNumber { get; set; }
        public String Age { get; set; }
        public String Description { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }
        public String Password { get; set; }


       public MCreateAcc()
       {}

    }
}
