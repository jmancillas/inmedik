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
    
    public partial class Concept
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Concept()
        {
            this.AlmBranchBillingTransaction = new HashSet<AlmBranchBillingTransaction>();
            this.AlmBranchRequestConfirmedTransaction = new HashSet<AlmBranchRequestConfirmedTransaction>();
            this.AlmBranchRequestDeliveredTransaction = new HashSet<AlmBranchRequestDeliveredTransaction>();
            this.AlmBranchRequestRejectedTransaction = new HashSet<AlmBranchRequestRejectedTransaction>();
            this.AlmBranchRequestResponseTransaction = new HashSet<AlmBranchRequestResponseTransaction>();
            this.AlmBranchRequestToDeliveryTransaction = new HashSet<AlmBranchRequestToDeliveryTransaction>();
            this.AlmBranchRequestTransaction = new HashSet<AlmBranchRequestTransaction>();
            this.AlmDropStockProducts = new HashSet<AlmDropStockProducts>();
            this.AlmInvoiceTransaction = new HashSet<AlmInvoiceTransaction>();
            this.AlmRecordTransactionInvoice = new HashSet<AlmRecordTransactionInvoice>();
            this.AlmReturnProducts = new HashSet<AlmReturnProducts>();
            this.AlmStock = new HashSet<AlmStock>();
            this.AlmSupplierRequestConfirmedTransaction = new HashSet<AlmSupplierRequestConfirmedTransaction>();
            this.AlmSupplierRequestDeliveredTransaction = new HashSet<AlmSupplierRequestDeliveredTransaction>();
            this.AlmSupplierRequestRejectedTransaction = new HashSet<AlmSupplierRequestRejectedTransaction>();
            this.AlmSupplierRequestResponseTransaction = new HashSet<AlmSupplierRequestResponseTransaction>();
            this.AlmSupplierRequestToDeliveryTransaction = new HashSet<AlmSupplierRequestToDeliveryTransaction>();
            this.AlmSupplierRequestTransaction = new HashSet<AlmSupplierRequestTransaction>();
            this.AuditDetail = new HashSet<AuditDetail>();
            this.CartConcepts = new HashSet<CartConcepts>();
            this.CostInBranch = new HashSet<CostInBranch>();
            this.Product = new HashSet<Product>();
            this.Consult = new HashSet<Consult>();
            this.DiscountConcept = new HashSet<DiscountConcept>();
            this.EvolutionNote = new HashSet<EvolutionNote>();
            this.Exam = new HashSet<Exam>();
            this.InternmentMaterial = new HashSet<InternmentMaterial>();
            this.InvoiceMovement = new HashSet<InvoiceMovement>();
            this.IReturnProducts = new HashSet<IReturnProducts>();
            this.OrdersConcepts = new HashSet<OrdersConcepts>();
            this.PackageConcept = new HashSet<PackageConcept>();
            this.Product1 = new HashSet<Product>();
            this.RecordTransactionInvoice = new HashSet<RecordTransactionInvoice>();
            this.RequestedMaterial = new HashSet<RequestedMaterial>();
            this.Service = new HashSet<Service>();
            this.ServiceOld = new HashSet<ServiceOld>();
            this.Stock = new HashSet<Stock>();
            this.tabletCartConcepts = new HashSet<tabletCartConcepts>();
            this.Test = new HashSet<Test>();
            this.WarehouseSuply = new HashSet<WarehouseSuply>();
        }
    
        public int id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public decimal MinPrice { get; set; }
        public decimal BasePrice { get; set; }
        public decimal Discount { get; set; }
        public bool Deleted { get; set; }
        public bool Iva { get; set; }
        public bool IsWarehouse { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmBranchBillingTransaction> AlmBranchBillingTransaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmBranchRequestConfirmedTransaction> AlmBranchRequestConfirmedTransaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmBranchRequestDeliveredTransaction> AlmBranchRequestDeliveredTransaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmBranchRequestRejectedTransaction> AlmBranchRequestRejectedTransaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmBranchRequestResponseTransaction> AlmBranchRequestResponseTransaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmBranchRequestToDeliveryTransaction> AlmBranchRequestToDeliveryTransaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmBranchRequestTransaction> AlmBranchRequestTransaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmDropStockProducts> AlmDropStockProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmInvoiceTransaction> AlmInvoiceTransaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmRecordTransactionInvoice> AlmRecordTransactionInvoice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmReturnProducts> AlmReturnProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmStock> AlmStock { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmSupplierRequestConfirmedTransaction> AlmSupplierRequestConfirmedTransaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmSupplierRequestDeliveredTransaction> AlmSupplierRequestDeliveredTransaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmSupplierRequestRejectedTransaction> AlmSupplierRequestRejectedTransaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmSupplierRequestResponseTransaction> AlmSupplierRequestResponseTransaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmSupplierRequestToDeliveryTransaction> AlmSupplierRequestToDeliveryTransaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlmSupplierRequestTransaction> AlmSupplierRequestTransaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AuditDetail> AuditDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CartConcepts> CartConcepts { get; set; }
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostInBranch> CostInBranch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consult> Consult { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountConcept> DiscountConcept { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EvolutionNote> EvolutionNote { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exam> Exam { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InternmentMaterial> InternmentMaterial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceMovement> InvoiceMovement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IReturnProducts> IReturnProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersConcepts> OrdersConcepts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PackageConcept> PackageConcept { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecordTransactionInvoice> RecordTransactionInvoice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestedMaterial> RequestedMaterial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service> Service { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceOld> ServiceOld { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock> Stock { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tabletCartConcepts> tabletCartConcepts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Test> Test { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WarehouseSuply> WarehouseSuply { get; set; }
    }
}
