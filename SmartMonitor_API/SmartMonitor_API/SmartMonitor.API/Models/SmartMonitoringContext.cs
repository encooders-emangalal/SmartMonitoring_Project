using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SmartMonitor.API.Models
{
    public partial class SmartMonitoringContext : DbContext
    {
        public SmartMonitoringContext()
        {
        }

        public SmartMonitoringContext(DbContextOptions<SmartMonitoringContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MontrMachinesList> MontrMachinesLists { get; set; } = null!;
        public virtual DbSet<MontrMonitorCounter> MontrMonitorCounters { get; set; } = null!;
        public virtual DbSet<MontrMonitorGroup> MontrMonitorGroups { get; set; } = null!;
        public virtual DbSet<MontrMonitorGroupsCounter> MontrMonitorGroupsCounters { get; set; } = null!;
        public virtual DbSet<MontrMonitorRule> MontrMonitorRules { get; set; } = null!;
        public virtual DbSet<MontrMonitorTransaction> MontrMonitorTransactions { get; set; } = null!;
        public virtual DbSet<SchdSchedulersDatum> SchdSchedulersData { get; set; } = null!;
        public virtual DbSet<ServersDatum> ServersData { get; set; } = null!;
        public virtual DbSet<ServersUpdate> ServersUpdates { get; set; } = null!;
        public virtual DbSet<SetCounter> SetCounters { get; set; } = null!;
        public virtual DbSet<SetCountersCategory> SetCountersCategories { get; set; } = null!;
        public virtual DbSet<SetSerialno> SetSerialnos { get; set; } = null!;
        public virtual DbSet<XxCountersTransaction> XxCountersTransactions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-QQD7L2O;Database=SmartMonitoring;Persist Security Info=True;User ID =sa; Password=123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Arabic_CI_AS");

            modelBuilder.Entity<MontrMachinesList>(entity =>
            {
                entity.HasKey(e => e.MachineId);

                entity.ToTable("montr_machines_list");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("machine_id");

                entity.Property(e => e.ConnDomainName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("conn_domain_name");

                entity.Property(e => e.ConnUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("conn_user_name");

                entity.Property(e => e.ConnUserPassword)
                    .HasMaxLength(150)
                    .HasColumnName("conn_user_password");

                entity.Property(e => e.DeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("delete_dt");

                entity.Property(e => e.DeleteUserId).HasColumnName("delete_user_id");

                entity.Property(e => e.HostName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("host_name");

                entity.Property(e => e.InsertDt)
                    .HasColumnType("datetime")
                    .HasColumnName("insert_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUserId).HasColumnName("insert_user_id");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ip_address");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsCurrentMachine).HasColumnName("is_current_machine");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.MachineDescription)
                    .HasMaxLength(250)
                    .HasColumnName("machine_description");

                entity.Property(e => e.MachineName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("machine_name");

                entity.Property(e => e.OsName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("os_name");

                entity.Property(e => e.UpdateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("update_dt");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");
            });

            modelBuilder.Entity<MontrMonitorCounter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("montr_monitor_counters");

                entity.Property(e => e.AverageDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("average_datetime");

                entity.Property(e => e.AverageValue).HasColumnName("average_value");

                entity.Property(e => e.CounterId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("counter_id");

                entity.Property(e => e.CurrentDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("current_datetime");

                entity.Property(e => e.CurrentValue).HasColumnName("current_value");

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("display_order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InsertDt)
                    .HasColumnType("datetime")
                    .HasColumnName("insert_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUserId).HasColumnName("insert_user_id");

                entity.Property(e => e.InstanceId)
                    .HasMaxLength(150)
                    .HasColumnName("instance_id");

                entity.Property(e => e.InstanceName)
                    .HasMaxLength(150)
                    .HasColumnName("instance_name");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("machine_id");

                entity.Property(e => e.MaximumDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("maximum_datetime");

                entity.Property(e => e.MaximumValue).HasColumnName("maximum_value");

                entity.Property(e => e.MinimumDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("minimum_datetime");

                entity.Property(e => e.MinimumValue).HasColumnName("minimum_value");
            });

            modelBuilder.Entity<MontrMonitorGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("montr_monitor_groups");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.DeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("delete_dt");

                entity.Property(e => e.DeleteUserId).HasColumnName("delete_user_id");

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("display_order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupImageId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("group_image_id");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("group_name");

                entity.Property(e => e.InsertDt)
                    .HasColumnType("datetime")
                    .HasColumnName("insert_dt");

                entity.Property(e => e.InsertUserId).HasColumnName("insert_user_id");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("machine_id");

                entity.Property(e => e.UpdateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("update_dt");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");
            });

            modelBuilder.Entity<MontrMonitorGroupsCounter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("montr_monitor_groups_counters");

                entity.Property(e => e.CounterId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("counter_id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.InstanceId)
                    .HasMaxLength(150)
                    .HasColumnName("instance_id");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("machine_id");
            });

            modelBuilder.Entity<MontrMonitorRule>(entity =>
            {
                entity.HasKey(e => e.RuleId)
                    .HasName("PK__montr_mo__E92A9296C12CB03B");

                entity.ToTable("montr_monitor_rules");

                entity.Property(e => e.RuleId)
                    .ValueGeneratedNever()
                    .HasColumnName("rule_id");

                entity.Property(e => e.ActionId).HasColumnName("action_id");

                entity.Property(e => e.CounterId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("counter_id");

                entity.Property(e => e.DisplayLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("display_level");

                entity.Property(e => e.FirstOccuranceDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("first_occurance_datetime");

                entity.Property(e => e.InstanceId)
                    .HasMaxLength(150)
                    .HasColumnName("instance_id");

                entity.Property(e => e.IsActionRaised).HasColumnName("is_action_raised");

                entity.Property(e => e.IsAlarmRaised).HasColumnName("is_alarm_raised");

                entity.Property(e => e.LastOccuranceDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("last_occurance_datetime");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("machine_id");

                entity.Property(e => e.OccuranceCount).HasColumnName("occurance_count");

                entity.Property(e => e.OccuranceInterval).HasColumnName("occurance_interval");

                entity.Property(e => e.OcuuranceInterval).HasColumnName("ocuurance_interval");

                entity.Property(e => e.RuleField)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rule_field");

                entity.Property(e => e.RuleMathSymbol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rule_math_symbol");

                entity.Property(e => e.RuleOcuuranceType).HasColumnName("rule_ocuurance_type");

                entity.Property(e => e.RuleValue).HasColumnName("rule_value");
            });

            modelBuilder.Entity<MontrMonitorTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("montr_monitor_transactions");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.CounterDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("counter_datetime");

                entity.Property(e => e.CounterId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("counter_id");

                entity.Property(e => e.CounterValue).HasColumnName("counter_value");

                entity.Property(e => e.InstanceId)
                    .HasMaxLength(150)
                    .HasColumnName("instance_id");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("machine_id");
            });

            modelBuilder.Entity<SchdSchedulersDatum>(entity =>
            {
                entity.HasKey(e => e.SchedulerId);

                entity.ToTable("schd_schedulers_data");

                entity.Property(e => e.SchedulerId).HasColumnName("scheduler_id");

                entity.Property(e => e.EntityId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("entity_id");

                entity.Property(e => e.EntityType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("entity_type");

                entity.Property(e => e.SchdDailyFrequency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("schd_daily_frequency");

                entity.Property(e => e.SchdDailyOnceTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("schd_daily_once_time");

                entity.Property(e => e.SchdDailyRepeatEndTime).HasColumnName("schd_daily_repeat_end_time");

                entity.Property(e => e.SchdDailyRepeatInterval).HasColumnName("schd_daily_repeat_interval");

                entity.Property(e => e.SchdDailyRepeatStartTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("schd_daily_repeat_start_time");

                entity.Property(e => e.SchdDailyRepeatUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("schd_daily_repeat_unit");

                entity.Property(e => e.SchdDurationEndDate)
                    .HasColumnType("date")
                    .HasColumnName("schd_duration_end_date");

                entity.Property(e => e.SchdDurationStartDate)
                    .HasColumnType("date")
                    .HasColumnName("schd_duration_start_date");

                entity.Property(e => e.SchdFrequencey)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("schd_frequencey");

                entity.Property(e => e.SchdIsEnabled)
                    .IsRequired()
                    .HasColumnName("schd_is_enabled")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SchdMonthlyDay).HasColumnName("schd_monthly_day");

                entity.Property(e => e.SchdWeeklyFriday).HasColumnName("schd_weekly_friday");

                entity.Property(e => e.SchdWeeklyMonday).HasColumnName("schd_weekly_monday");

                entity.Property(e => e.SchdWeeklySaturday).HasColumnName("schd_weekly_saturday");

                entity.Property(e => e.SchdWeeklySunday).HasColumnName("schd_weekly_sunday");

                entity.Property(e => e.SchdWeeklyThursday).HasColumnName("schd_weekly_thursday");

                entity.Property(e => e.SchdWeeklyTuesday).HasColumnName("schd_weekly_tuesday");

                entity.Property(e => e.SchdWeeklyWednesday).HasColumnName("schd_weekly_wednesday");
            });

            modelBuilder.Entity<ServersDatum>(entity =>
            {
                entity.HasKey(e => e.ServerId);

                entity.ToTable("servers_data");

                entity.Property(e => e.ServerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("server_id");

                entity.Property(e => e.ConnDomainName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("conn_domain_name");

                entity.Property(e => e.ConnUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("conn_user_name");

                entity.Property(e => e.ConnUserPassword)
                    .HasMaxLength(150)
                    .HasColumnName("conn_user_password");

                entity.Property(e => e.DeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("delete_dt");

                entity.Property(e => e.DeleteUserId).HasColumnName("delete_user_id");

                entity.Property(e => e.HostName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("host_name");

                entity.Property(e => e.InsertDt)
                    .HasColumnType("datetime")
                    .HasColumnName("insert_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUserId).HasColumnName("insert_user_id");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ip_address");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsCurrentMachine).HasColumnName("is_current_machine");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.OsName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("os_name");

                entity.Property(e => e.ServerDescription)
                    .HasMaxLength(250)
                    .HasColumnName("server_description");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("server_name");

                entity.Property(e => e.UpdateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("update_dt");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");
            });

            modelBuilder.Entity<ServersUpdate>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("servers_updates");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.CpuCoresCount).HasColumnName("cpu_cores_count");

                entity.Property(e => e.CpuCoresEnabledCount).HasColumnName("cpu_cores_enabled_count");

                entity.Property(e => e.CpuLogicalProcessorsCount).HasColumnName("cpu_logical_processors_count");

                entity.Property(e => e.CpuMaxClockSpeed).HasColumnName("cpu_max_clock_speed");

                entity.Property(e => e.CpuProcessorId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cpu_processor_id");

                entity.Property(e => e.CpuProcessorName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cpu_processor_name");

                entity.Property(e => e.MemoryTotal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("memory_total");

                entity.Property(e => e.ServerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("server_id");

                entity.Property(e => e.StorageTotal)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("storage_total");

                entity.Property(e => e.SysIpAddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sys_ip_address");

                entity.Property(e => e.SysSystemName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("sys_system_name");

                entity.Property(e => e.TransactionDt)
                    .HasColumnType("datetime")
                    .HasColumnName("transaction_dt");
            });

            modelBuilder.Entity<SetCounter>(entity =>
            {
                entity.HasKey(e => e.CounterId);

                entity.ToTable("set_counters");

                entity.Property(e => e.CounterId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("counter_id");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("category_name");

                entity.Property(e => e.CounterDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("counter_description");

                entity.Property(e => e.CounterName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("counter_name");

                entity.Property(e => e.CounterUnit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("counter_unit");

                entity.Property(e => e.DisplayOrder)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("display_order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InstanceAllPrefix)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("instance_all_prefix");

                entity.Property(e => e.InstanceBlankName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("instance_blank_name");

                entity.Property(e => e.InstanceTotalName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("instance_total_name");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SetCountersCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("set_counters_categories");

                entity.Property(e => e.CategoryDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("category_description");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("category_name");

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("display_order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SetSerialno>(entity =>
            {
                entity.HasKey(e => e.IdentifierId);

                entity.ToTable("set_serialno");

                entity.Property(e => e.IdentifierId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("identifier_id");

                entity.Property(e => e.SerialnoValue).HasColumnName("serialno_value");
            });

            modelBuilder.Entity<XxCountersTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xx_counters_transactions");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category_name");

                entity.Property(e => e.CounterDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("counter_datetime");

                entity.Property(e => e.CounterName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("counter_name");

                entity.Property(e => e.CounterValue).HasColumnName("counter_value");

                entity.Property(e => e.InstanceName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("instance_name");

                entity.Property(e => e.MachineName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("machine_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
