using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMonitoring.Repository
{
    public class RulesRepository
    {
        private readonly SmartMonitoringEntities1 db;
        public RulesRepository()
        {
            db = new SmartMonitoringEntities1();
        }

        public void Add(montr_monitor_rules rule)
        {
            db.montr_monitor_rules.Add(rule);
        }

        public void AddRange(IEnumerable<montr_monitor_rules> rules)
        {
            foreach (var rule in rules)
            {
                Add(rule);
            }
        }

        public void Edit(montr_monitor_rules entity)
        {
            var rule = db.montr_monitor_rules.FirstOrDefault(r => r.rule_id == entity.rule_id);

            if (rule != null)
                db.Entry(rule).State = EntityState.Detached;

            db.montr_monitor_rules.Attach(entity);
            entity.first_occurance_datetime = rule.first_occurance_datetime;
            entity.last_occurance_datetime = rule.last_occurance_datetime;
            entity.occurance_count = rule.occurance_count;
            entity.occurance_interval = rule.occurance_interval;            
            db.Entry(entity).State = EntityState.Modified;
        }

        public void EditRange(IEnumerable<montr_monitor_rules> rules)
        {
            foreach (var rule in rules)
            {
                Edit(rule);
            }
        }

        public void Delete(int id)
        {
            var entity = db.montr_monitor_rules.FirstOrDefault(r => r.rule_id == id);
            db.montr_monitor_rules.Remove(entity);
        }

        public void DeleteRange(IEnumerable<int> ids)
        {
            foreach (int id in ids)
            {
                Delete(id);
            }
        }

        public int Commit()
        {
            return db.SaveChanges();
        }
    }
}
