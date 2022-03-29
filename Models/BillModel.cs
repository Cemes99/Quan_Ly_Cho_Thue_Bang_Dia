using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    class BillModel
    {
        private string id;
        private DateTime date;
        private string memberId;
        private List<BillDetails> listDetail;

        public BillModel(string id, DateTime date, string memberId, List<BillDetails> listDetail)
        {
            this.id = id;
            this.date = date;
            this.memberId = memberId;
            this.listDetail = listDetail;
        }

        public string Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string MemberId { get => memberId; set => memberId = value; }
        internal List<BillDetails> ListDetail { get => listDetail; set => listDetail = value; }
    }
}
