//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NMCDriveShare_v1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Schedule()
        {
            this.RideRequests = new HashSet<RideRequest>();
            this.Routes = new HashSet<Route>();
        }
    
        public int ScheduleId { get; set; }
        public bool CheckedSunday { get; set; }
        public bool CheckedMonday { get; set; }
        public bool CheckedTuesday { get; set; }
        public bool CheckedWednesday { get; set; }
        public bool CheckedThursday { get; set; }
        public bool CheckedFriday { get; set; }
        public bool CheckedSaturday { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RideRequest> RideRequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Route> Routes { get; set; }
    }
}
