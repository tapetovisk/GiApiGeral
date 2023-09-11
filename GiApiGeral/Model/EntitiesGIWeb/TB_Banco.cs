using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_Banco : BaseTB
    {
        public short CodigoBanco { get; set; }

        [DefaultValue(0)]
        public short? NumeroBanco { get; set; }

        [DefaultValue("")]
        public string? NrAgencia { get; set; }

        [DefaultValue("")]
        public string? NrConta { get; set; }

        [DefaultValue("")]
        public string? NomeBanco { get; set; }

        [DefaultValue("")]
        public string? Endereco { get; set; }

        [DefaultValue("")]
        public string? Cidade { get; set; }

        [DefaultValue("")]
        public string? Estado { get; set; }

        [DefaultValue("00000-000")]
        public string? Cep { get; set; }

        [DefaultValue("")]
        public string? Bairro { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(18,0)")]
        public decimal? ChequeInicial { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(18,0)")]
        public decimal? ChequeFinal { get; set; }

        [DefaultValue("")]
        public string? ContaContabil { get; set; }

        [DefaultValue(0)]
        public int? CodigoHistCPA { get; set; }

        [DefaultValue(0)]
        public int? CodigoHistCRE { get; set; }

        [DefaultValue("")]
        public string? Telefone { get; set; }

        [DefaultValue("")]
        public string? FAX { get; set; }

        [DefaultValue(0)]
        public byte? DiasAntesPgt { get; set; }

        public DateTime? DataUltimoSaldo { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? ValorSaldo { get; set; }

        [DefaultValue(0)]
        public bool CartaoSalario { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? ValorCustoCobranca { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? ValorCustoPagamento { get; set; }

        [DefaultValue("0000")]
        public string? GrupoCustoCobranca { get; set; }

        [DefaultValue("0000")]
        public string? GrupoCustoPagamento { get; set; }

        [DefaultValue(0)]
        public bool InclusaoOk { get; set; }

        [DefaultValue(0)]
        public short? EmpresaBanco { get; set; }

        [DefaultValue(0)]
        public byte DiasPosteriorPgt { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal ValorLimite { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal ValorLimiteCaucao { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal PercentualCaucao { get; set; }

        [DefaultValue("")]
        public string CplEndereco { get; set; }

        [DefaultValue(0)]
        public bool Desativado { get; set; }

        [DefaultValue("")]
        public string ContaDebMutuo { get; set; }

        [DefaultValue("")]
        public string ContaCreMutuo { get; set; }

        [DefaultValue(0)]
        public short CodigoHistMutuo { get; set; }

        [DefaultValue("")]
        public string IDSistemaAnterior { get; set; }

        [DefaultValue(0)]
        public bool IntegraCreditoPortal { get; set; }

        [DefaultValue(0)]
        public int GrupoContas { get; set; }

        [DefaultValue(0)]
        public bool APISinc { get; set; }

        [DefaultValue(0)]
        public bool APISincExterno { get; set; }
    }

    public class TB_Banco_old : BaseTB
    {
        public short CodigoBanco { get; set; }
        public short? NumeroBanco { get; set; }
        public string NrAgencia { get; set; }
        public string NrConta { get; set; }
        public string NomeBanco { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public decimal? ChequeInicial { get; set; }
        public decimal? ChequeFinal { get; set; }
        public string ContaContabil { get; set; }
        public int? CodigoHistCPA { get; set; }
        public int? CodigoHistCRE { get; set; }
        public string Telefone { get; set; }
        public string FAX { get; set; }
        public byte? DiasAntesPgt { get; set; }
        public DateTime? DataUltimoSaldo { get; set; }
        public decimal? ValorSaldo { get; set; }
        public bool CartaoSalario { get; set; }
        public decimal? ValorCustoCobranca { get; set; }
        public decimal? ValorCustoPagamento { get; set; }
        public string GrupoCustoCobranca { get; set; }
        public string GrupoCustoPagamento { get; set; }
        public bool InclusaoOk { get; set; }
        public short? EmpresaBanco { get; set; }
        public byte DiasPosteriorPgt { get; set; }
        public decimal ValorLimite { get; set; }
        public decimal ValorLimiteCaucao { get; set; }
        public decimal PercentualCaucao { get; set; }
        public string CplEndereco { get; set; }
        public bool Desativado { get; set; }
        public string ContaDebMutuo { get; set; }
        public string ContaCreMutuo { get; set; }
        public short CodigoHistMutuo { get; set; }
        public string IDSistemaAnterior { get; set; }
        public bool IntegraCreditoPortal { get; set; }
        public int GrupoContas { get; set; }
    }
}
