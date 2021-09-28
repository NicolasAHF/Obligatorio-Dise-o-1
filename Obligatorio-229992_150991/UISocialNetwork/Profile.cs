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
            lblUsernameProfile.Text = user.Username;
            namelblModify.Text = user.Name;
        }

        private void PostModify()
        {
            namelblModify.Text = user.Name;
            panel1.Hide();
        }

        private void modifyUserBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ModifyUser modifyUser = new ModifyUser(user);
            modifyUser.AddListener(PostModify);
            panel1.Controls.Add(modifyUser);
            panel1.Show();
            modifyUserBtn.Enabled = false;
        }
    }
}
