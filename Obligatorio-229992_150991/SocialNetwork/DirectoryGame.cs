using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class DirectoryGame
    {
        public List<Game> GameList { get; set; }

        public DirectoryGame()
        {
            GameList = new List<Game>();
        }

        public void AddGame(Game game)
        {
            if (this.GameAdded(game))
            {
                const string GAME_ALREADY_EXISTS = "Ya existe un juego con ese nombre de usuario";
                throw new InvalidOperationException(GAME_ALREADY_EXISTS);
            }
            else
            {
                GameList.Add(game);
            }
        }

        public bool GameAdded(Game gameToAdd, User user)
        {
            foreach (Game game in this.GameList)
            {
                if (game.Equals(gameToAdd))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsEmpty()
        {
            return this.Count() == 0;
        }

        public int Count()
        {
            return GameList.Count;
        }

        public void RemoveGame(Game game)
        {
            if (GetGame(game).Played == 0)
            {
                GameList.Remove(game);
            }
            else
            {
                throw new InvalidOperationException("No se puede borrar un jugo que ya fue jugado por un usuario");
            }
        }

        public Game GetGame(Game elGame)
        {
            foreach (Game game in this.GameList)
            {
                if (game.Name.Equals(elGame.Name))
                {
                    return game;
                }
            }
            throw new InvalidOperationException("No hay un juego con ese nombre");
        }

        public void SetPlayed(Game elGame)
        {
            GetGame(elGame).SetPlayed();
        }
    }
}