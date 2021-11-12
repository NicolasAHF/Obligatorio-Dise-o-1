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
    public partial class StatusCreated : UserControl
    {
        private User actualUser;
        public StatusCreated(User actualUser)
        {
            InitializeComponent();
            this.actualUser = actualUser;
            usernameLbl.Text = actualUser.Username;
            statusUpdateLbl.Text = actualUser.Status;
        }
    }
}
