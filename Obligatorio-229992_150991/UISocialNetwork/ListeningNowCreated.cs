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
    public partial class ListeningNowCreated : UserControl
    {
        private User actualUser;
        public ListeningNowCreated(User actualUser)
        {
            this.actualUser = actualUser;
            InitializeComponent();
            usernameLbl.Text = actualUser.Username;
            songLbl.Text = songLbl.Text + " " + actualUser.Listening.SongName;
            albumLbl.Text = albumLbl.Text + " " + actualUser.Listening.AlbumName;
            artistLbl.Text = artistLbl.Text + " " + actualUser.Listening.Artist;
        }

        public bool CheckCreated()
        {
            if(songLbl.Text == "Cancion: " || albumLbl.Text == "Album: " || artistLbl.Text == "Artista: ")
            {
                return false;
            }
            return true;
        }
        public string UsernameUserSong()
        {
            return usernameLbl.Text;
        }
    }
}
