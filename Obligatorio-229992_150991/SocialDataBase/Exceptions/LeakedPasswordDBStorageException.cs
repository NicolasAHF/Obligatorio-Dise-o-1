using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.Exceptions
{
    public class LeakedPasswordDBStorageException : Exception
    {
        public LeakedPasswordDBStorageException(string msg):base(msg)
        {

        }
    }
}
