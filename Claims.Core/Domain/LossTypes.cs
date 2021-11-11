using System;
using System.Collections.Generic;
using System.Text;

namespace Claims.Core.Domain
{
    public class LossTypes
    {
        public int LossTypeId { get; set; }
        public string LossTypeCode { get; set; }
        public string LossTypeDescription { get; set; }
        public string Status { get; set; }
        public string LastUpdatedDate { get; set; }
        public int LastUpdatedId { get; set; }
        public string CreatedDate { get; set; }
        public int CreatedId { get; set; }

    }
}
