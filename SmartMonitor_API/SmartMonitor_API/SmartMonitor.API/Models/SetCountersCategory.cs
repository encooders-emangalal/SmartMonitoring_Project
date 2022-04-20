using System;
using System.Collections.Generic;

namespace SmartMonitor.API.Models
{
    public partial class SetCountersCategory
    {
        public string CategoryId { get; set; } = null!;
        public string CategoryDescription { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public byte? DisplayOrder { get; set; }
        public bool? IsActive { get; set; }
    }
}
