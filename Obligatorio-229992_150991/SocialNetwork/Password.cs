using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class Password
    {
        private string _password;

        const int MIN_LENGTH_FOR_VALID_PASSWORD = 8;

        public string LaPassword
        {
            get { return _password; }
            private set => SetPassword(value);
        }

        //Constructor
        public Password(string password)
        {
            //this.LaPassword = password;
            this.SetPassword(password);
        }



        public void SetPassword(string password)
        {
            if (EmptyString(password) || !ValidLenghtPassword(password))
            {
                throw new InvalidOperationException("Password no valida");
           }
           else
           {
                this._password = password.GetHashCode().ToString();
 
            }
        }

        public bool ValidLenghtPassword(string password)
        {
            return password.Length >= MIN_LENGTH_FOR_VALID_PASSWORD;
        }


        private bool StringSpecialLetters(string str)
        {
            return Regex.IsMatch(str, @"^[\p{L}]+$");
        }

        private bool EmptyString(string value)
        {
            return value.Length.Equals(0);
        }

        private bool Equals(Password pass)
        {
            return this.LaPassword.Equals(pass.LaPassword);
        }

        public bool CheckPassword(Password password)
        {
            
            if (!this.Equals(password))
            {
                throw new InvalidOperationException("Password incorrecta");
            }
            else
            {
                return true;

            }
        }



    }
}
