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
    public delegate void PostCreateStatus(StatusCreated status);
    public partial class CreateStatus : UserControl
    {
        private User actualUser;
        private event PostCreateStatus PostCreateStatusEvent;
        public CreateStatus(User actualUser)
        {
            InitializeComponent();
            this.actualUser = actualUser;
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
                StatusCreated status = new StatusCreated(actualUser);
                PostCreateStatusEvent(status);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
