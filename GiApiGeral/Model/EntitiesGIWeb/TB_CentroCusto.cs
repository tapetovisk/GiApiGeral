using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_CentroCusto : BaseTB
    {
        public int CodigoCliente { get; set; }

        public int CodigoCentroCusto { get; set; }

        [DefaultValue("")]
        public string? NomeCentroCusto { get; set; }

        [DefaultValue("")]
        public string? Observacao { get; set; }

        [DefaultValue(0)]
        public bool InclusaoOK { get; set; }

        [DefaultValue("")]
        public string Endereco { get; set; }

        [DefaultValue(0)]
        public int NroEndereco { get; set; }

        [DefaultValue("")]
        public string CplEndereco { get; set; }

        [DefaultValue("")]
        public string Cidade { get; set; }

        [DefaultValue("")]
        public string Bairro { get; set; }

        [DefaultValue("")]
        public string UF { get; set; }

        [DefaultValue("00000-000")]
        public string CEP { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(7,4)")]
        public decimal PercentInsalub { get; set; }

        [DefaultValue(0)]
        public int QtdeMaxFun { get; set; }

        [DefaultValue(1)]
        public bool CentroCustoAtivo { get; set; }

        [DefaultValue(0)]
        public short CodigoEmpresa { get; set; }

        [DefaultValue(0)]
        public short CodigoFilial { get; set; }

        [DefaultValue(0)]
        public int CodigoFuncionario { get; set; }

        [DefaultValue("")]
        public string IdIntegracao { get; set; }

        [DefaultValue(0)]
        public bool? APISinc { get; set; }

        [DefaultValue(0)]
        public bool APISincExterno { get; set; }
    }

}
