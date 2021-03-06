//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INMEDIK.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class WaitingTimes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WaitingTimes()
        {
            this.WaitingTimeCalc = new HashSet<WaitingTimeCalc>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> AttendingTimePatientRecS { get; set; }
        public Nullable<System.DateTime> AttendingTimePatientRecF { get; set; }
        public Nullable<System.DateTime> WaitingTimePatientRecInfS { get; set; }
        public Nullable<System.DateTime> WaitingTimePatientRecInfF { get; set; }
        public Nullable<System.DateTime> AttendingTimePatientInfS { get; set; }
        public Nullable<System.DateTime> AttendingTimePatientInfF { get; set; }
        public Nullable<System.DateTime> WaitingTimePatientInfConS { get; set; }
        public Nullable<System.DateTime> WaitingTimePatientInfConF { get; set; }
        public Nullable<System.DateTime> AttendingTimePatientConS { get; set; }
        public Nullable<System.DateTime> AttendingTimePatientConF { get; set; }
        public Nullable<int> ConsultId { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
    
        public virtual Consult Consult { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WaitingTimeCalc> WaitingTimeCalc { get; set; }
    }
}
