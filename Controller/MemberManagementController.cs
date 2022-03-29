using Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controller
{
    class MemberManagementController
    {
        public DataTable dt = new DataTable();

        public MemberManagementController()
        {
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone number");
            dt.Columns.Add("Id Card");
            dt.Columns.Add("Address");

            foreach (MemberModel item in Db.listMember)
            {
                var values = new object[5];
                values[0] = item.Id;
                values[1] = item.Name;
                values[2] = item.PhoneNumber;
                values[3] = item.IdCard;
                values[4] = item.Address;

                dt.Rows.Add(values);
            }
        }
    }
}
