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
    public partial class GameCreated : UserControl
    {
        private User actualUser;
        private Game game;
        public GameCreated(Game game)
        {
            InitializeComponent();
            this.coverPBox.ImageLocation = game.Cover.ElPath;
            this.nameLbl.Text = game.Name;
            this.categoryLbl.Text = game.Category;
        }

        private void playGameBtn_Click(object sender, EventArgs e)
        {
            GameScoreUI gameScore = new GameScoreUI(actualUser);
            gameScore.AddListener(PostGame);
            gamePanel.Controls.Clear();
            gamePanel.Controls.Add(gameScore);
        }

        private void PostGame()
        {
            gamePanel.Controls.Clear();
        }
    }
}
