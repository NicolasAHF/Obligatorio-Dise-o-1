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
    public delegate void PostModifyPassword();
    public partial class ChangePassword : UserControl
    {
        private User actualUser;
        private event PostModifyPassword PostModifyPasswordEvent;
        public ChangePassword(User actualUser)
        {
            InitializeComponent();
            this.actualUser = actualUser;
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

            }catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void CheckCurrentPassword(Password currentPassword)
        {
            try
            {
                currentPassword.CheckPassword(actualUser.GetPassword());

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

    }
}
