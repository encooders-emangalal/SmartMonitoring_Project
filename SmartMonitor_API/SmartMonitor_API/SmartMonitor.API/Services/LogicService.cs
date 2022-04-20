using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartMonitor.API.Models;
using SmartMonitor.API.ViewModels;

namespace SmartMonitor.API.Services
{
    public class LogicService : ILogic
    {
        protected IMapper _mapper;       
        private SmartMonitoringContext _context;
        public LogicService(SmartMonitoringContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Add(CountersVM model)
        {
            try
            {                
                var models = model.Counters.Select(x=> _mapper.Map<CountersEditViewModel, MontrMonitorTransaction>(x)).ToList();
                models.ForEach(x=> x.MachineId = model.MachineId);
                _context.MontrMonitorTransactions.AddRange(models);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }

        public ConfigurationViewModel GetConfiguration(string machineName, string ipAddress)
        {
            try
            {
                var machine = _context.MontrMachinesLists.FirstOrDefault(m => m.IsDeleted == false && m.MachineName == machineName && m.IpAddress == ipAddress && m.IsActive == true);
                if (machine != null)
                {
                    
                    var obj = _mapper.Map<MontrMachinesList, ConfigurationViewModel>(machine);
                    var counters = _context.MontrMonitorCounters.Where(c => c.MachineId == machine.MachineId && c.IsActive == true && c.IsDeleted == false).ToList();
                    
                    if (counters.Count > 0)
                    {
                        //List<string> counterId = new List<string>();
                        //List<string> instanceId = new List<string>();
                        //List<string> instanceName = new List<string>();
                        //List<string> categoryName = new List<string>();
                        //List<string> counterName = new List<string>();
                        foreach (var counter in counters)
                        {
                            var t = _context.SetCounters.FirstOrDefault(c => c.CounterId == counter.CounterId);
                            obj.counters = new List<Counters>() { new Counters() {
                            CounterId = counter.CounterId,
                            InstanceId = counter.InstanceId ?? String.Empty,
                            InstanceName = counter.InstanceName ?? String.Empty,
                            CategoryName = t.CategoryName?? String.Empty,
                            CounterName = t.CounterName,
                            } };
                            //obj.CounterId.Add(counter.CounterId);
                            ////if(!String.IsNullOrEmpty(counter.InstanceId))
                            //    obj.InstanceId.Add(counter.InstanceId);
                            ////if (!String.IsNullOrEmpty(counter.InstanceName))
                            //    obj.InstanceName.Add(counter.InstanceName);
                            ////if (!String.IsNullOrEmpty(t.CategoryName))
                            //    obj.CategoryName.Add(t.CategoryName);
                            ////if (!String.IsNullOrEmpty(t.CounterName))
                            //    obj.CounterName.Add(t.CounterName);
                        }
                    }

                    return obj;
                }
                return null;
            }
            catch (Exception ex)
            {

                return null;
            }
        }


    }
}
