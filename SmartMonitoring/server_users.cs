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
    
    public partial class server_users
    {
        public int id { get; set; }
        public string machine_id { get; set; }
        public int user_id { get; set; }
    
        public virtual montr_machines_list montr_machines_list { get; set; }
        public virtual user user { get; set; }
    }
}