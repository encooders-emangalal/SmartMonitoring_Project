using System;
using System.Collections.Generic;

namespace SmartMonitor.API.Models
{
    public partial class MontrMachinesList
    {
        public string MachineId { get; set; } = null!;
        public string MachineName { get; set; } = null!;
        public string? MachineDescription { get; set; }
        public string HostName { get; set; } = null!;
        public string? IpAddress { get; set; }
        public string? OsName { get; set; }
        public bool? IsCurrentMachine { get; set; }
        public string? ConnDomainName { get; set; }
        public string? ConnUserName { get; set; }
        public string? ConnUserPassword { get; set; }
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
