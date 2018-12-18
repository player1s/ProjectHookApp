using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace T1GUI
{
    // Model class for containing the results of command get all users, so it holds every user (except the one requested the command)
    class PeopleInMatchList
    {
        public ArrayList OtherUsers { get; set; }

        public PeopleInMatchList() { }
    }
}
