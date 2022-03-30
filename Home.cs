using System;
using System.Windows.Forms;
using Project.global;

namespace Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void toDisk_Click(object sender, EventArgs e)
        {
            this.Close();
            new DiskManagement().Show();
        }

        private void toMember_Click(object sender, EventArgs e)
        {
            this.Close();
            new MemberManagerment().Show();
        }

        private void toBill_Click(object sender, EventArgs e)
        {
            this.Close();
            new BillManagement().Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Global.currentUser = "";
            new LoginScreen().Show();
        }
    }
}
