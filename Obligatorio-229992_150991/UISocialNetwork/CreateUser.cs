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

namespace UISocialNetwork
{
    public partial class CreateUser : UserControl
    {
        private DirectoryUser users;
        private Photo avatar;
        public CreateUser(DirectoryUser users)
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
                users.AddUser(new User(textBoxUsername.Text, pass, textBoxName.Text, textBoxLastname.Text, dateofbirth.Value, direction, avatar, adminCheckBox.Checked));
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
                    FileInfo fileSize = new FileInfo(dialog.FileName);
                    Photo avatar = new Photo(lblPath.Text, fileSize.Length/1000);
                    this.avatar = avatar;
                    avatarBox.Image = new Bitmap(imageLocation);
                    lblPath.Text = "Path:" + imageLocation;
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
            File.Copy(imageLocation, Path.Combine(@"C:\Users\nicolas\Desktop\COPIA OBLI\OBLIDA1\229992_150991\Obligatorio-229992_150991\UISocialNetwork\Resources", Path.GetFileName(lblPath.Text)));
        }

    }
}
