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
    
    public partial class Skill
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public Nullable<int> EmployeeId { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
