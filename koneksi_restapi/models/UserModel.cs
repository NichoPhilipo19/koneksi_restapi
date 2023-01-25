using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace koneksi_restapi.models
{
    public class UserModel
    {
        
        public int recid { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int isActive { get; set; }
        public int isBanned { get; set; }
        public string Role { get; set; }
    }
}
