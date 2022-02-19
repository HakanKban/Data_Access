using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CODEFIRST_WFA.Models.Entities
{
    internal class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public short UnıtsInStock { get; set; }

        public int? CategoryID { get; set; } // ilişki için foreignkey
        public virtual Category Category { get; set; } // sqlde ilişki kurması için

    }
}
