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

namespace UISocialNetwork
{
    public delegate void PostCreateGame(GameCreated game);
    public partial class CreateGame : UserControl
    {
        private DirectoryGame games;
        private Photo cover;
        private event PostCreateGame PostCreateGameEvent;
        private User actualUser;
        public CreateGame(User actualUser)
        {
            InitializeComponent();
            games = new DirectoryGame();
            this.actualUser = actualUser;
        }

        public void AddListener(PostCreateGame del)
        {
            PostCreateGameEvent += del;
        }

        private void uploadCover_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Imagenes JPG,PNG,JPEG|*.jpeg;*.jpg;*.png";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FileInfo fileInfoToSize = new FileInfo(dialog.FileName);
                    Photo cover = new Photo(dialog.FileName, (int)fileInfoToSize.Length / 1000);
                    this.cover = cover;
                    imageLocation = dialog.FileName;
                    coverPBox.Image = new Bitmap(imageLocation);
                    SaveImage(imageLocation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveImage(string imageLocation)
        {

            File.Copy(imageLocation, Path.Combine(@"C:\", Path.GetFileName(cover.ElPath)));
        }

        private void saveGame_Click(object sender, EventArgs e)
        {
            try
            {
                Game game = new Game(nameTxtBox.Text, categoryTxrBox.Text, cover);
                games.AddGame(game, actualUser);
                GameCreated gameCreated = new GameCreated(game);
                PostCreateGameEvent(gameCreated);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
