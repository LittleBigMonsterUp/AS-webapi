using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASWebapi22.Models
{
    public class AdminUser
    {
        public int ID { get; set; }
        public string Administorname { get; set; }

        public string Password { get; set; }
        public string Answer { get; set; }
        public string Question { get; set; }
    }
}