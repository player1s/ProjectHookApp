using System;

namespace Model
{   
    //A model class implementing IReqModel, 
    //can be instantiated to contain the necessary information for searching for other users in the system
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
