using System;
using System.Collections.Generic;

namespace SmartMonitor.API.Models
{
    public partial class SetCounter
    {
        public string CounterId { get; set; } = null!;
        public string? CounterDescription { get; set; }
        public string CounterName { get; set; } = null!;
        public string? CategoryName { get; set; }
        public string? CounterUnit { get; set; }
        public string CategoryId { get; set; } = null!;
        public string? InstanceTotalName { get; set; }
        public string? InstanceAllPrefix { get; set; }
        public string? InstanceBlankName { get; set; }
        public decimal? DisplayOrder { get; set; }
        public bool? IsActive { get; set; }
    }
}
