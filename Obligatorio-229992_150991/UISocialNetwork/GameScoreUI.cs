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
    public delegate void PostGame();
    public partial class GameScoreUI : UserControl
    {
        private GameScore game = new GameScore();
        private User actualUser;
        private event PostGame PostGameScoreEvent;
        public GameScoreUI(User actualUser)
        {
            InitializeComponent();
            this.actualUser = actualUser;
        }

        public void AddListener(PostGame del)
        {
            PostGameScoreEvent += del;
        }

        private void saveScore_Click(object sender, EventArgs e)
        {
            game.SetName(actualUser.Username);
            game.SetScore(Convert.ToInt32(scroreTxtBox.Text));
            PostGameScoreEvent();
        }
    }
}
