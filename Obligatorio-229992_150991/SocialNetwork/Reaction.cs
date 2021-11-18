using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class Reaction
    {
        private string _reactionName;
        private User _user;

        public int Id { get; set; }
        public string ReactionName 
        {
            get { return _reactionName; }
            private set => SetReactionName(value);
        }

        public User User
        {
            get { return _user; }
            private set => SetUser(value);
        }

        public Reaction()
        {

        }

        public Reaction(string reaction, User user)
        {
            this.SetReactionName(reaction);
            this.SetUser(user);
        }

        public void SetReactionName(string reactionName)
        {
            if (EmptyString(reactionName))
            {
                throw new InvalidOperationException("Nombre de la reaccion no puede ser vacio");
            }
            else
            {
                this._reactionName = reactionName;
            }
        }

        public void SetUser(User user)
        {
            if (user == null)
            {
                throw new InvalidOperationException("El usuario no puede ser Nullo");
            }
            else
            {
                this._user = user;
            }
        }

        private bool EmptyString(string value)
        {
            return value.Length.Equals(0);
        }

    }
}
