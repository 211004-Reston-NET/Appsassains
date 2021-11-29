using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth0MVCApp.Models
{
    public class User
    {
        public int ID { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
