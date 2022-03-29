using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    class MemberModel
    {
        private String id;
        private String name;
        private String phoneNumber;
        private String idCard;
        private String address;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string IdCard { get => idCard; set => idCard = value; }
        public string Address { get => address; set => address = value; }
        public MemberModel(string id, string name, string phoneNumber, string idCard, string address)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.idCard = idCard;
            this.address = address;
        }
    }
}
