using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Models
{
    class Master
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public bool IsMaterial { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
