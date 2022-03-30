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
    public partial class LoginScreen : Form
    {
        private LoginController controller = new LoginController();

        public LoginScreen()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(controller.login(textBox1.Text, textBox2.Text))
            {
                this.Hide();
                new Home().Show();
            } else
            {

            }
        }

    }
}
