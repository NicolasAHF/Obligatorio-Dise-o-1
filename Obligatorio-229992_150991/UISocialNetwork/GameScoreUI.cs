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
    public delegate void PostGame(Game game);
    public partial class GameScoreUI : UserControl
    {
        private GameScore gameScore;
        private User actualUser;
        private Game game;
        private event PostGame PostGameScoreEvent;
        public GameScoreUI(User actualUser, Game game)
        {
            InitializeComponent();
            this.actualUser = actualUser;
            gameScore = new GameScore();
            this.game = game;
        }

        public void AddListener(PostGame del)
        {
            PostGameScoreEvent += del;
        }

        private void saveScore_Click(object sender, EventArgs e)
        {
            gameScore.Name = actualUser.Username;
            gameScore.Score = Convert.ToInt32(scroreTxtBox.Text);
            PostGameScoreEvent(game);
        }
    }
}
