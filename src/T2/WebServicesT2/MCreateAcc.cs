using System;

namespace Logic
{   
    class MCreateAcc : IReqModel
    {
        public String Command { get; set; }
        public String PhoneNumber { get; set; }
        public String Age { get; set; }
        public String Description { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }


       public MCreateAcc()
       {}

    }
}
