using System;
using System.Collections.Generic;

#nullable disable

namespace EcomFurniture.Models
{
    public partial class Product
    {
        public Product()
        {
            Custorders = new HashSet<Custorder>();
        }

        public int PId { get; set; }
        public string PName { get; set; }
        public int PCategory { get; set; }
        public decimal PPrice { get; set; }
        public decimal? PDiscount { get; set; }
        public string PDescription { get; set; }

        public virtual Category PCategoryNavigation { get; set; }
        public virtual ICollection<Custorder> Custorders { get; set; }
    }
}
