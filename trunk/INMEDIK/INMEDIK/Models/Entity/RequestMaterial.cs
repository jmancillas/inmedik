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
    
    public partial class RequestMaterial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RequestMaterial()
        {
            this.RequestedMaterial = new HashSet<RequestedMaterial>();
        }
    
        public int id { get; set; }
        public int StatusId { get; set; }
        public System.DateTime Created { get; set; }
        public int EmployeeCreatedId { get; set; }
        public System.DateTime Updated { get; set; }
        public int EmployeeUpdatedId { get; set; }
        public int ClinicId { get; set; }
    
        public virtual Clinic Clinic { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestedMaterial> RequestedMaterial { get; set; }
        public virtual Status Status { get; set; }
    }
}
