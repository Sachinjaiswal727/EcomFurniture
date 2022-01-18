using System;
using System.Collections.Generic;

#nullable disable

namespace EcomFurniture.Models
{
    public partial class User
    {
        public int UId { get; set; }
        public string UName { get; set; }
        public string ULastname { get; set; }
        public string UEmail { get; set; }
        public string UPassword { get; set; }
        public string UMobile { get; set; }
        public string UAddress { get; set; }
        public int? UPinCode { get; set; }
        public int? URole { get; set; }

        public virtual Role URoleNavigation { get; set; }
    }
}
