using Project.global;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controller
{
    class LoginController
    {
        public bool login(String user, String pass)
        {
            foreach (EmployeeModel item in Db.listEmp)
            {
                if(user == item.UserName && pass == item.Password)
                {
                    Global.currentUser = user;
                    return true;
                }
            }
            return true;
            // return false;
        }
    }
}
