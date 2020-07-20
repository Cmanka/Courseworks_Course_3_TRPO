using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Data
{
    class Exhibition
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string Genre { get; set; }
        public string Type { get; set; }
        public float Price { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }

        public Exhibition()
        {
            Pictures = new List<Picture>();
        }
    }
}
