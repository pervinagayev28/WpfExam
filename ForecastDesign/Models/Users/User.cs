using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastDesign.Models.Users
{
    public class History
    {
        public string? location { get; set; }
        public override string ToString()
        {
            return location!; 
        }
    }
    public class User
    {
        public string ?Gmail { get; set; }
        public string ?Password { get; set; }
        public string ?Location { get; set; }
        public ObservableCollection<History>? Histories { get; set; } = new();
    }
}
