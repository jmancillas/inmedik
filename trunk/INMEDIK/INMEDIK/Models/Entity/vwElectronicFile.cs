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
    
    public partial class vwElectronicFile
    {
        public int FileId { get; set; }
        public int PatientId { get; set; }
        public string FullName { get; set; }
        public Nullable<int> ClinicId { get; set; }
        public string ClinicName { get; set; }
        public string Curp { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string Sex { get; set; }
        public string Nationality { get; set; }
        public bool Deleted { get; set; }
    }
}