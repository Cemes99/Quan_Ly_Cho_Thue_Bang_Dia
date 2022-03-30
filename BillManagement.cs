using Project.Controller;
using Project.Models;
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
        int index = 0;

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
            if (idField.Text == "") return ;
            if (!controller.createBill(memberIdField.Text))
            {
                MessageBox.Show("Thành viên vẫn còn phiếu thuê trễ hạn", "Thông báo lập phiếu thuê", MessageBoxButtons.OK);
                
                return ;
            }

            var values = new object[7];
            values[0] = idField.Text;
            values[1] = dateField.Text;
            values[2] = memberIdField.Text;
            values[3] = diskIdField.Text;
            values[4] = rentalDateField.Text;
            values[5] = priceField.Text;
            values[6] = amountField.Text;

            controller.dt.Rows.Add(values);

            MessageBox.Show("Lập phiếu thuê thành công", "Thông báo lập phiếu thuê", MessageBoxButtons.OK);
        }

        private void searchByMember_Click(object sender, EventArgs e)
        {
            controller.search(memberIdField.Text);
        }

        private void payment_Click(object sender, EventArgs e)
        {
            index = table.CurrentRow.Index;
            DialogResult dr = MessageBox.Show(controller.makePayment(index), "Thông báo thanh toán", MessageBoxButtons.OKCancel);
            
            if(dr == DialogResult.OK)
            {
                Db.listBill[index].Status = BillModel.BillStatus.done;
            }
            table.Refresh();
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idField.Text = table.Rows[e.RowIndex].Cells[0].Value.ToString();
            dateField.Text = table.Rows[e.RowIndex].Cells[1].Value.ToString();
            memberIdField.Text = table.Rows[e.RowIndex].Cells[2].Value.ToString();
            diskIdField.Text = table.Rows[e.RowIndex].Cells[3].Value.ToString();
            rentalDateField.Text = table.Rows[e.RowIndex].Cells[4].Value.ToString();
            priceField.Text = table.Rows[e.RowIndex].Cells[5].Value.ToString();
            amountField.Text = table.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            controller = new BillManagementController();
            table.DataSource = controller.dt;
        }
    }
}
