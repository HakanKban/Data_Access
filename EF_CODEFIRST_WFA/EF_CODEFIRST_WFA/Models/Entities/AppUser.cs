using EF_CODEFIRST_WFA.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CODEFIRST_WFA.Models.Entities
{
    internal class AppUser:BaseEntity
    {

        public string UserName { get; set; }
        public string Password { get; set; }

        public UserRole Role { get; set; }
  
        // Birebirilişki appuserDetail ile
        public virtual AppUserDetail Profile { get; set; }

        public virtual List<Order> Orders { get; set; } 

    }
}
