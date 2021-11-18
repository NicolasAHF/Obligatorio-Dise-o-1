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
        private ScoresRepository scores;
        private AlbumRepository albums;
        private ListeningNowRepository songs;
        private StatusRepository statusDB;
        private CommentRepository comments;
        private List<UserControl> contents;
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
            CreateUser createUser = new CreateUser(users);
            mainPanel.Controls.Add(createUser);
        }

        private void CreateHomePanel(User user)
        {
            ClearPanel();
            Home home = new Home(users, user, contents, albums, songs, statusDB, comments);
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
            Profile profile = new Profile(users.Get(usernamelblHome.Text), users.Get(usernamelblHome.Text), users, scores);
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
            Profile profile = new Profile(user, users.Get(usernamelblHome.Text), users, scores);
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

        private void marketplaceBtn_Click(object sender, EventArgs e)
        {
            ClearPanel();
            MarketPlace marketPlace = new MarketPlace((users.Get(usernamelblHome.Text)), games, scores);
            mainPanel.Controls.Add(marketPlace);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            users = new UserRepository(new Password("Default123"), new Direction(), new Photo(), new List<Album>());
            contents = new List<UserControl>();
            games = new GamesRepository();
            scores = new ScoresRepository();
            albums = new AlbumRepository();
            songs = new ListeningNowRepository();
            statusDB = new StatusRepository();
            comments = new CommentRepository();
            if (!users.IsEmpty())
            {
                List<SocialNetwork.User> usersList = (List<SocialNetwork.User>)users.GetAll();
                if (!albums.IsEmpty())
                {
                    List<SocialNetwork.Album> albumsList = (List<SocialNetwork.Album>)albums.GetAll();
                   
                    foreach (User user in usersList)
                    {
                        foreach(Album album in albumsList)
                        {
                            AlbumCreated albumCreated = new AlbumCreated(user, album, comments, albums);
                            contents.Add(albumCreated);
                        }

                    }
                }
                if (!songs.IsEmpty())
                {
                    List<SocialNetwork.ListeningNow> songsList = (List<SocialNetwork.ListeningNow>)songs.GetAll();
                    foreach(User user in usersList)
                    {
                        foreach (ListeningNow song in songsList)
                        {
                            if (user.Listening.Equals(song))
                            {
                                ListeningNowCreated listeningNowCreated = new ListeningNowCreated(user, song, comments, songs);
                                contents.Add(listeningNowCreated);
                            }
                        }
                    }

                }
                //if (!statusDB.IsEmpty())
                //{
                //    List<SocialNetwork.Status> statusList = (List<SocialNetwork.Status>)statusDB.GetAll();
                //    foreach (User user in usersList)
                //    {
                //        foreach (Status status in statusList)
                //        {
                //            if (user.Status.Equals(status))
                //            {
                //                StatusCreated statusCreated = new StatusCreated(user, status, statusDB, comments);
                //                contents.Add(statusCreated);
                //            }
                //        }
                //    }
                //}
                if (!comments.IsEmpty())
                {
                    List<SocialNetwork.Comment> commentList = (List<SocialNetwork.Comment>)comments.GetAll();
                    foreach (User user in usersList)
                    {
                        foreach (Comment comm in commentList)
                        {
                            CommentCreated commentCreated = new CommentCreated(comm, user, comments);
                            contents.Add(commentCreated);
                        }
                    }
                }
            }
        }
    }
}
