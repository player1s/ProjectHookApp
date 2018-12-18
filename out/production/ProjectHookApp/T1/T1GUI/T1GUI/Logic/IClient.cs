using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1GUI
{
    interface IClient
    {
        Task<string> PostLogin(object obj);
        Task<string> PostCreateAcc(object obj);
        Task<string> PostGetAll(object obj);
    }
}
