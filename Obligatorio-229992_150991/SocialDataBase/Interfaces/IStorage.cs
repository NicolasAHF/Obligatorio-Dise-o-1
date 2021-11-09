using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DBStorage.Interfaces
{
    public interface IStorage<T> : ICreate<T>, IRead<T>, IUpdate<T>, IDelete<T> where T : class
    {
      
    }
}
