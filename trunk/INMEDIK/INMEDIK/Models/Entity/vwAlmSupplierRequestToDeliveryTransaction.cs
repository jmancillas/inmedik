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
    
    public partial class vwAlmSupplierRequestToDeliveryTransaction
    {
        public int AlmSupplierRequestToDeliveryTransactionId { get; set; }
        public int AlmSupplierRequestConfirmedId { get; set; }
        public int AlmSupplierRequestConfirmedTransactionId { get; set; }
        public int AlmSupplierRequestToDeliveryId { get; set; }
        public int Id { get; set; }
        public int ConceptId { get; set; }
        public string Concept { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public decimal ToSend { get; set; }
        public System.DateTime Created { get; set; }
        public string Batch { get; set; }
        public Nullable<System.DateTime> ExpiredDate { get; set; }
        public decimal MaxPrice { get; set; }
    }
}
