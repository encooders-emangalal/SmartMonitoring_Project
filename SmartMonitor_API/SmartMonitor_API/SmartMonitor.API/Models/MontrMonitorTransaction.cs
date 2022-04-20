using System;
using System.Collections.Generic;

namespace SmartMonitor.API.Models
{
    public partial class MontrMonitorTransaction
    {
        public int TransactionId { get; set; }
        public string MachineId { get; set; } = null!;
        public string CounterId { get; set; } = null!;
        public string? InstanceId { get; set; }
        public DateTime CounterDatetime { get; set; }
        public double CounterValue { get; set; }
    }
}
