using BusinessLogic.Entities;
using System;
using System.Collections.Generic;

namespace DBStorage.Interfaces
{
    public interface IPasswordStorage : IStorage<Password>
    {
        IEnumerable<Password> GetAllByCategory(Guid categoryId);
        IEnumerable<Password> GetAllUserPasswords(Guid userId);
        string GetUserKey(Guid userId);
            
    }
}
