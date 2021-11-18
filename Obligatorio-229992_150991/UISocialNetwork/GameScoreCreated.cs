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
    public partial class GameScoreCreated : UserControl
    {
        private GameScore gameScore;
        private Game game;
        public GameScoreCreated(GameScore gameScore, Game game)
        {
            InitializeComponent();
            this.game = game;
            this.gameScore = gameScore;
            this.score.Text = gameScore.Score.ToString();
            this.NameGame.Text = game.Name;
            this.PlayerName.Text = gameScore.Name;
        }
    }
}
