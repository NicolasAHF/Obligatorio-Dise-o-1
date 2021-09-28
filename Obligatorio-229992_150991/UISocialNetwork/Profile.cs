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
    public partial class Profile : UserControl
    {
        private User user;
        public Profile(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            lblUsername.Text = user.Username;
            avatar.ImageLocation = user.Avatar;
        }

        private void modifyUser_Click(object sender, EventArgs e)
        {
            
        }
    }
}
