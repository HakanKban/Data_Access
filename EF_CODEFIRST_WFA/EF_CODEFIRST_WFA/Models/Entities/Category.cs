using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CODEFIRST_WFA.Models.Entities
{
    internal class Category:BaseEntity
    {

        public string CategoryName { get; set; }
        public string Description { get; set; }

        // ilişi içiç property bire çok ilişki

        public virtual List<Product> Products { get; set; }
    }
}
