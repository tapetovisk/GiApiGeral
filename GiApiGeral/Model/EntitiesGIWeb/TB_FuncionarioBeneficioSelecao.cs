using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_FuncionarioBeneficioSelecao : BaseTB
    {
        public short CodigoEmpresa { get; set; }

        public short CodigoFilial { get; set; }

        public int CodigoFuncionario { get; set; }

        public byte TipoBeneficio { get; set; }

        public short CodigoBeneficio { get; set; }

        [DefaultValue(0)]
        public short? Quantidade { get; set; }

        [DefaultValue("")]
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

    public class TB_FuncionarioBeneficioSelecao_old : BaseTB
    {
        public short CodigoEmpresa { get; set; }
        public short CodigoFilial { get; set; }
        public int CodigoFuncionario { get; set; }
        public byte TipoBeneficio { get; set; }
        public short CodigoBeneficio { get; set; }
        public short? Quantidade { get; set; }
        public string TipoPagto { get; set; }
        public short QtdeFixa { get; set; }
        public decimal? CodigoFuncionarioWEB { get; set; }
        public int? QtdeBnfInformadoCod { get; set; }
        public decimal? ValorBnfInformadoCod { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public DateTime? DataInclusao { get; set; }
    }
}
