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
    public partial class AlbumCreated : UserControl
    {
        private User actualUser;
        private Album album;
        public AlbumCreated(User actualUser, Album album)
        {
            InitializeComponent();
            this.actualUser = actualUser;
            this.album = album;
            LoadAlbumPictures();
            usernameLblAlbum.Text = actualUser.Username;
            albumNameLbl.Text = album.Name;
        }

        private void LoadAlbumPictures()
        {
            foreach(Photo photo in album.PhotoList)
            {
                PictureBox image = new PictureBox();
                image.Size = new System.Drawing.Size(75, 75);
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.ImageLocation = photo.ElPath;
                image.Tag = "no";
                albumPanel.Controls.Add(image);
            }
        }

        private void EditAlbumBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < albumPanel.Controls.Count; i++)
            {
                albumPanel.Controls[i].Controls.Add(CreateDeleteButton());
                if (albumPanel.Controls[i].Tag.Equals("si"))
                {
                    albumPanel.Controls.Remove(albumPanel.Controls[i]);
                }
            }
        }

        private void commentBtn_Click(object sender, EventArgs e)
        {
            CreateComment comment = new CreateComment(actualUser, album);
            comment.AddListenerAlbum(PostCreateCommentAlbum);
            commentPanel.Controls.Add(comment);
            commentBtn.Enabled = false;
        }
        public void PostCreateCommentAlbum(CommentCreated newComment)
        {
            commentPanel.Controls.Add(newComment);
            commentBtn.Enabled = true;
        }

        private void likeBtn_Click(object sender, EventArgs e)
        {
            if (likeBtn.Text == "Me Gusta")
            {
                Reaction reaction = new Reaction(likeBtn.Text, actualUser);
                likeBtn.Text = "Quitar";
                likeBtn.BackColor = Color.White;
                likeBtn.ForeColor = Color.Maroon;
                album.Reaction.Add(reaction);
                likeCount.Text = Convert.ToString(CountLikes());
            }
            else
            {
                likeBtn.Text = "Me Gusta";
                Reaction reaction = album.GetReaction(likeBtn.Text, actualUser);
                likeBtn.BackColor = Color.Maroon;
                likeBtn.ForeColor = Color.White;
                album.Reaction.Remove(reaction);
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
                album.Reaction.Add(reaction);
                congratsCount.Text = Convert.ToString(CountCongrats());
            }
            else
            {
                congratsBtn.Text = "Felicitaciones";
                Reaction reaction = album.GetReaction(congratsBtn.Text, actualUser);
                congratsBtn.BackColor = Color.Maroon;
                congratsBtn.ForeColor = Color.White;
                album.Reaction.Remove(reaction);
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
                album.Reaction.Add(reaction);
                loveCount.Text = Convert.ToString(CountLoves());
            }
            else
            {
                loveBtn.Text = "Me Encanta";
                Reaction reaction = album.GetReaction(loveBtn.Text, actualUser);
                loveBtn.BackColor = Color.Maroon;
                loveBtn.ForeColor = Color.White;
                album.Reaction.Remove(reaction);
                loveCount.Text = Convert.ToString(CountLoves());
            }
        }
        private int CountLikes()
        {
            int count = 0;
            foreach (Reaction reaction in album.Reaction)
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
            foreach (Reaction reaction in album.Reaction)
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
            foreach (Reaction reaction in album.Reaction)
            {
                if (reaction.ReactionName.Equals("Me Encanta"))
                {
                    count++;
                }
            }
            return count;
        }
        private Button CreateDeleteButton()
        {
            Button deleteButton = new Button();
            deleteButton.Text = "X";
            deleteButton.Size = new System.Drawing.Size(25, 25);
            deleteButton.BackColor = Color.Maroon;
            deleteButton.ForeColor = Color.White;
            deleteButton.FlatStyle = FlatStyle.Flat;
            //deleteButton.Click += new EventHandler();
            return deleteButton;
        }
        public void HideEditBtn()
        {
            editAlbumBtn.Hide();
        }
        public string UsernameUserAlbum()
        {
            return usernameLblAlbum.Text;
        }
    }
}
