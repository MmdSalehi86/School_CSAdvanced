//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School.DataAccess.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Lesson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Lesson()
        {
            this.Tbl_Register = new HashSet<Tbl_Register>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string ss { get; set; }
        public string PcName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Register> Tbl_Register { get; set; }
    }
}