//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database_Layer
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobApply
    {
        public int JobAppliedId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<System.DateTime> JobApplyDateTime { get; set; }
        public Nullable<int> JobApplyStatusId { get; set; }
        public Nullable<System.DateTime> JobApplyStatusUpdatedDate { get; set; }
        public string JobApplyStatusUpdatedReason { get; set; }
        public Nullable<int> PostJobId { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Employee Employee1 { get; set; }
        public virtual JobApplyStatu JobApplyStatu { get; set; }
        public virtual PostJob PostJob { get; set; }
    }
}
