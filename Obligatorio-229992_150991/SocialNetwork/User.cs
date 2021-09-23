using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class User
    {
        private string _username;
        private string _name;
        private string _lastname;
        private DateTime _dateofbirth;
        private Direction _direction;
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
        public DateTime DateOfBirth 
        {
            get { return _dateofbirth; }
            private set => SetDateOfBirth(value);
        }

        public Direction Direction 
        {
            get { return _direction; }
            private set => SetDirection(value);
        }

        public User(string username, string name, string lastname, DateTime birthday, Direction direction)
        {
            this.Username = username;
            this.Name = name;
            this.Lastname = lastname;
            this.DateOfBirth = birthday;
            this.Direction = direction;
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
            if (EmptyString(name) || !StringOnlyLetters(name))
            {
                throw new InvalidOperationException("Nombre no valido");
            }
            else
            {
                this._name = name;
            }
        }

        public void SetLastname(string lastname)
        {
            if (EmptyString(lastname) || !StringOnlyLetters(lastname))
            {
                throw new InvalidOperationException("Apellido no valido");
            }
            else
            {
                this._lastname = lastname;
            }
        }

        public void SetDateOfBirth(DateTime dateofbirth)
        {
            if (!BirthdayAfter1940(dateofbirth) || !BirthdayBeforeActualDate(dateofbirth) || dateofbirth == null)
            {
                throw new InvalidOperationException("Fecha de nacimiento no valida");
            }
            else
            {
                this._dateofbirth = dateofbirth;
            }
        }

        public void SetDirection(Direction direction)
        {
            if (direction == null)
            {
                throw new InvalidOperationException("Direccion no puede ser vacia");
            }
            else
            {
                this._direction = direction;
            }
        }

        public bool IsEqual(User user)
        {
            return this.Username.ToUpper() == user.Username.ToUpper();
        }

        private bool ValidUsername(string username)
        {
            return username.Length >= MIN_LENGTH_FOR_VALID_NAME;
        }

        private bool EmptyString(string value)
        {
            return value.Length.Equals(0);
        }

        private bool StringOnlyLetters(string str)
        {
           return Regex.IsMatch(str, @"^[\p{L}]+$");
        }

        private bool BirthdayAfter1940(DateTime birthday)
        {
            DateTime dateLimit = new DateTime(1940, 12, 31);
            int result = DateTime.Compare(birthday, dateLimit);
            return result > 0;
        }

        private bool BirthdayBeforeActualDate(DateTime birthday)
        {
            DateTime dateLimit = DateTime.Now;
            int result = DateTime.Compare(birthday, dateLimit);
            return result < 0;
        }


    }
}
