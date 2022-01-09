using System;
using System.Collections.Generic;

#nullable disable

namespace EcomFurniture.Models
{
    public partial class Custorder
    {
        public int OId { get; set; }
        public int UId { get; set; }
        public int PId { get; set; }
        public string PName { get; set; }
        public int OQuantity { get; set; }
        public decimal OFinalprice { get; set; }
        public string OStatus { get; set; }
        public DateTime? ODate { get; set; }

        public virtual Product PIdNavigation { get; set; }
        public virtual User UIdNavigation { get; set; }
    }
}
