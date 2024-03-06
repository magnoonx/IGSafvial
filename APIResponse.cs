using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConexion
{
    internal class APIResponse
    {
        public class Root
        {
            public required string token { get; set; }
            public required User user { get; set; }
        }

        public class User
        {
            public int id { get; set; }
            public int rolId { get; set; }
            public int personId { get; set; }
            public required string userName { get; set; }
        }
    }
}
