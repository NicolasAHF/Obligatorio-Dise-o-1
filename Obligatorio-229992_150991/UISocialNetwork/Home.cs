using SocialNetwork;
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
    public delegate void PostSearch(User user);
    public partial class Home : UserControl
    {
        private UserRepository users;
        private User actualUser;
        private AlbumRepository albums;
        private ListeningNowRepository songs;
        private StatusRepository statusDB;
        private CommentRepository comments;
        private event PostSearch PostSearchEvent;
        private List<UserControl> content;
        public Home(UserRepository users, User actualUser, List<UserControl> contents, AlbumRepository albums, ListeningNowRepository songs, StatusRepository statusDB, CommentRepository comments)
        {
            InitializeComponent();
            this.users = users;
            this.actualUser = actualUser;
            this.content = contents;
            this.albums = albums;
            this.songs = songs;
            this.statusDB = statusDB;
            this.comments = comments;
            userList.DataSource = users.GetAll();
            ShowContent(content);
            HideEditBtn();
            FilterContentAlbum();
            //FilterContentSongs();
        }

        public void AddListener(PostSearch del)
        {
            PostSearchEvent += del;
        }

        private void ShowContent(List<UserControl> content)
        {
            for(int i = 0; i < content.Count(); i++)
                {
                showContentPanel.Controls.Add(content[i]);
            }
            //if (showContentPanel.Controls.Count < 0)
            //{
            //    showContentPanel.Controls.Clear();
            //}
            //else
            //{
            //    for(int i = 0; i< content.Count(); i++)
            //    {
            //        showContentPanel.Controls.Add(content[i]);
            //    }
            //}

        }
        private void FilterContentAlbum()
        {
            if(content != null)
            {
                foreach (AlbumCreated album in content)
                {
                    if (album.UsernameUserAlbum() != actualUser.Username && !actualUser.Following.Contains(users.Get(album.UsernameUserAlbum())))
                    {
                        album.Hide();
                    }
                    else
                    {
                        album.Show();
                    }
                }

            }
            
        }
        private void FilterContentSongs()
        {
            if (content != null)
            {
                foreach (ListeningNowCreated song in content)
                {
                    if (song.UsernameUserSong() != actualUser.Username || !actualUser.Following.Contains(users.Get(song.UsernameUserSong())))
                    {
                        song.Hide();
                    }
                    else
                    {
                        song.Show();
                    }
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
                PostSearchEvent(users.Get(searchBox.Text));
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
            CreateListeningNow listening = new CreateListeningNow(actualUser, songs, users, comments);
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

        private void PostCreateStatus(StatusCreated statusCreated)
        {
            panelContent.Controls.Clear();
            content.Add(statusCreated);
            ShowContent(content);
        }

        private void createAlbumBtn_Click(object sender, EventArgs e)
        {
            CreateAlbum album = new CreateAlbum(actualUser, albums, comments, users);
            album.AddListener(PostCreateAlbum);
            panelContent.Controls.Clear();
            panelContent.Controls.Add(album);
        }

        private void userList_Leave(object sender, EventArgs e)
        {
            userList.Hide();
        }

        private void statusBtn_Click(object sender, EventArgs e)
        {
            CreateStatus status = new CreateStatus(actualUser, users, statusDB, comments);
            status.AddListener(PostCreateStatus);
            panelContent.Controls.Clear();
            panelContent.Controls.Add(status);
        }
        private void HideEditBtn()
        {
            if (content != null)
            {
                foreach (AlbumCreated album in content)
                {
                    if (album.UsernameUserAlbum() != actualUser.Username)
                    {
                        album.HideEditBtn();
                    }
                }
            }
        }
    }

}
