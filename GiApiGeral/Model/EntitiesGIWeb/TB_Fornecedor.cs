using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_Fornecedor : BaseTB
    {
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Código", Prompt = "Código")]
        public int CodigoFornecedor { get; set; }

        [DefaultValue(0)]
        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Condição Pagamento", Prompt = "Condição Pagamento")]
        public string? CondicaoPagamento { get; set; }

        [DefaultValue("")]
        [StringLength(11, ErrorMessage = "Maximo de 11 Caracteres.")]
        [MaxLength(11, ErrorMessage = "Maximo de 11 Caracteres.")]
        [Display(Name = "Conta Contabil", Prompt = "Conta Contabil")]
        public string? ContaContabil { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Razão Social", Prompt = "Razão Social")]
        public string? Nome { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Maximo de 70 Caracteres.")]
        [MaxLength(70, ErrorMessage = "Maximo de 70 Caracteres.")]
        [Display(Name = "Endereço", Prompt = "Endereço")]
        public string? Endereco { get; set; }

        [DefaultValue("")]
        [StringLength(60, ErrorMessage = "Maximo de 60 Caracteres.")]
        [MaxLength(60, ErrorMessage = "Maximo de 60 Caracteres.")]
        [Display(Name = "Bairro", Prompt = "Bairro")]
        public string? Bairro { get; set; }

        [DefaultValue("")]
        [StringLength(60, ErrorMessage = "Maximo de 60 Caracteres.")]
        [MaxLength(60, ErrorMessage = "Maximo de 60 Caracteres.")]
        [Display(Name = "Cidade", Prompt = "Cidade")]
        public string? Cidade { get; set; }

        [DefaultValue("")]
        [StringLength(2, ErrorMessage = "Maximo de 2 Caracteres.")]
        [MaxLength(2, ErrorMessage = "Maximo de 2 Caracteres.")]
        [Display(Name = "UF", Prompt = "UF")]
        public string? UF { get; set; }

        [DefaultValue("00000-000")]
        [StringLength(9, ErrorMessage = "Maximo de 9 Caracteres.")]
        [MaxLength(9, ErrorMessage = "Maximo de 9 Caracteres.")]
        [Display(Name = "CEP", Prompt = "CEP")]
        public string? CEP { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Maximo de 30 Caracteres.")]
        [MaxLength(30, ErrorMessage = "Maximo de 30 Caracteres.")]
        [Display(Name = "Telefone", Prompt = "Telefone")]
        public string? Telefone { get; set; }

        [DefaultValue("")]
        public string? Fax { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Email", Prompt = "Email")]
        public string? Email { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "HTTP", Prompt = "HTTP")]
        public string? HTTP { get; set; }

        [DefaultValue('1')]
        [Display(Name = "Tipo Inscrição", Prompt = "Tipo Inscrição")]
        [MaxLength(1)]
        public string? TipoInscricao { get; set; }

        [DefaultValue("00.000.000/0000-00")]
        [Display(Name = "Inscrição", Prompt = "Inscrição")]
        [StringLength(30)]
        [MaxLength(30)]
        public string? CGC { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [MaxLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [Display(Name = "Inscrição Estadual", Prompt = "Inscrição Estadual")]
        public string? InscricaoEstadual { get; set; }

        [DefaultValue("")]
        [StringLength(255, ErrorMessage = "Maximo de 255 Caracteres.")]
        [MaxLength(255, ErrorMessage = "Maximo de 255 Caracteres.")]
        [Display(Name = "Comentário", Prompt = "Comentário")]
        public string? Comentario { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Banco", Prompt = "Banco")]
        public int? Banco { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Banco", Prompt = "Banco")]
        public int? BancoFornecedor { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Maximo de 10 Caracteres")]
        [Display(Name = "Agência", Prompt = "Agência")]
        public string? NrAgencia { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [Display(Name = "Conta", Prompt = "Conta")]
        public string? NrConta { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Contato", Prompt = "Contato")]
        public string? Contato { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Código Histórico", Prompt = "Código Histórico")]
        public int? CodigoHistorico { get; set; }

        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Maximo de 1 Caracteres")]
        [Display(Name = "Máscara", Prompt = "Máscara")]
        public string? TipoMskBanco { get; set; }

        [DefaultValue(0)]
        public bool InclusaoOK { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Código Retenção", Prompt = "Código Retenção")]
        public int? CodigoRetencao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Tipo Integração", Prompt = "Tipo Integração")]
        public int IntegraContab { get; set; }

        [DefaultValue(0)]
        public bool NaoEntraCusto { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Maximo de 20 Caracteres.")]
        [MaxLength(70, ErrorMessage = "Maximo de 20 Caracteres.")]
        [Display(Name = "Cpl Endereço", Prompt = "Cpl Endereço")]
        public string CplEndereco { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [MaxLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [Display(Name = "Inscrição Municipal", Prompt = "Inscrição Municipal")]
        public string InscricaoMunicipal { get; set; }

        [DefaultValue(0)]
        public bool ConsultaRapida { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Dias", Prompt = "Dias")]
        public int DiasPagto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Min Fat", Prompt = "Valor Min Fat")]
        [Column(TypeName = "DECIMAL(11,2)")]
        public decimal? ValorMinimoFat { get; set; }

        [DefaultValue(1)]
        public bool FornecedorAtivo { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Maximo de 70 Caracteres.")]
        [MaxLength(70, ErrorMessage = "Maximo de 70 Caracteres.")]
        [Display(Name = "Endereço", Prompt = "Endereço")]
        public string EnderecoAtend { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Bairro", Prompt = "Bairro")]
        public string BairroAtend { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Cidade", Prompt = "Cidade")]
        public string CidadeAtend { get; set; }

        [DefaultValue("")]
        [StringLength(2, ErrorMessage = "Maximo de 2 Caracteres.")]
        [MaxLength(2, ErrorMessage = "Maximo de 2 Caracteres.")]
        [Display(Name = "UF", Prompt = "UF")]
        public string UFAtend { get; set; }

        [DefaultValue("")]
        [StringLength(9, ErrorMessage = "Maximo de 9 Caracteres.")]
        [MaxLength(9, ErrorMessage = "Maximo de 9 Caracteres.")]
        [Display(Name = "CEP", Prompt = "CEP")]
        public string CepAtend { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Contato Comercial", Prompt = "Contato Comercial")]
        public string ContatoComercial { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Telefone", Prompt = "Telefone")]
        public string TelefoneAtend { get; set; }

        [DefaultValue(0)]
        public bool Insumo { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Código Insumo", Prompt = "Código Insumo")]
        public int CodigoInsumo { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Maximo de 30 Caracteres.")]
        [MaxLength(30, ErrorMessage = "Maximo de 30 Caracteres.")]
        [Display(Name = "Nome Fantasia", Prompt = "Nome Fantasia")]
        public string? NomeFantasia { get; set; }

        [DefaultValue("")]
        [StringLength(2000, ErrorMessage = "Maximo de 2000 Caracteres.")]
        [MaxLength(2000, ErrorMessage = "Maximo de 2000 Caracteres.")]
        [Display(Name = "Observação", Prompt = "Observação")]
        public string Observacao { get; set; }

        [DefaultValue(0)]
        public bool AprovadoISO { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Código Cidade", Prompt = "Código Cidade")]
        public int CodigoCidade { get; set; }

        public DateTime? DataInclusao { get; set; }

        [DefaultValue(0)]
        public bool ImprimeFantasia { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [MaxLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [Display(Name = "Usuário Inclusão", Prompt = "Usuário Inclusão")]
        public string UsuarioInclusao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Dias", Prompt = "Dias")]
        public int DiasPagto2 { get; set; }

        [DefaultValue(0)]
        public bool GeraDirf { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Código CST", Prompt = "Código CST")]
        public short? CodigoCST { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Código Prestação Serviço", Prompt = "Código Prestação Serviço")]
        public int? CodigoPrestacaoServico { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Maximo de 70 Caracteres.")]
        [MaxLength(70, ErrorMessage = "Maximo de 70 Caracteres.")]
        public string IDSistemaAnterior { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Maximo de 30 Caracteres.")]
        [MaxLength(30, ErrorMessage = "Maximo de 30 Caracteres.")]
        [Display(Name = "Celular", Prompt = "Celular")]
        public string Celular { get; set; }

        [DefaultValue(0)]
        public bool IncideIRF { get; set; }

        [DefaultValue(0)]
        public bool IncideISS { get; set; }

        [DefaultValue(0)]
        public bool IncidePIS { get; set; }

        [DefaultValue(0)]
        public bool IncideCOF { get; set; }

        [DefaultValue(0)]
        public bool IncideCSLL { get; set; }

        [DefaultValue(0)]
        public bool IncideINSS { get; set; }

        [DefaultValue(0)]
        public bool IncideINSSPAT { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Almoxarifado", Prompt = "Almoxarifado")]
        public int Almoxarifado { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Taxa PIS", Prompt = "Taxa PIS")]
        [Column(TypeName = "DECIMAL(7,2)")]
        public decimal TaxaPis { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Taxa Cofins", Prompt = "Taxa Cofins")]
        [Column(TypeName = "DECIMAL(7,2)")]
        public decimal TaxaCof { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Taxa CSLL", Prompt = "Taxa CSLL")]
        [Column(TypeName = "DECIMAL(7,2)")]
        public decimal TaxaCsl { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Taxa IRRF", Prompt = "Taxa IRRF")]
        [Column(TypeName = "DECIMAL(7,2)")]
        public decimal TaxaIrf { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Taxa ISS", Prompt = "Taxa ISS")]
        [Column(TypeName = "DECIMAL(7,2)")]
        public decimal TaxaIss { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Taxa INSS", Prompt = "Taxa INSS")]
        [Column(TypeName = "DECIMAL(7,2)")]
        public decimal TaxaIns { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Taxa INSS Patr.", Prompt = "Taxa INSS Patr.")]
        [Column(TypeName = "DECIMAL(7,2)")]
        public decimal TaxaInP { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Dia Vecto ISS", Prompt = "Dia Vecto ISS")]
        public short DiaVectoIss { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Tipo Vecto ISS", Prompt = "Tipo Vecto ISS")]
        public short TipoVectoIss { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Código País", Prompt = "Código País")]
        public int CodigoPais { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Tipo Serviço EFDReinf", Prompt = "Tipo Serviço EFDReinf")]
        [Column(TypeName = "DECIMAL(14,0)")]
        public decimal? TipoServicoEfdReinf { get; set; }

        [DefaultValue(0)]
        public bool? FlagNaoEFDReinf { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Regra Portal", Prompt = "Regra Portal")]
        public byte RegraLctoPortal { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Forma Pagto", Prompt = "Forma Pagto")]
        public byte FormaPagto { get; set; }

        [DefaultValue("")]
        [Display(Name = "Tipo Inscrição", Prompt = "Tipo Inscrição")]
        [MaxLength(1)]
        public string TipoInscricaoAvalista { get; set; }

        [DefaultValue("")]
        [Display(Name = "Inscrição", Prompt = "Inscrição")]
        [StringLength(18)]
        [MaxLength(18)]
        public string NroInscricaoAvalista { get; set; }

        [DefaultValue("")]
        [StringLength(2, ErrorMessage = "Maximo de 40 Caracteres.")]
        [MaxLength(2, ErrorMessage = "Maximo de 40 Caracteres.")]
        [Display(Name = "Nome", Prompt = "Nome")]
        public string NomeAvalista { get; set; }

        [DefaultValue("")]
        [Display(Name = "Despesa Padrão", Prompt = "Despesa Padrão")]
        public string DespesaFornPadrao { get; set; }

        [DefaultValue(0)]
        public byte TipoChavePixForn { get; set; }

        [DefaultValue("")]
        public string ChavePixForn { get; set; }

        [DefaultValue(0)]
        public int NaturezaRendForn { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(5,2)")]
        public decimal? PercentRedBaseInss { get; set; }

        [DefaultValue(0)]
        public bool APISinc { get; set; }

        [DefaultValue(0)]
        public bool APISincExterno { get; set; }
    }

    public class TB_Fornecedor_old : BaseTB
    {
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Código", Prompt = "Código")]

        public int CodigoFornecedor { get; set; }

        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Condição Pagamento", Prompt = "Condição Pagamento")]
        [DefaultValue("")]
        public string CondicaoPagamento { get; set; }

        [StringLength(11, ErrorMessage = "Maximo de 11 Caracteres.")]
        [MaxLength(11, ErrorMessage = "Maximo de 11 Caracteres.")]
        [Display(Name = "Conta Contabil", Prompt = "Conta Contabil")]
        [DefaultValue("")]
        public string ContaContabil { get; set; }

        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Razão Social", Prompt = "Razão Social")]
        [DefaultValue("")]
        public string Nome { get; set; }

        [StringLength(70, ErrorMessage = "Maximo de 70 Caracteres.")]
        [MaxLength(70, ErrorMessage = "Maximo de 70 Caracteres.")]
        [Display(Name = "Endereço", Prompt = "Endereço")]
        [DefaultValue("")]
        public string Endereco { get; set; }

        [StringLength(60, ErrorMessage = "Maximo de 60 Caracteres.")]
        [MaxLength(60, ErrorMessage = "Maximo de 60 Caracteres.")]
        [Display(Name = "Bairro", Prompt = "Bairro")]
        [DefaultValue("")]
        public string Bairro { get; set; }

        [StringLength(60, ErrorMessage = "Maximo de 60 Caracteres.")]
        [MaxLength(60, ErrorMessage = "Maximo de 60 Caracteres.")]
        [Display(Name = "Cidade", Prompt = "Cidade")]
        [DefaultValue("")]
        public string Cidade { get; set; }

        [StringLength(2, ErrorMessage = "Maximo de 2 Caracteres.")]
        [MaxLength(2, ErrorMessage = "Maximo de 2 Caracteres.")]
        [Display(Name = "UF", Prompt = "UF")]
        [DefaultValue("")]
        public string UF { get; set; }

        [StringLength(9, ErrorMessage = "Maximo de 9 Caracteres.")]
        [MaxLength(9, ErrorMessage = "Maximo de 9 Caracteres.")]
        [Display(Name = "CEP", Prompt = "CEP")]
        [DefaultValue("00000-000")]
        public string CEP { get; set; }

        [StringLength(30, ErrorMessage = "Maximo de 30 Caracteres.")]
        [MaxLength(30, ErrorMessage = "Maximo de 30 Caracteres.")]
        [Display(Name = "Telefone", Prompt = "Telefone")]
        [DefaultValue("")]
        public string Telefone { get; set; }

        [StringLength(30, ErrorMessage = "Maximo de 30 Caracteres.")]
        [MaxLength(30, ErrorMessage = "Maximo de 30 Caracteres.")]
        [Display(Name = "FAX", Prompt = "FAX")]
        [DefaultValue("")]
        public string FAX { get; set; }

        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Email", Prompt = "Email")]
        [DefaultValue("")]
        public string Email { get; set; }

        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "HTTP", Prompt = "HTTP")]
        [DefaultValue("")]
        public string HTTP { get; set; }

        [Display(Name = "Tipo Inscrição", Prompt = "Tipo Inscrição")]
        [MaxLength(1)]
        public string TipoInscricao { get; set; }

        [Display(Name = "Inscrição", Prompt = "Inscrição")]
        [DefaultValue("00.000.000/0000-00")]
        [StringLength(30)]
        [MaxLength(30)]
        public string CGC { get; set; }

        [StringLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [MaxLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [Display(Name = "Inscrição Estadual", Prompt = "Inscrição Estadual")]
        [DefaultValue("")]
        public string InscricaoEstadual { get; set; }

        [StringLength(255, ErrorMessage = "Maximo de 255 Caracteres.")]
        [MaxLength(255, ErrorMessage = "Maximo de 255 Caracteres.")]
        [Display(Name = "Comentário", Prompt = "Comentário")]
        [DefaultValue("")]
        public string Comentario { get; set; }

        [Display(Name = "Banco", Prompt = "Banco")]
        [DefaultValue(0)]
        public int Banco { get; set; }

        [Display(Name = "Banco", Prompt = "Banco")]
        [DefaultValue(0)]
        public int BancoFornecedor { get; set; }

        [StringLength(10, ErrorMessage = "Maximo de 10 Caracteres")]
        [Display(Name = "Agência", Prompt = "Agência")]
        [DefaultValue("")]
        public string NrAgencia { get; set; }

        [StringLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [Display(Name = "Conta", Prompt = "Conta")]
        [DefaultValue("")]
        public string NrConta { get; set; }

        [StringLength(1, ErrorMessage = "Maximo de 1 Caracteres")]
        [Display(Name = "Máscara", Prompt = "Máscara")]
        [DefaultValue("")]
        public string TipoMskBanco { get; set; }

        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Contato", Prompt = "Contato")]
        [DefaultValue("")]
        public string Contato { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Código Histórico", Prompt = "Código Histórico")]
        public int CodigoHistorico { get; set; }

        [Display(Name = "Código Retenção", Prompt = "Código Retenção")]
        [DefaultValue(0)]
        public int CodigoRetencao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Tipo Integração", Prompt = "Tipo Integração")]
        public int IntegraContab { get; set; }

        [DefaultValue(0)]
        public bool NaoEntraCusto { get; set; }

        [StringLength(70, ErrorMessage = "Maximo de 20 Caracteres.")]
        [MaxLength(70, ErrorMessage = "Maximo de 20 Caracteres.")]
        [Display(Name = "Cpl Endereço", Prompt = "Cpl Endereço")]
        [DefaultValue("")]
        public string CplEndereco { get; set; } = "";

        [StringLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [MaxLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [Display(Name = "Inscrição Municipal", Prompt = "Inscrição Municipal")]
        [DefaultValue("")]
        public string InscricaoMunicipal { get; set; }

        [DefaultValue(0)]
        public bool ConsultaRapida { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Dias", Prompt = "Dias")]
        public int DiasPagto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Min Fat", Prompt = "Valor Min Fat")]
        public decimal ValorMinimoFat { get; set; }

        [DefaultValue(1)]
        public bool FornecedorAtivo { get; set; }

        [StringLength(70, ErrorMessage = "Maximo de 70 Caracteres.")]
        [MaxLength(70, ErrorMessage = "Maximo de 70 Caracteres.")]
        [Display(Name = "Endereço", Prompt = "Endereço")]
        [DefaultValue("")]
        public string EnderecoAtend { get; set; }

        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Bairro", Prompt = "Bairro")]
        [DefaultValue("")]
        public string BairroAtend { get; set; } = "";

        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Cidade", Prompt = "Cidade")]
        [DefaultValue("")]
        public string CidadeAtend { get; set; }

        [StringLength(2, ErrorMessage = "Maximo de 2 Caracteres.")]
        [MaxLength(2, ErrorMessage = "Maximo de 2 Caracteres.")]
        [Display(Name = "UF", Prompt = "UF")]
        [DefaultValue("")]
        public string UFAtend { get; set; }

        [StringLength(9, ErrorMessage = "Maximo de 9 Caracteres.")]
        [MaxLength(9, ErrorMessage = "Maximo de 9 Caracteres.")]
        [Display(Name = "CEP", Prompt = "CEP")]
        [DefaultValue("00000-000")]
        public string CepAtend { get; set; }

        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Contato Comercial", Prompt = "Contato Comercial")]
        [DefaultValue("")]
        public string ContatoComercial { get; set; }

        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Telefone", Prompt = "Telefone")]
        [DefaultValue("")]
        public string TelefoneAtend { get; set; }

        [DefaultValue(0)]
        public bool Insumo { get; set; }

        [Display(Name = "Código Insumo", Prompt = "Código Insumo")]
        [DefaultValue(0)]
        public int CodigoInsumo { get; set; }

        [StringLength(30, ErrorMessage = "Maximo de 30 Caracteres.")]
        [MaxLength(30, ErrorMessage = "Maximo de 30 Caracteres.")]
        [Display(Name = "Nome Fantasia", Prompt = "Nome Fantasia")]
        [DefaultValue("")]
        public string NomeFantasia { get; set; }

        [StringLength(2000, ErrorMessage = "Maximo de 2000 Caracteres.")]
        [MaxLength(2000, ErrorMessage = "Maximo de 2000 Caracteres.")]
        [Display(Name = "Observação", Prompt = "Observação")]
        [DefaultValue("")]
        public string Observacao { get; set; }

        [DefaultValue(0)]
        public bool AprovadoISO { get; set; }

        [Display(Name = "Código Cidade", Prompt = "Código Cidade")]
        [DefaultValue(0)]
        public int CodigoCidade { get; set; }

        //[Display(Name = "Data Inclusão", Prompt = "Data Inclusão")]
        //public DateTime? DataInclusao { get; set; }

        [DefaultValue(0)]
        public bool ImprimeFantasia { get; set; }

        [StringLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [MaxLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [Display(Name = "Usuário Inclusão", Prompt = "Usuário Inclusão")]
        [DefaultValue("")]
        public string UsuarioInclusao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Dias", Prompt = "Dias")]
        public int DiasPagto2 { get; set; }

        [DefaultValue(0)]
        public bool GeraDirf { get; set; }

        [Display(Name = "Código CST", Prompt = "Código CST")]
        [DefaultValue(0)]
        public int CodigoCST { get; set; }

        [Display(Name = "Código Prestação Serviço", Prompt = "Código Prestação Serviço")]
        [DefaultValue(0)]
        public int CodigoPrestacaoServico { get; set; }

        [StringLength(70, ErrorMessage = "Maximo de 70 Caracteres.")]
        [MaxLength(70, ErrorMessage = "Maximo de 70 Caracteres.")]
        [DefaultValue("")]
        public string IDSistemaAnterior { get; set; }

        [StringLength(30, ErrorMessage = "Maximo de 30 Caracteres.")]
        [MaxLength(30, ErrorMessage = "Maximo de 30 Caracteres.")]
        [Display(Name = "Celular", Prompt = "Celular")]
        [DefaultValue("")]
        public string Celular { get; set; }

        [DefaultValue(0)]
        public bool IncideIRF { get; set; }

        [DefaultValue(0)]
        public bool IncideISS { get; set; }

        [DefaultValue(0)]
        public bool IncidePIS { get; set; }

        [DefaultValue(0)]
        public bool IncideCOF { get; set; }

        [DefaultValue(0)]
        public bool IncideCSLL { get; set; }

        [DefaultValue(0)]
        public bool IncideINSS { get; set; }

        [DefaultValue(0)]
        public bool IncideINSSPat { get; set; }

        [Display(Name = "Almoxarifado", Prompt = "Almoxarifado")]
        [DefaultValue(0)]
        public int Almoxarifado { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Taxa PIS", Prompt = "Taxa PIS")]
        public decimal TaxaPis { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Taxa Cofins", Prompt = "Taxa Cofins")]
        public decimal TaxaCof { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Taxa CSLL", Prompt = "Taxa CSLL")]
        public decimal TaxaCsl { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Taxa IRRF", Prompt = "Taxa IRRF")]
        public decimal TaxaIrf { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Taxa ISS", Prompt = "Taxa ISS")]
        public decimal TaxaIss { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Taxa INSS", Prompt = "Taxa INSS")]
        public decimal TaxaIns { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Taxa INSS Patr.", Prompt = "Taxa INSS Patr.")]
        public decimal TaxaInP { get; set; }

        public bool InclusaoOk { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Dia Vecto ISS", Prompt = "Dia Vecto ISS")]
        public int DiaVectoIss { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Tipo Vecto ISS", Prompt = "Tipo Vecto ISS")]
        public int TipoVectoIss { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Código País", Prompt = "Código País")]
        public int CodigoPais { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Tipo Serviço EFDReinf", Prompt = "Tipo Serviço EFDReinf")]
        public decimal TipoServicoEfdReinf { get; set; }

        [DefaultValue(0)]
        public bool FlagNaoEFDReinf { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Regra Portal", Prompt = "Regra Portal")]
        public int RegraLctoPortal { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Forma Pagto", Prompt = "Forma Pagto")]
        public int FormaPagto { get; set; }

        [Display(Name = "Tipo Inscrição", Prompt = "Tipo Inscrição")]
        [MaxLength(1)]
        public string TipoInscricaoAvalista { get; set; }

        [Display(Name = "Inscrição", Prompt = "Inscrição")]
        [DefaultValue("00.000.000/0000-00")]
        [StringLength(18)]
        [MaxLength(18)]
        public string NroInscricaoAvalista { get; set; }

        [StringLength(2, ErrorMessage = "Maximo de 40 Caracteres.")]
        [MaxLength(2, ErrorMessage = "Maximo de 40 Caracteres.")]
        [Display(Name = "Nome", Prompt = "Nome")]
        [DefaultValue("")]
        public string NomeAvalista { get; set; }
        [Display(Name = "Despesa Padrão", Prompt = "Despesa Padrão")]
        public string DespesaFornPadrao { get; set; }

        public int TipoChavePixForn { get; set; }
        public string ChavePixForn { get; set; }
        public int NaturezaRendForn { get; set; }
        public decimal PercentRedBaseInss { get; set; }

    }
}
