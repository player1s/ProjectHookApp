using System;

namespace Model
{   
    //interface for models to standardize the minimum sendable message/object
    interface IReqModel 
    {
         String Command { get; set; }
         String PhoneNumber { get; set; }
    }
}
