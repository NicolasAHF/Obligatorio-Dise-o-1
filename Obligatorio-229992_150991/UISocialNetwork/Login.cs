using SocialNetwork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UISocialNetwork
{
    public partial class Login : UserControl
    {
        private DirectoryUser users;
        public Login(DirectoryUser users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;


        }

        private User SearchUser(DirectoryUser users, string username, string password)
        {
            
        }
    }
}
