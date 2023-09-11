using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_FuncionarioBeneficio : BaseTB
    {
        public short CodigoEmpresa { get; set; }

        public short CodigoFilial { get; set; }

        public int CodigoFuncionario { get; set; }

        [Required(ErrorMessage = "Informe o Tipo do Benefício!")]
        public byte TipoBeneficio { get; set; }

        [Required(ErrorMessage = "Informe o Código do Benefício!")]
        public short CodigoBeneficio { get; set; }

        [DefaultValue(0)]
        [Required(ErrorMessage = "Informe a Quantidade!")]
        public short? Quantidade { get; set; }

        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Maximo de 1 Caracteres.")]
        [MaxLength(1, ErrorMessage = "Maximo de 1 Caracteres.")]
        [Required(ErrorMessage = "Informe o Tipo de Pagamento!")]
        public string TipoPagto { get; set; }

        [DefaultValue(0)]
        public short QtdeFixa { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(10,0)")]
        public decimal? CodigoFuncionarioWEB { get; set; }

        [DefaultValue(0)]
        public int? QtdeBnfInformadoCod { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal? ValorBnfInformadoCod { get; set; }

        public DateTime? DataInicio { get; set; }

        public DateTime? DataFim { get; set; }

        public DateTime? DataInclusao { get; set; }

        [DefaultValue(0)]
        public bool APISinc { get; set; }

        [DefaultValue(0)]
        public bool APISincExterno { get; set; }
    }

    public class TB_FuncionarioBeneficio_old : BaseTB
    {

        public short CodigoEmpresa { get; set; }
        public short CodigoFilial { get; set; }
        public int CodigoFuncionario { get; set; }

        [Required(ErrorMessage = "Informe o Tipo do Benefício!")]
        public byte TipoBeneficio { get; set; }

        [Required(ErrorMessage = "Informe o Código do Benefício!")]
        public short CodigoBeneficio { get; set; }

        [Required(ErrorMessage = "Informe a Quantidade!")]
        [DefaultValue(0)]
        public short Quantidade { get; set; }

        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Maximo de 1 Caracteres.")]
        [MaxLength(1, ErrorMessage = "Maximo de 1 Caracteres.")]
        [Required(ErrorMessage = "Informe o Tipo de Pagamento!")]
        public string TipoPagto { get; set; }
        public short QtdeFixa { get; set; }

        [DefaultValue(0)]
        public decimal CodigoFuncionarioWEB { get; set; }

        [DefaultValue(0)]
        public int QtdeBnfInformadoCod { get; set; }

        [DefaultValue(0)]
        public decimal ValorBnfInformadoCod { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public DateTime? DataInclusao { get; set; }

    }
}
