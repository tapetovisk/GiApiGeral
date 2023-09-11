using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_MovtoBanco : BaseTB
    {
        public int CodigoMovimento { get; set; }

        [DefaultValue(0)]
        public int? Banco { get; set; }

        [DefaultValue("")]
        public string? Agencia { get; set; }

        [DefaultValue("")]
        public string? Conta { get; set; }

        [DefaultValue("")]
        public string? CodigoDespesa { get; set; }

        [DefaultValue(0)]
        public int? CodigoHistorico { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(18,0)")]
        public decimal? NumDoc { get; set; }

        [DefaultValue("")]
        public string? TipoLcto { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(15,2)")]
        public decimal? ValorDoc { get; set; }

        public DateTime? DataEmissao { get; set; }

        public DateTime? DataDocumento { get; set; }

        [DefaultValue("")]
        public string? DataCompetencia { get; set; }

        [DefaultValue("")]
        public string? Flag { get; set; }

        [DefaultValue("")]
        public string? Observacao { get; set; }

        [DefaultValue("")]
        public string? ContaDebito { get; set; }

        [DefaultValue("")]
        public string? ContaCredito { get; set; }

        [DefaultValue(0)]
        public int? NumeroTitulo { get; set; }

        [DefaultValue("")]
        public string? TipoMovto { get; set; }

        [DefaultValue(0)]
        public int? CodigoEmpresaCus { get; set; }

        [DefaultValue(0)]
        public int? CodigoFilialCus { get; set; }

        [DefaultValue(0)]
        public int? CodigoFornecedorCus { get; set; }

        [DefaultValue("")]
        public string? TransfCpa { get; set; }

        [DefaultValue(1)]
        public bool Automatico { get; set; }

        [DefaultValue(0)]
        public int IdOrigem { get; set; }

        public DateTime? DataInclusao { get; set; }

        public DateTime? DataVencto { get; set; }

        [DefaultValue(0)]
        public bool? BaixaIntegrada { get; set; }

        [DefaultValue("")]
        public string? FormularioOrigem { get; set; }

        [DefaultValue(0)]
        public int CodigoBanco { get; set; }

        [DefaultValue(0)]
        public int? CodigoCentroCusto { get; set; }

        [DefaultValue(0)]
        public short? CodigoCR { get; set; }

        [DefaultValue(0)]
        public int? NumeroAP { get; set; }

        public string? BDOrigem { get; set; }

        [DefaultValue(0)]
        public int? CodigoCliente { get; set; }

        [DefaultValue(0)]
        public short? CodigoContrato { get; set; }

        [DefaultValue(0)]
        public short? TipoFat { get; set; }

        [DefaultValue(0)]
        public short? CentroCustoContab { get; set; }
    }

    public class TB_MovtoBanco_old : BaseTB
    {
        public int CodigoMovimento { get; set; }
        public int Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string CodigoDespesa { get; set; }
        public int CodigoHistorico { get; set; }
        public decimal NumDoc { get; set; }
        public string TipoLcto { get; set; }
        public decimal ValorDoc { get; set; }
        public DateTime? DataEmissao { get; set; }
        public DateTime? DataDocumento { get; set; }
        public string DataCompetencia { get; set; }
        public string Flag { get; set; }
        public string Observacao { get; set; }
        public string ContaDebito { get; set; }
        public string ContaCredito { get; set; }
        public int NumeroTitulo { get; set; }
        public string TipoMovto { get; set; }
        public int CodigoEmpresaCus { get; set; }
        public int CodigoFilialCus { get; set; }
        public int CodigoFornecedorCus { get; set; }
        public string TransfCpa { get; set; }
        public bool Automatico { get; set; }
        public int IdOrigem { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataVencto { get; set; }
        public bool BaixaIntegrada { get; set; }
        public string FormularioOrigem { get; set; }
        public int CodigoBanco { get; set; }
        public int CodigoCentroCusto { get; set; }
        public int CodigoCR { get; set; }
        public int NumeroAP { get; set; }
        public string BDOrigem { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoContrato { get; set; }
        public int TipoFat { get; set; }
        public int CentroCustoContab { get; set; }
    }
}
