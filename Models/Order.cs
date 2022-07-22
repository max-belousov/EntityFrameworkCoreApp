using System;
using System.Collections.Generic;

namespace EntityFrameworkCoreApp.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public string ItemName { get; set; } = null!;
        public int ItemCode { get; set; }
        public string Email { get; set; } = null!;
    }
}
