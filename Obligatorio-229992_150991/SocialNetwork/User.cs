using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class User
    {
        private string _username;
        const int MIN_LENGTH_FOR_VALID_NAME = 5;
        public string Username
        { 
            get { return _username; }
            private set => ChangeName(value); 
        }
        public User(string username)
        {
            this.Username = username;
        }
        public void ChangeName(string username)
        {
            if (!ValidUsername(username))
            {
                throw new InvalidOperationException("Largo del nombre de usuario demasiado corto");
            }
            else
            {
                this._username = username;
            }
        }
        private bool ValidUsername(string username)
        {
            return username.Length >= MIN_LENGTH_FOR_VALID_NAME;
        }
    }
}
