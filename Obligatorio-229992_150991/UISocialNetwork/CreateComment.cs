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
    public delegate void PostCreateCommentListening(CommentCreated newComment);
    public delegate void PostCreateCommentStatus(CommentCreated newComment);
    public delegate void PostCreateCommentInComment(CommentCreated newComment);
    public partial class CreateComment : UserControl
    {
        private User actualUser;
        private Contents actualContent;
        private event PostCreateCommentAlbum PostCreateCommentAlbumEvent;
        private event PostCreateCommentListening PostCreateCommentListeningEvent;
        private event PostCreateCommentStatus PostCreateCommentStatusEvent;
        private event PostCreateCommentInComment PostCreateCommentEvent;
        public CreateComment(User actualUser, Contents actualContent)
        {
            InitializeComponent();
            this.actualUser = actualUser;
            this.actualContent = actualContent;
        }
        public void AddListenerAlbum(PostCreateCommentAlbum del)
        {
            PostCreateCommentAlbumEvent += del;
        }
        public void AddListenerListening(PostCreateCommentListening del)
        {
            PostCreateCommentListeningEvent += del;
        }
        public void AddListenerStatus(PostCreateCommentStatus del)
        {
            PostCreateCommentStatusEvent += del;
        }
        public void AddListenerComment(PostCreateCommentInComment del)
        {
            PostCreateCommentEvent += del;
        }
        private void saveCommenBtn_Click(object sender, EventArgs e)
        {
            Comment comment = new Comment(commentString.Text, actualUser);
            comment.DateComment = DateTime.Now;
            CommentCreated newComment = new CommentCreated(comment, actualUser);
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
                PostCreateCommentAlbumEvent(newComment);
            }
            else if(typeof(ListeningNow).IsAssignableFrom(actualContent.GetType())){
                PostCreateCommentListeningEvent(newComment);
            }else if (typeof(Status).IsAssignableFrom(actualContent.GetType()))
            {
                PostCreateCommentStatusEvent(newComment);
            }
            else
            {
                PostCreateCommentEvent(newComment);
            }
        }
    }
}
