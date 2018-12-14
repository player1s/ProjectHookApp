using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1GUI
{
    class MCreateAcc : IReqModel
    {
        public String Command { get; set; }
        public String PhoneNumber { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Age { get; set; }
        public String Description { get; set; }
        public String Gender { get; set; }
        public String Password { get; set; }


        public MCreateAcc() { }
    }
}
