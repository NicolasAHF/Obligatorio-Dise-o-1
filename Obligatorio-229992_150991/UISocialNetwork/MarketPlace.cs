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
    public partial class MarketPlace : UserControl
    {
        private User actualUser;
        private GamesRepository games;
        private ScoresRepository scores;
        public MarketPlace(User actualUser, GamesRepository games, ScoresRepository scores)
        {
            InitializeComponent();
            this.actualUser = actualUser;
            this.games = games;
            this.scores = scores;
            CheckIfAdmin();
            ShowGames();
        }

        private void CheckIfAdmin()
        {
            if(actualUser.Admin == true)
            {
                createGameBtn.Show();
            }
        }
        private void ShowGames()
        {
            List<Game> gamesCreated = games.GetAll().ToList();
            foreach(Game game in gamesCreated)
            {
                GameCreated CreatedGame = new GameCreated(game, games, actualUser, scores);
                gamesPanel.Controls.Add(CreatedGame);
            }
        }

        private void PostCreateGame(GameCreated game)
        {
            gamesPanel.Controls.Add(game);
            crateGamePanel.Controls.Clear();
            crateGamePanel.Hide();
        }

        private void createGameBtn_Click(object sender, EventArgs e)
        {
            crateGamePanel.Controls.Clear();
            crateGamePanel.Show();
            CreateGame game = new CreateGame(games, actualUser, scores);
            game.AddListener(PostCreateGame);
            crateGamePanel.Controls.Add(game);
        }
    }
}
