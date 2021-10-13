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
    public partial class CreateUserControl : UserControl
    {
        DirectoryUser users;
        public CreateUserControl(DirectoryUser users)
        {
            InitializeComponent();
            this.users = users;
        }
    }
}
