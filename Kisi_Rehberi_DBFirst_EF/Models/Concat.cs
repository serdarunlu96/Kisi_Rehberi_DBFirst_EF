using System;
using System.Collections.Generic;

namespace Kisi_Rehberi_DBFirst_EF.Models
{
    public partial class Concat
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
