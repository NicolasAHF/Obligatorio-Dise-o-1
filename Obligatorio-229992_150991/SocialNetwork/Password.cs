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
        private string _hashpassword;

        const int MIN_LENGTH_FOR_VALID_PASSWORD = 8;
       
        public int Id { get; set; }
        public string Hashpassword
        {
            get { return _hashpassword; }
            private set => SetPassword(value);
        }


        public Password()
        {

        }
        public Password(string password)
        {
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
                this._hashpassword = password.GetHashCode().ToString();
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
            return this.Hashpassword.Equals(pass.Hashpassword);
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

        public override bool Equals(object obj)
        {
            Password passObj = obj as Password;

            if (passObj == null || this.GetType() != passObj.GetType())
            {
                return false;
            }

            return this.Id == passObj.Id ? true : false;
        }
    }
}