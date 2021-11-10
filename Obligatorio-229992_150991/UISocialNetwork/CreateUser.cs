using SocialNetwork;
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
using System.Data.Entity;
using SocialNetworkDB;

namespace UISocialNetwork
{
    public partial class CreateUser : UserControl
    {
        private UserRepository users;
        private Photo avatar;
        public CreateUser(UserRepository users)
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
                Password pass = new Password(textBoxPassword.Text);

                User elUsuario = new User(textBoxUsername.Text, pass, textBoxName.Text, textBoxLastname.Text, dateofbirth.Value, direction, avatar, adminCheckBox.Checked);
                users.Add(elUsuario);
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

        private void AvatarBtn_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Imagenes JPG,PNG,JPEG|*.jpeg;*.jpg;*.png";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    String destinationPath = Path.Combine(@"C:\", Path.GetFileName(imageLocation));
                    FileInfo fileSize = new FileInfo(dialog.FileName);
                    Photo avatar = new Photo(destinationPath, fileSize.Length);
                    this.avatar = avatar;
                    avatarBox.Image = new Bitmap(imageLocation);
                    SaveImage(imageLocation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveImage(string imageLocation)
        {
            File.Copy(imageLocation, Path.Combine(@"C:\", Path.GetFileName(imageLocation)));
        }

    }
}
