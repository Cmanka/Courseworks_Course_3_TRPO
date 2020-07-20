using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Model
{
    class Seller
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public DateTime DataBirth { get; set; }
        public int NumberPassport { get; set; }
        public string NameGetPassport { get; set; }
        public DateTime DataGetPassport { get; set; }
        public int? ShopId { get; set; }
        public virtual Shop Shop { get; set; }
        public string Department { get; set; }

        public override string ToString()
        {
            return $"{Firstname} {Surname}";
        }
    }
}
