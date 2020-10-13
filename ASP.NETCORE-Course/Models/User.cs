using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCORE_Course.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string FirstName { get; set; }

        public Project Project { get; set; }
    }
}
