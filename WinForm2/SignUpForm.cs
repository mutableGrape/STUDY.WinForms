using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm2
{
    public partial class SignUpForm : Form
    {
        private List<User> users = new List<User>();

        public SignUpForm()
        {
            //this.users = users;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User a = new User
            {
                FirstName = textBox1.Text,
                LastName = textBox1.Text,
                Email = textBox1.Text,
                PhoneNumber = textBox1.Text,
                OptIn = checkBox1.Checked
            };
            this.users.Add(a);
        }
    }
}
