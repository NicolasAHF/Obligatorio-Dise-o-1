using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.Interfaces
{
    public interface IUserStorage : ICreate<User>, IRead<User>
    {
        IEnumerable<User> GetAllOthersUsers(Guid userId);
        User GetUserByName(string name);
    }
}
