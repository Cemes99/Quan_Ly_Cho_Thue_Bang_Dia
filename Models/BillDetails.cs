using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    class BillDetails
    {
        private string diskId;
        private int date;
        private int price;
        private int amount;

        public BillDetails(string diskId, int date, int price, int amount)
        {
            this.diskId = diskId;
            this.date = date;
            this.price = price;
            this.amount = amount;
        }

        public string DiskId { get => diskId; set => diskId = value; }
        public int Date { get => date; set => date = value; }
        public int Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
    }
}
