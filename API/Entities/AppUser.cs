using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserNAme { get; set; }
        public byte[] passwordHash { get; set; }
        public byte[] passwordSalt { get; set; }

    }
}