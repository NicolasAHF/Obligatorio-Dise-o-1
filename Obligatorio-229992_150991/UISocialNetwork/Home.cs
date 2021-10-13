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
    public delegate void PostSearch(User user);
    public partial class Home : UserControl
    {
        private DirectoryUser users;
        private User actualUser;
        private event PostSearch PostSearchEvent;
        private List<UserControl> content;
        public Home(DirectoryUser users, User actualUser)
        {
            InitializeComponent();
            this.users = users;
            this.actualUser = actualUser;
            this.content = new List<UserControl>();
            userList.DataSource = users.Users;
        }

        public void AddListener(PostSearch del)
        {
            PostSearchEvent += del;
        }

        private void ShowContent(List<UserControl> content)
        {
            if (showContentPanel.Controls.Count < 0)
            {
                showContentPanel.Controls.Clear();
            }
            else
            {
                for(int i = 0; i< content.Count(); i++)
                {
                    showContentPanel.Controls.Add(content[i]);
                }
            }

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

        private void listeningBtn_Click(object sender, EventArgs e)
        {
            CreateListeningNow listening = new CreateListeningNow(actualUser);
            listening.AddListener(PostCreate);
            panelContent.Controls.Clear();
            panelContent.Controls.Add(listening);
        }

        private void PostCreate(ListeningNowCreated listeningCreated)
        {
            panelContent.Controls.Clear();
            content.Add(listeningCreated);
            ShowContent(content);
        }

        private void PostCreateAlbum(AlbumCreated albumCreated)
        {
            panelContent.Controls.Clear();
            content.Add(albumCreated);
            ShowContent(content);
        }

        private void createAlbumBtn_Click(object sender, EventArgs e)
        {
            CreateAlbum album = new CreateAlbum(actualUser);
            album.AddListener(PostCreateAlbum);
            panelContent.Controls.Clear();
            panelContent.Controls.Add(album);
        }
    }

}
