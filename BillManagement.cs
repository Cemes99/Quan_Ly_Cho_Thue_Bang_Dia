using Project.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class BillManagement : Form
    {
        private BillManagementController controller = new BillManagementController();

        public BillManagement()
        {
            InitializeComponent();
            table.DataSource = controller.dt;
        }

        private void toHome_Click(object sender, EventArgs e)
        {
            this.Close();
            new Home().Show();
        }

        private void createBill_Click(object sender, EventArgs e)
        {
            var values = new object[7];
            values[0] = idField.Text;
            values[1] = dateField.Text;
            values[2] = memberIdField.Text;
            values[3] = diskIdField.Text;
            values[4] = rentalDateField.Text;
            values[5] = priceField.Text;
            values[6] = amountField.Text;

            controller.dt.Rows.Add(values);
        }

        private void searchByMember_Click(object sender, EventArgs e)
        {
            controller.search(memberIdField.Text);
        }

        private void payment_Click(object sender, EventArgs e)
        {

        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            controller = new BillManagementController();
        }
    }
}
