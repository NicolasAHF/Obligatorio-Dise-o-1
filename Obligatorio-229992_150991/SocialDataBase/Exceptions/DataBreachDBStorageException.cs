using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.Exceptions
{
    public class DataBreachDBStorageException : Exception
    {
        public DataBreachDBStorageException(string msg) : base(msg)
        {

        }
    }
}
