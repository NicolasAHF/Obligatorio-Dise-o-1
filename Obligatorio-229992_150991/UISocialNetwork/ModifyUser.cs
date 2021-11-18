using SocialNetwork;
using SocialNetworkDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UISocialNetwork
{
    public delegate void PostModify();
    public partial class ModifyUser : UserControl
    {
        private User user;
        private UserRepository users;
        private event PostModify PostModifyEvent;
        public ModifyUser(User user, UserRepository users)
        {
            InitializeComponent();
            this.user = user;
            this.users = users;
        }

        public void AddListener(PostModify del)
        {
            PostModifyEvent += del;
        }

        private void uploadModifyBtn_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    avatarModifyBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception exp)
            {
                ShowFeedbackMessage(System.Drawing.Color.Red, exp.Message);
            }
        }

        private void saveModifyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Direction auxDirection = new Direction();
                auxDirection.Street = streetModifyBox.Text;
                auxDirection.City = cityModifyBox.Text;
                auxDirection.Counrty = countryModifyBox.Text;
                FileInfo fileInfo = new FileInfo(user.Avatar.ElPath);
                user.SetName(nameModifyBox.Text);
                user.SetLastname(lastnameModifyBox.Text);
                user.Direction = auxDirection;
                user.Avatar = new Photo(avatarModifyBox.ImageLocation, fileInfo.Length/1000);
                users.UpdateModifyUser(user);
                PostModifyEvent();
            }
            catch (Exception exp)
            {
                ShowFeedbackMessage(System.Drawing.Color.Red, exp.Message);
            }
        }

        private void ModifyUser_Load(object sender, EventArgs e)
        {
            lastnameModifyBox.Text = user.Lastname;
            nameModifyBox.Text = user.Name;
            streetModifyBox.Text = user.Direction.Street;
            cityModifyBox.Text = user.Direction.City;
            countryModifyBox.Text = user.Direction.Counrty;
            dobModify.Value = user.DateOfBirth;
            avatarModifyBox.ImageLocation = user.Avatar.ElPath;
        }

        private void ShowFeedbackMessage(System.Drawing.Color color, string message)
        {
            lblErrorMsg.Show();
            lblErrorMsg.ForeColor = color;
            lblErrorMsg.Text = message;
        }
    }
}
