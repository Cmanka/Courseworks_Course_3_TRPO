using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Data
{
    class Picture
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? ExhibitionId { get; set; }
        public virtual Exhibition Exhibition { get; set; }
    }
}
