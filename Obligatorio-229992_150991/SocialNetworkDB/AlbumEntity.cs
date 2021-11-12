using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    class AlbumEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PhotoEntity> Photos { get; set; }
    }
}
