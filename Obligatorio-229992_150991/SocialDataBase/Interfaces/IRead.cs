using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.Interfaces
{
    public interface IRead<T> where T : class
    {
        T Get(Guid id);
        
    }
}
