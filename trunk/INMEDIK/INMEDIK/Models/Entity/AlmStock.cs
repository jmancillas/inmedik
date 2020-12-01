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
    
    public partial class AlmStock
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AlmStock()
        {
            this.AlmBranchRequestToDeliveryTransaction = new HashSet<AlmBranchRequestToDeliveryTransaction>();
            this.AlmDropStockProducts = new HashSet<AlmDropStockProducts>();
            this.AlmInvoiceTransaction = new HashSet<AlmInvoiceTransaction>();
            this.AlmReturnProducts = new HashSet<AlmReturnProducts>();
            this.CostInBranch = new HashSet<CostInBranch>();
            this.IReturnProducts = new HashSet<IReturnProducts>();
        }
    
        public int Id { get; set; }
        public int ConceptId { get; set; }
        public decimal InStock { get; set; }
        public bool Iva { get; set; }
        public double CurrIva { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
        public string Batch { get; set; }
        public Nullable<System.DateTime> ExpiredDate { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal Cost { get; set; }
        public Nullable<int> AlmSupplierId { get; set; }
        public string SupplierName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmBranchRequestToDeliveryTransaction> AlmBranchRequestToDeliveryTransaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmDropStockProducts> AlmDropStockProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmInvoiceTransaction> AlmInvoiceTransaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmReturnProducts> AlmReturnProducts { get; set; }
        public virtual AlmSupplier AlmSupplier { get; set; }
        public virtual Concept Concept { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostInBranch> CostInBranch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IReturnProducts> IReturnProducts { get; set; }
    }
}