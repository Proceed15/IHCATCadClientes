using System.ComponentModel.DataAnnotations;

namespace IHCATCadClientes.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Informe seu Nome")]
        [Display(Name = "Nome")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe sua Data de Nascimento")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Informe seu RG")]
        [Display(Name = "RG")]
        [StringLength(20)]
        public string RG { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe seu CPF")]
        [Display(Name = "CPF")]
        [StringLength(14)]
        public string CPF { get; set; } = string.Empty;

        // Endereço residencial
        [Required(ErrorMessage = "Informe seu Logradouro (Endereço)")]
        [Display(Name = "Logradouro")]
        [StringLength(200)]
        public string Logradouro { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe seu Bairro")]
        [Display(Name = "Bairro")]
        [StringLength(100)]
        public string Bairro { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe sua Cidade")]
        [Display(Name = "Cidade")]
        [StringLength(100)]
        public string Cidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o Complemento")]
        [Display(Name = "Complemento")]
        [StringLength(100)]
        public string Complemento { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe sua Unidade Federativa")]
        [Display(Name = "UF")]
        [StringLength(2)]
        public string UF { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe seu CEP")]
        [Display(Name = "CEP")]
        [StringLength(9)]
        public string CEP { get; set; } = string.Empty;
        // fim do Endereço Residencial

        [Required(ErrorMessage = "Informe seu Estado Civil")]
        [Display(Name = "Estado Civil")]
        public EstadoCivil EstadoCivil { get; set; }

        [Required(ErrorMessage = "Informe o Nome do seu Pai")]
        [Display(Name = "Nome do Pai")]
        [StringLength(100)]
        public string NomePai { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o Nome de sua Mãe")]
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
