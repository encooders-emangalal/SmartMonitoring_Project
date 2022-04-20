namespace SmartMonitor.API.ViewModels
{
    public class ConfigurationViewModel
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
        public List<Counters> counters { get; set; }
        //public List<string> CounterId { get; set; } = new List<string>();
        //public List<string> InstanceId { get; set; } = new List<string>();
        //public List<string> InstanceName { get; set; } = new List<string>();
        //public List<string> CategoryName { get; set; } = new List<string>();
        //public List<string> CounterName { get; set; } = new List<string>();
    }

    public class Counters
    {
        public string CounterId { get; set; }
        public string InstanceId { get; set; }
        public string InstanceName { get; set; }
        public string CategoryName { get; set; }
        public string CounterName { get; set; }
    }
}