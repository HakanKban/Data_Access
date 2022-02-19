using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CODEFIRST_WFA.Models.Entities
{
    internal class Order:BaseEntity
    {


        public string ShippedAddress { get; set; }


        public int? ShipperID { get; set; }
        public int? AppUserID { get; set; }

        public virtual Shipper Shipper { get; set; }
        public virtual AppUser AppUser { get; set; }




    }
}
