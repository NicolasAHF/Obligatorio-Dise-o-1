using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class Comment : Contents
    {
        private string _comment;
        private User _user;
        private DateTime _dateComment;


        const int MIN_LENGTH_FOR_VALID_COMMENT = 5;
        const int MAX_LENGTH_FOR_VALID_COMMENT = 250;

        public int Id { get; set; }
        public string TheComment
        {
            get { return _comment; }
            set => SetComment(value);
        }

        public DateTime DateComment
        {
            get { return _dateComment; }
            set => SetDateComment();
        }
        public User User
        {
            get { return _user; }
            set => SetUser(value);
        }

        public Comment()
        {

        }

        public Comment(string comment, User user)
        {
            this.TheComment = comment;
            this.User = user;
            this.SetDateComment();
        }

        public void SetComment(String comment)
        {
            ValidMinLengthComment(comment);
            ValidMaxLengthComment(comment);
            this._comment = comment;
        }

        public void SetUser(User user)
        {
            if (user==null)
            {
                throw new InvalidOperationException("El usuario no puede ser Nullo");
            }
            else
            {
                this._user = user;
            }   
        }

        public void SetDateComment()
        {
                this._dateComment = DateTime.Now; ;
        }

        private void ValidMinLengthComment(string comment)
        {
            if (comment.Length < MIN_LENGTH_FOR_VALID_COMMENT)
            {
                throw new InvalidOperationException("El comentario no alcanza el largo minimo");
            }
        }
        private void ValidMaxLengthComment(string comment)
        {
            if (comment.Length > MAX_LENGTH_FOR_VALID_COMMENT)
            {
                throw new InvalidOperationException("El comentario supera el largo máximo");
            }
        }
    }
}
