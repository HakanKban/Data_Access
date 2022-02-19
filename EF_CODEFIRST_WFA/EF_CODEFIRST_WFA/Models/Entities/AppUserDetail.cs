using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CODEFIRST_WFA.Models.Entities
{
    internal class AppUserDetail:BaseEntity
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  string IdentityNo { get; set; }

        // ilişki için Property


        public virtual AppUser AppUser { get; set; }

    }
}
