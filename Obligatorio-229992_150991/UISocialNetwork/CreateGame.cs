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
    public delegate void PostCreateGame(GameCreated game);
    public partial class CreateGame : UserControl
    {
        private GamesRepository games;
        private Photo cover;
        private User actualUser;
        private ScoresRepository scores;
        private event PostCreateGame PostCreateGameEvent;
        public CreateGame(GamesRepository games, User actualUser, ScoresRepository scores)
        {
            InitializeComponent();
            this.games = games;
            this.actualUser = actualUser;
            this.scores = scores;
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
                games.Add(game);
                GameCreated gameCreated = new GameCreated(game, games, actualUser, scores);

                PostCreateGameEvent(gameCreated);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
