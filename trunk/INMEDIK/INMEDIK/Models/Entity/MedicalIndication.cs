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
    
    public partial class MedicalIndication
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedicalIndication()
        {
            this.Applications = new HashSet<Applications>();
        }
    
        public int id { get; set; }
        public int InternmentId { get; set; }
        public string Concept { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Updated { get; set; }
    
        public virtual Internment Internment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Applications> Applications { get; set; }
    }
}
