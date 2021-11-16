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
    public partial class CommentCreated : UserControl
    {
        private Comment comment;
        public CommentCreated(Comment comment)
        {
            InitializeComponent();
            this.comment = comment;
            this.usernameLbl.Text = comment.User.Username;
            this.commentBody.Text = comment.ElComment;
        }
    }
}
