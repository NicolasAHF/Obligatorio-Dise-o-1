using SocialNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    public class UserRepository
    {
        const string USER_ALREADY_EXISTS = "Usuario ya existente";
        private Mapper mapper = new Mapper();
        private Password password;
        private Direction direction;
        private Photo photo;
        private List<Album> albums;

        public UserRepository(Password password, Direction direction, Photo photo, List<Album> albums)
        {
            this.password = password;
            this.direction = direction;
            this.photo = photo;
            this.albums = albums;
        }

        public void Add(User user)
        {
            using (SocialContext context = new SocialContext())
            {
                if(context.Users.Any(c => c.Username == user.Username))
                {
                    throw new Exception(USER_ALREADY_EXISTS);
                }

                UserEntity entity = mapper.UserToEntity(user);
                context.Users.Add(entity);
                context.SaveChanges();
                user.Id = entity.Id;
            }
        }
        public User Get(String Username)
        {
            using (SocialContext context = new SocialContext())
            {
                UserEntity entity = context.Users.Include("Password").Include("Direction").Include("Avatar").Include("Following").Where(u => u.Username == Username).FirstOrDefault<UserEntity>();
                if(entity == null)
                {
                    throw new Exception("No se encontro");
                }

                User user = mapper.EntityToUser(entity);
                return user;
            }
        }
        public IEnumerable<User> GetAll()
        {
            List<User> users = new List<User>();
            using (SocialContext context = new SocialContext())
            {
                foreach (UserEntity entity in context.Users.Include("Password").Include("Direction").Include("Avatar").ToList())
                {
                    users.Add(mapper.EntityToUser(entity));
                }
            }
            return users;
        }
        public void UpdatePassword(Password password, User user)
        {
            using (SocialContext context = new SocialContext())
            {
                UserEntity entity = context.Users.Include("Password").Where(p => p.Id == user.Id).FirstOrDefault<UserEntity>(); ;
                if(entity == null)
                {
                    throw new Exception("No se encontro");
                }
                entity.Password.Hashpassword = password.Hashpassword;
                context.SaveChanges();
            }
        }

        public void UpdateModifyUser(User user)
        {
            using (SocialContext context = new SocialContext())
            {
                UserEntity entity = context.Users.Include("Direction").Include("Avatar").Where(p => p.Id == user.Id).FirstOrDefault<UserEntity>(); ;
                if (entity == null)
                {
                    throw new Exception("No se encontro");
                }
                entity.Avatar.Path = user.Avatar.ElPath;
                entity.Avatar.Size = user.Avatar.ElSize;
                entity.Direction.Street = user.Direction.Street;
                entity.Direction.City = user.Direction.City;
                entity.Direction.Counrty = user.Direction.City;
                entity.DateOfBirth = user.DateOfBirth;
                entity.Name = user.Name;
                entity.LastName = user.Lastname;
                context.SaveChanges();
            }
        }
        public void UpdateStatus(Status status, User user)
        {
            using (SocialContext context = new SocialContext())
            {
                UserEntity entity = context.Users.Include("Direction").Include("Avatar").Where(p => p.Id == user.Id).FirstOrDefault<UserEntity>(); ;
                if (entity == null)
                {
                    throw new Exception("No se encontro");
                }
                entity.status = mapper.StatusToEntity(status);
                context.SaveChanges();
            }
        }

        public void UpdateSong(ListeningNow song, User user)
        {
            using (SocialContext context = new SocialContext())
            {
                UserEntity entity = context.Users.Include("ListeningNow").Where(p => p.Id == user.Id).FirstOrDefault<UserEntity>(); ;
                if (entity == null)
                {
                    throw new Exception("No se encontro");
                }
                entity.ListeningNow = mapper.ListeningNowToEntity(song);
                context.SaveChanges();
            }
        }

        public void AddFollowing(User actualUser, User user)
        {
            using (SocialContext context = new SocialContext())
            {
                UserEntity userEntity = context.Users.Include("Following").Include("Password").Include("Direction").Include("Avatar").Where(p => p.Id == user.Id).FirstOrDefault<UserEntity>(); ;
                UserEntity actualUserEntity = context.Users.Include("Following").Include("Password").Include("Direction").Include("Avatar").Where(p => p.Id == actualUser.Id).FirstOrDefault<UserEntity>(); ;
                if (userEntity == null || actualUserEntity == null)
                {
                    throw new Exception("No se encontro");
                }
                actualUserEntity.Following.Add(userEntity);
                context.SaveChanges();
            }
        }
        public void RemoveFollowing(User actualUser, User user)
        {
            using (SocialContext context = new SocialContext())
            {
                UserEntity userEntity = context.Users.Include("Following").Include("Password").Include("Direction").Include("Avatar").Where(p => p.Id == user.Id).FirstOrDefault<UserEntity>(); ;
                UserEntity actualUserEntity = context.Users.Include("Following").Include("Password").Include("Direction").Include("Avatar").Where(p => p.Id == actualUser.Id).FirstOrDefault<UserEntity>(); ;
                if (userEntity == null || actualUserEntity == null)
                {
                    throw new Exception("No se encontro");
                }
                actualUserEntity.Following.Remove(userEntity);
                context.SaveChanges();
            }
        }
        public IEnumerable<User> GetFollowing(User actualUser, User user)
        {
            using (SocialContext context = new SocialContext())
            {
                List<User> following = new List<User>();
                UserEntity userEntity = context.Users.Include("Following").Include("Password").Include("Direction").Include("Avatar").Where(p => p.Id == user.Id).FirstOrDefault<UserEntity>(); ;
                UserEntity actualUserEntity = context.Users.Include("Following").Include("Password").Include("Direction").Include("Avatar").Where(p => p.Id == actualUser.Id).FirstOrDefault<UserEntity>(); ;
                if (userEntity == null || actualUserEntity == null)
                {
                    throw new Exception("No se encontro");
                }
                foreach(UserEntity userin in actualUserEntity.Following)
                {
                    following.Add(mapper.EntityToUser(userin));
                }
                return following;
            }
        }
        public bool IsEmpty()
        {
            using (SocialContext context = new SocialContext())
            {
                return context.Users.Count() == 0;
            }
        }
        public void AddAlbum(Album album, User user)
        {
            using (SocialContext context = new SocialContext())
            {
                UserEntity entity = context.Users.Include("Albums").Where(p => p.Id == user.Id).FirstOrDefault<UserEntity>(); ;
                UserEntity actualUserEntity = context.Users.Include("Following").Include("Password").Include("Direction").Include("Avatar").Include("Albums").Where(p => p.Id == user.Id).FirstOrDefault<UserEntity>(); ;
                if (entity == null)
                {
                    throw new Exception("No se encontro");
                }
                entity.Albums.Add(mapper.AlbumToEntity(album));
                context.SaveChanges();
            }
        }
    }

}
