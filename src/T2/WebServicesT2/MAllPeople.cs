using System;

namespace Logic
{   
    class MAllPeople : IReqModel
    {
        public String Command { get; set; }
        public String PhoneNumber { get; set; }
        public String MinAge { get; set; }
        public String MaxAge { get; set; }
        public String Gender { get; set; }

       public MAllPeople()
       {}

    }
}
