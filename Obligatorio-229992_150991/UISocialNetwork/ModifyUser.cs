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
    public partial class ModifyUser : UserControl
    {
        private User user;
        private DirectoryUser users;
        public ModifyUser(User user, DirectoryUser users)
        {
            InitializeComponent();
            this.user = user;
            this.users = users;
        }

        private void uploadModifyBtn_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    avatarModifyBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveModifyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception exp)
            {

            }
        }
    }
}
