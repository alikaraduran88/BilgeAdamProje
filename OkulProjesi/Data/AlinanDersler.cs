//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OkulProjesi.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class AlinanDersler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AlinanDersler()
        {
            this.Yoklamas = new HashSet<Yoklama>();
        }
    
        public int ID { get; set; }
        public string LessonID { get; set; }
        public string LessonName { get; set; }
        public int Student_Number { get; set; }
    
        public virtual Lesson Lesson { get; set; }
        public virtual Student Student { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yoklama> Yoklamas { get; set; }
    }
}