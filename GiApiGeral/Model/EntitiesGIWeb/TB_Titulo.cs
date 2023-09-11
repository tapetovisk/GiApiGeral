using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_Titulo : BaseTB
    {
        public int NumeroTitulo { get; set; }

        [DefaultValue(0)]
        public short? CodigoEmpresa { get; set; }

        [DefaultValue(0)]
        public short? CodigoFilial { get; set; }

        [DefaultValue(0)]
        public int? ClienteFornec { get; set; }

        [DefaultValue('C')]
        public string? TipoCliFor { get; set; }

        [DefaultValue(0)]
        public int? Titulo { get; set; }

        [DefaultValue(0)]
        public int? OrdemTitulo { get; set; }

        [DefaultValue(0)]
        public short? CodigoContrato { get; set; }

        [DefaultValue(0)]
        public short? TipoFat { get; set; }

        [DefaultValue("")]
        public string? Despesa { get; set; }

        [DefaultValue(0)]
        public short? CodigoBanco { get; set; }

        [DefaultValue(0)]
        public int? CodigoHistorico { get; set; }

        [DefaultValue("")]
        public string? DescHistorico { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(18,0)")]
        public decimal? Cheque { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(18,0)")]
        public decimal? Cheque2 { get; set; }

        [DefaultValue(0)]
        public short? CodigoEmpresaFun { get; set; }

        [DefaultValue(0)]
        public short? CodigoFilialFun { get; set; }

        [DefaultValue(0)]
        public int? CodigoFuncionario { get; set; }

        [DefaultValue(0)]
        public int? CodigoCentroCusto { get; set; }

        [DefaultValue(0)]
        public int? Ficha { get; set; }

        [DefaultValue("")]
        public string? Tipocalculo { get; set; }

        [DefaultValue("")]
        public string? Status { get; set; }

        public DateTime? DataEmissao { get; set; }

        public DateTime? DataVecto { get; set; }

        public DateTime? DataBaixa { get; set; }

        [DefaultValue("")]
        public string? DataCompetencia { get; set; }

        [DefaultValue(0)]
        public double? ValorTitulo { get; set; }

        [DefaultValue(0)]
        public double? ValorJuros { get; set; }

        [DefaultValue(0)]
        public double? ValorDesconto { get; set; }

        [DefaultValue(0)]
        public double? ValorMulta { get; set; }

        [DefaultValue(0)]
        public double? ValorBaixa { get; set; }

        [DefaultValue("")]
        public string? NumPedido { get; set; }

        [DefaultValue("")]
        public string? Portador { get; set; }

        [DefaultValue(0)]
        public int? NumOrdem { get; set; }

        [DefaultValue("")]
        public string? Rateio { get; set; }

        [DefaultValue(0)]
        public double? PorcentagemRateio { get; set; }

        [DefaultValue(0)]
        public short? CodigoBancoOri { get; set; }

        [DefaultValue("")]
        public string? NumeroTituloPrincipal { get; set; }

        public DateTime? DataCadastro { get; set; }

        [DefaultValue("")]
        public string? Duplicata { get; set; }

        [DefaultValue(0)]
        public int? Lote { get; set; }

        [DefaultValue("")]
        public string? CompetenciaCalculo { get; set; }

        [DefaultValue(0)]
        public double? ValorBaseTitulo { get; set; }

        [DefaultValue("")]
        public string? TituloTransferencia { get; set; }

        [DefaultValue("")]
        public string? TipoBeneficio { get; set; }

        [DefaultValue("")]
        public string? Previsao { get; set; }

        [DefaultValue("")]
        public string? TemIRF { get; set; }

        [DefaultValue("")]
        public string? TemISS { get; set; }

        [DefaultValue(0)]
        public double? ValorIrf { get; set; }

        [DefaultValue(0)]
        public double? ValorIss { get; set; }

        [DefaultValue(0)]
        public int? NumeroTituloEntrada { get; set; }

        [DefaultValue("")]
        public string? TemInss { get; set; }

        [DefaultValue(0)]
        public double? ValorInss { get; set; }

        [DefaultValue("")]
        public string? CodigodeBarra { get; set; }

        [DefaultValue("")]
        public string? Observacao { get; set; }

        [DefaultValue("")]
        public string? ObsPagtoEletronico { get; set; }

        [DefaultValue("")]
        public string? NaturezaOperacao { get; set; }

        [DefaultValue(0)]
        public int? BancoTransferencia { get; set; }

        [DefaultValue("")]
        public string? TemInssPatronal { get; set; }

        public double? ValorInssPatronal { get; set; }

        [DefaultValue("")]
        public string TemCOF { get; set; }

        [DefaultValue(0)]
        public double ValorCOF { get; set; }

        [DefaultValue("")]
        public string TemPIS { get; set; }

        [DefaultValue(0)]
        public double ValorPIS { get; set; }

        [DefaultValue("")]
        public string TemCSLL { get; set; }

        [DefaultValue(0)]
        public double ValorCSLL { get; set; }

        [DefaultValue(0)]
        public bool TituloInterno { get; set; }

        [DefaultValue(0)]
        public int IdOrigem { get; set; }

        [DefaultValue(0)]
        public double ValorPrevisao { get; set; }

        [DefaultValue(0)]
        public short NroParcelaEmprestimo { get; set; }

        [DefaultValue("")]
        public string NroContratoEmprestimo { get; set; }

        [DefaultValue(0)]
        public short QtdeParcelas { get; set; }

        [DefaultValue("")]
        public string TipoCtaBanco { get; set; }

        [DefaultValue("")]
        public string? IDSistemaAnterior { get; set; }

        [DefaultValue(0)]
        public bool FiltroOrdemPagto { get; set; }

        [DefaultValue(0)]
        public int IdCaixinha { get; set; }

        [DefaultValue("")]
        public string? FormularioOrigem { get; set; }

        [DefaultValue("")]
        public string Usuario_Lib01 { get; set; }

        [DefaultValue("")]
        public string Usuario_Lib02 { get; set; }

        [DefaultValue("")]
        public string Usuario_Lib03 { get; set; }

        [DefaultValue("")]
        public string Usuario_Lib04 { get; set; }

        [DefaultValue("")]
        public string Usuario_Lib05 { get; set; }

        [DefaultValue("")]
        public string Usuario_Lib06 { get; set; }

        [DefaultValue("")]
        public string Usuario_Lib07 { get; set; }

        [DefaultValue("")]
        public string Usuario_Lib08 { get; set; }

        [DefaultValue("")]
        public string Usuario_Lib09 { get; set; }

        public DateTime? DataLiberacao { get; set; }

        [DefaultValue("")]
        public string OBSLiberacao { get; set; }

        [DefaultValue(0)]
        public short? CodigoPensionista { get; set; }

        [DefaultValue(0)]
        public int? NumeroBcoTitulo { get; set; }

        [DefaultValue("")]
        public string? TipoMskTitulo { get; set; }

        [DefaultValue("")]
        public string? AgenciaTitulo { get; set; }

        [DefaultValue("")]
        public string? ContaTitulo { get; set; }

        [DefaultValue(0)]
        public int? IdEstoque { get; set; }

        [DefaultValue(0)]
        public int? NumeroTituloParcelamento { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal? ValorAntecipado { get; set; }

        [DefaultValue(0)]
        public int? IDTituloAntecipado { get; set; }

        [DefaultValue("")]
        public string? LinhaDigitavel { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(11,2)")]
        public decimal? ValorRateioInsumo { get; set; }

        [DefaultValue(0)]
        public bool? RemessaEletronica { get; set; }

        [DefaultValue(0)]
        public bool? RetornoProcessado { get; set; }

        [DefaultValue(0)]
        public bool? ProvisaoIntegrada { get; set; }

        [DefaultValue(0)]
        public bool? BaixaIntegrada { get; set; }

        [DefaultValue(0)]
        public short? CodigoSindicato { get; set; }

        [DefaultValue(0)]
        public int? CodigoDocumento { get; set; }

        [DefaultValue("")]
        public string? CodigoDepto { get; set; }

        [DefaultValue(0)]
        public short? CodigoEventoFat { get; set; }

        [DefaultValue(0)]
        public int? IdMovtoFat { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal? ValorFat { get; set; }

        [DefaultValue("")]
        public string? SituacaoWeb { get; set; }

        [DefaultValue("")]
        public string? StatusWeb { get; set; }

        [DefaultValue(0)]
        public short? CodigoCR { get; set; }

        [DefaultValue(0)]
        public short? NaoIntegraBaixaCNT { get; set; }

        [DefaultValue(0)]
        public int? CodigoFuncionarioPortal { get; set; }

        [DefaultValue(0)]
        public int? IdTituloPortal { get; set; }

        [DefaultValue(0)]
        public int? IdTituloReembolso { get; set; }

        [DefaultValue(0)]
        public short? CodigoCRJD { get; set; }

        [DefaultValue("")]
        public string? CompetenciaFat { get; set; }

        [DefaultValue("")]
        public string? NomeColaboradorWeb { get; set; }

        [DefaultValue(0)]
        public int? CentroCustoContabil { get; set; }

        [DefaultValue("")]
        public string? IdRemessa { get; set; }

        [DefaultValue("")]
        public string? AutenticacaoBancaria { get; set; }

        public DateTime? DataLimitePagto { get; set; }

        [DefaultValue(0)]
        public int? NumeroAP { get; set; }

        [DefaultValue(0)]
        public bool? FlagAdto { get; set; }

        [DefaultValue(0)]
        public int? CodigoUsuarioInclusao { get; set; }

        [DefaultValue(0)]
        public int? NumeroAPPrestacaoContas { get; set; }

        [DefaultValue(0)]
        public byte? FaturaRateio { get; set; }

        [DefaultValue(0)]
        public int? IdTituloDesctouAdto { get; set; }

        public DateTime? DataVectoOriginal { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(11,2)")]
        public decimal? ValorDesctoAdtoForn { get; set; }

        [DefaultValue("")]
        public string? TipoImposto { get; set; }

        public string? BDOrigem { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(11,2)")]
        public decimal? ValorBaseInss { get; set; }

        [DefaultValue("")]
        public string? MotivoCancelamento { get; set; }

        public DateTime? DataCancelamento { get; set; }

        [DefaultValue(0)]
        public int? UsuarioCancelamento { get; set; }

        [DefaultValue(0)]
        public bool? FlagRejeitado { get; set; }

        [DefaultValue("")]
        public string? ObsRejeitado { get; set; }

        public DateTime? DataRejeitado { get; set; }

        [DefaultValue("")]
        public string? ChaveDocFiscal { get; set; }

        [DefaultValue('0')]
        public short? TipoEntradaSaidaEFD { get; set; }

        [DefaultValue("")]
        public string? CodModeloDoctoEFD { get; set; }

        [DefaultValue("")]
        public string? SerieNF { get; set; }

        [DefaultValue('0')]
        public short? TipoPagtoNFEFD { get; set; }

        [DefaultValue('0')]
        public short? TipoFreteEFD { get; set; }

        [DefaultValue("")]
        public string? LacreConectividade { get; set; }

        [DefaultValue(0)]
        public long? IdGrupoGPS { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal? ValorJurosFiscais { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal? ValorAbatimento { get; set; }

        [DefaultValue(0)]
        public bool APISinc { get; set; }
    }

    public class TB_Titulo_old : BaseTB
    {
        public int NumeroTitulo { get; set; }
        public short CodigoEmpresa { get; set; }
        public short CodigoFilial { get; set; }
        public int ClienteFornec { get; set; }
        public string TipoCliFor { get; set; }
        public int Titulo { get; set; }
        public int OrdemTitulo { get; set; }
        public short CodigoContrato { get; set; }
        public short TipoFat { get; set; }
        public string Despesa { get; set; }
        public short CodigoBanco { get; set; }
        public int CodigoHistorico { get; set; }
        public string DescHistorico { get; set; }
        public decimal Cheque { get; set; }
        public decimal Cheque2 { get; set; }
        public short CodigoEmpresaFun { get; set; }
        public short CodigoFilialFun { get; set; }
        public int CodigoFuncionario { get; set; }
        public int CodigoCentroCusto { get; set; }
        public int Ficha { get; set; }
        public string Tipocalculo { get; set; }
        public string Status { get; set; }
        public DateTime? DataEmissao { get; set; }
        public DateTime? DataVecto { get; set; }
        public DateTime? DataBaixa { get; set; }
        public string DataCompetencia { get; set; }
        public double ValorTitulo { get; set; }
        public double ValorJuros { get; set; }
        public double ValorDesconto { get; set; }
        public double ValorMulta { get; set; }
        public double ValorBaixa { get; set; }
        public string NumPedido { get; set; }
        public string Portador { get; set; }
        public int NumOrdem { get; set; }
        public string Rateio { get; set; }
        public double PorcentagemRateio { get; set; }
        public short CodigoBancoOri { get; set; }
        public string NumeroTituloPrincipal { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string Duplicata { get; set; }
        public int Lote { get; set; }
        public string CompetenciaCalculo { get; set; }
        public double ValorBaseTitulo { get; set; }
        public string TituloTransferencia { get; set; }
        public string TipoBeneficio { get; set; }
        public string Previsao { get; set; }
        public string TemIRF { get; set; }
        public string TemISS { get; set; }
        public double ValorIrf { get; set; }
        public double ValorIss { get; set; }
        public int NumeroTituloEntrada { get; set; }
        public string TemInss { get; set; }
        public double ValorInss { get; set; }
        public string CodigodeBarra { get; set; }
        public string Observacao { get; set; }
        public string ObsPagtoEletronico { get; set; }
        public string NaturezaOperacao { get; set; }
        public int BancoTransferencia { get; set; }
        public string TemInssPatronal { get; set; }
        public double ValorInssPatronal { get; set; }
        public string TemCOF { get; set; }
        public double ValorCOF { get; set; }
        public string TemPIS { get; set; }
        public double ValorPIS { get; set; }
        public string TemCSLL { get; set; }
        public double ValorCSLL { get; set; }
        public bool TituloInterno { get; set; }
        public int IdOrigem { get; set; }
        public double ValorPrevisao { get; set; }
        public short NroParcelaEmprestimo { get; set; }
        public string NroContratoEmprestimo { get; set; }
        public short QtdeParcelas { get; set; }
        public string TipoCtaBanco { get; set; }
        public string IDSistemaAnterior { get; set; }
        public bool FiltroOrdemPagto { get; set; }
        public int IdCaixinha { get; set; }
        public string FormularioOrigem { get; set; }
        public string Usuario_Lib01 { get; set; }
        public string Usuario_Lib02 { get; set; }
        public string Usuario_Lib03 { get; set; }
        public string Usuario_Lib04 { get; set; }
        public string Usuario_Lib05 { get; set; }
        public string Usuario_Lib06 { get; set; }
        public string Usuario_Lib07 { get; set; }
        public string Usuario_Lib08 { get; set; }
        public string Usuario_Lib09 { get; set; }
        public DateTime? DataLiberacao { get; set; }
        public string OBSLiberacao { get; set; }
        public short CodigoPensionista { get; set; }
        public int NumeroBcoTitulo { get; set; }
        public string TipoMskTitulo { get; set; }
        public string AgenciaTitulo { get; set; }
        public string ContaTitulo { get; set; }
        public int IdEstoque { get; set; }
        public int NumeroTituloParcelamento { get; set; }
        public decimal ValorAntecipado { get; set; }
        public int IDTituloAntecipado { get; set; }
        public string LinhaDigitavel { get; set; }
        public decimal ValorRateioInsumo { get; set; }
        public bool RemessaEletronica { get; set; }
        public bool RetornoProcessado { get; set; }
        public bool ProvisaoIntegrada { get; set; }
        public bool BaixaIntegrada { get; set; }
        public short CodigoSindicato { get; set; }
        public int CodigoDocumento { get; set; }
        public string CodigoDepto { get; set; }
        public short CodigoEventoFat { get; set; }
        public int IdMovtoFat { get; set; }
        public decimal ValorFat { get; set; }
        public string SituacaoWeb { get; set; }
        public string StatusWeb { get; set; }
        public short CodigoCR { get; set; }
        public short NaoIntegraBaixaCNT { get; set; }
        public int CodigoFuncionarioPortal { get; set; }
        public int IdTituloPortal { get; set; }
        public int IdTituloReembolso { get; set; }
        public short CodigoCRJD { get; set; }
        public string CompetenciaFat { get; set; }
        public string NomeColaboradorWeb { get; set; }
        public int CentroCustoContabil { get; set; }
        public string IdRemessa { get; set; }
        public string AutenticacaoBancaria { get; set; }
        public DateTime? DataLimitePagto { get; set; }
        public int NumeroAP { get; set; }
        public bool FlagAdto { get; set; }
        public int CodigoUsuarioInclusao { get; set; }
        public int NumeroAPPrestacaoContas { get; set; }
        public int FaturaRateio { get; set; }
        public int IdTituloDesctouAdto { get; set; }
        public DateTime? DataVectoOriginal { get; set; }
        public decimal ValorDesctoAdtoForn { get; set; }
        public string TipoImposto { get; set; }
        public string BDOrigem { get; set; }
        public decimal ValorBaseInss { get; set; }
        public string MotivoCancelamento { get; set; }
        public DateTime? DataCancelamento { get; set; }
        public int UsuarioCancelamento { get; set; }
        public bool FlagRejeitado { get; set; }
        public string ObsRejeitado { get; set; }
        public DateTime? DataRejeitado { get; set; }
        public string ChaveDocFiscal { get; set; }
        public short TipoEntradaSaidaEFD { get; set; }
        public string CodModeloDoctoEFD { get; set; }
        public string SerieNF { get; set; }
        public short TipoPagtoNFEFD { get; set; }
        public short TipoFreteEFD { get; set; }
        public string LacreConectividade { get; set; }
        public Int64 IdGrupoGPS { get; set; }
        public decimal ValorJurosFiscais { get; set; }
        public decimal ValorAbatimento { get; set; }
    }
}
