using SmartMonitor.API.ViewModels;

namespace SmartMonitor.API.Services
{
    public interface ILogic
    {
        //TViewModel GetByID(string ID);
        //TEditViewModel Add(TEditViewModel model);                 
        ConfigurationViewModel GetConfiguration(string machineName, string ipAddress);
        void Add(CountersVM model);
    }
}
