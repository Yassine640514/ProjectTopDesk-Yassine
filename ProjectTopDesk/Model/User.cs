using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTopDesk.Model
{
    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public UserType type { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public Location location { get; set; }
        public string password { get; set; }
    }
}
