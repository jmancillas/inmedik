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
    
    public partial class AlmRecordTransactionInvoice
    {
        public int RecordTransactionInvoiceId { get; set; }
        public int RecordInvoiceId { get; set; }
        public int TransactionInvoiceId { get; set; }
        public string Batch { get; set; }
        public int ConceptId { get; set; }
        public int Quantity { get; set; }
        public bool Iva { get; set; }
        public decimal Cost { get; set; }
        public decimal MaxPrice { get; set; }
        public System.DateTime ExpiredDate { get; set; }
        public string TypeOfModification { get; set; }
    
        public virtual AlmRecordInvoice AlmRecordInvoice { get; set; }
        public virtual Concept Concept { get; set; }
    }
}
