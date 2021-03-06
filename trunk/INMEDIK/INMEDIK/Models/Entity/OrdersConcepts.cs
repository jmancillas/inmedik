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
    
    public partial class OrdersConcepts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdersConcepts()
        {
            this.Consult = new HashSet<Consult>();
            this.Laboratory = new HashSet<Laboratory>();
            this.ServiceOld = new HashSet<ServiceOld>();
            this.Xray = new HashSet<Xray>();
        }
    
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ConceptId { get; set; }
        public Nullable<int> MedicId { get; set; }
        public int ClinicId { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public decimal Total { get; set; }
        public Nullable<System.DateTime> Scheduled { get; set; }
        public string Medicname { get; set; }
        public string Decree { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Updated { get; set; }
        public Nullable<int> Stockid { get; set; }
        public Nullable<decimal> Iva { get; set; }
    
        public virtual Clinic Clinic { get; set; }
        public virtual Concept Concept { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consult> Consult { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Laboratory> Laboratory { get; set; }
        public virtual Orders Orders { get; set; }
        public virtual Stock Stock { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceOld> ServiceOld { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Xray> Xray { get; set; }
    }
}
