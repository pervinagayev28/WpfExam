using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastDesign.Models.Users
{
    public class History
    {
        public string  ?location{ get; set; }
    }
    public class User
    {
        public string ?Gmail { get; set; }
        public string ?Password { get; set; }
        public string ?Location { get; set; }
        public List<History>?Histories { get; set; }
    }
}
