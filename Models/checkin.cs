//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alpha.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class checkin
    {
        public int checkin_Id { get; set; }
        [Display(Name = "Nome Completo")]
        public string hospede1 { get; set; }
        [Display(Name = "Hor�rio de Check-in")]
        public System.TimeSpan horario_checkin { get; set; }
        [Display(Name = "Hor�rio de Checkout")]
        public System.TimeSpan horario_checkout { get; set; }
        [Display(Name = "N�mero do Quarto")]
        public string num_quarto1 { get; set; }
    }
}
