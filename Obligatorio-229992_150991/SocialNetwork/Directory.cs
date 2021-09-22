using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class Directory
    {
        public List<User> Users { get; set; }

        public Directory(){
            Users = new List<User>();
        }

        public void AddUser(User user)
        {
            if (this.UsersAdded(user))
            {
                const string USER_ALREADY_EXISTS = "Ya existe una usuario con ese nombre de usuario";
                throw new InvalidOperationException(USER_ALREADY_EXISTS);
            }
            else
            {
                Users.Add(user);
            }
        }

        public bool UsersAdded(User userToAdd)
        {
            foreach (User user in this.Users)
            {
                if (user.IsEqual(userToAdd))
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
            return Users.Count;
        }

        public void RemoveUser(User user)
        {
            Users.Remove(user);
        }
    }
}
