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
            login.AddListener(PostLogin(user));
            mainPanel.Controls.Add(login);
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            ClearPanel();
            CreateUserControl createUser = new CreateUserControl(users);
            mainPanel.Controls.Add(createUser);
        }

        private void CreateHomePanel()
        {
            ClearPanel();
            UserControl home = new Home();
            mainPanel.Controls.Add(home);
        }

        private void PostLogin()
        {
            ClearPanel();
            CreateHomePanel();
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
    }
}
