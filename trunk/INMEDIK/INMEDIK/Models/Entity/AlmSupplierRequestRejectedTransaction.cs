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
    
    public partial class AlmSupplierRequestRejectedTransaction
    {
        public int Id { get; set; }
        public int AlmSupplierRequestRejectedId { get; set; }
        public int AlmSupplierRequestResponseTransactionId { get; set; }
        public int ConceptId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Updated { get; set; }
    
        public virtual AlmSupplierRequestRejected AlmSupplierRequestRejected { get; set; }
        public virtual Concept Concept { get; set; }
    }
}