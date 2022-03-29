using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    class EmployeeModel
    {
        private String id;
        private String userName;
        private String password;
        private String phoneNumber;
        private String details;

        public string Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Details { get => details; set => details = value; }

        public EmployeeModel(string id, string userName, string password, string phoneNumber, string details)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.phoneNumber = phoneNumber;
            this.details = details;
        }
    }
}
