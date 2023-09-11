using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_ContratoSelecao : BaseTB
    {
        public int CodigoCliente { get; set; }

        public short CodigoContrato { get; set; }

        public short TipoFat { get; set; }

        [DefaultValue(0)]
        public short? CodigoEmpresaFolha { get; set; }

        [DefaultValue(0)]
        public short? CodigoFilialFolha { get; set; }

        [DefaultValue(0)]
        public short? CodigoEmpresaFat { get; set; }

        [DefaultValue(0)]
        public short? CodigoFilialFat { get; set; }

        [DefaultValue(0)]
        public short? CodigoSelecionador { get; set; }

        [DefaultValue(0)]
        public short? CodigoVendedor { get; set; }

        [DefaultValue(0)]
        public short? CodigoRecrutador { get; set; }

        [DefaultValue(0)]
        public short? CodigoCom1 { get; set; }

        [DefaultValue(0)]
        public short? CodigoCom2 { get; set; }

        [DefaultValue(0)]
        public short? CodigoCom3 { get; set; }

        [DefaultValue(0)]
        public short? CodigoBanco { get; set; }

        [DefaultValue(0)]
        public short? CentroCustoContab { get; set; }

        [DefaultValue("")]
        public string? DiaFatFolha { get; set; }

        [DefaultValue("")]
        public string? DiaFatAdiant { get; set; }

        [DefaultValue("1")]
        public string? TipoInscricaoCobr { get; set; }

        [DefaultValue("00.000.000/0000-00")]
        public string? CGCCobr { get; set; }

        [DefaultValue("")]
        public string? IE { get; set; }

        [DefaultValue("")]
        public string? EnderecoCobr { get; set; }

        [DefaultValue("")]
        public string? BairroCobr { get; set; }

        [DefaultValue("")]
        public string? CidadeCobr { get; set; }

        [DefaultValue("")]
        public string? EstadoCobr { get; set; }

        [DefaultValue("00000-000")]
        public string? CEPCobr { get; set; }

        [DefaultValue("")]
        public string? Fone { get; set; }

        [DefaultValue(0)]
        public int? CondPagto { get; set; }

        public string? NatOper { get; set; }

        public DateTime? DataIniContrato { get; set; }

        public DateTime? DataFimContrato { get; set; }

        [DefaultValue(0)]
        public int? RefContasPagar { get; set; }

        [DefaultValue(0)]
        public int? RefEncargFolha { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,4)")]
        public decimal? TaxaEncargos { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,4)")]
        public decimal? TaxaEncargos13 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,4)")]
        public decimal? TaxaEncFerias { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,4)")]
        public decimal? TaxaEncargosAvi { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(7,4)")]
        public decimal? TaxaFatur { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(7,4)")]
        public decimal? TaxaFatIndic { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(7,4)")]
        public decimal? TaxaAgenc { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(7,4)")]
        public decimal? TaxaTributo { get; set; }

        [DefaultValue("")]
        public string? TipoResDS { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? ValorMinNF { get; set; }

        public DateTime? DataUltFat { get; set; }

        [DefaultValue(0)]
        public bool? EmissTribDS { get; set; }

        [DefaultValue(0)]
        public bool? EmissLocTrabDS { get; set; }

        [DefaultValue(1)]
        public bool? EmissBaseEncDS { get; set; }

        [DefaultValue(1)]
        public bool? EmissVctoDS { get; set; }

        [DefaultValue(1)]
        public bool? DemTxEncDS { get; set; }

        [DefaultValue(1)]
        public bool? DemTXFatDS { get; set; }

        [DefaultValue(0)]
        public bool? SeparaNFporDS { get; set; }

        [DefaultValue("")]
        public string? FaturaAdiant { get; set; }

        [DefaultValue("")]
        public string? FatPrimParc13 { get; set; }

        [DefaultValue("")]
        public string? FaturaVT { get; set; }

        [DefaultValue("")]
        public string? FaturaVR { get; set; }

        [DefaultValue("")]
        public string? FaturaCB { get; set; }

        [DefaultValue("")]
        public string? FaturaAM { get; set; }

        [DefaultValue("")]
        public string? FaturaAO { get; set; }

        [DefaultValue("")]
        public string? FaturaVA { get; set; }

        [DefaultValue("")]
        public string? FaturaOB { get; set; }

        [DefaultValue(0)]
        public bool? Prov13Ferias { get; set; }

        [DefaultValue("")]
        public string? TipoContrCusto { get; set; }

        [DefaultValue("")]
        public string? Comentario { get; set; }

        [DefaultValue(0)]
        public bool? ImpEventoZerDS { get; set; }

        [DefaultValue(0)]
        public bool? ImpEncargoZerDS { get; set; }

        [DefaultValue(1)]
        public bool? DemBruDS { get; set; }

        [DefaultValue(1)]
        public bool? DemLiqFolDS { get; set; }

        [DefaultValue(1)]
        public bool? IRRF_Taxa { get; set; }

        [DefaultValue(1)]
        public bool? IRRF_Reemb { get; set; }

        [DefaultValue(0)]
        public bool? IRRF_Iss { get; set; }

        [DefaultValue(0)]
        public bool? IRRF_Tri { get; set; }

        [DefaultValue(1)]
        public bool? INSS_Taxa { get; set; }

        [DefaultValue(1)]
        public bool? INSS_Reemb { get; set; }

        [DefaultValue(1)]
        public bool? ISS_Taxa { get; set; }

        [DefaultValue(1)]
        public bool? ISS_Reemb { get; set; }

        [DefaultValue(0)]
        public bool? ISS_Tri { get; set; }

        [DefaultValue(0)]
        public bool? TRI_Taxa { get; set; }

        [DefaultValue(0)]
        public bool? TRI_Reemb { get; set; }

        [DefaultValue(0)]
        public bool? TRI_Tri { get; set; }

        [DefaultValue(0)]
        public bool? PIS_Taxa { get; set; }

        [DefaultValue(0)]
        public bool? PIS_Reemb { get; set; }

        [DefaultValue(0)]
        public bool? COF_Taxa { get; set; }

        [DefaultValue(0)]
        public bool? COF_Reemb { get; set; }

        [DefaultValue(1)]
        public bool? Liq_IRRF { get; set; }

        [DefaultValue(1)]
        public bool? Liq_INSS { get; set; }

        [DefaultValue(0)]
        public byte? Liq_ISS { get; set; }

        [DefaultValue(0)]
        public bool? Liq_Tri { get; set; }

        [DefaultValue(0)]
        public bool? Tri_Analitico { get; set; }

        [DefaultValue(0)]
        public bool InclusaoOK { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? PercentISS { get; set; }

        [DefaultValue(0)]
        public bool? TRI_Iss { get; set; }

        [DefaultValue("")]
        public string? NomeUsuario { get; set; }

        [DefaultValue(1)]
        public bool? INSS_Iss { get; set; }

        [DefaultValue(1)]
        public bool? INSS_Tri { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(7,4)")]
        public decimal? TaxaTributoBnf { get; set; }

        [DefaultValue(0)]
        public bool? ProvisionaFerias { get; set; }

        [DefaultValue(0)]
        public bool? Provisiona13 { get; set; }

        [DefaultValue(0)]
        public bool? ProvisionaAviso { get; set; }

        [DefaultValue(0)]
        public bool? ProvisionaAuxEnfermidade { get; set; }

        [DefaultValue(0)]
        public bool? ProvisionaAuxPaternidade { get; set; }

        [DefaultValue(0)]
        public bool? ProvisionaAuxMaternidade { get; set; }

        [DefaultValue(0)]
        public bool? ProvisionaFaltasLegais { get; set; }

        [DefaultValue(0)]
        public bool? ProvisionaEncargosMot { get; set; }

        [DefaultValue(0)]
        public int? CodigoClienteCusto { get; set; }

        [DefaultValue(0)]
        public short? CodigoContratoCusto { get; set; }

        [DefaultValue(0)]
        public short? TipoFaturamentoCusto { get; set; }

        [DefaultValue(0)]
        public bool? ISS_Iss { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? ProvisionaOutrosFerias { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? ProvisionaOutrosAviso { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? ProvisionaOutros13o { get; set; }

        [DefaultValue(1)]
        public bool? Ativo { get; set; }

        [DefaultValue(0)]
        public bool? ISSCNT_Taxa { get; set; }

        [DefaultValue(0)]
        public bool? ISSCNT_Reemb { get; set; }

        [DefaultValue(0)]
        public bool? ISSCNT_Tri { get; set; }

        [DefaultValue(0)]
        public bool? ISSCNT_Iss { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? PercentISSCNT { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(8,5)")]
        public decimal TaxaSelecionador { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(8,5)")]
        public decimal TaxaVendedor { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(8,5)")]
        public decimal TaxaRecrutador { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(8,5)")]
        public decimal TaxaCom1 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(8,5)")]
        public decimal TaxaCom2 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(8,5)")]
        public decimal TaxaCom3 { get; set; }

        [DefaultValue(1)]
        public bool PIS_Tri { get; set; }

        [DefaultValue(1)]
        public bool PIS_Iss { get; set; }

        [DefaultValue(1)]
        public bool COF_Tri { get; set; }

        [DefaultValue(1)]
        public bool COF_Iss { get; set; }

        [DefaultValue(1)]
        public bool CSLL_Taxa { get; set; }

        [DefaultValue(1)]
        public bool CSLL_Reemb { get; set; }

        [DefaultValue(1)]
        public bool CSLL_Tri { get; set; }

        [DefaultValue(1)]
        public bool CSLL_Iss { get; set; }

        [DefaultValue(1)]
        public bool LIQ_Cof { get; set; }

        [DefaultValue(1)]
        public bool LIQ_Pis { get; set; }

        [DefaultValue(1)]
        public bool LIQ_Csll { get; set; }

        [DefaultValue("")]
        public string? RazaoSocial { get; set; }

        [DefaultValue("")]
        public string NumeroCCM { get; set; }

        [DefaultValue(0)]
        public byte Liq_ISS_Duplicata { get; set; }

        [DefaultValue(0)]
        public bool SepNFReeTax { get; set; }

        [DefaultValue(0)]
        public short CodigoBancoRee { get; set; }

        [DefaultValue(0)]
        public short CodigoBancoTax { get; set; }

        [DefaultValue(1)]
        public short Regiao { get; set; }

        [DefaultValue("C")]
        public string TipoDiaVcto { get; set; }

        [DefaultValue(0)]
        public bool ProvisionaMultaFgts { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal PercentualTributo { get; set; }

        [DefaultValue(1)]
        public bool CalculaTributoAntes { get; set; }

        [DefaultValue(0)]
        public bool ISSAcumulativo { get; set; }

        [DefaultValue("")]
        public string CplEnderecoCobr { get; set; }

        [DefaultValue(0)]
        public bool SeparaNFTaxReeDeb { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal SomadorVTFat { get; set; }

        [DefaultValue(0)]
        public byte BaseProvisaoFerDS { get; set; }

        [DefaultValue(0)]
        public byte BaseProvisao13oDS { get; set; }

        [DefaultValue(0)]
        public int CodigoCidadeCobr { get; set; }

        [DefaultValue("")]
        public string InscricaoMunicipal { get; set; }

        [DefaultValue("")]
        public string? Email { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(14,0)")]
        public decimal CodServicoPrestado { get; set; }

        [DefaultValue(0)]
        public int NroEnderecoCobr { get; set; }

        [DefaultValue("")]
        public string Descricao { get; set; }

        [DefaultValue(0)]
        public bool ReterISS_SobreTaxa { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(5,2)")]
        public decimal AlqCaucao { get; set; }

        [DefaultValue(0)]
        public bool Caucao_Taxa { get; set; }

        [DefaultValue(0)]
        public bool Caucao_Reemb { get; set; }

        [DefaultValue(0)]
        public bool Caucao_Tri { get; set; }

        [DefaultValue(0)]
        public bool Liq_Caucao { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(15,0)")]
        public decimal NFeMOGI_CodAtv { get; set; }

        [DefaultValue(0)]
        public bool INSS_TaxaBnf { get; set; }

        [DefaultValue(0)]
        public int QtdeMaximaFuncionario { get; set; }

        [DefaultValue(0)]
        public bool NFeMOGI_TribMunicipio { get; set; }

        [DefaultValue(0)]
        public bool SeparaTribVTAnalitico { get; set; }

        [DefaultValue(0)]
        public bool SeparaTribReembTaxa { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,4)")]
        public decimal AlqTribTaxa { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,4)")]
        public decimal AlqTribReemb { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? HorPosto1_Ini { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? HorPosto1_Fim { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? HorPosto2_Ini { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? HorPosto2_Fim { get; set; }

        [DefaultValue(0)]
        public bool FatTaxaSobreTaxa { get; set; }

        [DefaultValue(0)]
        public bool AntecipacaoFat { get; set; }

        [DefaultValue(0)]
        public bool ReembISS { get; set; }

        [DefaultValue(0)]
        public bool JuntarTribISS { get; set; }

        [DefaultValue(0)]
        public int? CFPS { get; set; }

        [DefaultValue(0)]
        public bool AbaterPISCOFCSLNOISS { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal AlqBaseISS { get; set; }

        [DefaultValue("1111111")]
        public string DiaVctoNFValido { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(14,0)")]
        public decimal? NFSe_CodigoTributacao { get; set; }

        [DefaultValue("")]
        public string IDSistemaAnterior { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? AlqAdtoFat { get; set; }

        [DefaultValue(0)]
        public int? TipoContratoWeb { get; set; }

        [DefaultValue(0)]
        public byte? SituacaoComercial { get; set; }

        [DefaultValue(0)]
        public int? TaxaFatur2 { get; set; }

        [DefaultValue(0)]
        public int? TaxaFatIndic2 { get; set; }

        [DefaultValue("000000")]
        public string? TaxaFatur3 { get; set; }

        [DefaultValue("000000")]
        public string? TaxaFatIndic3 { get; set; }

        [DefaultValue(0)]
        public string ISSNfe { get; set; }

        [DefaultValue(3034)]
        public int CodigoPAIS { get; set; }

        [DefaultValue("")]
        public string EstadoExterior { get; set; }

        [DefaultValue("")]
        public string NatOperacaoNF { get; set; }

        [DefaultValue(0)]
        public int CodigoCidadeServ { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal AlqBaseINSS { get; set; }

        [DefaultValue(0)]
        public bool Arred_ISS { get; set; }

        [DefaultValue("")]
        public string? Idintegracao { get; set; }

        [DefaultValue(0)]
        public bool SeparaNFReeTaxDeb { get; set; }

        [DefaultValue(0)]
        public int NroOrcamento { get; set; }

        [DefaultValue(0)]
        public byte SeqOrcamento { get; set; }

        [DefaultValue(0)]
        public bool MatrizAssociacao { get; set; }

        [DefaultValue("")]
        public string? MotivoDesligamento { get; set; }

        [DefaultValue(0)]
        public short? DiasVctoEmiNF { get; set; }

        [DefaultValue("Nao Informado")]
        public string? tipoEnderecoCobr { get; set; }

        [DefaultValue(0)]
        public bool? TaxaTribInvert { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(8,4)")]
        public decimal? AlqCustoOper { get; set; }

        [DefaultValue(0)]
        public bool? AnteciparDiaVctoNF { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(7,4)")]
        public decimal? TaxaFat1Menos15Dias { get; set; }

        [DefaultValue("000000")]
        public string? TaxaFat2Menos15Dias { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? AlqRatEnc_INSS { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? AlqRatEnc_FGTS { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? AlqRatEnc_SalEdu { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? AlqRatEnc_SAT { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? AlqRatEnc_SESI { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? AlqRatEnc_SEBRAE { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? AlqRatEnc_INCRA { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? AlqRatEnc_SENAI { get; set; }

        [DefaultValue(0)]
        public bool? SubsTributario { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? AlqRatTri_COF { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? AlqRatTri_ISS { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? AlqRatTri_CSLL { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? AlqRatTri_IRPJ { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? AlqRatTri_PIS { get; set; }

        [DefaultValue(0)]
        public byte ModeloDS { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? AlqRatEnc_ProvFer { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? AlqRatEnc_Prov13o { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? AlqRatEnc_ProvAvi { get; set; }

        [DefaultValue(0)]
        public bool NaoEmitirBoletoCobranca { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(8,5)")]
        public decimal? AlqISSLei58 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal AlqNFLei12741 { get; set; }

        [DefaultValue(0)]
        public short? CodigoCR { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(4,2)")]
        public decimal AlqDesctoBoleto { get; set; }

        [DefaultValue(0)]
        public bool SeparaDS_CCusto { get; set; }

        [DefaultValue(0)]
        public bool SeparaDS_Funcao { get; set; }

        [DefaultValue(0)]
        public bool SeparaDS_Lote { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(4,2)")]
        public decimal PercentMultaCobr { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(7,5)")]
        public decimal PercentMoraDiariaCobr { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,4)")]
        public decimal TaxaEncargos2 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(7,2)")]
        public decimal? AlqRatDup { get; set; }

        [DefaultValue(2)]
        public short TipoFatEstoque { get; set; }

        [DefaultValue("")]
        public string Dimensao1 { get; set; }

        [DefaultValue("")]
        public string Dimensao2 { get; set; }

        [DefaultValue("")]
        public string Dimensao3 { get; set; }

        [DefaultValue("")]
        public string Dimensao4 { get; set; }

        [DefaultValue("")]
        public string Dimensao5 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal ValorLimiteCredito { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? ValorRatDup { get; set; }

        public DateTime? DataAlteracao { get; set; }

        public DateTime? DataInclusao { get; set; }

        [DefaultValue(0)]
        public short FPAS { get; set; }

        [DefaultValue(0)]
        public short CodTerceiro { get; set; }

        [DefaultValue(0)]
        public short CodigoContratoNF { get; set; }

        [DefaultValue(0)]
        public short TipoFatNF { get; set; }

        [DefaultValue(0)]
        public bool DeduzirBnfPagoBaseINSS { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(14,0)")]
        public decimal? TipoServicoEfdReinf { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(14,0)")]
        public decimal CodAtividadeEfdReinf { get; set; }

        [DefaultValue("")]
        public string? ObsDS { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,4)")]
        public decimal TaxaEncargosDiversos { get; set; }

        [DefaultValue(0)]
        public int GI_CodigoClienteGasc { get; set; }

        [DefaultValue(0)]
        public int GI_QtdMinReciboWeb { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal GI_ValorMinReciboWeb { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal GI_ValorUniReciboWeb { get; set; }

        [DefaultValue(0)]
        public short GI_CodigoHistorico { get; set; }

        [DefaultValue(0)]
        public short GI_DiaFatReciboWeb { get; set; }

        [DefaultValue("")]
        public string GI_FiltroFat { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal ValorFatPrevisto { get; set; }

        [DefaultValue(0)]
        public bool FlagCortesiaFatGI { get; set; }

        [DefaultValue(0)]
        public int PrazoMinimoVecto { get; set; }

        [DefaultValue("")]
        public string GI_CptReajusteRecibo { get; set; }

        public DateTime? GI_DataUltReajusteRecibo { get; set; }

        [DefaultValue(0)]
        public int GI_QtdMinFunAdmin { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal GI_ValorMinFunAdmin { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal GI_ValorUniFunAdmin { get; set; }

        [DefaultValue(0)]
        public short GI_CodigoHistoricoFunAdmin { get; set; }

        [DefaultValue(0)]
        public bool GI_FlagCortesiaFunAdmin { get; set; }

        [DefaultValue(0)]
        public short GI_DiaFatFunAdmin { get; set; }

        [DefaultValue("")]
        public string GI_FiltroFunAdmin { get; set; }

        [DefaultValue("")]
        public string GI_CptReajusteFunAdmin { get; set; }

        public DateTime? GI_DataUltReajusteFunAdmin { get; set; }

        [DefaultValue(0)]
        public int GI_QtdMinSSTAdmin { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal GI_ValorMinSSTAdmin { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal GI_ValorUniSSTAdmin { get; set; }

        [DefaultValue(0)]
        public short GI_CodigoHistoricoSSTAdmin { get; set; }

        [DefaultValue(0)]
        public bool GI_FlagCortesiaSSTAdmin { get; set; }

        [DefaultValue(0)]
        public short GI_DiaFatSSTAdmin { get; set; }

        [DefaultValue("")]
        public string GI_FiltroSSTAdmin { get; set; }

        [DefaultValue("")]
        public string GI_CptReajusteSSTAdmin { get; set; }

        public DateTime? GI_DataUltReajusteSSTAdmin { get; set; }

        [DefaultValue(0)]
        public int GI_QtdMinAdmDigAdmin { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal GI_ValorMinAdmDigAdmin { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal GI_ValorUniAdmDigAdmin { get; set; }

        [DefaultValue(0)]
        public short GI_CodigoHistoricoAdmDigAdmin { get; set; }

        [DefaultValue(0)]
        public bool GI_FlagCortesiaAdmDigAdmin { get; set; }

        [DefaultValue(0)]
        public short GI_DiaFatAdmDigAdmin { get; set; }

        [DefaultValue("")]
        public string GI_FiltroAdmDigAdmin { get; set; }

        [DefaultValue("")]
        public string GI_CptReajusteAdmDigAdmin { get; set; }

        public DateTime? GI_DataUltReajusteAdmDigAdmin { get; set; }

        [DefaultValue(0)]
        public int NaturezaRendCtr { get; set; }

        [DefaultValue(0)]
        public bool APISinc { get; set; }

        [DefaultValue(0)]
        public bool APISincExterno { get; set; }
    }

    public class TB_ContratoSelecao_old : BaseTB
    {
        public int CodigoCliente { get; set; }

        public short CodigoContrato { get; set; }

        public short TipoFat { get; set; }

        public short? CodigoEmpresaFolha { get; set; }

        public short? CodigoFilialFolha { get; set; }

        public short? CodigoEmpresaFat { get; set; }

        public short? CodigoFilialFat { get; set; }

        public short? CodigoSelecionador { get; set; }

        public short? CodigoVendedor { get; set; }

        public short? CodigoRecrutador { get; set; }

        public short? CodigoCom1 { get; set; }

        public short? CodigoCom2 { get; set; }

        public short? CodigoCom3 { get; set; }

        public short? CodigoBanco { get; set; }

        public short? CentroCustoContab { get; set; }

        public string DiaFatFolha { get; set; }

        public string DiaFatAdiant { get; set; }

        public string TipoInscricaoCobr { get; set; }

        public string CGCCobr { get; set; }

        public string IE { get; set; }

        public string EnderecoCobr { get; set; }

        public string BairroCobr { get; set; }

        public string CidadeCobr { get; set; }

        public string EstadoCobr { get; set; }

        public string CEPCobr { get; set; }

        public string Fone { get; set; }

        public int? CondPagto { get; set; }

        public string NatOper { get; set; }

        public DateTime? DataIniContrato { get; set; }

        public DateTime? DataFimContrato { get; set; }

        public int? RefContasPagar { get; set; }

        public int? RefEncargFolha { get; set; }

        public decimal? TaxaEncargos { get; set; }

        public decimal? TaxaEncargos13 { get; set; }

        public decimal? TaxaEncFerias { get; set; }

        public decimal? TaxaEncargosAvi { get; set; }

        public decimal? TaxaFatur { get; set; }

        public decimal? TaxaFatIndic { get; set; }

        public decimal? TaxaAgenc { get; set; }

        public decimal? TaxaTributo { get; set; }

        public string TipoResDS { get; set; }

        public decimal? ValorMinNF { get; set; }

        public DateTime? DataUltFat { get; set; }

        public bool? EmissTribDS { get; set; }

        public bool? EmissLocTrabDS { get; set; }

        public bool? EmissBaseEncDS { get; set; }

        public bool? EmissVctoDS { get; set; }

        public bool? DemTxEncDS { get; set; }

        public bool? DemTXFatDS { get; set; }

        public bool? SeparaNFporDS { get; set; }

        public string FaturaAdiant { get; set; }

        public string FatPrimParc13 { get; set; }

        public string FaturaVT { get; set; }

        public string FaturaVR { get; set; }

        public string FaturaCB { get; set; }

        public string FaturaAM { get; set; }

        public string FaturaAO { get; set; }

        public string FaturaVA { get; set; }

        public string FaturaOB { get; set; }

        public bool? Prov13Ferias { get; set; }

        public string TipoContrCusto { get; set; }

        public string Comentario { get; set; }

        public bool? ImpEventoZerDS { get; set; }

        public bool? ImpEncargoZerDS { get; set; }

        public bool? DemBruDS { get; set; }

        public bool? DemLiqFolDS { get; set; }

        public bool? IRRF_Taxa { get; set; }

        public bool? IRRF_Reemb { get; set; }

        public bool? IRRF_Iss { get; set; }

        public bool? IRRF_Tri { get; set; }

        public bool? INSS_Taxa { get; set; }

        public bool? INSS_Reemb { get; set; }

        public bool? ISS_Taxa { get; set; }

        public bool? ISS_Reemb { get; set; }

        public bool? ISS_Tri { get; set; }

        public bool? TRI_Taxa { get; set; }

        public bool? TRI_Reemb { get; set; }

        public bool? TRI_Tri { get; set; }

        public bool? PIS_Taxa { get; set; }

        public bool? PIS_Reemb { get; set; }

        public bool? COF_Taxa { get; set; }

        public bool? COF_Reemb { get; set; }

        public bool? Liq_IRRF { get; set; }

        public bool? Liq_INSS { get; set; }

        public int? Liq_ISS { get; set; }

        public bool? Liq_Tri { get; set; }

        public bool? Tri_Analitico { get; set; }

        public bool InclusaoOK { get; set; }

        public decimal? PercentISS { get; set; }

        public bool? TRI_Iss { get; set; }

        public string NomeUsuario { get; set; }

        public bool? INSS_Iss { get; set; }

        public bool? INSS_Tri { get; set; }

        public decimal? TaxaTributoBnf { get; set; }

        public bool? ProvisionaFerias { get; set; }

        public bool? Provisiona13 { get; set; }

        public bool? ProvisionaAviso { get; set; }

        public bool? ProvisionaAuxEnfermidade { get; set; }

        public bool? ProvisionaAuxPaternidade { get; set; }

        public bool? ProvisionaAuxMaternidade { get; set; }

        public bool? ProvisionaFaltasLegais { get; set; }

        public bool? ProvisionaEncargosMot { get; set; }

        public int? CodigoClienteCusto { get; set; }

        public short? CodigoContratoCusto { get; set; }

        public short? TipoFaturamentoCusto { get; set; }

        public bool? ISS_Iss { get; set; }

        public decimal? ProvisionaOutrosFerias { get; set; }

        public decimal? ProvisionaOutrosAviso { get; set; }

        public decimal? ProvisionaOutros13o { get; set; }

        public bool? Ativo { get; set; }

        public bool? ISSCNT_Taxa { get; set; }

        public bool? ISSCNT_Reemb { get; set; }

        public bool? ISSCNT_Tri { get; set; }

        public bool? ISSCNT_Iss { get; set; }

        public decimal? PercentISSCNT { get; set; }

        public decimal TaxaSelecionador { get; set; }

        public decimal TaxaVendedor { get; set; }

        public decimal TaxaRecrutador { get; set; }

        public decimal TaxaCom1 { get; set; }

        public decimal TaxaCom2 { get; set; }

        public decimal TaxaCom3 { get; set; }

        public bool PIS_Tri { get; set; }

        public bool PIS_Iss { get; set; }

        public bool COF_Tri { get; set; }

        public bool COF_Iss { get; set; }

        public bool CSLL_Taxa { get; set; }

        public bool CSLL_Reemb { get; set; }

        public bool CSLL_Tri { get; set; }

        public bool CSLL_Iss { get; set; }

        public bool LIQ_Cof { get; set; }

        public bool LIQ_Pis { get; set; }

        public bool LIQ_Csll { get; set; }

        public string RazaoSocial { get; set; }

        public string NumeroCCM { get; set; }

        public int Liq_ISS_Duplicata { get; set; }

        public bool SepNFReeTax { get; set; }

        public short CodigoBancoRee { get; set; }

        public short CodigoBancoTax { get; set; }

        public short Regiao { get; set; }

        public string TipoDiaVcto { get; set; }

        public bool ProvisionaMultaFgts { get; set; }

        public decimal PercentualTributo { get; set; }

        public bool CalculaTributoAntes { get; set; }

        public bool ISSAcumulativo { get; set; }

        public string CplEnderecoCobr { get; set; }

        public bool SeparaNFTaxReeDeb { get; set; }

        public decimal SomadorVTFat { get; set; }

        public int BaseProvisaoFerDS { get; set; }

        public int BaseProvisao13oDS { get; set; }

        public int CodigoCidadeCobr { get; set; }

        public string InscricaoMunicipal { get; set; }

        public string Email { get; set; }

        public decimal CodServicoPrestado { get; set; }

        public int NroEnderecoCobr { get; set; }

        public string Descricao { get; set; }

        public bool ReterISS_SobreTaxa { get; set; }

        public decimal AlqCaucao { get; set; }

        public bool Caucao_Taxa { get; set; }

        public bool Caucao_Reemb { get; set; }

        public bool Caucao_Tri { get; set; }

        public bool Liq_Caucao { get; set; }

        public decimal NFeMOGI_CodAtv { get; set; }

        public bool INSS_TaxaBnf { get; set; }

        public int QtdeMaximaFuncionario { get; set; }

        public bool NFeMOGI_TribMunicipio { get; set; }

        public bool SeparaTribVTAnalitico { get; set; }

        public bool SeparaTribReembTaxa { get; set; }

        public decimal AlqTribTaxa { get; set; }

        public decimal AlqTribReemb { get; set; }

        public decimal? HorPosto1_Ini { get; set; }

        public decimal? HorPosto1_Fim { get; set; }

        public decimal? HorPosto2_Ini { get; set; }

        public decimal? HorPosto2_Fim { get; set; }

        public bool FatTaxaSobreTaxa { get; set; }

        public bool AntecipacaoFat { get; set; }

        public bool ReembISS { get; set; }

        public bool JuntarTribISS { get; set; }

        public int? CFPS { get; set; }

        public bool AbaterPISCOFCSLNOISS { get; set; }

        public decimal AlqBaseISS { get; set; }

        public string DiaVctoNFValido { get; set; }

        public decimal? NFSe_CodigoTributacao { get; set; }

        public string IDSistemaAnterior { get; set; }

        public decimal? AlqAdtoFat { get; set; }

        public int? TipoContratoWeb { get; set; }

        public int? SituacaoComercial { get; set; }

        public int? TaxaFatur2 { get; set; }

        public int? TaxaFatIndic2 { get; set; }

        public string TaxaFatur3 { get; set; }

        public string TaxaFatIndic3 { get; set; }

        public string ISSNfe { get; set; }

        public int CodigoPAIS { get; set; }

        public string EstadoExterior { get; set; }

        public string NatOperacaoNF { get; set; }

        public int CodigoCidadeServ { get; set; }

        public decimal AlqBaseINSS { get; set; }

        public bool Arred_ISS { get; set; }

        public string IdIntegracao { get; set; }

        public bool SeparaNFReeTaxDeb { get; set; }

        public int NroOrcamento { get; set; }

        public int SeqOrcamento { get; set; }

        public bool MatrizAssociacao { get; set; }

        public string MotivoDesligamento { get; set; }

        public short? DiasVctoEmiNF { get; set; }

        public string tipoEnderecoCobr { get; set; }

        public bool? TaxaTribInvert { get; set; }

        public decimal? AlqCustoOper { get; set; }

        public bool? AnteciparDiaVctoNF { get; set; }

        public decimal? TaxaFat1Menos15Dias { get; set; }

        public string TaxaFat2Menos15Dias { get; set; }

        public decimal? AlqRatEnc_INSS { get; set; }

        public decimal? AlqRatEnc_FGTS { get; set; }

        public decimal? AlqRatEnc_SalEdu { get; set; }

        public decimal? AlqRatEnc_SAT { get; set; }

        public decimal? AlqRatEnc_SESI { get; set; }

        public decimal? AlqRatEnc_SEBRAE { get; set; }

        public decimal? AlqRatEnc_INCRA { get; set; }

        public decimal? AlqRatEnc_SENAI { get; set; }

        public bool? SubsTributario { get; set; }

        public decimal? AlqRatTri_COF { get; set; }

        public decimal? AlqRatTri_ISS { get; set; }

        public decimal? AlqRatTri_CSLL { get; set; }

        public decimal? AlqRatTri_IRPJ { get; set; }

        public decimal? AlqRatTri_PIS { get; set; }

        public int ModeloDS { get; set; }

        public decimal? AlqRatEnc_ProvFer { get; set; }

        public decimal? AlqRatEnc_Prov13o { get; set; }

        public decimal? AlqRatEnc_ProvAvi { get; set; }

        public bool NaoEmitirBoletoCobranca { get; set; }

        public decimal? AlqISSLei58 { get; set; }

        public decimal AlqNFLei12741 { get; set; }

        public short? CodigoCR { get; set; }

        public decimal AlqDesctoBoleto { get; set; }

        public bool SeparaDS_CCusto { get; set; }

        public bool SeparaDS_Funcao { get; set; }

        public bool SeparaDS_Lote { get; set; }

        public decimal PercentMultaCobr { get; set; }

        public decimal PercentMoraDiariaCobr { get; set; }

        public decimal TaxaEncargos2 { get; set; }

        public decimal? AlqRatDup { get; set; }

        public short TipoFatEstoque { get; set; }

        public string Dimensao1 { get; set; }

        public string Dimensao2 { get; set; }

        public string Dimensao3 { get; set; }

        public string Dimensao4 { get; set; }

        public string Dimensao5 { get; set; }

        public decimal ValorLimiteCredito { get; set; }

        public decimal? ValorRatDup { get; set; }

        public DateTime? DataAlteracao { get; set; }

        public DateTime? DataInclusao { get; set; }

        public short FPAS { get; set; }

        public short CodTerceiro { get; set; }

        public short CodigoContratoNF { get; set; }

        public short TipoFatNF { get; set; }

        public bool DeduzirBnfPagoBaseINSS { get; set; }

        public decimal? TipoServicoEfdReinf { get; set; }

        public decimal CodAtividadeEfdReinf { get; set; }

        public string ObsDS { get; set; }

        public decimal TaxaEncargosDiversos { get; set; }

        public int GI_CodigoClienteGasc { get; set; }

        public int GI_QtdMinReciboWeb { get; set; }

        public decimal GI_ValorMinReciboWeb { get; set; }

        public decimal GI_ValorUniReciboWeb { get; set; }

        public short GI_CodigoHistorico { get; set; }

        public short GI_DiaFatReciboWeb { get; set; }

        public string GI_FiltroFat { get; set; }

        public decimal ValorFatPrevisto { get; set; }

        public bool FlagCortesiaFatGI { get; set; }

        public int PrazoMinimoVecto { get; set; }

        public string GI_CptReajusteRecibo { get; set; }

        public DateTime? GI_DataUltReajusteRecibo { get; set; }

        public int GI_QtdMinFunAdmin { get; set; }

        public decimal GI_ValorMinFunAdmin { get; set; }

        public decimal GI_ValorUniFunAdmin { get; set; }

        public short GI_CodigoHistoricoFunAdmin { get; set; }

        public bool GI_FlagCortesiaFunAdmin { get; set; }

        public short GI_DiaFatFunAdmin { get; set; }

        public string GI_FiltroFunAdmin { get; set; }

        public string GI_CptReajusteFunAdmin { get; set; }

        public DateTime? GI_DataUltReajusteFunAdmin { get; set; }

        public int GI_QtdMinSSTAdmin { get; set; }

        public decimal GI_ValorMinSSTAdmin { get; set; }

        public decimal GI_ValorUniSSTAdmin { get; set; }

        public short GI_CodigoHistoricoSSTAdmin { get; set; }

        public bool GI_FlagCortesiaSSTAdmin { get; set; }

        public short GI_DiaFatSSTAdmin { get; set; }

        public string GI_FiltroSSTAdmin { get; set; }

        public string GI_CptReajusteSSTAdmin { get; set; }

        public DateTime? GI_DataUltReajusteSSTAdmin { get; set; }

        public int GI_QtdMinAdmDigAdmin { get; set; }

        public decimal GI_ValorMinAdmDigAdmin { get; set; }

        public decimal GI_ValorUniAdmDigAdmin { get; set; }

        public short GI_CodigoHistoricoAdmDigAdmin { get; set; }

        public bool GI_FlagCortesiaAdmDigAdmin { get; set; }

        public short GI_DiaFatAdmDigAdmin { get; set; }

        public string GI_FiltroAdmDigAdmin { get; set; }

        public string GI_CptReajusteAdmDigAdmin { get; set; }

        public DateTime? GI_DataUltReajusteAdmDigAdmin { get; set; }

        public int NaturezaRendCtr { get; set; }

        public bool APISinc { get; set; }
        public bool APISincExterno { get; set; }
    }
}
