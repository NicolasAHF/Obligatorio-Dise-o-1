using DBStorage.DBAccess.EnititesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.Interfaces
{
    public interface IDataBreachReport : ICreate<DataBreachDTO>, IRead<DataBreachDTO>
    {
        IEnumerable<DataBreachDTO> GetAllRecordsByUser(Guid ID);
    }
}
