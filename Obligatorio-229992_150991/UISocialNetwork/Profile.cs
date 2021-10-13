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
        private User actualUser;
        public Profile(User user, User actualUser)
        {
            InitializeComponent();
            this.user = user;
            this.actualUser = actualUser;
            CheckFollowing(user, actualUser);
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            lblUsername.Text = user.Username;
            avatar.ImageLocation = user.Avatar.ElPath;
            completeNameLbl.Text = user.Name + " " + user.Lastname;
            if (user.Username != actualUser.Username)
            {
                modifyUser.Hide();
            }
            else
            {
                followBtn.Hide();
            }

        }

        private void PostModify()
        {
            completeNameLbl.Text = user.Name + " " + user.Lastname;
            modifyPanel.Hide();
            modifyUser.Enabled = true;
        }

        private void modifyUser_Click(object sender, EventArgs e)
        {
            modifyPanel.Controls.Clear();
            ModifyUser modifyUser = new ModifyUser(user);
            modifyUser.AddListener(PostModify);
            modifyPanel.Controls.Add(modifyUser);
            modifyPanel.Show();
            modifyUser.Enabled = false;
        }

        private void followBtn_Click(object sender, EventArgs e)
        {
            if (followBtn.Text == "Seguir")
            {
                followBtn.Text = "Siguiendo";
                followBtn.BackColor = Color.White;
                followBtn.ForeColor = Color.Maroon;
            }
            else
            {
                followBtn.Text = "Seguir";
                followBtn.BackColor = Color.Maroon;
                followBtn.ForeColor = Color.White;
            }

        }

        private void followBtn_MouseHover(object sender, EventArgs e)
        {
            if (followBtn.Text == "Siguiendo")
            {
                followBtn.Text = "Dejar de seguir";
            }
        }

        private void followBtn_MouseLeave(object sender, EventArgs e)
        {
            if (followBtn.Text == "Dejar de seguir")
            {
                followBtn.Text = "Siguiendo";
            }
        }

        private void CheckFollowing(User user, User actualUser)
        {
            if (actualUser.Following.Contains(user))
            {
                followBtn.Text = "Siguiendo";
                followBtn.BackColor = Color.White;
                followBtn.ForeColor = Color.Maroon;
            }
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePassword newPassword = new ChangePassword(actualUser);
            newPassword.AddListener(PostModifyPassword);
            changePasswordBtn.Enabled = false;
            passwordPanel.Controls.Clear();
            passwordPanel.Controls.Add(newPassword);
        }

        private void PostModifyPassword()
        {
            passwordPanel.Controls.Clear();
            changePasswordBtn.Enabled = true;
        }
    }
}
