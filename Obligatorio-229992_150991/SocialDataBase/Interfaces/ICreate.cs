using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.Interfaces
{
    public interface ICreate<T> where T : class
    {
        void Insert(T entity);
        bool Exists(Guid Id);
        bool IsEmpty();
        void Clear();
        
    }
}
