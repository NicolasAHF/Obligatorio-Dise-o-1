using SocialNetwork;
using SocialNetworkDB;
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
    public delegate void PostModifyPassword();
    public partial class ChangePassword : UserControl
    {
        private User actualUser;
        private UserRepository users;
        private event PostModifyPassword PostModifyPasswordEvent;
        public ChangePassword(User actualUser, UserRepository users)
        {
            InitializeComponent();
            this.actualUser = actualUser;
            this.users = users;
        }

        public void AddListener(PostModifyPassword del)
        {
            PostModifyPasswordEvent += del;
        }

        private void SavePassword_Click(object sender, EventArgs e)
        {
            try
            {
                Password currentPassword = new Password(currentPasswordTxtBox.Text);
                Password newPassword = new Password(newPasswordTxtBox.Text);
                actualUser.ChangePassword(actualUser, currentPassword, newPassword);
                users.Update(newPassword, actualUser);
                PostModifyPasswordEvent();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
