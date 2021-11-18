using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    class ListeningNowEntity : ContentEntity
    {
        public int Id { get; set; }
        public string SongName { get; set; }
        public string Artist { get; set; }
        public string AlbumName { get; set; }
    }
}
