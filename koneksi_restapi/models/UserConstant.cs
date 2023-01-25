using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace koneksi_restapi.models
{
    public class UserConstant
    {
        public static List<UserModel> Users = new()
            {
                    new UserModel(){ username="niko_krenz",password="123",Role="Admin"}
            };
    }
}
