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
    public delegate void PostModify();
    public partial class ModifyUser : UserControl
    {
        private User user;
        private event PostModify PostModifyEvent;
        public ModifyUser(User user)
        {
            InitializeComponent();
            this.user = user;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                user.SetName(nameModifyBox.Text);
                user.SetLastname(lastnameModifyBox.Text);
                user.SetDirection(auxDirection);
                user.SetAvatar(avatarModifyBox.ImageLocation);
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
            avatarModifyBox.ImageLocation = user.Avatar;
        }

        private void ShowFeedbackMessage(System.Drawing.Color color, string message)
        {
            lblErrorMsg.Show();
            lblErrorMsg.ForeColor = color;
            lblErrorMsg.Text = message;
        }
    }
}
