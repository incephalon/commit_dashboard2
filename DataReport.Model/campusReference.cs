//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataReport.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class campusReference
    {
        public campusReference()
        {
            this.college = new HashSet<college>();
            this.noner = new HashSet<noner>();
            this.staff = new HashSet<staff>();
            this.student = new HashSet<student>();
        }
    
        public int CampusId { get; set; }
        public string CAMPUS { get; set; }
        public string CAMPNAME { get; set; }
        public string CNTYNAME { get; set; }
        public string COUNTY { get; set; }
        public string DISTNAME { get; set; }
        public string GRDSPAN { get; set; }
        public string GRDTYPE { get; set; }
    
        public virtual ICollection<college> college { get; set; }
        public virtual ICollection<noner> noner { get; set; }
        public virtual ICollection<staff> staff { get; set; }
        public virtual ICollection<student> student { get; set; }
    }
}
