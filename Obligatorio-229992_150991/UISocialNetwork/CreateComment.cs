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
    public delegate void PostCreateCommentAlbum(CommentCreated newComment, Comment comment);
    public delegate void PostCreateCommentListening(CommentCreated newComment, Comment comment);
    public delegate void PostCreateCommentStatus(CommentCreated newComment, Comment comment);
    public delegate void PostCreateCommentInComment(CommentCreated newComment, Comment comment);
    public partial class CreateComment : UserControl
    {
        private User actualUser;
        private Contents actualContent;
        private CommentRepository comments;
        private event PostCreateCommentAlbum PostCreateCommentAlbumEvent;
        private event PostCreateCommentListening PostCreateCommentListeningEvent;
        private event PostCreateCommentStatus PostCreateCommentStatusEvent;
        private event PostCreateCommentInComment PostCreateCommentEvent;
        public CreateComment(User actualUser, Contents actualContent, CommentRepository comments)
        {
            InitializeComponent();
            this.actualUser = actualUser;
            this.actualContent = actualContent;
            this.comments = comments;
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
            try
            {
                Comment comment = new Comment(commentString.Text, actualUser);
                comment.DateComment = DateTime.Now;
                CommentCreated newComment = new CommentCreated(comment, actualUser, comments);
                actualContent.Comments.Add(comment);
                this.Hide();
                CheckContentType(newComment, comment);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void CheckContentType(CommentCreated newComment, Comment comment)
        {
            if(typeof(Album).IsAssignableFrom(actualContent.GetType()))
            {
                PostCreateCommentAlbumEvent(newComment, comment);
            }
            else if(typeof(ListeningNow).IsAssignableFrom(actualContent.GetType())){
                PostCreateCommentListeningEvent(newComment, comment);
            }else if (typeof(Status).IsAssignableFrom(actualContent.GetType()))
            {
                PostCreateCommentStatusEvent(newComment, comment);
            }
            else
            {
                PostCreateCommentEvent(newComment, comment);
            }
        }
    }
}
