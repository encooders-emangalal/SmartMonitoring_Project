//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class montr_monitor_groups
    {
        public int group_id { get; set; }
        public string group_name { get; set; }
        public string machine_id { get; set; }
        public string group_image_id { get; set; }
        public Nullable<int> display_order { get; set; }
        public Nullable<bool> is_active { get; set; }
        public Nullable<bool> is_deleted { get; set; }
        public Nullable<int> insert_user_id { get; set; }
        public Nullable<System.DateTime> insert_dt { get; set; }
        public Nullable<int> update_user_id { get; set; }
        public Nullable<System.DateTime> update_dt { get; set; }
        public Nullable<int> delete_user_id { get; set; }
        public Nullable<System.DateTime> delete_dt { get; set; }
    }
}
