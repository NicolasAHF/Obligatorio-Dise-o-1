<<<<<<< HEAD
﻿using System;
=======
﻿using SocialNetwork;
using System;
>>>>>>> develop
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
<<<<<<< HEAD
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
=======
    public partial class MainForm : Form
    {
        private DirectoryUser users = new DirectoryUser();
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            ClearPanel();
            Login login = new Login(users);
            login.AddListener(PostLogin);
            mainPanel.Controls.Add(login);
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            ClearPanel();
            CreateUserControl createUser = new CreateUserControl(users);
            mainPanel.Controls.Add(createUser);
        }

        private void CreateHomePanel(User user)
        {
            ClearPanel();
            UserControl home = new Home(user);
            mainPanel.Controls.Add(home);
        }

        private void PostLogin(User user)
        {
            ClearPanel();
            CreateHomePanel(user);
            PostLoginHide();
            PostLoginShow();
        }

        private void PostLoginHide()
        {
            createUserBtn.Hide();
            loginBtn.Hide();
        }

        private void PostLoginShow()
        {
            profileBtn.Show();
            marketplaceBtn.Show();
            LogoutBtn.Show();
        }
        private void ClearPanel()
        {
            mainPanel.Controls.Clear();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            ClearPanel();
            Profile profile = new Profile();
            mainPanel.Controls.Add(profile);
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
           ClearPanel();
           label1.Show(); 
           PostLogoutShow();
           PostLogoutHide();
        }

        private void PostLogoutShow()
        {
            createUserBtn.Show();
            loginBtn.Show();
        }

        private void PostLogoutHide()
        {
            profileBtn.Hide();
            marketplaceBtn.Hide();
            LogoutBtn.Hide();
>>>>>>> develop
        }
    }
}
