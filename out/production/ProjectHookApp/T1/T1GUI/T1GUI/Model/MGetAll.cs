using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1GUI
{
    // Model class for command: Get all users (but the user requesting this)
    //this object is instantiated, then serialized & sent in Json form as a HTTP Post request
    class MGetAll : IReqModel
    {
        public String Command { get; set; }
        public String PhoneNumber { get; set; }
        public String MinAge { get; set; }
        public String MaxAge { get; set; }
        public String Gender { get; set; }
        public MGetAll() { }

    }
}
