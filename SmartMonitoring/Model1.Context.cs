﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartMonitoring
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SmartMonitoringEntities1 : DbContext
    {
        public SmartMonitoringEntities1()
            : base("name=SmartMonitoringEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<montr_machines_list> montr_machines_list { get; set; }
        public virtual DbSet<montr_monitor_groups> montr_monitor_groups { get; set; }
        public virtual DbSet<schd_schedulers_data> schd_schedulers_data { get; set; }
        public virtual DbSet<servers_data> servers_data { get; set; }
        public virtual DbSet<servers_updates> servers_updates { get; set; }
        public virtual DbSet<set_counters> set_counters { get; set; }
        public virtual DbSet<set_serialno> set_serialno { get; set; }
        public virtual DbSet<montr_monitor_counters> montr_monitor_counters { get; set; }
        public virtual DbSet<montr_monitor_groups_counters> montr_monitor_groups_counters { get; set; }
        public virtual DbSet<set_counters_categories> set_counters_categories { get; set; }
        public virtual DbSet<xx_counters_transactions> xx_counters_transactions { get; set; }
        public virtual DbSet<montr_monitor_transactions> montr_monitor_transactions { get; set; }
        public virtual DbSet<server_groups> server_groups { get; set; }
        public virtual DbSet<server_users> server_users { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<montr_transaction_calculated> montr_transaction_calculated { get; set; }
        public virtual DbSet<sys_settings> sys_settings { get; set; }
        public virtual DbSet<rule_events> rule_events { get; set; }
        public virtual DbSet<montr_monitor_rules> montr_monitor_rules { get; set; }
    }
}
