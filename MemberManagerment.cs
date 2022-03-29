using Project.Controller;
using System;
using System.Windows.Forms;

namespace Project
{
    public partial class MemberManagerment : Form
    {
        private MemberManagementController controller = new MemberManagementController();
        private int index;

        public MemberManagerment()
        {
            InitializeComponent();
            table.DataSource = controller.dt;
        }

        private void addMember_Click(object sender, EventArgs e)
        {
            var values = new object[5];
            values[0] = idField.Text;
            values[1] = nameField.Text;
            values[2] = phoneNumberField.Text;
            values[3] = idCardField.Text;
            values[4] = addressField.Text;

            controller.dt.Rows.Add(values);
        }

        private void save_Click(object sender, EventArgs e)
        {
            index = table.CurrentRow.Index;
            table.Rows[index].Cells[0].Value = idField.Text;
            table.Rows[index].Cells[1].Value = nameField.Text;
            table.Rows[index].Cells[2].Value = phoneNumberField.Text;
            table.Rows[index].Cells[3].Value = idCardField.Text;
            table.Rows[index].Cells[4].Value = addressField.Text;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            index = table.CurrentCell.RowIndex;
            table.Rows.RemoveAt(index);
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idField.Text = table.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameField.Text = table.Rows[e.RowIndex].Cells[1].Value.ToString();
            phoneNumberField.Text = table.Rows[e.RowIndex].Cells[2].Value.ToString();
            idCardField.Text = table.Rows[e.RowIndex].Cells[3].Value.ToString();
            addressField.Text = table.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Home().Show();
        }
    }
}
