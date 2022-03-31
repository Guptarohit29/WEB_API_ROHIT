using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_API.Models
{
    public class modelclass
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public Nullable<int> AGE { get; set; }
        public Nullable<int> SALARY { get; set; }
        public string CITY { get; set; }
    }
}