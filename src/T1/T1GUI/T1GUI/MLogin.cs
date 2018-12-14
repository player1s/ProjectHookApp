using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1GUI
{
    class MLogin : IReqModel
    {
        public String Command { get; set; }

        public String PhoneNumber { get; set; }
        public String Password { get; set; }

        public MLogin() { }

    }
}
