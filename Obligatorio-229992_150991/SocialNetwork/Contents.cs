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
        public int Id { get; set; }

        public ICollection<Reaction> Reactions
        {
            get { return _reactionList; }
            set { _reactionList = new List<Reaction>(); }
        }

        public ICollection<Comment> Comments
        {
            get { return _commentList; }
            set { _commentList = new List<Comment>(); }
        }
        public Reaction GetReaction(string reactionName, User user)
        {
            foreach(Reaction reactions in Reactions)
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
