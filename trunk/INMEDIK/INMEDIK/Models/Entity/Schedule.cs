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
    
    public partial class Schedule
    {
        public int EmployeeId { get; set; }
        public int DayOfWeekId { get; set; }
        public int HourOfDayId { get; set; }
    
        public virtual DayOfWeek DayOfWeek { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual HoursOfDay HoursOfDay { get; set; }
    }
}
