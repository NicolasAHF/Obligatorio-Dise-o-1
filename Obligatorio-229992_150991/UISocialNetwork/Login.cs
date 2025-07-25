﻿using SocialNetwork;
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

    public delegate void PostLogin(User user);
    public partial class Login : UserControl
    {
        private UserRepository users;
        private event PostLogin PostLoginEvent;
        public Login(UserRepository users)
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
                User actualUser = users.Get(username);
                if (actualUser.GetPassword().CheckPassword(password))
                {
                    PostLoginEvent(actualUser);
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

        private void UsernameTextBox_Enter(object sender, EventArgs e)
        {
            if(UsernameTextBox.Text.Equals("Nombre de usuario"))
            {
                UsernameTextBox.Text = "";

                UsernameTextBox.ForeColor = Color.Black;
            }
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Equals(""))
            {
                UsernameTextBox.Text = "Nombre de usuario";

                UsernameTextBox.ForeColor = Color.Maroon;
            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Equals("Contraseña"))
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.ForeColor = Color.Black;
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Equals(""))
            {
                PasswordTextBox.Text = "Contraseña";
                PasswordTextBox.ForeColor = Color.Maroon;
            }
        }
    }
}
