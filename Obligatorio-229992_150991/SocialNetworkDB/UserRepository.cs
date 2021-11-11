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

        public UserRepository(Password password, Direction direction, Photo photo)
        {
            this.password = password;
            this.direction = direction;
            this.photo = photo;
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
                //entity.Password = context.Passwords.Find(this.password.Id);
                //entity.Direction = context.Directions.Find(this.direction.Id);
                //entity.Avatar = context.Photos.Find(this.photo.Id);
                context.Users.Add(entity);
                context.SaveChanges();
                user.Id = entity.Id;
            }
        }
        public bool IsEmpty()
        {
            using (SocialContext context = new SocialContext())
            {
                return context.Users.Count() == 0;
            }
        }
        public User Get(String Username)
        {
            using (SocialContext context = new SocialContext())
            {
                UserEntity entity = context.Users.Include("Password").Include("Direction").Include("Avatar").Where(u => u.Username == Username).FirstOrDefault<UserEntity>();
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
        public void Delete(int id)
        {
            using (SocialContext context = new SocialContext())
            {
                UserEntity entity = context.Users.Find(id);
                if(entity != null)
                {
                    context.Users.Remove(entity);
                    context.SaveChanges();
                }
            }
        }
        public void Update(Password password, User user)
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
    }

}
