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
    public delegate void PostCreate(ListeningNowCreated listening);
    public partial class CreateListeningNow : UserControl
    {
        private User actualUser;
        private event PostCreate PostCreateEvent;
        public CreateListeningNow(User actualUser)
        {
            InitializeComponent();
            this.actualUser = actualUser;

        }
        public void AddListener(PostCreate del)
        {
            PostCreateEvent += del;
        }

        private void saveListeningNowBtn_Click(object sender, EventArgs e)
        {
            ListeningNow actualListening = new ListeningNow(songTxtBox.Text, artistTxtBox.Text, albumTxtBox.Text);
            actualUser.Listening = actualListening;
            ListeningNowCreated listening = new ListeningNowCreated(actualUser, actualListening);
            PostCreateEvent(listening);
        }
    }
}
