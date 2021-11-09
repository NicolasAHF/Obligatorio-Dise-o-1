using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.Interfaces
{
    public interface IDelete<T> where T : class
    {
        void Remove(Guid Id);
    }
}
