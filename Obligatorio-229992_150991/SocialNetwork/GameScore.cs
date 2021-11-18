using System;
using System.Collections;

namespace SocialNetwork
{
    public class GameScore
    {
        private string _name;
        private int _score = 0;

        public int Id { get; set; }
        public string Name
        {
            get { return _name; }
            set => SetName(value);
        }
     
        public int Score
        {
            get { return _score; }
            set => SetScore(value);
        }

        public GameScore()
        {

        }

        public GameScore(string name, int score)
        {
            this.SetName(name);
            this.SetScore(score);

        }

        public void SetName(string name)
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
        public void SetScore(int score)
        {
            if (score < 0)
            {
                throw new InvalidOperationException("La puntuación no puede ser inferior a 0");
            }
            else
            {
                this._score = score;
            }
        }
        private bool IsNullOrEmptyString(string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}

