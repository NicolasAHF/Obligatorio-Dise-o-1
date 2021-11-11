using SocialNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string status { get; set; }
        public PasswordEntity Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DirectionEntity Direction { get; set; }
        public PhotoEntity Avatar { get; set; }
        public bool Admin { get; set; }
        public List<UserEntity> Following { get; set; }
        public List<AlbumEntity> Albums { get; set; }
        public ListeningNowEntity ListeningNow { get; set; }
    }
}
