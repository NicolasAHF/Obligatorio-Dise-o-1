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
    public partial class GameCreated : UserControl
    {
        private User actualUser;
        private Game game;
        private GamesRepository games;
        public GameCreated(Game game, GamesRepository games, User actualUser)
        {
            InitializeComponent();
            this.coverPBox.ImageLocation = game.Cover.ElPath;
            this.nameLbl.Text = game.Name;
            this.categoryLbl.Text = game.Category;
            this.games = games;
            this.actualUser = actualUser;
            this.game = game;
            CheckIfPlayed();
        }

        private void playGameBtn_Click(object sender, EventArgs e)
        {
            GameScoreUI gameScore = new GameScoreUI(actualUser, game);
            gameScore.AddListener(PostGame);
            gamePanel.Controls.Clear();
            gamePanel.Controls.Add(gameScore);
        }

        private void PostGame(Game game)
        {
            gamePanel.Controls.Clear();
            game.Played = 1;
            games.UpdatePlayed(game);
            CheckIfPlayed();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            games.Delete(nameLbl.Text);
        }
        private void CheckIfPlayed()
        {
            if(game != null)
            {
                if (game.Played != 0)
                {
                    deleteBtn.Hide();
                }
                else
                {
                    deleteBtn.Show();
                }
            }
           
        }
    }
}
