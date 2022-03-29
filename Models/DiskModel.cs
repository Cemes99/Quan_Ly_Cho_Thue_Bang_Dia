using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    class DiskModel
    {
        private string id;
        private string name;
        private string category;
        private string status;
        private string company;
        private string note;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public string Status { get => status; set => status = value; }
        public string Company { get => company; set => company = value; }
        public string Note { get => note; set => note = value; }

        public DiskModel(string id, string name, string category, string status, string company, string note)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.status = status;
            this.company = company;
            this.note = note;
        }

        public DiskModel()
        {
        }
    }
}
