using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_Duplicata : BaseTB
    {
        public short CodigoEmpresaFat { get; set; }
        public short CodigoFilialFat { get; set; }
        public int Duplicata { get; set; }
        [DefaultValue("")]
        public string Ordem { get; set; }
        [DefaultValue(0)]
        public short? CodigoEmpresa { get; set; }
        [DefaultValue(0)]
        public short? CodigoFilial { get; set; }
        [DefaultValue(0)]
        public int? CodigoCliente { get; set; }
        [DefaultValue(0)]
        public short? CodigoContrato { get; set; }
        [DefaultValue(0)]
        public short? TipoFat { get; set; }
        [DefaultValue(0)]
        public int? CodigoCentroCusto { get; set; }
        [DefaultValue(0)]
        public short? CodigoVendedor { get; set; }
        [DefaultValue(0)]
        public short? CodigoSelecionador { get; set; }
        [DefaultValue(0)]
        public short? CodigoRecrutador { get; set; }
        [DefaultValue(0)]
        public short? CodigoBanco { get; set; }
        public DateTime? DataEmissao { get; set; }
        public DateTime? DataVecto { get; set; }
        public DateTime? DataBaixa { get; set; }
        public DateTime? DataCredito { get; set; }
        [DefaultValue("")]
        public string? DataCompetencia { get; set; }
        [DefaultValue(0)]
        public decimal? ValorPagoFolha { get; set; }
        [DefaultValue(0)]
        public decimal? ValorReembolso { get; set; }
        [DefaultValue(0)]
        public decimal? ValorTaxa { get; set; }
        [DefaultValue(0)]
        public decimal? ValorBruto { get; set; }
        [DefaultValue(0)]
        public decimal? BaseIRF { get; set; }
        [DefaultValue(0)]
        public decimal? BaseINSS { get; set; }
        [DefaultValue(0)]
        public decimal? BaseISS { get; set; }
        [DefaultValue(0)]
        public decimal? BaseIPI { get; set; }
        [DefaultValue(0)]
        public decimal? BaseTributo { get; set; }
        [DefaultValue(0)]
        public decimal? BasePis { get; set; }
        [DefaultValue(0)]
        public decimal? BaseCofins { get; set; }
        [DefaultValue(0)]
        public decimal? ValorIRF { get; set; }
        [DefaultValue(0)]
        public decimal? ValorINSS { get; set; }
        [DefaultValue(0)]
        public decimal? ValorISS { get; set; }
        [DefaultValue(0)]
        public decimal? ValorIPI { get; set; }
        [DefaultValue(0)]
        public decimal? ValorTributo { get; set; }
        [DefaultValue(0)]
        public decimal? ValorPis { get; set; }
        [DefaultValue(0)]
        public decimal? ValorCofins { get; set; }
        [DefaultValue(0)]
        public decimal? ValorLiquido { get; set; }
        [DefaultValue(0)]
        public decimal? ValorBaixa { get; set; }
        [DefaultValue(0)]
        public decimal? ValorJuros { get; set; }
        [DefaultValue(0)]
        public decimal? ValorDesconto { get; set; }
        [DefaultValue(0)]
        public decimal? ValorMulta { get; set; }
        [DefaultValue("")]
        public string? Status { get; set; }
        [DefaultValue('N')]
        public string? TipoDuplicata { get; set; }
        [DefaultValue("")]
        public string? NumeroBoleto { get; set; }
        [DefaultValue("")]
        public string? Descricao { get; set; }
        [DefaultValue(0)]
        public decimal? ValorBeneficio { get; set; }
        [DefaultValue(0)]
        public int? ChaveMovtoBanco { get; set; }
        [DefaultValue(0)]
        public bool InclusaoOK { get; set; }
        [DefaultValue(0)]
        public int? ChaveMovtoBancoJD { get; set; }
        [DefaultValue("")]
        public string? MotivoCancelamento { get; set; }
        [DefaultValue("")]
        public string? DataCompetencia2 { get; set; }
        [DefaultValue("")]
        public string DataVectoImp { get; set; }
        [DefaultValue(0)]
        public decimal BaseCSLL { get; set; }
        [DefaultValue(0)]
        public decimal ValorCSLL { get; set; }
        [DefaultValue(0)]
        public bool NF13oSalario { get; set; }
        [DefaultValue(0)]
        public decimal ValorLiquidoDS { get; set; }
        [DefaultValue(0)]
        public short? CodigoBancoOriginal { get; set; }
        [DefaultValue(0)]
        public decimal AlqISS { get; set; }
        [DefaultValue(0)]
        public decimal? BaseISSReal { get; set; }
        [DefaultValue(0)]
        public decimal BaseCaucao { get; set; }
        [DefaultValue(0)]
        public decimal ValorCaucao { get; set; }
        [DefaultValue("")]
        public string? Observacao { get; set; }
        [DefaultValue(0)]
        public decimal NossoNumero { get; set; }
        public string? NFeXML { get; set; }
        public string? NFeResultadoEnvio { get; set; }
        public string? NFeRetorno { get; set; }
        [DefaultValue(0)]
        public byte? Situacao { get; set; }
        [DefaultValue(0)]
        public decimal ValorJurosNegociado { get; set; }
        [DefaultValue(0)]
        public decimal ValorMultaNegociada { get; set; }
        [DefaultValue(0)]
        public decimal? ValorInssOri { get; set; }
        [DefaultValue(0)]
        public decimal? ValorCsllOri { get; set; }
        [DefaultValue(0)]
        public decimal? ValorPisOri { get; set; }
        [DefaultValue(0)]
        public decimal? ValorIrfOri { get; set; }
        [DefaultValue(0)]
        public decimal? ValorCofinsOri { get; set; }
        [DefaultValue(0)]
        public decimal? ValorIssRetido { get; set; }
        [DefaultValue(0)]
        public decimal? ValorIssRecolhido { get; set; }
        [DefaultValue(0)]
        public decimal? ValorLiquidoOri { get; set; }
        [DefaultValue("")]
        public string? Obs1Emissao { get; set; }
        [DefaultValue("")]
        public string? Obs2Emissao { get; set; }
        [DefaultValue("")]
        public string? Obs3Emissao { get; set; }
        [DefaultValue("")]
        public string IDSistemaAnterior { get; set; }
        [DefaultValue(0)]
        public decimal? ValorBoleto { get; set; }
        [DefaultValue(0)]
        public int NroNotaDB { get; set; }
        [DefaultValue(0)]
        public decimal? ValorAbatimentoNDB { get; set; }
        [DefaultValue(0)]
        public bool FlagExportacao { get; set; }
        [DefaultValue(0)]
        public int? NumeroRPS { get; set; }
        [DefaultValue(0)]
        public bool? ProvisaoIntegrada { get; set; }
        [DefaultValue(0)]
        public bool? BaixaIntegrada { get; set; }
        [DefaultValue(0)]
        public bool NfeExportada { get; set; }
        public DateTime? DataCadastro { get; set; }
        [DefaultValue("")]
        public string? FormularioOrigem { get; set; }
        [DefaultValue(0)]
        public bool? Tri_Tri { get; set; }
        [DefaultValue(0)]
        public decimal? AlqTriBnf { get; set; }
        [DefaultValue(0)]
        public decimal? AlqTriFol { get; set; }
        [DefaultValue("")]
        public string? CodigoDepto { get; set; }
        [DefaultValue(0)]
        public short? FaseEnvioCobr { get; set; }
        public DateTime? DataEnvioAviso { get; set; }
        [DefaultValue(0)]
        public short? CodigoCR { get; set; }
        [DefaultValue(0)]
        public decimal? NroNFe { get; set; }
        [DefaultValue("")]
        public string? CodigoVerificacaoNFe { get; set; }
        [DefaultValue(0)]
        public short? CodigoCRJD { get; set; }
        [DefaultValue(0)]
        public decimal? LiqNFe { get; set; }
        [DefaultValue(0)]
        public decimal? ValorVariacaoCambial { get; set; }
        [DefaultValue(0)]
        public bool ContratoMulti { get; set; }
        [DefaultValue(0)]
        public decimal? ValorIrfDevBX { get; set; }
        [DefaultValue(0)]
        public decimal? ValorPisDevBX { get; set; }
        [DefaultValue(0)]
        public decimal? ValorCofDevBX { get; set; }
        [DefaultValue(0)]
        public decimal? ValorCsllDevBX { get; set; }
        [DefaultValue(0)]
        public decimal? ValorIssDevBX { get; set; }
        [DefaultValue(0)]
        public decimal? ValorInssDevBX { get; set; }
        [DefaultValue(0)]
        public decimal? ValorOutrasDevBX { get; set; }
        [DefaultValue(1)]
        public byte? TipoBaixaRemessa { get; set; }
        [DefaultValue(0)]
        public decimal? ValorBrutoAntesParcelamento { get; set; }
        [DefaultValue(0)]
        public decimal? ValorLiquidoAntesParcelamento { get; set; }
        [DefaultValue(0)]
        public decimal? ValorCompensadoAntecipacao { get; set; }
        [DefaultValue(0)]
        public decimal? ValorDescontoAntecipacao { get; set; }
        [DefaultValue(0)]
        public short? QtdParcelas { get; set; }
        [DefaultValue("")]
        public string UsuarioInclusao { get; set; }
        [DefaultValue(0)]
        public bool APISinc { get; set; }
        [DefaultValue(0)]
        public bool APISincExterno { get; set; }



        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        //[Display(Name = "Empresa Prompt = "Empresa")]
        //public int CodigoEmpresaFat { get; set; }
        //
        //[Display(Name = "Filial Prompt = "Filial")]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        //public int CodigoFilialFat { get; set; }
        //
        //[Display(Name = "Duplicata Prompt = "Duplicata")]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        //public int Duplicata { get; set; }
        //
        //[StringLength(3, ErrorMessage = "Maximo de caracteres são de 3.")]
        //[MaxLength(3, ErrorMessage = "Maximo de caracteres são de 3.")]
        ////[Required(ErrorMessage = "Campo Obrigatorio!")]
        //[Display(Name = "Ord Prompt = "Ord")]
        //[DefaultValue("")]
        //public string Ordem { get; set; }
        //
        //[Display(Name = "Empresa Prompt = "Empresa")]
        //public int CodigoEmpresa { get; set; }
        //
        //[Display(Name = "Filial Prompt = "Filial")]
        //public int CodigoFilial { get; set; }
        //
        //[Display(Name = "Cliente Prompt = "Cliente")]
        //public int CodigoCliente { get; set; }
        //
        //[Display(Name = "Contrato Prompt = "Contrato")]
        //public int CodigoContrato { get; set; }
        //
        //[Display(Name = "Tipo Faturam. Prompt = "Tipo Faturam.")]
        //public int TipoFat { get; set; }
        //
        //[Display(Name = "Centro de Custo Prompt = "Centro de Custo")]
        //public int CodigoCentroCusto { get; set; }
        //
        //[Display(Name = "Vendedor Prompt = "Vendedor")]
        //public int CodigoVendedor { get; set; }
        //
        //[Display(Name = "Selecionador Prompt = "Selecionador")]
        //public int CodigoSelecionador { get; set; }
        //
        //[Display(Name = "Recrutador Prompt = "Recrutador")]
        //public int CodigoRecrutador { get; set; }
        //
        //[Display(Name = "Banco Prompt = "Banco")]
        //public int CodigoBanco { get; set; }
        //
        //[Display(Name = "Emissão Prompt = "Emissão")]
        //public DateTime? DataEmissao { get; set; }
        //
        //[Display(Name = "Vencimento Prompt = "Vencimento")]
        //public DateTime? DataVecto { get; set; }
        //
        //[Display(Name = "Baixa Prompt = "Baixa")]
        //public DateTime? DataBaixa { get; set; }
        //
        //[Display(Name = "Crédito Prompt = "Crédito")]
        //public DateTime? DataCredito { get; set; }
        //
        //[StringLength(6, ErrorMessage = "Maximo de caracteres são de 6.")]
        //[MaxLength(6, ErrorMessage = "Maximo de caracteres são de 6.")]
        //[Display(Name = "1ª Cpt. Prompt = "1ª Cpt.")]
        //public string DataCompetencia { get; set; }
        //
        //[Display(Name = "Pago (Folha) Prompt = "Pago (Folha)")]
        //public decimal ValorPagoFolha { get; set; }
        //
        //[Display(Name = "Reembolso Prompt = "Reembolso")]
        //public decimal ValorReembolso { get; set; }
        //
        //[Display(Name = "Taxa Prompt = "Taxa")]
        //public decimal ValorTaxa { get; set; }
        //
        //[Display(Name = "Bruto Prompt = "Bruto")]
        //public decimal ValorBruto { get; set; }
        //
        //[Display(Name = "IRF Prompt = "IRF")]
        //public decimal BaseIRF { get; set; }
        //
        //[Display(Name = "INSS Prompt = "INSS")]
        //public decimal BaseINSS { get; set; }
        //
        //[Display(Name = "ISS Prompt = "ISS")]
        //public decimal BaseISS { get; set; }
        //
        //[Display(Name = "IPI Prompt = "IPI")]
        //public decimal BaseIPI { get; set; }
        //
        //[Display(Name = "Tributo Prompt = "Tributo")]
        //public decimal BaseTributo { get; set; }
        //
        //[Display(Name = "PIS Prompt = "PIS")]
        //public decimal BasePis { get; set; }
        //
        //[Display(Name = "Cofins Prompt = "Cofins")]
        //public decimal BaseCofins { get; set; }
        //
        //[Display(Name = "IRF Prompt = "IRF")]
        //public decimal ValorIRF { get; set; }
        //
        //[Display(Name = "INSS Prompt = "INSS")]
        //public decimal ValorINSS { get; set; }
        //
        //[Display(Name = "ISS Prompt = "ISS")]
        //public decimal ValorISS { get; set; }
        //
        //[Display(Name = "IPI Prompt = "IPI")]
        //public decimal ValorIPI { get; set; }
        //
        //[Display(Name = "Tributo Prompt = "Tributo")]
        //public decimal ValorTributo { get; set; }
        //
        //[Display(Name = "PIS Prompt = "PIS")]
        //public decimal ValorPis { get; set; }
        //
        //[Display(Name = "Cofins Prompt = "Cofins")]
        //public decimal ValorCofins { get; set; }
        //
        //[Display(Name = "Líquido Prompt = "Líquido")]
        //public decimal ValorLiquido { get; set; }
        //
        //[Display(Name = "Baixa Prompt = "Baixa")]
        //public decimal ValorBaixa { get; set; }
        //
        //[Display(Name = "Juros Prompt = "Juros")]
        //public decimal ValorJuros { get; set; }
        //
        //[Display(Name = "Desconto Prompt = "Desconto")]
        //public decimal ValorDesconto { get; set; }
        //
        //[Display(Name = "Multa Prompt = "Multa")]
        //public decimal ValorMulta { get; set; }
        //
        //[StringLength(1, ErrorMessage = "Maximo de caracteres são de 1.")]
        //[MaxLength(1, ErrorMessage = "Maximo de caracteres são de 1.")]
        //[DefaultValue("A")]
        //public string Status { get; set; }
        //
        //[StringLength(1, ErrorMessage = "Maximo de caracteres são de 1.")]
        //[MaxLength(1, ErrorMessage = "Maximo de caracteres são de 1.")]
        //[Display(Name = "Tipo Prompt = "Tipo")]
        //[DefaultValue("N")]
        //public string TipoDuplicata { get; set; }
        //
        //[StringLength(30, ErrorMessage = "Maximo de caracteres são de 30.")]
        //[MaxLength(30, ErrorMessage = "Maximo de caracteres são de 30.")]
        //[Display(Name = "Boleto Prompt = "Boleto")]
        //public string NumeroBoleto { get; set; }
        //
        //[StringLength(50, ErrorMessage = "Maximo de caracteres são de 50.")]
        //[MaxLength(50, ErrorMessage = "Maximo de caracteres são de 50.")]
        //public string Descricao { get; set; }
        //
        //[Display(Name = "Benefício Prompt = "Benefício")]
        //public decimal ValorBeneficio { get; set; }
        //public int ChaveMovtoBanco { get; set; }
        //public bool InclusaoOK { get; set; }
        //public int ChaveMovtoBancoJD { get; set; }
        //
        //[StringLength(60, ErrorMessage = "Maximo de caracteres são de 60.")]
        //[MaxLength(60, ErrorMessage = "Maximo de caracteres são de 60.")]
        //public string MotivoCancelamento { get; set; }
        //
        //[StringLength(6, ErrorMessage = "Maximo de caracteres são de 6.")]
        //[MaxLength(6, ErrorMessage = "Maximo de caracteres são de 6.")]
        //[Display(Name = "2ª Cpt. Prompt = "2ª Cpt.")]
        //public string DataCompetencia2 { get; set; }
        //
        //[StringLength(10, ErrorMessage = "Maximo de caracteres são de 10.")]
        //[MaxLength(10, ErrorMessage = "Maximo de caracteres são de 10.")]
        //// [Required(ErrorMessage = "Campo Obrigatorio!")]
        //public string DataVectoImp { get; set; }
        //
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        //[Display(Name = "CSLL Prompt = "CSLL")]
        //public decimal BaseCSLL { get; set; }
        //
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        //[Display(Name = "CSLL Prompt = "CSLL")]
        //public decimal ValorCSLL { get; set; }
        //
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        //public bool NF13oSalario { get; set; }
        //
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        //public decimal ValorLiquidoDS { get; set; }
        //public int CodigoBancoOriginal { get; set; }
        //
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        //public decimal AlqISS { get; set; }
        //public decimal BaseISSReal { get; set; }
        //
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        //[Display(Name = "Caução Prompt = "Caução")]
        //public decimal BaseCaucao { get; set; }
        //
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        //[Display(Name = "Caução Prompt = "Caução")]
        //public decimal ValorCaucao { get; set; }
        //
        //[StringLength(200, ErrorMessage = "Maximo de caracteres são de 200.")]
        //[MaxLength(200, ErrorMessage = "Maximo de caracteres são de 200.")]
        //[Display(Name = "Observação Prompt = "Observação")]
        //public string Observacao { get; set; }
        //
        //[Display(Name = "Nosso Número Prompt = "Nosso Número")]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        //public decimal NossoNumero { get; set; }
        //
        //[StringLength(3000, ErrorMessage = "Maximo de caracteres são de 3000.")]
        //[MaxLength(3000, ErrorMessage = "Maximo de caracteres são de 3000.")]
        //public string NFeXML { get; set; }
        //
        //[StringLength(600, ErrorMessage = "Maximo de caracteres são de 600.")]
        //[MaxLength(600, ErrorMessage = "Maximo de caracteres são de 600.")]
        //public string NFeResultadoEnvio { get; set; }
        //
        //[StringLength(600, ErrorMessage = "Maximo de caracteres são de 600.")]
        //[MaxLength(600, ErrorMessage = "Maximo de caracteres são de 600.")]
        //public string NFeRetorno { get; set; }
        //public int Situacao { get; set; }
        //
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        //public decimal ValorJurosNegociado { get; set; }
        //
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        //public decimal ValorMultaNegociada { get; set; }
        //public decimal ValorInssOri { get; set; }
        //public decimal ValorCsllOri { get; set; }
        //public decimal ValorPisOri { get; set; }
        //public decimal ValorIrfOri { get; set; }
        //public decimal ValorCofinsOri { get; set; }
        //public decimal ValorIssRetido { get; set; }
        //public decimal ValorIssRecolhido { get; set; }
        //public decimal ValorLiquidoOri { get; set; }
        //
        //[StringLength(100, ErrorMessage = "Maximo de caracteres são de 100.")]
        //[MaxLength(100, ErrorMessage = "Maximo de caracteres são de 100.")]
        ////[Display(Name = ". Prompt = "")]
        //public string Obs1Emissao { get; set; }
        //
        //[StringLength(100, ErrorMessage = "Maximo de caracteres são de 100.")]
        //[MaxLength(100, ErrorMessage = "Maximo de caracteres são de 100.")]
        ////[Display(Name = ". Prompt = "")]
        //public string Obs2Emissao { get; set; }
        //
        //[StringLength(100, ErrorMessage = "Maximo de caracteres são de 100.")]
        //[MaxLength(100, ErrorMessage = "Maximo de caracteres são de 100.")]
        ////[Display(Name = ". Prompt = "")]
        //public string Obs3Emissao { get; set; }
        //
        //[StringLength(70, ErrorMessage = "Maximo de caracteres são de 70.")]
        //[MaxLength(70, ErrorMessage = "Maximo de caracteres são de 70.")]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        //public string IDSistemaAnterior { get; set; }
        //
        //[Display(Name = "Boleto Prompt = "Boleto")]
        //public decimal ValorBoleto { get; set; }
        //
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        //public int NroNotaDB { get; set; }
        //public decimal ValorAbatimentoNDB { get; set; }
        //
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        //public bool FlagExportacao { get; set; }
        //public int NumeroRPS { get; set; }
        //public bool ProvisaoIntegrada { get; set; }
        //public bool BaixaIntegrada { get; set; }
        //
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        //public bool NfeExportada { get; set; }
        //public DateTime? DataCadastro { get; set; }
        //
        //[StringLength(50, ErrorMessage = "Maximo de caracteres são de 50.")]
        //[MaxLength(50, ErrorMessage = "Maximo de caracteres são de 50.")]
        //public string FormularioOrigem { get; set; }
        //public bool Tri_Tri { get; set; }
        //public decimal AlqTriBnf { get; set; }
        //public decimal AlqTriFol { get; set; }
        //
        //[StringLength(20, ErrorMessage = "Maximo de caracteres são de 20.")]
        //[MaxLength(20, ErrorMessage = "Maximo de caracteres são de 20.")]
        //public string CodigoDepto { get; set; }
        //public int FaseEnvioCobr { get; set; }
        //public DateTime? DataEnvioAviso { get; set; }
        //public int CodigoCR { get; set; }
        //public decimal NroNFe { get; set; }
        //
        //[StringLength(80, ErrorMessage = "Maximo de caracteres são de 80.")]
        //[MaxLength(80, ErrorMessage = "Maximo de caracteres são de 80.")]
        //public string CodigoVerificacaoNFe { get; set; }
        //public int CodigoCRJD { get; set; }
        //public decimal LiqNFe { get; set; }
        //
        //[Display(Name = "Variação Cambial Prompt = "Variação Cambial")]
        //public decimal ValorVariacaoCambial { get; set; }
        //
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        //public bool ContratoMulti { get; set; }
        //public decimal ValorIrfDevBX { get; set; }
        //public decimal ValorPisDevBX { get; set; }
        //public decimal ValorCofDevBX { get; set; }
        //public decimal ValorCsllDevBX { get; set; }
        //public decimal ValorIssDevBX { get; set; }
        //public decimal ValorInssDevBX { get; set; }
        //public decimal ValorOutrasDevBX { get; set; }
        //public int TipoBaixaRemessa { get; set; }
        //
        //public decimal ValorBrutoAntesParcelamento { get; set; }
        //public decimal ValorLiquidoAntesParcelamento { get; set; }
        //public decimal ValorCompensadoAntecipacao { get; set; }
        //public decimal ValorDescontoAntecipacao { get; set; }
        //public int QtdParcelas { get; set; }
        //public string UsuarioInclusao { get; set; }

    }
}
