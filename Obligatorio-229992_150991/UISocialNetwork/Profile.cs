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
    public partial class Profile : UserControl
    {
        private User user;
        private User actualUser;
        private UserRepository users;
        private ScoresRepository scores;
        public Profile(User user, User actualUser, UserRepository users, ScoresRepository scores)
        {
            InitializeComponent();
            this.user = user;
            this.actualUser = actualUser;
            this.users = users;
            this.scores = scores;
            CheckFollowing(user, actualUser);
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            lblUsername.Text = user.Username;
            avatar.ImageLocation = user.Avatar.ElPath;
            completeNameLbl.Text = user.Name + " " + user.Lastname;
            if (user.Username != actualUser.Username)
            {
                modifyUserBtn.Hide();
                changePasswordBtn.Hide();
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
            modifyUserBtn.Enabled = true;
        }

        private void modifyUser_Click(object sender, EventArgs e)
        {
            modifyPanel.Controls.Clear();
            ModifyUser modifyUser = new ModifyUser(user, users);
            modifyUser.AddListener(PostModify);
            modifyPanel.Controls.Add(modifyUser);
            modifyPanel.Show();
            modifyUserBtn.Enabled = false;
        }

        private void followBtn_Click(object sender, EventArgs e)
        {
            if (followBtn.Text == "Seguir")
            {
                followBtn.Text = "Siguiendo";
                followBtn.BackColor = Color.White;
                followBtn.ForeColor = Color.Maroon;
                actualUser.Following.Add(user);
                users.AddFollowing(actualUser, user);
            }
            else
            {
                followBtn.Text = "Seguir";
                followBtn.BackColor = Color.Maroon;
                followBtn.ForeColor = Color.White;
                actualUser.Following.Remove(user);
                users.RemoveFollowing(actualUser, user);
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
            if (users.Get(actualUser.Username).Following.Contains(user))
            {
                followBtn.Text = "Siguiendo";
                followBtn.BackColor = Color.White;
                followBtn.ForeColor = Color.Maroon;
            }
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePassword newPassword = new ChangePassword(actualUser, users);
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
