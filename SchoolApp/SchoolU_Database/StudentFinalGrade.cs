//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolU_Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentFinalGrade
    {
        public int StudentFinalGradesId { get; set; }
        public int StudentId { get; set; }
        public int StudentClassesId { get; set; }
        public string StudentLetterGrade { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual StudentClass StudentClass { get; set; }
    }
}
