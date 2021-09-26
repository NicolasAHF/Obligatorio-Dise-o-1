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
    public delegate void PostLogin();
    public partial class Login : UserControl
    {
        private DirectoryUser users;
        private event PostLogin PostLoginEvent;
        public Login(DirectoryUser users)
        {
            InitializeComponent();
            this.users = users;
        }
        public void AddListener(PostLogin del)
        {
            PostLoginEvent += del;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = UsernameTextBox.Text;
                Password password = new Password(PasswordTextBox.Text);

                User actualUser = users.GetUser(username);
                if (actualUser.GetPassword().CheckPassword(password))
                {
                    PostLoginEvent();
                }
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
    }
}
