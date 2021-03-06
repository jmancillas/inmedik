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
    
    public partial class AlmStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AlmStatus()
        {
            this.AlmBranchRequest = new HashSet<AlmBranchRequest>();
            this.AlmBranchRequestConfirmed = new HashSet<AlmBranchRequestConfirmed>();
            this.AlmBranchRequestDelivered = new HashSet<AlmBranchRequestDelivered>();
            this.AlmBranchRequestRejected = new HashSet<AlmBranchRequestRejected>();
            this.AlmBranchRequestResponse = new HashSet<AlmBranchRequestResponse>();
            this.AlmBranchRequestToDelivery = new HashSet<AlmBranchRequestToDelivery>();
            this.AlmSupplierRequest = new HashSet<AlmSupplierRequest>();
            this.AlmSupplierRequestCancelled = new HashSet<AlmSupplierRequestCancelled>();
            this.AlmSupplierRequestConfirmed = new HashSet<AlmSupplierRequestConfirmed>();
            this.AlmSupplierRequestDelivered = new HashSet<AlmSupplierRequestDelivered>();
            this.AlmSupplierRequestRejected = new HashSet<AlmSupplierRequestRejected>();
            this.AlmSupplierRequestResponse = new HashSet<AlmSupplierRequestResponse>();
            this.AlmSupplierRequestToDelivery = new HashSet<AlmSupplierRequestToDelivery>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Updated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmBranchRequest> AlmBranchRequest { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmBranchRequestConfirmed> AlmBranchRequestConfirmed { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmBranchRequestDelivered> AlmBranchRequestDelivered { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmBranchRequestRejected> AlmBranchRequestRejected { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmBranchRequestResponse> AlmBranchRequestResponse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmBranchRequestToDelivery> AlmBranchRequestToDelivery { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmSupplierRequest> AlmSupplierRequest { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmSupplierRequestCancelled> AlmSupplierRequestCancelled { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmSupplierRequestConfirmed> AlmSupplierRequestConfirmed { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmSupplierRequestDelivered> AlmSupplierRequestDelivered { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmSupplierRequestRejected> AlmSupplierRequestRejected { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmSupplierRequestResponse> AlmSupplierRequestResponse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmSupplierRequestToDelivery> AlmSupplierRequestToDelivery { get; set; }
    }
}
