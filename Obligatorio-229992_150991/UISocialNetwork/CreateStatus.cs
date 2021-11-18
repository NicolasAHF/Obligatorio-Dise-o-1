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
        private StatusRepository statusBD;
        private CommentRepository comments;
        private event PostCreateStatus PostCreateStatusEvent;
        public CreateStatus(User actualUser, UserRepository users, StatusRepository statusBD, CommentRepository comments)
        {
            InitializeComponent();
            this.actualUser = actualUser;
            this.users = users;
            this.statusBD = statusBD;
            this.comments = comments;
        }

        public void AddListener(PostCreateStatus del)
        {
            PostCreateStatusEvent += del;
        }

        private void saveStatusbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Status newStatus = new Status(statusTxtBox.Text);
                actualUser.Status = newStatus;
                users.UpdateStatus(newStatus, actualUser);
                StatusCreated status = new StatusCreated(actualUser, newStatus, statusBD, comments);
                PostCreateStatusEvent(status);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
