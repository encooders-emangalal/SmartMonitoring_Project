using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMonitoring.Repository
{
    public class ServerRepository
    {
        private readonly SmartMonitoringEntities1 db;

        public ServerRepository(SmartMonitoringEntities1 db)
        {
            this.db = db;
        }

        public montr_machines_list Add(montr_machines_list newServer)
        {
            return db.montr_machines_list.Add(newServer);
        }

        public int Commit()
        {
            return db.SaveChanges();
        }
    }
}
