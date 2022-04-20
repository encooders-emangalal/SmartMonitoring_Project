using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeServer_WinService.Models
{
    public class CountersEditViewModel
    {
        public string CounterId { get; set; } = null;
        public string InstanceId { get; set; } = null;
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
