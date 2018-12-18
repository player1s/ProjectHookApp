using System;
using Newtonsoft.Json;

namespace Logic
{   
    // a class with a responsibility to store the response of the database tier as an object, for later serialization when 
    //transferring back to the presentation layer is being prepared
    class LoginResponse 
    {
        public String OTP { get; set; }

       public LoginResponse()
       {}

    }
}
