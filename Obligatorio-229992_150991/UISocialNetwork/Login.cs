using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SocialNetwork;

namespace UISocialNetwork
{
    public partial class Login : Form
    {
        private DirectoryUser users = new DirectoryUser();
        public Login()
        {
            InitializeComponent();
        }

        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            CreateUser formUser = new CreateUser(users);
            formUser.Show();
        }
    }
}
