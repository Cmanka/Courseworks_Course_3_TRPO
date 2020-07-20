using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Model
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public bool IsByThePiece { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
