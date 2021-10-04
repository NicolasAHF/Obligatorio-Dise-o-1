using System;

namespace SocialNetwork
{
    public class Album
    {
        private string _name;
        const int MIN_LENGTH_FOR_VALID_NAME = 5;
        const int MAX_CANT_FOR_VALID_LOAD_PHOTO = 10;
        const int MAX_SIZE_FOR_VALID_LOAD_PHOTO = 5; //MB

        public string Name
        {
            get { return _name; }
            private set => SetName(value);
        }

        public Album(string elNombre)
        {
            this.Name = elNombre;
        }


        public void SetName(string elNombre)
        {
            if (EmptyString(elNombre) || !ValidName(elNombre))
            {
                throw new InvalidOperationException("Nombre no valido");
            }
            else
            {
                this._name = elNombre;
            }
        }


        private bool ValidName(string elNombre)
        {
            return elNombre.Length >= MIN_LENGTH_FOR_VALID_NAME;
        }

        private bool EmptyString(string value)
        {
            return value.Length.Equals(0);
        }
    }
}

