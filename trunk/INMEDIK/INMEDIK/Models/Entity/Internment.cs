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
    
    public partial class Internment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Internment()
        {
            this.InternmentMaterial = new HashSet<InternmentMaterial>();
            this.MedicalIndication = new HashSet<MedicalIndication>();
            this.MedicalNotes = new HashSet<MedicalNotes>();
            this.NurserySummary = new HashSet<NurserySummary>();
        }
    
        public int id { get; set; }
        public int OrderId { get; set; }
        public int PatientId { get; set; }
        public int PackageId { get; set; }
        public System.DateTime InternmentDate { get; set; }
        public string Room { get; set; }
        public int ClinicId { get; set; }
    
        public virtual Clinic Clinic { get; set; }
        public virtual Orders Orders { get; set; }
        public virtual Package Package { get; set; }
        public virtual Patient Patient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InternmentMaterial> InternmentMaterial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalIndication> MedicalIndication { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalNotes> MedicalNotes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NurserySummary> NurserySummary { get; set; }
    }
}
