using System;
using System.Collections.Generic;
using System.Text;

namespace Claims.Core.Domain
{
    public class LoginUserResult
    {
        public int UserId { get; set; }

        public string UserFullName { get; set; }

        public string LoginDateTime { get; set; }

        public SignInStatus Status { get; set; }

        public string ErrorMessage { get; set; }
    }

}
