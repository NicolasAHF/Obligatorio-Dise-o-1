using System;
using System.Collections;

namespace SocialNetwork
{
    public class Game
    {
        private string _name;
        private string _category;
        private Photo _cover;
        private int _played = 0;
        public int Id { get; set; }

        public string Name
        {
            get { return _name; }
            set => SetName(value);
        }

        public string Category
        {
            get { return _category; }
            set => SetCategory(value);
        }
        public Photo Cover
        {
            get { return _cover; }
            set => SetCover(value);
        }

        public int Played
        {
            get { return _played; }
            set => SetPlayed();
        }

        public Game()
        {

        }
        public Game(string name, string category, Photo cover)
        {
            this.SetName(name);
            this.SetCategory(category);
            this.SetCover(cover);
        }

        private void SetName(string name)
        {
            if (IsNullOrEmptyString(name))
            {
                throw new InvalidOperationException("Nombre no puede ser vacio o nullo");
            }
            else
            {
                this._name = name;
            }
        }
        private void SetCategory(string category)
        {
            if (IsNullOrEmptyString(category))
            {
                throw new InvalidOperationException("Categoria no puede ser vacia o nullo");
            }
            else
            {
                this._category = category;
            }
        }

        public void SetCover(Photo cover)
        {
                this._cover = cover;
        }

        public void SetPlayed()
        {
            this._played++;
        }


        private bool IsNullOrEmptyString(string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            else 
            {
                Game elObj = (Game)obj;
                return this.Name.Equals(elObj.Name) || this.Id == elObj.Id ? true : false;
            }
        }
    }
}

