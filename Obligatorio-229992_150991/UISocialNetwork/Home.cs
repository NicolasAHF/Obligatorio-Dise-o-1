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
    public partial class Home : UserControl
    {
        private DirectoryUser users;
        private event PostSearch PostSearchEvent;
        public Home(DirectoryUser users)
        {
            InitializeComponent();
            this.users = users;
            userList.DataSource = users.Users;
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            userList.Show();
        }
        private void userList_DoubleClick(object sender, EventArgs e)
        {
            searchBox.Text = userList.SelectedItem.ToString();
            userList.Hide();
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PostSearchEvent(users.GetUser(searchBox.Text));
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
