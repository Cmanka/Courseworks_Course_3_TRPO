using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Models
{
    class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int? MasterId { get; set; }
        public virtual Master Master { get; set; }

        public override string ToString()
        {
            return $"{Name},Стоимость:{Price},Выполняет:{Master}";
        }
    }
}
