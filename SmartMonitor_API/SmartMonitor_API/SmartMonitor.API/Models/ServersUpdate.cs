using System;
using System.Collections.Generic;

namespace SmartMonitor.API.Models
{
    public partial class ServersUpdate
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDt { get; set; }
        public string ServerId { get; set; } = null!;
        public string? SysSystemName { get; set; }
        public string? SysIpAddress { get; set; }
        public string? CpuProcessorId { get; set; }
        public string? CpuProcessorName { get; set; }
        public short? CpuCoresCount { get; set; }
        public short? CpuCoresEnabledCount { get; set; }
        public short? CpuLogicalProcessorsCount { get; set; }
        public short? CpuMaxClockSpeed { get; set; }
        public decimal? MemoryTotal { get; set; }
        public decimal? StorageTotal { get; set; }
    }
}
