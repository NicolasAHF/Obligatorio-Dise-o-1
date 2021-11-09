using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStorage.Exceptions
{
    public class CategoryDBStorageException:Exception
    {
        public CategoryDBStorageException(string msg):base(msg)
        {

        }
    }
}
