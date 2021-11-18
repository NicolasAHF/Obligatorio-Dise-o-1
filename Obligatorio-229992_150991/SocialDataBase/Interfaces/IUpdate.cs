using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.Interfaces
{
    public interface IUpdate<T> where T : class
    {
        void Update(T entity);
    }
}
