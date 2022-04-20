using System;
using System.Collections.Generic;

namespace SmartMonitor.API.Models
{
    public partial class SchdSchedulersDatum
    {
        public int SchedulerId { get; set; }
        public string EntityType { get; set; } = null!;
        public string EntityId { get; set; } = null!;
        public bool? SchdIsEnabled { get; set; }
        public DateTime SchdDurationStartDate { get; set; }
        public DateTime SchdDurationEndDate { get; set; }
        public string SchdFrequencey { get; set; } = null!;
        public string SchdDailyFrequency { get; set; } = null!;
        public TimeSpan? SchdDailyOnceTime { get; set; }
        public byte? SchdDailyRepeatInterval { get; set; }
        public string? SchdDailyRepeatUnit { get; set; }
        public TimeSpan? SchdDailyRepeatStartTime { get; set; }
        public TimeSpan? SchdDailyRepeatEndTime { get; set; }
        public bool? SchdWeeklySaturday { get; set; }
        public bool? SchdWeeklySunday { get; set; }
        public bool? SchdWeeklyMonday { get; set; }
        public bool? SchdWeeklyTuesday { get; set; }
        public bool? SchdWeeklyWednesday { get; set; }
        public bool? SchdWeeklyThursday { get; set; }
        public bool? SchdWeeklyFriday { get; set; }
        public byte? SchdMonthlyDay { get; set; }
    }
}
