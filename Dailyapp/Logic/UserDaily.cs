using System;
using System.Collections.Generic;
using System.Text;

namespace Dailyapp.Logic
{
    public class UserDaily
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }

        public UserDaily(int userId, string userName, string userPass)
        {
            UserId = userId;
            UserName = userName;
            UserPass = userPass;
        }
    }
}
