using SocialNetwork;
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
using System.Data.Entity;
using SocialNetworkDB;

namespace UISocialNetwork
{
    public delegate void PostCreateAlbum(AlbumCreated album);
    public partial class CreateAlbum : UserControl
    {
        private Album album = new Album("Default");
        private User actualUser;
        private AlbumRepository albums;
        private event PostCreateAlbum PostCreateAlbumEvent;
        public CreateAlbum(User actualUser, AlbumRepository albums)
        {
            InitializeComponent();
            this.actualUser = actualUser;
            this.albums = albums;
        }

        public void AddListener(PostCreateAlbum del)
        {
            PostCreateAlbumEvent += del;
        }

        private void AddPhotoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string imageLocation = "";
                OpenFileDialog dialog = new OpenFileDialog();

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    PictureBox image = new PictureBox();
                    image.Size = new System.Drawing.Size(75, 75);
                    image.SizeMode = PictureBoxSizeMode.StretchImage;
                    FileInfo fileNameInfo = new FileInfo(dialog.FileName);
                    Photo newPhoto = new Photo(dialog.FileName, fileNameInfo.Length);
                    imageLocation = dialog.FileName;
                    image.ImageLocation = imageLocation;
                    album.addPhoto(newPhoto);
                    AlbumPanel.Controls.Add(image);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void SaveAlbumBtn_Click(object sender, EventArgs e)
        {
            try
            {
                album.SetName(albumNameTxtBox.Text);
                actualUser.Albums.Add(album);
                AlbumCreated albumAdded = new AlbumCreated(actualUser, album);
                albums.Add(album);
                actualUser.Albums.Add(album);
                
                PostCreateAlbumEvent(albumAdded);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
