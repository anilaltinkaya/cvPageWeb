//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cvPageWeb.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_CERTIFICATE
    {
        public int id { get; set; }
        public Nullable<int> placement { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string source { get; set; }
        public string certificate_name { get; set; }
        public string visible { get; set; }
        public Nullable<int> member_id { get; set; }
    }
}
