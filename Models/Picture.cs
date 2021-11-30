using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth0MVCApp.Models
{
    public class Picture
    {
        public int ID { get; set; }

        public string userEmail { get; set; }
        public string name { get; set; }
        public string rating { get; set; }
        public string data { get; set; }

    }
}
