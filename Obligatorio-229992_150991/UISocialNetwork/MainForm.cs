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
        private User user;
        private DirectoryUser users = new DirectoryUser();
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            ClearPanel();
            UserControl login = new Login(users);
            mainPanel.Controls.Add(login);
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            ClearPanel();
            UserControl createUser = new CreateUserControl(users);
            mainPanel.Controls.Add(createUser);
        }

        private void CreateHomePanel(User user)
        {
            ClearPanel();
            UserControl home = new Home();
            mainPanel.Controls.Add(home);
        }
        private void ClearPanel()
        {
            mainPanel.Controls.Clear();
        }
    }
}
