using System.ComponentModel.DataAnnotations;

namespace IHCATCadClientes.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name = "Nome")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [Display(Name = "RG")]
        [StringLength(20)]
        public string RG { get; set; } = string.Empty;

        [Required]
        [Display(Name = "CPF")]
        [StringLength(14)]
        public string CPF { get; set; } = string.Empty;

        // Endereço residencial
        [Required]
        [Display(Name = "Logradouro")]
        [StringLength(200)]
        public string Logradouro { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Bairro")]
        [StringLength(100)]
        public string Bairro { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Cidade")]
        [StringLength(100)]
        public string Cidade { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Complemento")]
        [StringLength(100)]
        public string Complemento { get; set; } = string.Empty;

        [Required]
        [Display(Name = "UF")]
        [StringLength(2)]
        public string UF { get; set; } = string.Empty;

        [Required]
        [Display(Name = "CEP")]
        [StringLength(9)]
        public string CEP { get; set; } = string.Empty;
        // fim do Endereço Residencial

        [Required]
        [Display(Name = "Estado Civil")]
        public EstadoCivil EstadoCivil { get; set; }

        [Required]
        [Display(Name = "Nome do Pai")]
        [StringLength(100)]
        public string NomePai { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Nome da Mãe")]
        [StringLength(100)]
        public string NomeMae { get; set; } = string.Empty;
    }
    public enum EstadoCivil
    {
        NaoInformar = 0,
        Solteiro = 1,
        Casado = 2,
        Divorciado = 3,
        Viuvo = 4
    }

}
