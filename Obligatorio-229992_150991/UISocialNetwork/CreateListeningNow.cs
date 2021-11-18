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
    public delegate void PostCreate(ListeningNowCreated listening);
    public partial class CreateListeningNow : UserControl
    {
        private User actualUser;
        private UserRepository users;
        private ListeningNowRepository songs;
        private CommentRepository comments;
        private event PostCreate PostCreateEvent;
        public CreateListeningNow(User actualUser, ListeningNowRepository songs, UserRepository users, CommentRepository comments)
        {
            InitializeComponent();
            this.actualUser = actualUser;
            this.users = users;
            this.songs = songs;
            this.comments = comments;

        }
        public void AddListener(PostCreate del)
        {
            PostCreateEvent += del;
        }

        private void saveListeningNowBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ListeningNow actualListening = new ListeningNow(songTxtBox.Text, artistTxtBox.Text, albumTxtBox.Text);
                actualUser.Listening = actualListening;
                users.UpdateSong(actualListening, actualUser);
                ListeningNowCreated listening = new ListeningNowCreated(actualUser, actualListening, comments, songs);
                PostCreateEvent(listening);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
