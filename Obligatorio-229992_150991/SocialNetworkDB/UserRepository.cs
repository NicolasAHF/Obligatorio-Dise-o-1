using SocialNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    public class UserRepository : IRepository<User>
    {
        const string USER_ALREADY_EXISTS = "Usuario ya existente";
        private Mapper mapper = new Mapper();

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
        public bool IsEmpty()
        {
            using (SocialContext context = new SocialContext())
            {
                return context.Users.Count() == 0;
            }
        }
        public User Get(int Id)
        {
            using (SocialContext context = new SocialContext())
            {
                UserEntity entity = context.Users.Include("Username").Where(p => p.Id == Id).FirstOrDefault<UserEntity>();
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
                foreach(UserEntity entity in context.Users.ToList())
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
        public void Update(User user)
        {
            using (SocialContext context = new SocialContext())
            {
                if(context.Users.Any(c => c.Username == user.Username))
                {
                    throw new Exception(USER_ALREADY_EXISTS);
                }
                UserEntity entity = context.Users.Include("Username").Where(p => p.Id == user.Id).FirstOrDefault<UserEntity>(); ;
                if(entity == null)
                {
                    throw new Exception("No se encontro");
                }
                entity.Username = user.Username;
                context.SaveChanges();
            }
        }
    }

}
