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

    public partial class dados_pessoais
    {
        public int dados_pessoais_Id { get; set; }
        [Display(Name = "Nome Completo")]
        public string nome { get; set; }
        [Display(Name = "Data de Nascimento")]
        public System.DateTime data_nascimento { get; set; }
        [Display(Name = "Cpf")]
        public short cpf { get; set; }
        [Display(Name = "Sexo")]
        public bool sexo { get; set; }
        [Display(Name = "Telefone")]
        public short telefone { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Rua")]
        public string rua { get; set; }
        [Display(Name = "N�mero")]
        public short numero { get; set; }
        [Display(Name = "Bairro")]
        public string bairro { get; set; }
        [Display(Name = "CEP")]
        public short cep { get; set; }
        [Display(Name = "UF")]
        public bool uf { get; set; }
        [Display(Name = "Status de Relacionamento")]
        public string status_relacionamento { get; set; }
    }
}
