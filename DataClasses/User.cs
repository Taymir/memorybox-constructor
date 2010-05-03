using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    public class User
    {
        public User()
        {
            this.birthday = new DateTime(1987, 01, 01);
        }

        public string name { get; set; }

        public string photo { get; set; }

        public bool isTeacher { get; set; }
        public DateTime birthday { get; set; }
        public string disipline { get; set; }

        public string contacts_cellphone { get; set; }
        public string contacts_phone { get; set; }
        public string contacts_links { get; set; }

        public string photos { get; set; }

        public string videos { get; set; }
    }
}
