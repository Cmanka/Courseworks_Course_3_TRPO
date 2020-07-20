using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Model
{
    class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAvailableProduct { get; set; }
        public int? ProductId { get; set; }
        public int? IncomeId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Income Income { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
