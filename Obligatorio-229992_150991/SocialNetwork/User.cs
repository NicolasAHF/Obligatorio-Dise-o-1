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
        private string _name;
        private string _lastname;
        const int MIN_LENGTH_FOR_VALID_NAME = 5;

        public string Name 
        {
            get { return _name; }
            private set => SetName(value);
        }
        public string Username
        { 
            get { return _username; }
            private set => SetUsername(value); 
        }
        public string Lastname 
        {
            get { return _lastname; }
            private set => SetLastname(value);
        }
        public User(string username, string name, string lastname)
        {
            this.Username = username;
            this.Name = name;
            this.Lastname = lastname;
        }
        
        public void SetUsername(string username)
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

        public void SetName(string name)
        {
            if (name.Length == 0)
            {
                throw new InvalidOperationException("Largo del nombre no puede ser vacio");
            }
            else
            {
                this._name = name;
            }
        }

        public void SetLastname(string lastname)
        {
            if (lastname.Length == 0)
            {
                throw new InvalidOperationException("Largo del apellido no puede ser vacio");
            }
            else
            {
                this._lastname = lastname;
            }
        }
        private bool ValidUsername(string username)
        {
            return username.Length >= MIN_LENGTH_FOR_VALID_NAME;
        }
    }
}
