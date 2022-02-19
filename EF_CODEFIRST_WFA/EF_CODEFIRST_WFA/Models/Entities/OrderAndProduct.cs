using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CODEFIRST_WFA.Models.Entities
{
    internal class OrderAndProduct:BaseEntity
    {
        // çoka çok ilişki order and Prodduct
        public int OrderID { get; set; }
        public int ProductId { get; set; }

        public decimal TotalPrice{ get; set; }

        public double Discount { get; set; }
        // ilişki propları

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }


    }
}
