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
    
    public partial class Diagnostic
    {
        public int Id { get; set; }
        public Nullable<int> CIE10Id { get; set; }
        public Nullable<int> ElectronicFileId { get; set; }
        public string Pronostic { get; set; }
        public Nullable<int> Dose { get; set; }
        public string Presentation { get; set; }
        public string WayOfAdministration { get; set; }
        public string Frequency { get; set; }
        public Nullable<int> DaysOfThreatment { get; set; }
        public string ActiveSubstance { get; set; }
        public string CommercialBrand { get; set; }
        public string Unit { get; set; }
        public Nullable<int> ServiceId { get; set; }
        public Nullable<int> ProductId { get; set; }
    
        public virtual CIE10 CIE10 { get; set; }
        public virtual ElectronicFile ElectronicFile { get; set; }
        public virtual ProductNote ProductNote { get; set; }
        public virtual Service Service { get; set; }
    }
}