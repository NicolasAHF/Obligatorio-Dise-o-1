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
    public delegate void PostCreateStatus(StatusCreated status);
    public partial class CreateStatus : UserControl
    {
        private User actualUser;
        private UserRepository users;
        private event PostCreateStatus PostCreateStatusEvent;
        public CreateStatus(User actualUser, UserRepository users)
        {
            InitializeComponent();
            this.actualUser = actualUser;
            this.users = users;
        }

        public void AddListener(PostCreateStatus del)
        {
            PostCreateStatusEvent += del;
        }

        private void saveStatusbtn_Click(object sender, EventArgs e)
        {
            try
            {
                actualUser.Status.ElStatus = statusTxtBox.Text;
                users.UpdateStatus(statusTxtBox.Text, actualUser);
                StatusCreated status = new StatusCreated(actualUser);
                PostCreateStatusEvent(status);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
