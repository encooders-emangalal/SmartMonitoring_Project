using System;
using System.Collections.Generic;

namespace SmartMonitor.API.Models
{
    public partial class MontrMonitorCounter
    {
        public string MachineId { get; set; } = null!;
        public string CounterId { get; set; } = null!;
        public string? InstanceId { get; set; }
        public string? InstanceName { get; set; }
        public int? DisplayOrder { get; set; }
        public double? CurrentValue { get; set; }
        public DateTime? CurrentDatetime { get; set; }
        public double? MinimumValue { get; set; }
        public DateTime? MinimumDatetime { get; set; }
        public double? MaximumValue { get; set; }
        public DateTime? MaximumDatetime { get; set; }
        public double? AverageValue { get; set; }
        public DateTime? AverageDatetime { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public int? InsertUserId { get; set; }
        public DateTime? InsertDt { get; set; }
    }
}
