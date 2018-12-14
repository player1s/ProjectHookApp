using System;

namespace Logic
{   
    class MLogin : IReqModel
    {
        public String Command { get; set; }
        public String PhoneNumber { get; set; }
        public String Password { get; set; }


       public MLogin()
       {}

    }
}
