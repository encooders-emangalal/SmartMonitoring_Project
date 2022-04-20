using System;
using System.Collections.Generic;

namespace SmartMonitor.API.Models
{
    public partial class MontrMonitorRule
    {
        public int RuleId { get; set; }
        public string MachineId { get; set; } = null!;
        public string CounterId { get; set; } = null!;
        public string? InstanceId { get; set; }
        public string RuleField { get; set; } = null!;
        public string RuleMathSymbol { get; set; } = null!;
        public double RuleValue { get; set; }
        public byte RuleOcuuranceType { get; set; }
        public int OcuuranceInterval { get; set; }
        public string DisplayLevel { get; set; } = null!;
        public int ActionId { get; set; }
        public DateTime? FirstOccuranceDatetime { get; set; }
        public DateTime? LastOccuranceDatetime { get; set; }
        public int? OccuranceCount { get; set; }
        public int? OccuranceInterval { get; set; }
        public bool? IsAlarmRaised { get; set; }
        public bool? IsActionRaised { get; set; }
    }
}
