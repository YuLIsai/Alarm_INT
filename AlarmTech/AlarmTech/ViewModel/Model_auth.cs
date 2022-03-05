using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmTech.ViewModel
{
    public class Model_auth
    {
        public string user;
        public string pass;

        public bool Authentication(string user, string pass)
        {
            bool auth = false;
            if (user.Equals("User1") && pass.Equals("user1"))
            {
                auth = true;
            }
            else
            {
                auth = false;
            }
            return auth;
        }
    }
}
