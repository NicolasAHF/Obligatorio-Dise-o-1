using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class ListeningNow : Contents
    {
        private string _songName;
        private string _artist;
        private string _albumName;


        public string SongName 
        {
            get { return _songName; }
            private set => SetSongName(value);
        }

        public string Artist 
        {
            get { return _artist; }
            private set => SetArtist(value);
        }

        public string AlbumName
        {
            get { return _albumName; }
            private set => SetAlbumName(value);
        }

        public ListeningNow()
        {

        }

        public ListeningNow(string songName, string artist, string albumName)
        {
            this.SongName = songName;
            this.Artist = artist;
            this.AlbumName = albumName;
        }

        public void SetSongName(string songName)
        {
            if (EmptyString(songName))
            {
                throw new InvalidOperationException("Nombre de la cancion no puede ser vacio");
            }
            else
            {
                this._songName = songName;
            }
        }

        public void SetArtist(string artist)
        {
            if (EmptyString(artist))
            {
                throw new InvalidOperationException("El artista no puede ser vacio");
            }
            else
            {
                this._artist = artist;
            }
        }

        public void SetAlbumName(string albumName)
        {
            if (EmptyString(albumName))
            {
                throw new InvalidOperationException("El nombre del album no puede ser vacio");
            }
            else
            {
                this._albumName = albumName;
            }
        }

        private bool EmptyString(string value)
        {
            return value.Length.Equals(0);
        }

    }
}
