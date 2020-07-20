using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Models
{
    class Client
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public int Number { get; set; }
        public DateTime OrderTime { get; set; }
        public int? ServiceId { get; set; }
        public virtual Service Service { get; set; }

    }
}
