using System;
using System.Collections.Generic;

#nullable disable

namespace EcomFurniture.Models
{
    public partial class Contactu
    {
        public int ContactusId { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
    }
}
