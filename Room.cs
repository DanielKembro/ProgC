//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProgramConstruction
{
    using System;
    using System.Collections.Generic;
    
    public partial class Room
    {
        public Room(string Name, int IId)
        {
            this.Name = Name;
            this.IId = IId;
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            this.People = new HashSet<Person>();
        }
    
        public int Nr { get; set; }
        public string Name { get; set; }
        public Nullable<int> IId { get; set; }
    
        public virtual Institution Institution { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> People { get; set; }
    }
}
