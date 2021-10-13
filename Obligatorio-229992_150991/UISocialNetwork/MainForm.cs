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
    public partial class MainForm : Form
    {
        private DirectoryUser users;
        public MainForm()
        {
            InitializeComponent();
            users = new DirectoryUser();
            
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
            CreateUser createUser = new CreateUser(users);
            mainPanel.Controls.Add(createUser);
        }

        private void CreateHomePanel(User user)
        {
            ClearPanel();
            Home home = new Home(users, user);
            home.AddListener(PostSearch);
            mainPanel.Controls.Add(home);

        }

        private void PostLogin(User user)
        {
            ClearPanel();
            CreateHomePanel(user);
            PostLoginHide();
            PostLoginShow();
            usernamelblHome.Show();
            usernamelblHome.Text = user.Username;
            if (user.Admin == true)
            {
                adminLbl.Show();
            }

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
            Profile profile = new Profile(users.GetUser(usernamelblHome.Text), users.GetUser(usernamelblHome.Text));
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
            usernamelblHome.Hide();
        }

        private void PostSearch(User user)
        {
            ClearPanel();
            Profile profile = new Profile(user, users.GetUser(usernamelblHome.Text));
            mainPanel.Controls.Add(profile);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (loginBtn.Visible != true)
            {
                ClearPanel();
                CreateHomePanel(users.GetUser(usernamelblHome.Text));
            }

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DirectoryInfo path = new DirectoryInfo(@"C:\Users\Admin\Desktop\OBLIDA1\229992_150991\Obligatorio-229992_150991\UISocialNetwork\Resources");
            foreach(FileInfo image in path.GetFiles())
            {
                image.Delete();
            }
        }

        private void marketplaceBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
