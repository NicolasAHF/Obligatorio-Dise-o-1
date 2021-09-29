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
    public partial class Home : UserControl
    {
        private DirectoryUser users;
        public Home(DirectoryUser users)
        {
            InitializeComponent();
            this.users = users;
            userList.DataSource = users.Users;
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            userList.Show();
        }
    }

}
