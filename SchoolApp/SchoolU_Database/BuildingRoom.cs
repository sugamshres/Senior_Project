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
    
    public partial class BuildingRoom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BuildingRoom()
        {
            this.Classes = new HashSet<Class>();
        }
    
        public int BuildingRoomId { get; set; }
        public int BuildingId { get; set; }
        public short RoomNumber { get; set; }
        public string Status__ { get; set; }
    
        public virtual Building Building { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class> Classes { get; set; }
    }
}
