using System.ComponentModel.DataAnnotations;

namespace SmartMonitor.API.ViewModels
{
    public class CountersEditViewModel
    {       
        public string CounterId { get; set; } = null!;
        public string? InstanceId { get; set; }
        public DateTime CounterDatetime { get; set; }
        public double CounterValue { get; set; }
    }
    public class CountersVM
    {
        [Required]
        public string MachineId { get; set; }
        public List<CountersEditViewModel> Counters { get; set; }
    }
}
