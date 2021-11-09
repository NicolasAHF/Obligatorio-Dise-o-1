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
    public partial class MarketPlace : UserControl
    {
        private User actualUser;
        public MarketPlace(User actualUser)
        {
            InitializeComponent();
            this.actualUser = actualUser;
            CheckIfAdmin();
        }

        private void CheckIfAdmin()
        {
            if(actualUser.Admin == true)
            {
                createGameBtn.Show();
            }
        }

        private void PostCreateGame(GameCreated game)
        {
            gamesPanel.Controls.Add(game);
        }

        private void createGameBtn_Click(object sender, EventArgs e)
        {
            crateGamePanel.Controls.Clear();
            CreateGame game = new CreateGame(actualUser);
            game.AddListener(PostCreateGame);
            crateGamePanel.Controls.Add(game);
        }
    }
}
