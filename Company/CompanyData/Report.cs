//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Report
    {
        public int Id { get; set; }
        public System.DateTime DayWorked { get; set; }
        public int EmployeeId { get; set; }
        public System.DateTime TimeOfReporting { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}