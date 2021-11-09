using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.Exceptions
{
    public class LeakedCreditCardDBStorageException : Exception
    {
        public LeakedCreditCardDBStorageException(string msg) : base(msg)
        {

        }
    }
}
