using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1GUI
{
    interface IReqModel
    {
        // interface to define the necessary elements of a Model element, 
        //which is to be serialized, and complies with our communication protocol.
        string Command { get; set; }
        string PhoneNumber { get; set; }
    }
}
