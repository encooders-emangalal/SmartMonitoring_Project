using System;
using System.Collections.Generic;

namespace SmartMonitor.API.Models
{
    public partial class MontrMonitorGroupsCounter
    {
        public string MachineId { get; set; } = null!;
        public int GroupId { get; set; }
        public string CounterId { get; set; } = null!;
        public string InstanceId { get; set; } = null!;
    }
}
