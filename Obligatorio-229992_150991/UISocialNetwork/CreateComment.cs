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
    public delegate void PostCreateCommentAlbum(CommentCreated newComment);
    public partial class CreateComment : UserControl
    {
        private User actualUser;
        private Contents actualContent;
        private event PostCreateCommentAlbum PostCreateCommentEvent;
        public CreateComment(User actualUser, Contents actualContent)
        {
            InitializeComponent();
            this.actualUser = actualUser;
            this.actualContent = actualContent;
        }
        public void AddListenerAlbum(PostCreateCommentAlbum del)
        {
            PostCreateCommentEvent += del;
        }
        public void AddListenerListening(PostCreateCommentAlbum del)
        {
            PostCreateCommentEvent += del;
        }
        private void saveCommenBtn_Click(object sender, EventArgs e)
        {
            Comment comment = new Comment(commentString.Text, actualUser);
            comment.DateComment = DateTime.Now;
            CommentCreated newComment = new CommentCreated(comment);
            actualContent.Comment.Add(comment);
            this.Hide();
            CheckContentType(newComment);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void CheckContentType(CommentCreated newComment)
        {
            if(typeof(Album).IsAssignableFrom(actualContent.GetType()))
            {
                PostCreateCommentEvent(newComment);
            }
        }
    }
}
