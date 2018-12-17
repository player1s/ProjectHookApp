using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1GUI
{
    class MGetAll : IReqModel
    {
        public String Command { get; set; }
        public String PhoneNumber { get; set; }
        public MGetAll() { }

    }
}
