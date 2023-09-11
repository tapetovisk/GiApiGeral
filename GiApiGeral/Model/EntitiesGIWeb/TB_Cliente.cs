using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_Cliente : BaseTB
    {
        public int CodigoCliente { get; set; }

        [DefaultValue("")]
        public string? RazaoSocial { get; set; }

        [DefaultValue("")]
        public string? Endereco { get; set; }

        [DefaultValue("")]
        public string? Bairro { get; set; }

        [DefaultValue("")]
        public string? Cidade { get; set; }

        [DefaultValue("")]
        public string? UF { get; set; }

        [DefaultValue("00000-000")]
        public string? CEP { get; set; }

        [DefaultValue("")]
        public string? CaixaPostal { get; set; }

        [DefaultValue("")]
        public string? Telefone { get; set; }

        [DefaultValue("")]
        public string? FaxTelefone { get; set; }

        [DefaultValue("")]
        public string? Email { get; set; }

        [DefaultValue("")]
        public string? HTTP { get; set; }

        [DefaultValue('1')]
        public string? TipoInscricao { get; set; }

        [DefaultValue("00.000.000/0000-00")]
        public string? CGC { get; set; }

        [DefaultValue("")]
        public string? IE { get; set; }

        [DefaultValue("")]
        public string? Contato { get; set; }

        [DefaultValue(1)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? TrocoPagamento { get; set; }

        [DefaultValue(1)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? TrocoAdiantamento { get; set; }

        [DefaultValue(40)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? PercentualAdiantado { get; set; }

        [DefaultValue(0.3)]
        [Column(TypeName = "DECIMAL(12,4)")]
        public decimal? TaxaPericulosidade { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,4)")]
        public decimal? TaxaInsalubridade { get; set; }

        [DefaultValue(5)]
        public short? DiaPagamento { get; set; }

        [DefaultValue(20)]
        public short? DiaAdiantamento { get; set; }

        [DefaultValue(0)]
        public short? DiaEmissaoEtiqueta { get; set; }

        [DefaultValue(0)]
        public short? DiaFaturamento { get; set; }

        [DefaultValue(0)]
        public short? DiaFichaHorario { get; set; }

        [DefaultValue(0)]
        public int? GrupoCusto { get; set; }

        [DefaultValue(0)]
        public int? CentroCustoCNT { get; set; }

        [DefaultValue("")]
        public string? Comentario { get; set; }

        [DefaultValue('E')]
        public string? FornecVT { get; set; }

        [DefaultValue('E')]
        public string? FornecVR { get; set; }

        [DefaultValue(0)]
        public bool? FornecCesta { get; set; }

        [DefaultValue(0)]
        public bool? FornecAssitMed { get; set; }

        [DefaultValue(0)]
        public bool? FornecAssOdo { get; set; }

        [DefaultValue(1)]
        public bool? ClienteAtivo { get; set; }

        [DefaultValue(1)]
        public bool? SaldoNegSal { get; set; }

        [DefaultValue(1)]
        public bool? CAGED { get; set; }

        [DefaultValue('1')]
        public string? Op_DSRHE { get; set; }

        [DefaultValue('1')]
        public string? Op_DSRPremio { get; set; }

        [DefaultValue('1')]
        public string? Op_DSRAdc { get; set; }

        [DefaultValue('E')]
        public string? Op_TipoDescVT { get; set; }

        [DefaultValue(1)]
        public bool? Op_QtdeDiasSalario { get; set; }

        [DefaultValue(0)]
        public bool? Op_ValeAlimDiario { get; set; }

        [DefaultValue(7)]
        public int? Op_Tipo13o { get; set; }

        [DefaultValue(7)]
        public int? Op_TipoFerias { get; set; }

        [DefaultValue(0)]
        public bool? Op_BeneficioIntegral { get; set; }

        [DefaultValue(1)]
        public bool? Adt_UltDiaMes { get; set; }

        [DefaultValue('N')]
        public string? Adt_Pericul { get; set; }

        [DefaultValue(1)]
        public bool? Adt_PropDem { get; set; }

        [DefaultValue(1)]
        public bool? Adt_PropAdm { get; set; }

        [DefaultValue(1)]
        public bool? Adt_DescIRF { get; set; }

        [DefaultValue(0)]
        public bool? Adt_ArredDireto { get; set; }

        [DefaultValue(1)]
        public bool? Adt_Apenas1 { get; set; }

        public DateTime? DataInclusao { get; set; }

        public DateTime? DataAlteracao { get; set; }

        [DefaultValue("")]
        public string? PeriodoVT { get; set; }

        [DefaultValue(0)]
        public bool? GpsExclusiva { get; set; }

        [DefaultValue(1)]
        public short? BaseInsalubridade { get; set; }

        [DefaultValue("V")]
        public string? TipAdc13o { get; set; }

        [DefaultValue("V")]
        public string? TipAdcFer { get; set; }

        [DefaultValue(0)]
        public bool? PgtPer13o { get; set; }

        [DefaultValue(0)]
        public bool? PgtPerFer { get; set; }

        [DefaultValue(100)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? PerAnt13o { get; set; }

        [DefaultValue("")]
        public string? MascaraCCusto { get; set; }

        [DefaultValue("")]
        public string? NomeUsuario { get; set; }

        [DefaultValue(50)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? Per1P13o { get; set; }

        [DefaultValue(0)]
        public bool? Pgt1PAntecipacao { get; set; }

        [DefaultValue(1)]
        public bool? Mes1PTrab { get; set; }

        [DefaultValue(0)]
        public bool InclusaoOK { get; set; }

        [DefaultValue(0)]
        public bool? PagtoForaMes { get; set; }

        [DefaultValue(0)]
        public bool? Op_CCusto { get; set; }

        [DefaultValue(0)]
        public bool Divisor2P13o12 { get; set; }

        [DefaultValue(1)]
        public bool ImprimeEtiqueta { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal PercentualGratificacao { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal ValorAnuenio { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal ValorTrienio { get; set; }

        [DefaultValue(0)]
        public bool Op_ClienteInterno { get; set; }

        [DefaultValue(0)]
        public bool AdtPropFerias { get; set; }

        [DefaultValue("")]
        public string NomeRepresentante { get; set; }

        [DefaultValue("")]
        public string CargoRepresentante { get; set; }

        [DefaultValue("")]
        public string CplEndereco { get; set; }

        [DefaultValue(0)]
        public bool RecalculaSalAdto { get; set; }

        [DefaultValue("")]
        public string IDSistemaAnterior { get; set; }

        [DefaultValue(0)]
        public int CodigoCidade { get; set; }

        [DefaultValue("")]
        public string NomeSupervisor { get; set; }

        [DefaultValue("")]
        public string CargoSupervisor { get; set; }

        [DefaultValue("")]
        public string InscricaoMunicipal { get; set; }

        [DefaultValue(0)]
        public bool? Adt_PgtoAposVcto { get; set; }

        [DefaultValue(0)]
        public bool ArredondaDireto1Parcela { get; set; }

        [DefaultValue(1)]
        public bool Mes1PTrabTemp { get; set; }

        [DefaultValue(0)]
        public short EventoAdcPerAdto { get; set; }

        [DefaultValue(1)]
        public short Regiao { get; set; }

        [DefaultValue(0)]
        public bool PeriodoLoteDSR { get; set; }

        [DefaultValue("")]
        public string FiltroVT { get; set; }

        [DefaultValue(0)]
        public int QtdeFixaVT { get; set; }

        [DefaultValue(0)]
        public short OpcaoVTAdmissao { get; set; }

        [DefaultValue(0)]
        public short OpcaoVRAdmissao { get; set; }

        [DefaultValue(0)]
        public bool Desc1P13oOutroEvento { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(5,2)")]
        public decimal PercentualVT { get; set; }

        [DefaultValue(0)]
        public bool PagarBnfCtrVctoCli { get; set; }

        [DefaultValue(1)]
        public bool FaltaBnfIntegral { get; set; }

        [DefaultValue(0)]
        public int? TipoContratoWeb { get; set; }

        [DefaultValue(0)]
        public bool VAmensalprop { get; set; }

        [DefaultValue('N')]
        public string TipoInsalub13o { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? AlqLimiteSalario { get; set; }

        [DefaultValue(0)]
        public short CodigoAnalista { get; set; }

        [DefaultValue(0)]
        public short CodigoCoordenador { get; set; }

        [DefaultValue(0)]
        public int DiaIniPonto { get; set; }

        [DefaultValue(0)]
        public byte TipoMedia13oRes { get; set; }

        [DefaultValue(0)]
        public byte TipoMediaFerRes { get; set; }

        [DefaultValue(0)]
        public short FoneDDD { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,0)")]
        public decimal FoneNro { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,0)")]
        public decimal FoneRamal { get; set; }

        [DefaultValue("")]
        public string NomeFantasia { get; set; }

        [DefaultValue(0)]
        public byte? SituacaoComercial { get; set; }

        [DefaultValue("")]
        public string? Limpurb_Nro { get; set; }

        public DateTime? Limpurb_DataVcto { get; set; }

        [DefaultValue(0)]
        public short DiaFaturamento2 { get; set; }

        [DefaultValue(0)]
        public short DiaIniColeta1 { get; set; }

        [DefaultValue(0)]
        public short DiaFimColeta1 { get; set; }

        [DefaultValue(0)]
        public short DiaIniColeta2 { get; set; }

        [DefaultValue(0)]
        public short DiaFimColeta2 { get; set; }

        [DefaultValue(0)]
        public int? CodigoGrupoEconomico { get; set; }

        [DefaultValue("")]
        public string? NroCCM { get; set; }

        public DateTime? DataVctoPPRA { get; set; }

        public DateTime? DataVctoPCMSO { get; set; }

        [DefaultValue("")]
        public string? FiltroBnfVR { get; set; }

        [DefaultValue("")]
        public string? FiltroBnfCB { get; set; }

        [DefaultValue("")]
        public string? FiltroBnfAM { get; set; }

        [DefaultValue("")]
        public string? FiltroBnfAO { get; set; }

        [DefaultValue("")]
        public string? FiltroBnfVA { get; set; }

        [DefaultValue("")]
        public string? FiltroBnfOB { get; set; }

        [DefaultValue("")]
        public string? FiltroBnfIF { get; set; }

        [DefaultValue(0)]
        public bool FeriasBnfVT { get; set; }

        [DefaultValue(0)]
        public bool FeriasBnfVR { get; set; }

        [DefaultValue(0)]
        public bool FeriasBnfCB { get; set; }

        [DefaultValue(0)]
        public bool FeriasBnfAM { get; set; }

        [DefaultValue(0)]
        public bool FeriasBnfAO { get; set; }

        [DefaultValue(0)]
        public bool FeriasBnfVA { get; set; }

        [DefaultValue(0)]
        public bool FeriasBnfOB { get; set; }

        [DefaultValue(0)]
        public bool FeriasBnfIF { get; set; }

        [DefaultValue(3034)]
        public int CodigoPAIS { get; set; }

        [DefaultValue("")]
        public string EstadoExterior { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,5)")]
        public decimal? ValorFixo01 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,5)")]
        public decimal? ValorFixo02 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,5)")]
        public decimal? ValorFixo03 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,5)")]
        public decimal? ValorFixo04 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,5)")]
        public decimal? ValorFixo05 { get; set; }

        [DefaultValue(0)]
        public bool ImprimeFantasia { get; set; }

        [DefaultValue('N')]
        public string Adt_Insalub { get; set; }

        [DefaultValue(0)]
        public short EventoAdcInsAdto { get; set; }

        [DefaultValue(3)]
        public short IndNaturezaRetencaoSPEED { get; set; }

        [DefaultValue(0)]
        public short? CodigoAnalistaFinan { get; set; }

        [DefaultValue("")]
        public string? EmailAprovacao { get; set; }

        [DefaultValue(1)]
        public bool Adt_AdmMes { get; set; }

        [DefaultValue("")]
        public string? SMSMsgFol { get; set; }

        [DefaultValue("")]
        public string? SMSMsgBnf { get; set; }

        [DefaultValue("")]
        public string? SMSMsgRes { get; set; }

        [DefaultValue("")]
        public string? SMSMsgFer { get; set; }

        [DefaultValue("")]
        public string? SMSMsgAniversario { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? ValorBienio { get; set; }

        [DefaultValue("")]
        public string? NumeroMTPS { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? ValorQuadrienio { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? ValorQuinquenio { get; set; }

        public DateTime? dtIniValidade { get; set; }

        public DateTime? dtFimValidade { get; set; }

        [DefaultValue(0)]
        public byte? tipo_eSocial { get; set; }

        [DefaultValue("Nao Informado")]
        public string? tipoEndereco { get; set; }

        [DefaultValue("0")]
        public string? TipoInscObra { get; set; }

        [DefaultValue("")]
        public string? NroInscObra { get; set; }

        [DefaultValue("0")]
        public string? TipoInscPropObra { get; set; }

        [DefaultValue("")]
        public string? NroInscPropObra { get; set; }

        [DefaultValue(0)]
        public bool DiaAdiantamentoUtil { get; set; }

        [DefaultValue(0)]
        public bool DiaPagamentoUtil { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(7,0)")]
        public decimal? CNAE { get; set; }

        [DefaultValue(0)]
        public int? NroEndereco { get; set; }

        [DefaultValue(0)]
        public short CodigoSindicato { get; set; }

        [DefaultValue(0)]
        public short? CodigoCR { get; set; }

        [DefaultValue(0)]
        public byte QtdFaltaPerdeVA { get; set; }

        [DefaultValue(0)]
        public byte QtdMesAfastadoTemVA { get; set; }

        [DefaultValue("")]
        public string FiltroBnfPr { get; set; }

        [DefaultValue("")]
        public string IdIntegracao { get; set; }

        [DefaultValue(0)]
        public bool SaldoNegAdto { get; set; }

        [DefaultValue(0)]
        public short OpcaoVAAdmissao { get; set; }

        [DefaultValue(0)]
        public short OpcaoCBAdmissao { get; set; }

        public DateTime? DTIniEdicaoPortalCliente { get; set; }

        [DefaultValue("")]
        public string? TipoOperacaoWebCliente { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(11,2)")]
        public decimal ValorLimiteCreditoCliente { get; set; }

        [DefaultValue(0)]
        public int QtdFaltaPerdeCB { get; set; }

        [DefaultValue(0)]
        public int QtdMesAfastadoTemCB { get; set; }

        [DefaultValue(0)]
        public bool OptanteSimplesNacional { get; set; }

        [DefaultValue("")]
        public string CodigoAmlurb { get; set; }

        [DefaultValue(0)]
        public bool NaoAtualizarSalMesHorista { get; set; }

        [DefaultValue(0)]
        public bool CalcSalHoristaMedia { get; set; }

        [DefaultValue(0)]
        public bool OP_QtdeDiasSalarioHorista { get; set; }

        [DefaultValue("")]
        public string? WebUsuario { get; set; }

        [DefaultValue("")]
        public string? WebeMail { get; set; }

        [DefaultValue("")]
        public string? WebSenha { get; set; }

        [DefaultValue(0)]
        public bool OP_SomenteBNFCreditoAlelo { get; set; }

        [DefaultValue(0)]
        public bool PgtInsalFer { get; set; }

        [DefaultValue("")]
        public string TokenAPIGI { get; set; }

        [DefaultValue(0)]
        public bool? APISinc { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(5,2)")]
        public decimal HorasPgtJanta { get; set; }

        [DefaultValue(0)]
        public byte OpVRMensalProp { get; set; }

        [DefaultValue(0)]
        public byte QtFixaVRMensalProp { get; set; }

        [DefaultValue("")]
        public string RespAssCliNome { get; set; }

        [DefaultValue("")]
        public string RespAssCliEmail { get; set; }

        [DefaultValue("")]
        public string RespAssCliCpf { get; set; }

        [DefaultValue(0)]
        public short RespAssCliDDDCel { get; set; }

        [DefaultValue("")]
        public string RespAssCliCelular { get; set; }

        [DefaultValue(0)]
        public byte OpVAMensalProp { get; set; }

        [DefaultValue(0)]
        public byte QtFixaVAMensalProp { get; set; }

        [DefaultValue(0)]
        public bool? Adt_PropAfast { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(5,2)")]
        public decimal? Percentual_AdtoMot { get; set; }

        [DefaultValue(0)]
        public bool? TrataFeriasPeloBnfOB { get; set; }

        [DefaultValue(0)]
        public bool APISincExterno { get; set; }
    }

    public class TB_Cliente_old : BaseTB
    {
        public int CodigoCliente { get; set; }

        public string RazaoSocial { get; set; }

        public string Endereco { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }

        public string CEP { get; set; }

        public string CaixaPostal { get; set; }

        public string Telefone { get; set; }

        public string FaxTelefone { get; set; }

        public string Email { get; set; }

        public string HTTP { get; set; }

        public string TipoInscricao { get; set; }

        public string CGC { get; set; }

        public string IE { get; set; }

        public string Contato { get; set; }

        public decimal? TrocoPagamento { get; set; }

        public decimal? TrocoAdiantamento { get; set; }

        public decimal? PercentualAdiantado { get; set; }

        public decimal? TaxaPericulosidade { get; set; }

        public decimal? TaxaInsalubridade { get; set; }

        public short? DiaPagamento { get; set; }

        public short? DiaAdiantamento { get; set; }

        public short? DiaEmissaoEtiqueta { get; set; }

        public short? DiaFaturamento { get; set; }

        public short? DiaFichaHorario { get; set; }

        public int? GrupoCusto { get; set; }

        public int? CentroCustoCNT { get; set; }

        public string Comentario { get; set; }

        public string FornecVT { get; set; }

        public string FornecVR { get; set; }

        public bool? FornecCesta { get; set; }

        public bool? FornecAssitMed { get; set; }

        public bool? FornecAssOdo { get; set; }

        public bool? ClienteAtivo { get; set; }

        public bool? SaldoNegSal { get; set; }

        public bool? CAGED { get; set; }

        public string Op_DSRHE { get; set; }

        public string Op_DSRPremio { get; set; }

        public string Op_DSRAdc { get; set; }

        public string Op_TipoDescVT { get; set; }

        public bool? Op_QtdeDiasSalario { get; set; }

        public bool? Op_ValeAlimDiario { get; set; }

        public int? Op_Tipo13o { get; set; }

        public int? Op_TipoFerias { get; set; }

        public bool? Op_BeneficioIntegral { get; set; }

        public bool? Adt_UltDiaMes { get; set; }

        public string Adt_Pericul { get; set; }

        public bool? Adt_PropDem { get; set; }

        public bool? Adt_PropAdm { get; set; }

        public bool? Adt_DescIRF { get; set; }

        public bool? Adt_ArredDireto { get; set; }

        public bool? Adt_Apenas1 { get; set; }

        public DateTime? DataInclusao { get; set; }

        public DateTime? DataAlteracao { get; set; }

        public string PeriodoVT { get; set; }

        public bool? GpsExclusiva { get; set; }

        public short? BaseInsalubridade { get; set; }

        public string TipAdc13o { get; set; }

        public string TipAdcFer { get; set; }

        public bool? PgtPer13o { get; set; }

        public bool? PgtPerFer { get; set; }

        public decimal? PerAnt13o { get; set; }

        public string MascaraCCusto { get; set; }

        public string NomeUsuario { get; set; }

        public decimal? Per1P13o { get; set; }

        public bool? Pgt1PAntecipacao { get; set; }

        public bool? Mes1PTrab { get; set; }

        public bool InclusaoOK { get; set; }

        public bool? PagtoForaMes { get; set; }

        public bool? Op_CCusto { get; set; }

        public bool Divisor2P13o12 { get; set; }

        public bool ImprimeEtiqueta { get; set; }

        public decimal PercentualGratificacao { get; set; }

        public decimal ValorAnuenio { get; set; }

        public decimal ValorTrienio { get; set; }

        public bool Op_ClienteInterno { get; set; }

        public bool AdtPropFerias { get; set; }

        public string NomeRepresentante { get; set; }

        public string CargoRepresentante { get; set; }

        public string CplEndereco { get; set; }

        public bool RecalculaSalAdto { get; set; }

        public string IDSistemaAnterior { get; set; }

        public int CodigoCidade { get; set; }

        public string NomeSupervisor { get; set; }

        public string CargoSupervisor { get; set; }

        public string InscricaoMunicipal { get; set; }

        public bool? Adt_PgtoAposVcto { get; set; }

        public bool ArredondaDireto1Parcela { get; set; }

        public bool Mes1PTrabTemp { get; set; }

        public short EventoAdcPerAdto { get; set; }

        public short Regiao { get; set; }

        public bool PeriodoLoteDSR { get; set; }

        public string FiltroVT { get; set; }

        public int QtdeFixaVT { get; set; }

        public short OpcaoVTAdmissao { get; set; }

        public short OpcaoVRAdmissao { get; set; }

        public bool Desc1P13oOutroEvento { get; set; }

        public decimal PercentualVT { get; set; }

        public bool PagarBnfCtrVctoCli { get; set; }

        public bool FaltaBnfIntegral { get; set; }

        public int? TipoContratoWeb { get; set; }

        public bool VAmensalprop { get; set; }

        public string TipoInsalub13o { get; set; }

        public decimal? AlqLimiteSalario { get; set; }

        public short CodigoAnalista { get; set; }

        public short CodigoCoordenador { get; set; }

        public int DiaIniPonto { get; set; }

        public int TipoMedia13oRes { get; set; }

        public int TipoMediaFerRes { get; set; }

        public short FoneDDD { get; set; }

        public decimal FoneNro { get; set; }

        public decimal FoneRamal { get; set; }

        public string NomeFantasia { get; set; }

        public int? SituacaoComercial { get; set; }

        public string Limpurb_Nro { get; set; }

        public DateTime? Limpurb_DataVcto { get; set; }

        public short DiaFaturamento2 { get; set; }

        public short DiaIniColeta1 { get; set; }

        public short DiaFimColeta1 { get; set; }

        public short DiaIniColeta2 { get; set; }

        public short DiaFimColeta2 { get; set; }

        public int? CodigoGrupoEconomico { get; set; }

        public string NroCCM { get; set; }

        public DateTime? DataVctoPPRA { get; set; }

        public DateTime? DataVctoPCMSO { get; set; }

        public string FiltroBnfVR { get; set; }

        public string FiltroBnfCB { get; set; }

        public string FiltroBnfAM { get; set; }

        public string FiltroBnfAO { get; set; }

        public string FiltroBnfVA { get; set; }

        public string FiltroBnfOB { get; set; }

        public string FiltroBnfIF { get; set; }

        public bool FeriasBnfVT { get; set; }

        public bool FeriasBnfVR { get; set; }

        public bool FeriasBnfCB { get; set; }

        public bool FeriasBnfAM { get; set; }

        public bool FeriasBnfAO { get; set; }

        public bool FeriasBnfVA { get; set; }

        public bool FeriasBnfOB { get; set; }

        public bool FeriasBnfIF { get; set; }

        public int CodigoPAIS { get; set; }

        public string EstadoExterior { get; set; }

        public decimal? ValorFixo01 { get; set; }

        public decimal? ValorFixo02 { get; set; }

        public decimal? ValorFixo03 { get; set; }

        public decimal? ValorFixo04 { get; set; }

        public decimal? ValorFixo05 { get; set; }

        public bool ImprimeFantasia { get; set; }

        public string Adt_Insalub { get; set; }

        public short EventoAdcInsAdto { get; set; }

        public short IndNaturezaRetencaoSPEED { get; set; }

        public short? CodigoAnalistaFinan { get; set; }

        public string EmailAprovacao { get; set; }

        public bool Adt_AdmMes { get; set; }

        public string SMSMsgFol { get; set; }

        public string SMSMsgBnf { get; set; }

        public string SMSMsgRes { get; set; }

        public string SMSMsgFer { get; set; }

        public string SMSMsgAniversario { get; set; }

        public decimal? ValorBienio { get; set; }

        public string NumeroMTPS { get; set; }

        public decimal? ValorQuadrienio { get; set; }

        public decimal? ValorQuinquenio { get; set; }

        public DateTime? dtIniValidade { get; set; }

        public DateTime? dtFimValidade { get; set; }

        public int? tipo_eSocial { get; set; }

        public string tipoEndereco { get; set; }

        public string TipoInscObra { get; set; }

        public string NroInscObra { get; set; }

        public string TipoInscPropObra { get; set; }

        public string NroInscPropObra { get; set; }

        public bool DiaAdiantamentoUtil { get; set; }

        public bool DiaPagamentoUtil { get; set; }

        public decimal? CNAE { get; set; }

        public int? NroEndereco { get; set; }

        public short CodigoSindicato { get; set; }

        public short? CodigoCR { get; set; }

        public int QtdFaltaPerdeVA { get; set; }

        public int QtdMesAfastadoTemVA { get; set; }

        public string FiltroBnfPr { get; set; }

        public string IdIntegracao { get; set; }

        public bool SaldoNegAdto { get; set; }

        public short OpcaoVAAdmissao { get; set; }

        public short OpcaoCBAdmissao { get; set; }

        public DateTime? DTIniEdicaoPortalCliente { get; set; }

        public string TipoOperacaoWebCliente { get; set; }

        public decimal ValorLimiteCreditoCliente { get; set; }

        public int QtdFaltaPerdeCB { get; set; }

        public int QtdMesAfastadoTemCB { get; set; }

        public bool OptanteSimplesNacional { get; set; }

        public string CodigoAmlurb { get; set; }

        public bool NaoAtualizarSalMesHorista { get; set; }

        public bool CalcSalHoristaMedia { get; set; }

        public bool OP_QtdeDiasSalarioHorista { get; set; }

        public string WebUsuario { get; set; }

        public string WebeMail { get; set; }

        public string WebSenha { get; set; }

        public bool OP_SomenteBNFCreditoAlelo { get; set; }

        public bool PgtInsalFer { get; set; }

        public string TokenAPIGI { get; set; }

        public bool? APISinc { get; set; }

        public decimal HorasPgtJanta { get; set; }

        public int OpVRMensalProp { get; set; }

        public int QtFixaVRMensalProp { get; set; }

        public string RespAssCliNome { get; set; }

        public string RespAssCliEmail { get; set; }

        public string RespAssCliCpf { get; set; }

        public short RespAssCliDDDCel { get; set; }

        public string RespAssCliCelular { get; set; }

        public int OpVAMensalProp { get; set; }

        public int QtFixaVAMensalProp { get; set; }

        public bool? Adt_PropAfast { get; set; }

        public decimal? Percentual_AdtoMot { get; set; }

        public bool? TrataFeriasPeloBnfOB { get; set; }


    }
}
