using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    class StatusEntity : ContentEntity
    {
        public int Id { get; set; }
        public string StatusBody { get; set; }
    }
}
