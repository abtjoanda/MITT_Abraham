using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class UserProfile
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Bod { get; set; }
        public string Email { get; set; }
    }
}
