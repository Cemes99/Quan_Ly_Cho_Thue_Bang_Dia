using Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controller
{
    class DiskManagementController
    {
        public DataTable dt = new DataTable();

        public DiskManagementController()
        {
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Category");
            dt.Columns.Add("Status");
            dt.Columns.Add("Company");
            dt.Columns.Add("Note");



            foreach(DiskModel item in Db.listDisk)
            {
                var values = new object[6];
                values[0] = item.Id;
                values[1] = item.Name;
                values[2] = item.Category;
                values[3] = item.Status;
                values[4] = item.Company;
                values[5] = item.Note;

                dt.Rows.Add(values);
            }
        }

    }
}
