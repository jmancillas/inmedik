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
    
    public partial class vwPaymentReport
    {
        public int paymentId { get; set; }
        public int paymentTypeId { get; set; }
        public string paymentTypeName { get; set; }
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public int orderId { get; set; }
        public int clinicId { get; set; }
        public string clinicName { get; set; }
        public decimal Amount { get; set; }
        public decimal Commission { get; set; }
        public Nullable<decimal> total { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<int> Ticket { get; set; }
        public bool IsCanceled { get; set; }
    }
}