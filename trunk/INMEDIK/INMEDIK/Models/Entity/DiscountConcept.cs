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
    
    public partial class DiscountConcept
    {
        public int id { get; set; }
        public int DiscountId { get; set; }
        public int ConceptId { get; set; }
        public decimal Percentage { get; set; }
    
        public virtual Concept Concept { get; set; }
        public virtual Discount Discount { get; set; }
    }
}