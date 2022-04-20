using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SmartMonitor.API.Services;
using SmartMonitor.API.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartMonitor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServerController : ControllerBase
    {
        private ILogic _service;
        protected IMapper _mapper;
        public ServerController(ILogic logic, IMapper mapper)
        {
            _service = logic;
            _mapper = mapper;
        }
        // GET api/<ServerController>/5
        [HttpGet]
        [Route("GetConfigurations")]
        public ConfigurationViewModel Get(string machineName, string ipAddress)
        {
            return _service.GetConfiguration(machineName, ipAddress);
            //return JsonConvert.SerializeObject(_service.GetConfiguration(machineName, ipAddress));
        }

        // POST api/<ServerController>
        [HttpPost]
        [Route("PostCounters")]
        public void Post([FromBody] CountersVM model)
        {
            if (ModelState.IsValid)
            {
                _service.Add(model);
            }
             
        }
    }
}
