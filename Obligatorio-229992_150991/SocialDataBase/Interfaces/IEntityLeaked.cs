using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.Interfaces
{
    public interface IEntityLeaked<T> : ICreate<T>, IRead<T> where T : class 
    {
        IEnumerable<T> GetAllRecordByDataBreach(Guid ID);        
    }
}
