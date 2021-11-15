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
                if(albumPanel.Controls[i].Tag.Equals("si"))
                {
                    albumPanel.Controls.Remove(albumPanel.Controls[i]);
                }
            }
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
