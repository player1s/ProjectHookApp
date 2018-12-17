using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1GUI
{
    class Session : ISession
    {
       public String Identifier { get; set; }

        public Session (String id)
        {
            Identifier = id;
        }
    }
}
