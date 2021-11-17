using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public abstract class Contents

    {

        private List<Reaction> _reactionList = new List<Reaction>();
        private List<Comment> _commentList = new List<Comment>();

        public Contents()
        {

        }

        public List<Reaction> Reaction
        {
            get { return _reactionList; }
            set { _reactionList = value; }
        }

        public List<Comment> Comment
        {
            get { return _commentList; }
            set { _commentList = value; }
        }
        public Reaction GetReaction(string reactionName, User user)
        {
            foreach(Reaction reactions in Reaction)
            {
                if(reactions.User.Equals(user) && reactions.ReactionName.Equals(reactionName))
                {
                    return reactions;
                }
            }
            return null;
        }

    }
}
