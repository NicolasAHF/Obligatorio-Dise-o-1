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
    public partial class CreateUserControl : UserControl
    {
        private DirectoryUser users;
        public CreateUserControl(DirectoryUser users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void saveUser_Click(object sender, EventArgs e)
        {
            const string USER_CREATED_SUCCESFULLY = "Usuario creado con exito";
            try
            {
                Direction direction = new Direction();
                direction.Street = textBoxStreet.Text;
                direction.City = textBoxCity.Text;
                direction.Counrty = textBoxCountry.Text;
                users.AddUser(new User(textBoxUsername.Text, textBoxPassword.Text, textBoxName.Text, textBoxLastname.Text, dateofbirth.Value, direction, lblPath.Text));
                ShowFeedbackMessage(System.Drawing.Color.Green, USER_CREATED_SUCCESFULLY);
            }
            catch (Exception exp)
            {
                ShowFeedbackMessage(System.Drawing.Color.Red, exp.Message);
            }
        }
        private void ShowFeedbackMessage(System.Drawing.Color color, string message)
        {
            lblErrorMsg.Show();
            lblErrorMsg.ForeColor = color;
            lblErrorMsg.Text = message;
        }

        private void avatarBtn_Click_1(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    avatarBox.ImageLocation = imageLocation;
                    lblPath.Text = "Path:" + imageLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
