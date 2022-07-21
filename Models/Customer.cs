using System;
using System.Collections.Generic;

namespace EntityFrameworkCoreApp.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string SecondName { get; set; } = null!;
        public string ThirdName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
