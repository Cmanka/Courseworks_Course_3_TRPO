using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Model
{
    class Income
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? SellerId { get; set; }
        public DateTime Date { get; set; }
        public bool IsByThePiece { get; set; }
        public int CountSold { get; set; }
        public virtual Product Product { get; set; }
        public virtual Seller Seller { get; set; }

        public override string ToString()
        {
            return $"{CountSold*Product.Price}";
        }
    }
}
