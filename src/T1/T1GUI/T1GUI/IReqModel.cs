using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1GUI
{
    interface IReqModel
    {
        string Command { get; set; }
        string PhoneNumber { get; set; }
    }
}
