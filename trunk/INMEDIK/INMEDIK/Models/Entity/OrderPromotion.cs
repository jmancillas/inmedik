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
    
    public partial class OrderPromotion
    {
        public int id { get; set; }
        public int OrderId { get; set; }
        public Nullable<int> ConceptId { get; set; }
        public string TextPromotion { get; set; }
        public decimal AmountSaved { get; set; }
    
        public virtual Orders Orders { get; set; }
    }
}
