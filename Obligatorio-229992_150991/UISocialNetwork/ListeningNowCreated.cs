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
using System.Windows.Forms.Design;

namespace UISocialNetwork
{
    public partial class ListeningNowCreated : UserControl
    {
        private User actualUser;
        private ListeningNow song;
        private CommentRepository comments;
        private ListeningNowRepository songs;
        public ListeningNowCreated(User actualUser, ListeningNow song, CommentRepository comments, ListeningNowRepository songs)
        {
            this.actualUser = actualUser;
            this.song = song;
            InitializeComponent();
            usernameLbl.Text = actualUser.Username;
            songLbl.Text = songLbl.Text + " " + song.SongName;
            albumLbl.Text = albumLbl.Text + " " + song.AlbumName;
            artistLbl.Text = artistLbl.Text + " " + song.Artist;
            this.comments = comments;
            this.songs = songs;
        }

        public bool CheckCreated()
        {
            if(songLbl.Text == "Cancion: " || albumLbl.Text == "Album: " || artistLbl.Text == "Artista: ")
            {
                return false;
            }
            return true;
        }
        public void PostCreateCommentListening(CommentCreated newComment, Comment comment)
        {
            commentPanel.Controls.Add(newComment);
            songs.UpdateComment(song, comment);
            commentBtn.Enabled = true;
        }

        private void commentBtn_Click(object sender, EventArgs e)
        {
            CreateComment comment = new CreateComment(actualUser, actualUser.Listening, comments);
            comment.AddListenerListening(PostCreateCommentListening);
            commentPanel.Controls.Add(comment);
            commentBtn.Enabled = false;
        }
        private void likeBtn_Click(object sender, EventArgs e)
        {
            if (likeBtn.Text == "Me Gusta")
            {
                Reaction reaction = new Reaction(likeBtn.Text, actualUser);
                likeBtn.Text = "Quitar";
                likeBtn.BackColor = Color.White;
                likeBtn.ForeColor = Color.Maroon;
                song.Reactions.Add(reaction);
                likeCount.Text = Convert.ToString(CountLikes());
            }
            else
            {
                likeBtn.Text = "Me Gusta";
                Reaction reaction = song.GetReaction(likeBtn.Text, actualUser);
                likeBtn.BackColor = Color.Maroon;
                likeBtn.ForeColor = Color.White;
                song.Reactions.Remove(reaction);
                likeCount.Text = Convert.ToString(CountLikes());
            }
        }

        private void congratsBtn_Click(object sender, EventArgs e)
        {
            if (congratsBtn.Text == "Felicitaciones")
            {
                Reaction reaction = new Reaction(congratsBtn.Text, actualUser);
                congratsBtn.Text = "Quitar";
                congratsBtn.BackColor = Color.White;
                congratsBtn.ForeColor = Color.Maroon;
                song.Reactions.Add(reaction);
                congratsCount.Text = Convert.ToString(CountCongrats());
            }
            else
            {
                congratsBtn.Text = "Felicitaciones";
                Reaction reaction = song.GetReaction(congratsBtn.Text, actualUser);
                congratsBtn.BackColor = Color.Maroon;
                congratsBtn.ForeColor = Color.White;
                song.Reactions.Remove(reaction);
                congratsCount.Text = Convert.ToString(CountCongrats());
            }
        }

        private void loveBtn_Click(object sender, EventArgs e)
        {
            if (loveBtn.Text == "Me Encanta")
            {
                Reaction reaction = new Reaction(loveBtn.Text, actualUser);
                loveBtn.Text = "Quitar";
                loveBtn.BackColor = Color.White;
                loveBtn.ForeColor = Color.Maroon;
                song.Reactions.Add(reaction);
                loveCount.Text = Convert.ToString(CountLoves());
            }
            else
            {
                loveBtn.Text = "Me Encanta";
                Reaction reaction = song.GetReaction(loveBtn.Text, actualUser);
                loveBtn.BackColor = Color.Maroon;
                loveBtn.ForeColor = Color.White;
                song.Reactions.Remove(reaction);
                loveCount.Text = Convert.ToString(CountLoves());
            }
        }
        private int CountLikes()
        {
            int count = 0;
            foreach (Reaction reaction in song.Reactions)
            {
                if (reaction.ReactionName.Equals("Me Gusta"))
                {
                    count++;
                }
            }
            return count;
        }
        private int CountCongrats()
        {
            int count = 0;
            foreach (Reaction reaction in song.Reactions)
            {
                if (reaction.ReactionName.Equals("Felicitaciones"))
                {
                    count++;
                }
            }
            return count;
        }
        private int CountLoves()
        {
            int count = 0;
            foreach (Reaction reaction in song.Reactions)
            {
                if (reaction.ReactionName.Equals("Me Encanta"))
                {
                    count++;
                }
            }
            return count;
        }
        public string UsernameUserSong()
        {
            return usernameLbl.Text;
        }
    }
}
