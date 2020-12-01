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
    
    public partial class AlmSupplierRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AlmSupplierRequest()
        {
            this.AlmSupplierRequestCancelled = new HashSet<AlmSupplierRequestCancelled>();
            this.AlmSupplierRequestResponse = new HashSet<AlmSupplierRequestResponse>();
            this.AlmSupplierRequestTransaction = new HashSet<AlmSupplierRequestTransaction>();
        }
    
        public int Id { get; set; }
        public int Folio { get; set; }
        public int AlmStatusId { get; set; }
        public bool Seen { get; set; }
        public bool Status { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Updated { get; set; }
    
        public virtual AlmStatus AlmStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmSupplierRequestCancelled> AlmSupplierRequestCancelled { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmSupplierRequestResponse> AlmSupplierRequestResponse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmSupplierRequestTransaction> AlmSupplierRequestTransaction { get; set; }
    }
}
