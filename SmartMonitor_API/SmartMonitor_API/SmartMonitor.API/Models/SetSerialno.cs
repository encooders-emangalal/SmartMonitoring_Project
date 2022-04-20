using System;
using System.Collections.Generic;

namespace SmartMonitor.API.Models
{
    public partial class SetSerialno
    {
        public string IdentifierId { get; set; } = null!;
        public int SerialnoValue { get; set; }
    }
}
