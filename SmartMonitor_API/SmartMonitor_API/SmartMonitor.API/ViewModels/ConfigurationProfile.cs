using AutoMapper;
using SmartMonitor.API.Models;

namespace SmartMonitor.API.ViewModels
{
    public class ConfigurationProfile : Profile
    {
        public ConfigurationProfile()
        {
            CreateMap<MontrMachinesList, ConfigurationViewModel>();
            CreateMap<MontrMonitorCounter, ConfigurationViewModel>();
            CreateMap<CountersEditViewModel, MontrMonitorTransaction>(MemberList.None);
            CreateMap<MontrMonitorTransaction, CountersEditViewModel>();
        }
    }
}
