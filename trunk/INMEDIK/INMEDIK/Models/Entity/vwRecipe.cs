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
    
    public partial class vwRecipe
    {
        public int NoteId { get; set; }
        public string Nombre { get; set; }
        public string ActiveSubstance { get; set; }
        public string RecipeText { get; set; }
        public string CommercialBrand { get; set; }
        public Nullable<int> DaysOfThreatment { get; set; }
        public Nullable<int> Dose { get; set; }
        public string Frequency { get; set; }
        public string Presentation { get; set; }
        public string Pronostic { get; set; }
        public string Unit { get; set; }
        public string WayOfAdministration { get; set; }
    }
}
