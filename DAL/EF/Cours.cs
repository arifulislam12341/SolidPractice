//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cours
    {
        public Cours()
        {
            this.StudentCourses = new HashSet<StudentCours>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Deptid { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual ICollection<StudentCours> StudentCourses { get; set; }
    }
}