using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1GUI
{
    //Model class for command: Login
    //this object is instantiated, then serialized & sent in Json form as a HTTP Post request
    class MLogin : IReqModel
    {
        public String Command { get; set; }
        public String PhoneNumber { get; set; }
        public String Password { get; set; }

        public MLogin() { }

    }
}
