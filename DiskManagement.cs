using Project.Controller;
using System;
using System.Windows.Forms;

namespace Project
{
    public partial class DiskManagement : Form
    {
        private DiskManagementController controller = new DiskManagementController();
        private int index = 0;

        public DiskManagement()
        {
            InitializeComponent();
            table.DataSource = controller.dt;
        }

        private void addDisk_Click(object sender, EventArgs e)
        {
            var values = new object[6];
            values[0] = idField.Text;
            values[1] = nameField.Text;
            values[2] = categoryField.Text;
            values[3] = statusField.Text;
            values[4] = companyField.Text;
            values[5] = noteField.Text;

            controller.dt.Rows.Add(values);
        }

        private void save_Click(object sender, EventArgs e)
        {
            index = table.CurrentRow.Index;
            table.Rows[index].Cells[0].Value = idField.Text;
            table.Rows[index].Cells[1].Value = nameField.Text;
            table.Rows[index].Cells[2].Value = categoryField.Text;
            table.Rows[index].Cells[3].Value = statusField.Text;
            table.Rows[index].Cells[4].Value = companyField.Text;
            table.Rows[index].Cells[5].Value = noteField.Text;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            index = table.CurrentCell.RowIndex;
            table.Rows.RemoveAt(index);
            table.Refresh();
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idField.Text = table.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameField.Text = table.Rows[e.RowIndex].Cells[1].Value.ToString();
            categoryField.Text = table.Rows[e.RowIndex].Cells[2].Value.ToString();
            statusField.Text = table.Rows[e.RowIndex].Cells[3].Value.ToString();
            companyField.Text = table.Rows[e.RowIndex].Cells[4].Value.ToString();
            noteField.Text = table.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

    }
}
