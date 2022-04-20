using System;
using System.Collections.Generic;

namespace SmartMonitor.API.Models
{
    public partial class MontrMonitorGroup
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; } = null!;
        public string MachineId { get; set; } = null!;
        public string? GroupImageId { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public int? InsertUserId { get; set; }
        public DateTime? InsertDt { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDt { get; set; }
        public int? DeleteUserId { get; set; }
        public DateTime? DeleteDt { get; set; }
    }
}
