using EF_CODEFIRST_WFA.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CODEFIRST_WFA.Models.Entities
{
    internal abstract class BaseEntity
    {

        public int ID { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string UpdatedBy { get; set; }

        public DataStatus Status { get; set; }


        public BaseEntity()
        {
            Status = DataStatus.Inserted;
            CreateDate = DateTime.Now;
        } 

    }
}
