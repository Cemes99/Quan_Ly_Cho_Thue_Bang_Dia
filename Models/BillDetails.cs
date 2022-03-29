using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    class BillDetails
    {
        private DiskModel disk;
        private int date;
        private double price;

        public int Date { get => date; set => date = value; }
        public double Price { get => price; set => price = value; }
        internal DiskModel Disk { get => disk; set => disk = value; }

        public BillDetails(DiskModel disk, int date, double price)
        {
            this.disk = disk;
            this.date = date;
            this.price = price;
        }

    }
}
