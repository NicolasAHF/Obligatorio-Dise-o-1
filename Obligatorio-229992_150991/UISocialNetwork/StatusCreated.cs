﻿using SocialNetwork;
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
    public partial class StatusCreated : UserControl
    {
        private User actualUser;
        private Status status;
        private StatusRepository statusDB;
        private CommentRepository comments;
        public StatusCreated(User actualUser, Status status, StatusRepository statusDB, CommentRepository comments)
        {
            InitializeComponent();
            this.actualUser = actualUser;
            this.status = status;
            usernameLbl.Text = actualUser.Username;
            statusUpdateLbl.Text = status.StatusBody;
            this.statusDB = statusDB;
            this.comments = comments;
        }
        public void PostCreateCommentStatus(CommentCreated newComment, Comment comment)
        {
            commentPanel.Controls.Add(newComment);
            commentBtn.Enabled = true;
            statusDB.AddComment(status, comment);
        }

        private void commentBtn_Click(object sender, EventArgs e)
        {
            CreateComment comment = new CreateComment(actualUser, actualUser.Status, comments);
            comment.AddListenerStatus(PostCreateCommentStatus);
            commentPanel.Controls.Add(comment);
            commentBtn.Enabled = false;
        }
        private void likeBtn_Click(object sender, EventArgs e)
        {
            if (likeBtn.Text == "Me Gusta")
            {
                Reaction reaction = new Reaction(likeBtn.Text, actualUser);
                likeBtn.Text = "Quitar";
                likeBtn.BackColor = Color.White;
                likeBtn.ForeColor = Color.Maroon;
                status.Reactions.Add(reaction);
                statusDB.AddReaction(status, reaction);
                likeCount.Text = Convert.ToString(CountLikes());
            }
            else
            {
                likeBtn.Text = "Me Gusta";
                Reaction reaction = status.GetReaction(likeBtn.Text, actualUser);
                likeBtn.BackColor = Color.Maroon;
                likeBtn.ForeColor = Color.White;
                status.Reactions.Remove(reaction);
                statusDB.RemoveReaction(status, reaction);
                likeCount.Text = Convert.ToString(CountLikes());
            }
        }

        private void congratsBtn_Click(object sender, EventArgs e)
        {
            if (congratsBtn.Text == "Felicitaciones")
            {
                Reaction reaction = new Reaction(congratsBtn.Text, actualUser);
                congratsBtn.Text = "Quitar";
                congratsBtn.BackColor = Color.White;
                congratsBtn.ForeColor = Color.Maroon;
                status.Reactions.Add(reaction);
                statusDB.AddReaction(status, reaction);
                congratsCount.Text = Convert.ToString(CountCongrats());
            }
            else
            {
                congratsBtn.Text = "Felicitaciones";
                Reaction reaction = status.GetReaction(congratsBtn.Text, actualUser);
                congratsBtn.BackColor = Color.Maroon;
                congratsBtn.ForeColor = Color.White;
                status.Reactions.Remove(reaction);
                statusDB.RemoveReaction(status, reaction);
                congratsCount.Text = Convert.ToString(CountCongrats());
            }
        }

        private void loveBtn_Click(object sender, EventArgs e)
        {
            if (loveBtn.Text == "Me Encanta")
            {
                Reaction reaction = new Reaction(loveBtn.Text, actualUser);
                loveBtn.Text = "Quitar";
                loveBtn.BackColor = Color.White;
                loveBtn.ForeColor = Color.Maroon;
                status.Reactions.Add(reaction);
                statusDB.AddReaction(status, reaction);
                loveCount.Text = Convert.ToString(CountLoves());
            }
            else
            {
                loveBtn.Text = "Me Encanta";
                Reaction reaction = status.GetReaction(loveBtn.Text, actualUser);
                loveBtn.BackColor = Color.Maroon;
                loveBtn.ForeColor = Color.White;
                status.Reactions.Remove(reaction);
                statusDB.RemoveReaction(status, reaction);
                loveCount.Text = Convert.ToString(CountLoves());
            }
        }
        private int CountLikes()
        {
            int count = 0;
            foreach (Reaction reaction in status.Reactions)
            {
                if (reaction.ReactionName.Equals("Me Gusta"))
                {
                    count++;
                }
            }
            return count;
        }
        private int CountCongrats()
        {
            int count = 0;
            foreach (Reaction reaction in status.Reactions)
            {
                if (reaction.ReactionName.Equals("Felicitaciones"))
                {
                    count++;
                }
            }
            return count;
        }
        private int CountLoves()
        {
            int count = 0;
            foreach (Reaction reaction in status.Reactions)
            {
                if (reaction.ReactionName.Equals("Me Encanta"))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
