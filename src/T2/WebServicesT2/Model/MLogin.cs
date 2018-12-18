using System;

namespace Model
{   
    //A model class implementing IReqModel, 
    //can be instantiated to contain the necessary information for loggin in to the system
    class MLogin : IReqModel
    {
        public String Command { get; set; }
        public String PhoneNumber { get; set; }
        public String Password { get; set; }


       public MLogin()
       {}

    }
}
