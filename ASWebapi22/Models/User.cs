using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASWebapi22.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Password { get; set; }

        public string UserNmae { get; set; }
    }
}