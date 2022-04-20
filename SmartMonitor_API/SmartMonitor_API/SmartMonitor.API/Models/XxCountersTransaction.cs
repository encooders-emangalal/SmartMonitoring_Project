using System;
using System.Collections.Generic;

namespace SmartMonitor.API.Models
{
    public partial class XxCountersTransaction
    {
        public string? MachineName { get; set; }
        public string CategoryName { get; set; } = null!;
        public string CounterName { get; set; } = null!;
        public string? InstanceName { get; set; }
        public DateTime CounterDatetime { get; set; }
        public double CounterValue { get; set; }
    }
}
