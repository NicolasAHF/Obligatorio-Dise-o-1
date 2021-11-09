using BusinessLogic.Entities;
using System;
using System.Collections.Generic;

namespace DBStorage.Interfaces
{
    public interface ICategoryStorage : ICreate<Category>, IRead<Category>, IUpdate<Category>
    {
        IEnumerable<Category> GetUserCategories (Guid userId);
    }
}
