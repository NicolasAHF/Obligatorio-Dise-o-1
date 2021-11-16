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
        private User actualUser;
        public CommentCreated(Comment comment, User actualUser)
        {
            InitializeComponent();
            this.comment = comment;
            this.actualUser = actualUser;
            this.usernameLbl.Text = comment.User.Username;
            this.commentBody.Text = comment.ElComment;
        }
        public void PostCreateCommentInComment(CommentCreated newComment)
        {
            commentPanel.Controls.Add(newComment);
            commentBtn.Enabled = true;
        }

        private void commentBtn_Click(object sender, EventArgs e)
        {
            CreateComment newComment = new CreateComment(actualUser, comment);
            newComment.AddListenerComment(PostCreateCommentInComment);
            commentPanel.Controls.Add(newComment);
            commentBtn.Enabled = false;
        }
    }
}
