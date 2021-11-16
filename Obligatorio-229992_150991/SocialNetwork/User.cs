using System;
using System.Collections.Generic;
using System.IO;
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
        private Status _status;
        private Password _password;
        private DateTime _dateofbirth;
        private Direction _direction;
        private Photo _avatar;
        private bool _admin = false;
        private List<User> _followingList = new List<User>();
        private List<Album> _albumList = new List<Album>();
        private List<GameScore> _gameScoreList = new List<GameScore>();
        private ListeningNow _listeningNow = new ListeningNow();

        const int MIN_LENGTH_FOR_VALID_NAME = 5;


        public virtual ICollection<User> Users { get; set; }


        public int Id { get; set; }
        public string Name
        {
            get { return _name; }
            set => SetName(value);
        }
        public string Username
        {
            get { return _username; }
            set => SetUsername(value);
        }
        public string Lastname
        {
            get { return _lastname; }
            set => SetLastname(value);
        }
        public Status Status
        {
            get { return _status; }
            set => SetStatus(value);
        }

        public Password Password
        {
            get { return _password; }
            set => SetPassword(value);
        }

        public DateTime DateOfBirth 
        {
            get { return _dateofbirth; }
            set => SetDateOfBirth(value);
        }

        public Direction Direction 
        {
            get { return _direction; }
            set => _direction = value;
        }
        public Photo Avatar
        {
            get { return _avatar; }
            set => SetAvatar(value);
        }
        public bool Admin
        {
            get { return _admin; }
            set => SetAdmin(value);
        }

        public ICollection<User> Following
        {
            get { return _followingList; }
            set { _followingList = new List<User>(); }
        }

        public List<Album> Albums
        {
            get { return _albumList; }
            set { _albumList = value; }
        }

        public Password GetPassword()
        {
            return this._password;
        }

        public ListeningNow Listening
        {
            get{ return _listeningNow; }
            set { _listeningNow = value; }
        }

        public User()
        {
            this.Users = new HashSet<User>();
        }
        public User(string username, Password password, string name, string lastname, DateTime birthday, Direction direction, Photo avatar, bool Admin)
        {
            this.Username = username;
            this.Name = name;
            this.Lastname = lastname;
            this.DateOfBirth = birthday;
            this.Direction = direction;
            this.SetPassword(password);
            this.Avatar = avatar;
            this.Admin = Admin;
            this._followingList = new List<User>();
            this._albumList = new List<Album>();
            this._gameScoreList = new List<GameScore>();
            this._listeningNow = new ListeningNow();

        }
        public void SetStatus(Status status)
        {
            this._status = status;
        }

        private void SetPassword (Password password)
        {
            this._password = password;
        }

        public void ChangePassword(User elUsuario, Password userEnteredActualPassword, Password pasNueva)
        {

            if (this.GetPassword().Hashpassword != userEnteredActualPassword.Hashpassword)
            {
                throw new InvalidOperationException("La Password ingresada no es correcta");
            }
            else
            {
                this.SetPassword(pasNueva);

            }
        }

        public void AddGameScore(string gameName, int score)
        {
            GameScore newGameScore = new GameScore(gameName, score);
            _gameScoreList.Add(newGameScore);
         }

        public void SetAdmin(bool admin)
        {
            this._admin = admin;
        }

        public void SetUsername(string username)
        {
            if (!ValidUsername(username))
            {
                throw new InvalidOperationException("Nombre de usuario demasiado corto");
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

        public void SetDirection(string Country, string City, string Sreet)
        {
            this._direction.SetDirection(Country, City, Sreet);
        }

        public void SetAvatar(Photo avatar)
        {
            this._avatar = avatar;
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

        public override string ToString()
        {
            return this.Username;
        }

        public override bool Equals(object obj)
        {
            User userObj = obj as User;

            if (userObj == null || this.GetType() != userObj.GetType())
            {
                return false;
            }

            return Id == userObj.Id ? true : false;
        }
    }
}

