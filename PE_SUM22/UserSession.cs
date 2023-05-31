using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_SUM22
{
    public class UserSession
    {
        private static UserSession instance;
        public string Username { get; set; }
        public string Role { get; set; }
        public UserSession()
        {
        }

        public static UserSession Instance { get {
                if(instance == null) instance = new UserSession();
                return instance;
            } }
    }
}
