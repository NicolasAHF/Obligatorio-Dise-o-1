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
    public partial class MainForm : Form
    {
        private UserRepository users;
        private GamesRepository games;
        private List<UserControl> contents;
        public MainForm()
        {
            InitializeComponent();
            users = new UserRepository(new Password("Default123"), new Direction(), new Photo(), new List<Album>());
            contents = new List<UserControl>();
            games = new GamesRepository();
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
            Home home = new Home(users, user, contents);
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
            Profile profile = new Profile(users.Get(usernamelblHome.Text), users.Get(usernamelblHome.Text), users);
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
            Profile profile = new Profile(user, users.Get(usernamelblHome.Text), users);
            mainPanel.Controls.Add(profile);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (loginBtn.Visible != true)
            {
                ClearPanel();
                CreateHomePanel(users.Get(usernamelblHome.Text));
            }

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DirectoryInfo path = new DirectoryInfo(@"C:\Foto");

            foreach (FileInfo image in path.GetFiles())
            {
                image.Delete();
            }
        }

        private void marketplaceBtn_Click(object sender, EventArgs e)
        {
            ClearPanel();
            MarketPlace marketPlace = new MarketPlace((users.Get(usernamelblHome.Text)), games);
            mainPanel.Controls.Add(marketPlace);
        }
    }
}
