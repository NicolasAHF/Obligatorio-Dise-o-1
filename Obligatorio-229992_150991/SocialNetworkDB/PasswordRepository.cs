using SocialNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    public class PasswordRepository
    {
        private Mapper mapper = new Mapper();

        public PasswordRepository()
        {
        }

        public void Add(Password password)
        {
            using (SocialContext context = new SocialContext())
            {

                PasswordEntity entity = mapper.PasswordToEntity(password);
                context.Passwords.Add(entity);
                context.SaveChanges();
                password.Id = entity.Id;
            }
        }
        public void Update(Password password)
        {
            using (SocialContext context = new SocialContext())
            {
                PasswordEntity entity = context.Passwords.Where(p => p.Id == password.Id).FirstOrDefault<PasswordEntity>(); ;
                if (entity == null)
                {
                    throw new Exception("No se encontro");
                }
                entity.Id = password.Id;
                context.SaveChanges();
            }
        }
    }
}
