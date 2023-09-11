using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_FuncionarioSelecao
    {

        //[DefaultValue("")]
        //[Display(Name = "Foto")]
        //public string FotoFuncionario { get; set; }

        public DateTime? DataUltAtuTurnovo { get; set; }

        public DateTime? DataInclusao { get; set; }

        public DateTime? Dataalteracao { get; set; }

        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        public string CodigoAfastamento { get; set; }

        [DefaultValue(0)]
        public int Situacao { get; set; }

        [DefaultValue("")]
        [StringLength(300, ErrorMessage = "Máximo 300 caracteres.")]
        [MaxLength(300, ErrorMessage = "Máximo 300 caracteres.")]
        public string Foto { get; set; }

        [DefaultValue(false)]
        public bool DeficienteFisico { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        public string PortadorCheque { get; set; }

        public bool? DescontaCS { get; set; }

        [DefaultValue(false)]
        public bool DescontaCC { get; set; }

        [DefaultValue(false)]
        public bool DescontaMS { get; set; }

        [DefaultValue(false)]
        public bool DescontaCA { get; set; }

        [DefaultValue(false)]
        public bool DescontaTA { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public bool InclusaoOK { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public decimal ValorUltimoBnfInformado { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public bool TransferenciaOnus { get; set; }

        //[DefaultValue("")]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        public string IDSistemaAnterior { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public int EventoPensao13o { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public int EventoPensaoFer { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public int BasePensao13o { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public int BasePensaoFer { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public decimal AliqPensao13o { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public decimal AliqPensaoFer { get; set; }

        [DefaultValue("")]
        [StringLength(120, ErrorMessage = "Máximo 120 caracteres.")]
        [MaxLength(120, ErrorMessage = "Máximo 120 caracteres.")]
        public string UsuarioInclusao { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        public string SenhaCaixinha { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public bool NovoBnf { get; set; }

        [DefaultValue(0)]
        public decimal SAP_Id { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        public string SAP_Area { get; set; }

        [DefaultValue(0)]
        public decimal CodigoFuncionarioWEB { get; set; }

        [DefaultValue(0)]
        public int IdUsuarioGI { get; set; }

        [DefaultValue(0)]
        public int QtdeBnfInformado { get; set; }

        public int PercentFatu2 { get; set; }

        [DefaultValue("")]
        [StringLength(6, ErrorMessage = "Máximo 6 caracteres.")]
        [MaxLength(6, ErrorMessage = "Máximo 6 caracteres.")]
        public string PercentFatu3 { get; set; }

        [DefaultValue("")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string ObsWeb { get; set; }

        [DefaultValue(0)]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        public string CartaApresentacao { get; set; }

        [DefaultValue(true)]
        public bool residenciaPropria { get; set; }

        [DefaultValue(false)]
        public bool residenciarecursoFGTS { get; set; }

        [DefaultValue(0)]
        public decimal vlrSalVariavel { get; set; }

        public DateTime? DataDemissaoAgenda { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        public string codConv { get; set; }

        public DateTime? DataIniEdicaoPortal { get; set; }

        [DefaultValue("")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string CertificadoSeguranca { get; set; }

        public DateTime? DTIniEdicaoPortal { get; set; }

        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        public string TipoOperacaoWeb { get; set; }

        [DefaultValue(0)]
        public decimal cpfAnt { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        public string matricAnt { get; set; }

        public DateTime? dtAltCPF { get; set; }

        [DefaultValue("")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string ObsAltCPF { get; set; }

        [DefaultValue("")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string objDet { get; set; }

        #region Geral

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Empresa", Prompt = "Empresa")]
        public int CodigoEmpresa { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Filial", Prompt = "Filial")]
        public int CodigoFilial { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Código", Prompt = "Código")]
        public int CodigoFuncionario { get; set; }

        [DefaultValue("")]
        [StringLength(60, ErrorMessage = "Nome Inválido para o e-Social! Ulrapassou o limite de 60 caracteres!")]
        [MaxLength(60, ErrorMessage = "Nome Inválido para o e-Social! Ulrapassou o limite de 60 caracteres!")]
        [Display(Name = "Nome", Prompt = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Qualificado no e-Social", Prompt = "Qualificado no e-Social")]
        public bool eSocialQualifCad { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Matrícula no e-Social", Prompt = "Matrícula no e-Social")]
        public string eSocialMatricula { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Cliente", Prompt = "Cliente")]
        [Required(ErrorMessage = "Selecione um Cliente!")]
        public int CodigoCliente { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Contrato", Prompt = "Contrato")]
        [Required(ErrorMessage = "Digite o Contrato/Tipo!")]
        public int CodigoContrato { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Tipo de Faturamento", Prompt = "Tipo de Faturamento")]
        //[Required(ErrorMessage = "Digite o Contrato/Tipo!")]
        public int TipoFat { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Função", Prompt = "Função")]
        //[Required(ErrorMessage = "Selecione uma Função!")]
        public int CodigoFuncao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Horário", Prompt = "Horário")]
        [Required(ErrorMessage = "Selecione um Horário!")]
        public int CodigoHorario { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Submetidos a Horário de Trabalho(Cap.II da CLT)
        /// 2 - Atividade Externa especificada no Inciso I do Art. 62 da CLT
        /// 3 - Funções específicadas no Inciso II do Art. 62 da CLT
        /// 4 - Teletrabalho, previsto no Inciso III do Art. 62 da CLT
        /// </summary>
        [DefaultValue(0)]
        [Display(Name = "Regime de Jornada do Empregado", Prompt = "Regime de Jornada do Empregado")]
        public int tpRegimeJor { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Jornada com horário diário e folga fixos
        /// 2 - Jornada 12 x 36 (12 horas de trabalho seguidas de 36 horas ininterruptas de descanso)
        /// 3 - Jornada com horário diário fixo e folga variável
        /// 9 - Demais tipos de jornada
        /// </summary>
        [DefaultValue(1)]
        [Display(Name = "", Prompt = "Tipo da Jornada")]
        public int tpJornada { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Região", Prompt = "Região")]
        [Required(ErrorMessage = "Selecione uma Regiao!")]
        public int Regiao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Centro de Custo", Prompt = "Centro de Custo")]
        public int CodigoCentroCusto { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Departamento", Prompt = "Departamento")]
        public string CodigoDepto { get; set; }

        [Display(Name = "Admissão", Prompt = "Admissão")]
        public DateTime? DataAdmissao { get; set; }

        /// <summary>
        /// 1 - Contrato CLT
        /// 2 - Estagiário(Lei Antiga)
        /// 3 - Avulso
        /// 4 - Temporário
        /// 5 - Diretor sem FGTS
        /// 6 - Serviço não Efetivo
        /// 7 - CLT Prazo Determinado
        /// 8 - Diretor com FGTS
        /// 9 - Outros
        /// C - Agente Público
        /// D - Autônomo que Contribui com Remuneração
        /// E - Autônomo que Contribui com Salário Base
        /// F - Transportador Autônomo que Contribui com Remuneração
        /// G - Transportador Autônomo que Contribui com Salário Base
        /// H - Menor Aprendiz(Lei 10.097/2000)
        /// I - Doméstico(a)
        /// J - Estagiário(Nova Lei 11.788 09/2008)
        /// K - Contrato Intermitente
        /// </summary>
        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Vínculo", Prompt = "Vínculo")]
        public string Vinculo { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Trabalho Urbano
        /// 2 - Trabalho Rural
        /// </summary>
        [DefaultValue(1)]
        [Display(Name = "Natureza da Atividade", Prompt = "Natureza da Atividade")]
        public int natAtividade { get; set; }

        /// <summary>
        /// 000 - Não Informado
        /// 101 - Empregado - Geral, inclusive o empregado público da administração direta ou indireta contratado pela CLT
        /// 102 - Empregado - Trabalhador Rural por Pequeno Prazo da Lei 11.718/2008
        /// 103 - Empregado - Aprendiz
        /// 104 - Empregado - Doméstico
        /// 105 - Empregado - contrato a termo firmado nos termos da Lei 9601/98
        /// 106 - Empregado - contrato por prazo determinado nos termos da Lei 6019/74
        /// 111 - Empregado - contrato de trabalho intermitente
        /// 201 - Trabalhador Avulso Portuário
        /// 202 - Trabalhador Avulso Não Portuário
        /// 301 - Servidor Público Titular de Cargo Efetivo, Magistrado, Ministro de Tribunal de Contas, Conselheiro de Tribunal de Contas e Membro do Ministério Público
        /// 302 - Servidor Público Ocupante de Cargo exclusivo em comissão
        /// 303 - Agente Político
        /// 305 - Servidor Público indicado para conselho ou órgão representativo, na condição de representante do governo, órgão ou entidade da administração pública
        /// 306 - Servidor Público Temporário, sujeito a regime administrativo especial definido em lei própria
        /// 307 - Militar Efetivo
        /// 308 - Conscrito
        /// 309 - Agente Público - Outros
        /// 401 - Dirigente Sindical - informação prestada pelo Sindicato
        /// 410 - Trabalhador cedido - informação prestada pelo Cessionário
        /// 701 - Contribuinte individual - Autônomo em geral, exceto se enquadrado em uma das demais categorias de contribuinte individual
        /// 711 - Contribuinte individual - Transportador autônomo de passageiros
        /// 712 - Contribuinte individual - Transportador autônomo de carga
        /// 721 - Contribuinte individual - Diretor não empregado, com FGTS
        /// 722 - Contribuinte individual - Diretor não empregado, sem FGTS
        /// 723 - Contribuinte individual - empresários, sócios e membro de conselho de administração ou fiscal
        /// 731 - Contribuinte individual - Cooperado que presta serviços por intermédio de Cooperativa de Trabalho
        /// 734 - Contribuinte individual - Transportador Cooperado que presta serviços por intermédio de cooperativa de trabalho
        /// 738 - Contribuinte individual - Cooperado filiado a Cooperativa de Produção
        /// 741 - Contribuinte individual - Micro Empreendedor Individual
        /// 751 - Contribuinte individual - magistrado classista temporário da Justiça do Trabalho ou da Justiça Eleitoral que seja aposentado de qualquer regime prev.
        /// 761 - Contribuinte individual - Associado eleito para direção de Cooperativa, associação ou entidade de classe de qualquer natureza ou finalidade
        /// 771 - Contribuinte individual - Membro de conselho tutelar, nos termos da Lei nº 8.069, de 13 de julho de 1990
        /// 781 - Ministro de confissão religiosa ou membro de vida consagrada, de congregação ou de ordem religiosa
        /// 901 - Estagiário
        /// 902 - Médico Residente
        /// 903 - Bolsista, nos termos da lei 8958/1994
        /// </summary>
        [DefaultValue(0)]
        [Display(Name = "Categoria do Trabalhador", Prompt = "Categoria do Trabalhador")]
        public int codCateg_eSocial { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Admissão
        /// 2 - Transferência de empresa do mesmo grupo econômico
        /// 3 - Transferência de empresa consorciada ou de consórcio
        /// 4 - Transferência por motivo de sucessão, incorporação, cisão ou fusão 
        /// 5 - Transferência do empregado doméstico para outro representante da mesma unidade familiar
        /// </summary>
        [DefaultValue(1)]
        [Display(Name = "Tipo de Admissão do Trabalhador", Prompt = "Tipo de Admissão do Trabalhador")]
        public int tpAdmissao { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - CLT - Consolidação das Leis de Trabalho e legislações trabalhistas
        /// 2 - Estatutário
        /// </summary>
        [DefaultValue(1)]
        [Display(Name = "Tipo de Regime Trabalhista", Prompt = "Tipo de Regime Trabalhista")]
        public int tpRegimeTrab { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - RGPS - Regime Geral da Previdência Social
        /// 2 - RPPS - Regime Próprio de Previdência Social
        /// 3 - RPPE - Regime de Previdência Social no Exterior
        /// </summary>
        [DefaultValue(1)]
        [Display(Name = "Tipo de Regime Previdenciário", Prompt = "Tipo de Regime Previdenciário")]
        public int tpRegimePrev { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Normal
        /// 2 - Decorrente de Ação Fiscal
        /// 3 - Decorrente de Decisão Judicial
        /// </summary>
        [DefaultValue(1)]
        [Display(Name = "Indicativo de Admissão", Prompt = "Indicativo de Admissão")]
        public int indAdmissao { get; set; }

        /// <summary>
        /// Direta
        /// Indireta
        /// </summary>
        [DefaultValue("D")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Tipo", Prompt = "Tipo")]
        public string TipoAdmissao { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Nro. Processo Judicial", Prompt = "Nro. Processo Judicial")]
        public string nrProcJudAlvaraJudicial { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Normal
        /// 2 - Decorrente de Decisão Judicial
        /// </summary>
        [DefaultValue(1)]
        [Display(Name = "Tipo Trabalhador Estatutário", Prompt = "Tipo Trabalhador Estatutário")]
        public int indProvim { get; set; }

        [Display(Name = "Demissão", Prompt = "Demissão")]
        public DateTime? DataDemissao { get; set; }

        /// <summary>
        /// 
        /// 1 - Pela Empresa com Justa Causa
        /// 2 - Pela Empresa sem Justa Causa
        /// 3 - Pelo Empregado com Justa Causa
        /// 4 - Pelo Empregado sem Justa Causa
        /// 5 - Término de Contrato
        /// 6 - Transferência com Ônus
        /// 7 - Aposentadoria
        /// 8 - Morte
        /// 9 - Término de Contrato Antecipado pela Empresa
        /// 10 - Outros
        /// 11 - Término de Contrato Antecipado pelo Empregado
        /// 12 - Aposentadoria por Invalidez
        /// 13 - Término de Contrato Por Motivo de Acordo
        /// 14 - Motivo de Acordo(Contrato Intermitente)
        /// </summary>
        [DefaultValue(0)]
        [Display(Name = "Código Rescisão (Motivo)", Prompt = "Código Rescisão (Motivo)")]
        public int CodigoRescisao { get; set; }

        /// <summary>
        /// 
        /// Dispensa
        /// Efetivaçao
        /// Renovação
        /// </summary>
        [DefaultValue("")]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Tipo de Demissão", Prompt = "Tipo de Demissão")]
        public string TipoDemissao { get; set; }

        [DefaultValue("")]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Avaliação de Comportamento", Prompt = "Avaliação de Comportamento")]
        public string AvaliacaoComportamento { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Trabalho Parcial", Prompt = "Trabalho Parcial")]
        public bool TrabalhoParcial { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Teletrabalho", Prompt = "Teletrabalho")]
        public bool TeleTrabalho { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Trabalho Intermitente", Prompt = "Trabalho Intermitente")]
        public bool TrabalhoIntermitente { get; set; }

        /// <summary>
        /// Dias
        /// Meses
        /// </summary>
        [DefaultValue("D")]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Tipo Vcto. Contrato / Prorrogação", Prompt = "Tipo Vcto. Contrato / Prorrogação")]
        public string TipoVctoContrato { get; set; }

        /// <summary>
        /// Dias
        /// Meses
        /// </summary>
        [DefaultValue("D")]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Tipo Vcto. Contrato / Prorrogação", Prompt = "Tipo Vcto. Contrato / Prorrogação")]
        public string TipoVctoContratoProrr { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Contrato", Prompt = "Contrato")]
        public int DiasContrato { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Prorrogação", Prompt = "Prorrogação")]
        public int DiasProrrogacao { get; set; }

        [Display(Name = "Contrato", Prompt = "Contrato")]
        public DateTime? DtVectoContrato { get; set; }

        [Display(Name = "Prorrogação", Prompt = "Prorrogação")]
        public DateTime? DtVectoProrrogacao { get; set; }

        /// <summary>
        /// Determinado
        /// Indeterminado
        /// </summary>
        [DefaultValue("I")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Contrato", Prompt = "Contrato")]
        public string TipoContrato { get; set; }

        /// <summary>
        /// Comissao
        /// Dia
        /// Hora
        /// Mês
        /// Quinzenal
        ///Tarefa
        /// </summary>
        [DefaultValue("M")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Salário", Prompt = "Salário")]
        public string TipoSalario { get; set; }

        /// <summary>
        /// Mensal
        /// Quinzenal
        /// Semanal
        /// </summary>
        [DefaultValue("M")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Pagamento", Prompt = "Pagamento")]
        public string TipoPgto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Mensais", Prompt = "Mensais")]
        public decimal QtdeHorasMes { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Semanais", Prompt = "Semanais")]
        public decimal QtdeHorasSem { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Mês", Prompt = "Mês")]
        public decimal Salario { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Hora", Prompt = "Hora")]
        public decimal SalarioHora { get; set; }

        [DefaultValue("")]
        [StringLength(60, ErrorMessage = "Máximo 60 caracteres.")]
        [MaxLength(60, ErrorMessage = "Máximo 60 caracteres.")]
        [Display(Name = "Descrição Salário Variável", Prompt = "Descrição Salário Variável")]
        public string descSalVariavel { get; set; }

        [DefaultValue(30)]
        [Display(Name = "Pgto", Prompt = "Pgto")]
        public int DiaPgto { get; set; }

        [DefaultValue(20)]
        [Display(Name = "Adto", Prompt = "Adto")]
        public int DiaAdto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "IRF", Prompt = "IRF")]
        public int DepIRF { get; set; }

        [DefaultValue(0)]
        [Display(Name = "SF", Prompt = "SF")]
        public int DepSF { get; set; }

        #endregion

        #region Pessoal

        [DefaultValue("00000-000")]
        [StringLength(9, ErrorMessage = "Máximo 9 caracteres.")]
        [MaxLength(9, ErrorMessage = "Máximo 9 caracteres.")]
        [Display(Name = "CEP", Prompt = "CEP")]
        public string CepResid { get; set; }

        [DefaultValue("")]
        [StringLength(60, ErrorMessage = "Máximo 60 caracteres.")]
        [MaxLength(60, ErrorMessage = "Máximo 60 caracteres.")]
        [Display(Name = "Bairro", Prompt = "Bairro")]
        public string BairroResid { get; set; }

        [DefaultValue("")]
        [StringLength(60, ErrorMessage = "Máximo 60 caracteres.")]
        [MaxLength(60, ErrorMessage = "Máximo 60 caracteres.")]
        [Display(Name = "Cidade", Prompt = "Cidade")]
        public string CidadeResid { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Cód.Cid", Prompt = "Cód.Cid")]
        public int CodigoCidadeResid { get; set; }

        /// <summary>
        /// 
        /// AC
        /// AL
        /// AM
        /// AP
        /// BA
        /// CE
        /// DF
        /// ES
        /// GO
        /// MA
        /// MG
        /// MS
        /// MT
        /// PA
        /// PB
        /// PE
        /// PI
        /// PR
        /// RJ
        /// RN
        /// RO
        /// RR
        /// RS
        /// SC
        /// SE
        /// SP
        /// TO
        /// </summary>
        [DefaultValue("")]
        [StringLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [MaxLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [Display(Name = "UF", Prompt = "UF")]
        public string UFResid { get; set; }

        /// <summary>
        /// Nao Informado
        /// Area
        /// Acesso
        /// Acampamento
        /// Acesso Local
        /// Adro
        /// Area Especial
        /// Aeroporto
        /// Alameda
        /// Avenida Marginal Direita
        /// Avenida Marginal Esquerda
        /// Anel Viario
        /// Antiga Estrada
        /// Arteria
        /// Alto
        /// Atalho
        /// Area Verde
        /// Avenida
        /// Avenida Contorno
        /// Avenida Marginal
        /// Avenida Velha
        /// Balneario
        /// Beco
        /// Buraco
        /// Belvedere
        /// Bloco
        /// Balao
        /// Blocos
        /// Bulevar
        /// Bosque
        /// Boulevard
        /// Baixa
        /// Cais
        /// Calcada
        /// Caminho
        /// Canal
        /// Chacara
        /// Chapadao
        /// Ciclovia
        /// Circular
        /// Conjunto
        /// Conjunto Mutirao
        /// Complexo Viario
        /// Colonia
        /// Comunidade
        /// Condominio
        /// Corredor
        /// Campo
        /// Corrego
        /// Contorno
        /// Descida
        /// Desvio
        /// Distrito
        /// Entre Bloco
        /// Estrada Intermunicipal
        /// Enseada
        /// Entrada Particular
        /// Entre Quadra
        /// Escada
        /// Escadaria
        /// Estrada Estadual
        /// Estrada Vicinal
        /// Estrada de Ligacao
        /// Estrada Municipal
        /// Esplanada
        /// Estrada de Servidao
        /// Estrada
        /// Estrada Velha
        /// Estrada Antiga
        /// Estacao
        /// Estadio
        /// Estancia
        /// Estrada Particular
        /// Estacionamento
        /// Evangelica
        /// Elevada
        /// Eixo Industrial
        /// Favela
        /// Fazenda
        /// Ferrovia
        /// Fonte
        /// Feira
        /// Forte
        /// Galeria
        /// Granja
        /// Nucleo Habitacional
        /// Ilha
        /// Indeterminado
        /// Ilhota
        /// Jardim
        /// Jardinete
        /// Ladeira
        /// Lagoa
        /// Lago
        /// Loteamento
        /// Largo
        /// Lote
        /// Mercado
        /// Marina
        /// Modulo
        /// Projecao
        /// Morro
        /// Monte
        /// Nucleo
        /// Nucleo Rural
        /// Outeiro
        /// Paralela
        /// Passeio
        /// Patio
        /// Praca
        /// Praca de Esportes
        /// Parada
        /// Paradouro
        /// Ponta
        /// Praia
        /// Prolongamento
        /// Parque Municipal
        /// Parque
        /// Parque Residencial
        /// Passarela
        /// Passagem
        /// Passagem de Pedestre
        /// Passagem Subterranea
        /// Ponte
        /// Porto
        /// Quadra
        /// Quinta
        /// Quintas
        /// Rua
        /// Rua Integracao
        /// Rua de Ligacao
        /// Rua Particular
        /// Rua Velha
        /// Ramal
        /// Recreio
        /// Recanto
        /// Retiro
        /// Residencial
        /// Reta
        /// Ruela
        /// Rampa
        /// Rodo Anel
        /// Rodovia
        /// Rotula
        /// Rua de Pedestre
        /// Margem
        /// Retorno
        /// Rotatoria
        /// Segunda Avenida
        /// Sitio
        /// Servidao
        /// Setor
        /// Subida
        /// Trincheira
        /// Terminal
        /// Trecho
        /// Trevo
        /// Tunel
        /// Travessa
        /// Travessa Particular
        /// Travessa Velha
        /// Unidade
        /// Via
        /// Via Coletora
        /// Via Local
        /// Via de Acesso
        /// Vala
        /// Via Costeira
        /// Viaduto
        /// Via Expressa
        /// Vereda
        /// Via Elevado
        /// Vila
        /// Viela
        /// Vale
        /// Via Litoranea
        /// Via de Pedestre
        /// Variante
        /// Zigue-Zague
        /// </summary>
        [DefaultValue("Nao Informado")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Tipo", Prompt = "Tipo")]
        public string tipoEndereco { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Endereço", Prompt = "Endereço")]
        public string EnderecoResid { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Número", Prompt = "Número")]
        public int NroEndereco { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Complemento", Prompt = "Complemento")]
        public string CplEndereco { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Telefone", Prompt = "Telefone")]
        public string TelefoneResid { get; set; }

        [DefaultValue(0)]
        [Display(Name = "DDD-Celular (Envio SMS)")]
        public int SMSDDDCel { get; set; }

        [DefaultValue(0)]
        [Display(Name = "DDD-Celular (Envio SMS)")]
        public decimal SMSNroCel { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Email", Prompt = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email Inválido!")]
        public string Email { get; set; }

        /// <summary>
        /// 0 - Não é Portador de Deficiência
        /// 1 - Física
        /// 2 - Auditiva
        /// 3 - Visual
        /// 4 - Mental
        /// 5 - Múltipla
        /// 6 - Reabilitado
        /// 7 - Intelectual
        /// </summary>
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Tipo de Deficiência", Prompt = "Tipo de Deficiência")]
        public int TipoDeficiencia { get; set; }

        /// <summary>
        /// F - Feminino
        /// M - Masculino
        /// </summary>
        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Sexo", Prompt = "Sexo")]
        public string Sexo { get; set; }

        /// <summary>
        /// 1 - Branca
        /// 2 - Preta
        /// 3 - Amarela
        /// 4 - Parda
        /// 5 - Indígena
        /// </summary>
        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Raça", Prompt = "Raça")]
        public string Raca { get; set; }

        /// <summary>
        /// C - Casado(a)
        /// D - Divorciado(a)
        /// Q - Desquitado(a)
        /// S - Solteiro(a)
        /// V - Viúvo(a)
        /// U - União Estável
        /// O - Outros
        /// </summary>
        [DefaultValue("S")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Estado Civil", Prompt = "Estado Civil")]
        public string EstadoCivil { get; set; }

        /// <summary>
        /// 1 - Analfabeto
        /// 2 - Até 5º Ano Incompleto
        /// 3 - 5º Ano Completo
        /// 4 - 6º ao 9º Ano Incompleto
        /// 5 - Fundamental Completo
        /// 6 - Ensino Médio Incompleto
        /// 7 - Ensino Médio Completo
        /// 8 - Superior Incompleto
        /// 9 - Superior Completo
        /// A - Pós-Graduação Completa
        /// B - Mestrado Completo
        /// C - Doutorado Completo
        /// D - Pós-Doutorado Completo
        /// </summary>
        [DefaultValue("4")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Instrução", Prompt = "Instrução")]
        public string GrauInstrucao { get; set; }

        [Display(Name = "Nascimento", Prompt = "Nascimento")]
        public DateTime? DataNascimento { get; set; }

        /// <summary>
        /// 010 - Brasileiro
        /// 013 - Afeganistao
        /// 017 - Albania, Republica Da
        /// 020 - Naturalizado
        /// 021 - Argentino
        /// 022 - Boliviano
        /// 023 - Chileno
        /// 024 - Paraguaio
        /// 025 - Uruguaio
        /// 026 - Venezuelano
        /// 027 - Colombiano
        /// 028 - Peruano
        /// 029 - Equatoriano
        /// 030 - Alemão
        /// 031 - Belga
        /// 032 - Britanico
        /// 034 - Canadense
        /// 035 - Espanhol
        /// 036 - EUA
        /// 037 - Francês
        /// 038 - Suíço
        /// 039 - Italiano
        /// 040 - Haitiano
        /// 041 - Japonês
        /// 042 - Chinês
        /// 043 - Coreano
        /// 044 - Russo
        /// 045 - Português
        /// 046 - Paquistanês
        /// 047 - Indiano
        /// 048 - Outros Latinos
        /// 049 - Outros Asiáticos
        /// 050 - Outros
        /// 051 - Outros Europeus
        /// 053 - Arabia Saudita
        /// 059 - Argelia
        /// 060 - Angolano
        /// 061 - Congolês
        /// 062 - Sul - Africano
        /// 064 - Armenia, Republica Da
        /// 065 - Aruba
        /// 069 - Australia
        /// 070 - Outros Africanos
        /// 072 - Austria
        /// 073 - Azerbaijao, Republica Do
        /// 076 - Burkina Faso
        /// 077 - Bahamas, Ilhas
        /// 078 - Belarus, Republica Da
        /// 079 - Belize
        /// 080 - República Tcheca
        /// 081 - Palestina
        /// 082 - Guiné - Bissau
        /// 083 - Cubano
        /// 084 - Marrocos
        /// 085 - Gana
        /// 086 - México
        /// 087 - Senegal
        /// 088 - Filipinas
        /// 089 - Zambia
        /// 090 - Bermudas
        /// 091 - Andorra
        /// 092 - Anguilla
        /// 093 - Mianmar(BIRMANIA)
        /// 094 - Antigua E Barbuda
        /// 095 - Antilhas Holandesas
        /// 096 - Bahrein, Ilhas
        /// 097 - Bangladesh
        /// 098 - Bosnia-Herzegovina(REPUBLICA Da)
        /// 099 - Barbados
        /// 101 - Botsuana
        /// 108 - Brunei
        /// 111 - Bulgaria, Republica Da
        /// 115 - Burundi
        /// 119 - Butao
        /// 127 - Cabo Verde, Republica De
        /// 137 - Cayan, Ilhas
        /// 141 - Camboja
        /// 145 - Camaroes
        /// 150 - Jersey, Ilha Do Canal
        /// 151 - Canarias, Ilhas
        /// 153 - Cazaquistao, Republica Do
        /// 154 - Catar
        /// 161 - Formosa(TAIWAN)
        /// 163 - Chipre
        /// 165 - Cocos(Keeling),Ilhas
        /// 173 - Comores, Ilhas
        /// 183 - Cook, Ilhas
        /// 187 - Coreia(DO Norte), Rep.Pop.Democratica
        /// 193 - Costa Do Marfim
        /// 195 - Croacia(REPUBLICA Da)
        /// 196 - Costa Rica
        /// 198 - Coveite
        /// 229 - Benin
        /// 232 - Dinamarca
        /// 235 - Dominica,Ilha
        /// 240 - Egito
        /// 243 - Eritreia
        /// 244 - Emirados Arabes Unidos
        /// 246 - Eslovenia, Republica Da
        /// 247 - Eslovaca, Republica
        /// 251 - Estonia, Republica Da
        /// 253 - Etiopia
        /// 255 - Falkland(ILHAS Malvinas)
        /// 259 - Feroe, Ilhas
        /// 271 - Finlandia
        /// 281 - Gabao
        /// 285 - Gambia
        /// 291 - Georgia, Republica Da
        /// 293 - Gibraltar
        /// 297 - Granada
        /// 301 - Grecia
        /// 305 - Groenlandia
        /// 309 - Guadalupe
        /// 313 - Guam
        /// 317 - Guatemala
        /// 325 - Guiana Francesa
        /// 329 - Guine
        /// 331 - Guine-Equatorial
        /// 337 - Guiana
        /// 345 - Honduras
        /// 351 - Hong Kong
        /// 355 - Hungria, Republica Da
        /// 357 - Iemen
        /// 359 - Man, Ilha De
        /// 365 - Indonesia
        /// 369 - Iraque
        /// 372 - Ira, Republica Islamica Do
        /// 375 - Irlanda
        /// 379 - Islandia
        /// 383 - Israel
        /// 388 - Servia E Montenegro
        /// 391 - Jamaica
        /// 396 - Johston, Ilhas
        /// 403 - Jordania
        /// 411 - Kiribati
        /// 420 - Laos, Rep.Pop.Democr.Do
        /// 423 - Lebuan,Ilhas
        /// 426 - Lesoto
        /// 427 - Letonia, Republica Da
        /// 431 - Libano
        /// 434 - Liberia
        /// 438 - Libia
        /// 440 - Liechtenstein
        /// 442 - Lituania, Republica Da
        /// 445 - Luxemburgo
        /// 447 - Macau
        /// 449 - Macedonia, Ant.Rep.Iugoslava
        /// 450 - Madagascar
        /// 452 - Ilha Da Madeira
        /// 455 - Malasia
        /// 458 - Malavi
        /// 461 - Maldivas
        /// 464 - Mali
        /// 467 - Malta
        /// 472 - Marianas Do Norte
        /// 476 - Marshall,Ilhas
        /// 477 - Martinica
        /// 485 - Mauricio
        /// 488 - Mauritania
        /// 490 - Midway, Ilhas
        /// 494 - Moldavia, Republica Da
        /// 495 - Monaco
        /// 497 - Mongolia
        /// 499 - Micronesia
        /// 501 - Montserrat,Ilhas
        /// 505 - Mocambique
        /// 507 - Namibia
        /// 508 - Nauru
        /// 511 - Christmas,Ilha(NAVIDAD)
        /// 517 - Nepal
        /// 521 - Nicaragua
        /// 525 - Niger
        /// 528 - Nigeria
        /// 531 - Niue,Ilha
        /// 535 - Norfolk,Ilha
        /// 538 - Noruega
        /// 542 - Nova Caledonia
        /// 545 - Papua Nova Guine
        /// 548 - Nova Zelandia
        /// 551 - Vanuatu
        /// 556 - Oma
        /// 566 - Pacifico,Ilhas Do(POSSESSAO Dos Eua)
        /// 573 - Paises Baixos(HOLANDA)
        /// 575 - Palau
        /// 580 - Panama
        /// 593 - Pitcairn,Ilha
        /// 599 - Polinesia Francesa
        /// 603 - Polonia, Republica Da
        /// 611 - Porto Rico
        /// 623 - Quenia
        /// 625 - Quirguiz, Republica
        /// 628 - Reino Unido
        /// 640 - Republica Centro-Africana
        /// 647 - Republica Dominicana
        /// 660 - Reuniao, Ilha
        /// 665 - Zimbabue
        /// 670 - Romenia
        /// 675 - Ruanda
        /// 677 - Salomao, Ilhas
        /// 678 - Saint Kitts E Nevis
        /// 685 - Saara Ocidental
        /// 687 - El Salvador
        /// 690 - Samoa
        /// 691 - Samoa Americana
        /// 695 - Sao Cristovao E Neves, Ilhas
        /// 697 - San Marino
        /// 700 - Sao Pedro E Miquelon
        /// 705 - Sao Vicente E Granadinas
        /// 710 - Santa Helena
        /// 715 - Santa Lucia
        /// 720 - Sao Tome E Principe, Ilhas
        /// 731 - Seychelles
        /// 735 - Serra Leoa
        /// 738 - Sikkim
        /// 741 - Cingapura
        /// 744 - Siria, Republica Arabe Da
        /// 748 - Somalia
        /// 750 - Sri Lanka
        /// 754 - Suazilandia
        /// 756 - Africa Do Sul
        /// 759 - Sudao
        /// 764 - Suecia
        /// 770 - Suriname
        /// 772 - Tadjiquistao, Republica Do
        /// 776 - Tailandia
        /// 780 - Tanzania, Rep.Unida Da
        /// 782 - Territorio Brit.Oc.Indico
        /// 783 - Djibuti
        /// 785 - Territorio da Alta Comissao do Pacifico Ocidental
        /// 788 - Chade
        /// 790 - Tchecoslovaquia
        /// 795 - Timor Leste
        /// 800 - Togo
        /// 805 - Toquelau, Ilhas
        /// 810 - Tonga
        /// 815 - Trinidad E Tobago
        /// 820 - Tunisia
        /// 823 - Turcas E Caicos, Ilhas
        /// 824 - Turcomenistao, Republica Do
        /// 827 - Turquia
        /// 828 - Tuvalu
        /// 831 - Ucrania
        /// 833 - Uganda
        /// 840 - Uniao Das Republicas Socialistas Sovieticas
        /// 847 - Uzbequistao, Republica Do
        /// 848 - Vaticano, Est.Da Cidade Do
        /// 855 - Vietname Norte
        /// 858 - Vietna
        /// 863 - Virgens, Ilhas (BRITANICAS)
        /// 866 - Virgens, Ilhas (E.U.A.)
        /// 870 - Fiji
        /// 873 - Wake, Ilha
        /// 875 - Wallis E Futuna, Ilhas
        /// 888 - Congo, Republica Democratica Do
        /// </summary>
        [DefaultValue("010")]
        [StringLength(3, ErrorMessage = "Máximo 3 caracteres.")]
        [MaxLength(3, ErrorMessage = "Máximo 3 caracteres.")]
        [Display(Name = "Nacionalidade", Prompt = "Nacionalidade")]
        public string Nacionalidade { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Cód.Cid. Nascimento", Prompt = "Cód.Cid. Nascimento")]
        public int AnoChegada { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Cód.Cid. Nascimento", Prompt = "Cód.Cid. Nascimento")]
        public int codMunicipioNascto { get; set; }

        /// <summary>
        /// 
        /// AC
        /// AL
        /// AM
        /// AP
        /// BA
        /// CE
        /// DF
        /// ES
        /// GO
        /// MA
        /// MG
        /// MS
        /// MT
        /// PA
        /// PB
        /// PE
        /// PI
        /// PR
        /// RJ
        /// RN
        /// RO
        /// RR
        /// RS
        /// SC
        /// SE
        /// SP
        /// TO
        /// </summary>
        [DefaultValue("")]
        [StringLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [MaxLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [Display(Name = "Naturalidade", Prompt = "Naturalidade")]
        public string Naturalidade { get; set; }

        //[DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Cidade de Nascimento", Prompt = "Cidade de Nascimento")]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public string CidadeNascimento { get; set; }

        [DefaultValue(false)]
        [Display(Name = "Casado com Brasileiro", Prompt = "Casado com Brasileiro")]
        public bool CasadoBrasileiro { get; set; }

        [DefaultValue(false)]
        [Display(Name = "Tem filhos Brasileiros", Prompt = "Tem filhos Brasileiros")]
        public bool FilhosBrasileiros { get; set; }

        [Display(Name = "Data de Naturalização Brasileira", Prompt = "Data de Naturalização Brasileira")]
        public DateTime? dtNaturalizacao { get; set; }

        /// <summary>
        /// 00 - Não Informado
        /// 01 - Visto permanente
        /// 02 - Visto temporário
        /// 03 - Asilado
        /// 04 - Refugiado
        /// 05 - Solicitante de Refúgio
        /// 06 - Residente fora do Brasil
        /// 07 - Deficiente físico e com mais de 51 anos
        /// 08 - Com residência provisória e anistiado, em situação irregular
        /// 09 - Permanência no Brasil em razão de filhos ou cônjuge brasileiros
        /// 10 - Beneficiado pelo acordo entre países do Mercosul
        /// 11 - Dependente de agente diplomático e/ou consular de países que mantém convênio de reciprocidade para o exercício de atividade remunerada no Brasil
        /// 12 - Beneficiado pelo Tratado de Amizade, Cooperação e Consulta entre a República Federativa do Brasil e a República Portuguesa
        /// </summary>
        [DefaultValue(0)]
        [Display(Name = "Condição do Trabalhador Estrangeiro no Brasil", Prompt = "Condição do Trabalhador Estrangeiro no Brasil")]
        public int classTrabEstrang { get; set; }

        /// <summary>
        /// 0000 - Brasil
        /// 0008 - Abu Dhabi
        /// 0009 - Dirce
        /// 0013 - Afeganistao
        /// 0017 - Albania, Republica Da
        /// 0020 - Alboran-Perejil,Ilhas
        /// 0023 - Alemanha
        /// 0025 - Alemanha, Republica Democratica
        /// 0031 - Burkina Faso
        /// 0037 - Andorra
        /// 0040 - Angola
        /// 0041 - Anguilla
        /// 0043 - Antigua E Barbuda
        /// 0047 - Antilhas Holandesas
        /// 0053 - Arabia Saudita
        /// 0059 - Argelia
        /// 0063 - Argentina
        /// 0064 - Armenia, Republica Da
        /// 0065 - Aruba
        /// 0069 - Australia
        /// 0072 - Austria
        /// 0073 - Azerbaijao, Republica Do
        /// 0077 - Bahamas, Ilhas
        /// 0080 - Bahrein, Ilhas
        /// 0081 - Bangladesh
        /// 0083 - Barbados
        /// 0085 - Belarus, Republica Da
        /// 0087 - Belgica
        /// 0088 - Belize
        /// 0090 - Bermudas
        /// 0093 - Mianmar(BIRMANIA)
        /// 0097 - Bolivia, Estado Plurinacional Da
        /// 0098 - Bosnia-Herzegovina(REPUBLICA Da)
        /// 0100 - Int.Z.F.Manaus
        /// 0101 - Botsuana
        /// 0105 - Brasil
        /// 0106 - Fretado P/Brasil
        /// 0108 - Brunei
        /// 0111 - Bulgaria, Republica Da
        /// 0115 - Burundi
        /// 0119 - Butao
        /// 0127 - Cabo Verde, Republica De
        /// 0131 - Cachemira
        /// 0137 - Cayman, Ilhas
        /// 0141 - Camboja
        /// 0145 - Camaroes
        /// 0149 - Canada
        /// 0150 - Jersey, Ilha Do Canal
        /// 0151 - Canarias, Ilhas
        /// 0152 - Canal,Ilhas
        /// 0153 - Cazaquistao, Republica Do
        /// 0154 - Catar
        /// 0158 - Chile
        /// 0160 - China, Republica Popular
        /// 0161 - Formosa(TAIWAN)
        /// 0163 - Chipre
        /// 0165 - Cocos(Keeling),Ilhas
        /// 0169 - Colombia
        /// 0173 - Comores, Ilhas
        /// 0177 - Congo
        /// 0183 - Cook, Ilhas
        /// 0187 - Coreia(DO Norte), Rep.Pop.Democratica
        /// 0190 - Coreia(DO Sul), Republica Da
        /// 0193 - Costa Do Marfim
        /// 0195 - Croacia(REPUBLICA Da)
        /// 0196 - Costa Rica
        /// 0198 - Coveite
        /// 0199 - Cuba
        /// 0229 - Benin
        /// 0232 - Dinamarca
        /// 0235 - Dominica,Ilha
        /// 0237 - Dubai
        /// 0239 - Equador
        /// 0240 - Egito
        /// 0243 - Eritreia
        /// 0244 - Emirados Arabes Unidos
        /// 0245 - Espanha
        /// 0246 - Eslovenia, Republica Da
        /// 0247 - Eslovaca, Republica
        /// 0249 - Estados Unidos
        /// 0251 - Estonia, Republica Da
        /// 0253 - Etiopia
        /// 0255 - Falkland(ILHAS Malvinas)
        /// 0259 - Feroe, Ilhas
        /// 0263 - Fezzan
        /// 0267 - Filipinas
        /// 0271 - Finlandia
        /// 0275 - Franca
        /// 0281 - Gabao
        /// 0285 - Gambia
        /// 0289 - Gana
        /// 0291 - Georgia, Republica Da
        /// 0293 - Gibraltar
        /// 0297 - Granada
        /// 0301 - Grecia
        /// 0305 - Groenlandia
        /// 0309 - Guadalupe
        /// 0313 - Guam
        /// 0317 - Guatemala
        /// 0325 - Guiana Francesa
        /// 0329 - Guine
        /// 0331 - Guine-Equatorial
        /// 0334 - Guine-Bissau
        /// 0337 - Guiana
        /// 0341 - Haiti
        /// 0345 - Honduras
        /// 0351 - Hong Kong
        /// 0355 - Hungria, Republica Da
        /// 0357 - Iemen
        /// 0358 - Iemem Do Sul
        /// 0359 - Man, Ilha De
        /// 0361 - India
        /// 0365 - Indonesia
        /// 0367 - Inglaterra
        /// 0369 - Iraque
        /// 0372 - Ira, Republica Islamica Do
        /// 0375 - Irlanda
        /// 0379 - Islandia
        /// 0383 - Israel
        /// 0386 - Italia
        /// 0388 - Servia E Montenegro
        /// 0391 - Jamaica
        /// 0395 - Jammu
        /// 0396 - Johnston, Ilhas
        /// 0399 - Japao
        /// 0403 - Jordania
        /// 0411 - Kiribati
        /// 0420 - Laos, Rep.Pop.Democr.Do
        /// 0423 - Lebuan,Ilhas
        /// 0426 - Lesoto
        /// 0427 - Letonia, Republica Da
        /// 0431 - Libano
        /// 0434 - Liberia
        /// 0438 - Libia
        /// 0440 - Liechtenstein
        /// 0442 - Lituania, Republica Da
        /// 0445 - Luxemburgo
        /// 0447 - Macau
        /// 0449 - Macedonia, Ant.Rep.Iugoslava
        /// 0450 - Madagascar
        /// 0452 - Ilha Da Madeira
        /// 0455 - Malasia
        /// 0458 - Malavi
        /// 0461 - Maldivas
        /// 0464 - Mali
        /// 0467 - Malta
        /// 0472 - Marianas Do Norte
        /// 0474 - Marrocos
        /// 0476 - Marshall,Ilhas
        /// 0477 - Martinica
        /// 0485 - Mauricio
        /// 0488 - Mauritania
        /// 0490 - Midway, Ilhas
        /// 0493 - Mexico
        /// 0494 - Moldavia, Republica Da
        /// 0495 - Monaco
        /// 0497 - Mongolia
        /// 0499 - Micronesia
        /// 0501 - Montserrat,Ilhas
        /// 0505 - Mocambique
        /// 0507 - Namibia
        /// 0508 - Nauru
        /// 0511 - Christmas,Ilha(NAVIDAD)
        /// 0517 - Nepal
        /// 0521 - Nicaragua
        /// 0525 - Niger
        /// 0528 - Nigeria
        /// 0531 - Niue,Ilha
        /// 0535 - Norfolk,Ilha
        /// 0538 - Noruega
        /// 0542 - Nova Caledonia
        /// 0545 - Papua Nova Guine
        /// 0548 - Nova Zelandia
        /// 0551 - Vanuatu
        /// 0556 - Oma
        /// 0563 - Pacifico,Ilhas Do(ADMINISTRACAO Dos Eua)
        /// 0566 - Pacifico,Ilhas Do(POSSESSAO Dos Eua)
        /// 0569 - Pacifico,Ilhas Do(TERRITORIO Em Fideicomisso Dos
        /// 0573 - Paises Baixos (HOLANDA)
        /// 0575 - Palau
        /// 0576 - Paquistao
        /// 0578 - Palestina
        /// 0580 - Panama
        /// 0583 - Papua Nova Guiné
        /// 0586 - Paraguai
        /// 0589 - Peru
        /// 0593 - Pitcairn, Ilha
        /// 0599 - Polinesia Francesa
        /// 0603 - Polonia, Republica Da
        /// 0607 - Portugal
        /// 0611 - Porto Rico
        /// 0623 - Quenia
        /// 0625 - Quirguiz, Republica
        /// 0628 - Reino Unido
        /// 0640 - Republica Centro-Africana
        /// 0647 - Republica Dominicana
        /// 0660 - Reuniao, Ilha
        /// 0665 - Zimbabue
        /// 0670 - Romenia
        /// 0675 - Ruanda
        /// 0676 - Russia, Federacao Da
        /// 0677 - Salomao, Ilhas
        /// 0678 - Saint Kitts E Nevis
        /// 0685 - Saara Ocidental
        /// 0687 - El Salvador
        /// 0690 - Samoa
        /// 0691 - Samoa Americana
        /// 0695 - Sao Cristovao E Neves, Ilhas
        /// 0697 - San Marino
        /// 0700 - Sao Pedro E Miquelon
        /// 0705 - Sao Vicente E Granadinas
        /// 0710 - Santa Helena
        /// 0715 - Santa Lucia
        /// 0720 - Sao Tome E Principe, Ilhas
        /// 0728 - Senegal
        /// 0731 - Seychelles
        /// 0735 - Serra Leoa
        /// 0738 - Sikkim
        /// 0741 - Cingapura
        /// 0744 - Siria, Republica Arabe Da
        /// 0748 - Somalia
        /// 0750 - Sri Lanka
        /// 0754 - Suazilandia
        /// 0756 - Africa Do Sul
        /// 0759 - Sudao
        /// 0764 - Suecia
        /// 0767 - Suica
        /// 0770 - Suriname
        /// 0772 - Tadjiquistao, Republica Do
        /// 0776 - Tailandia
        /// 0780 - Tanzania, Rep.Unida Da
        /// 0782 - Territorio Brit.Oc.Indico
        /// 0783 - Djibuti
        /// 0785 - Territorio da Alta Comissao do Pacifico Ocidental
        /// 0788 - Chade
        /// 0790 - Tchecoslovaquia
        /// 0791 - Tcheca, Republica
        /// 0795 - Timor Leste
        /// 0800 - Togo
        /// 0805 - Toquelau, Ilhas
        /// 0810 - Tonga
        /// 0815 - Trinidad E Tobago
        /// 0820 - Tunisia
        /// 0823 - Turcas E Caicos, Ilhas
        /// 0824 - Turcomenistao, Republica Do
        /// 0827 - Turquia
        /// 0828 - Tuvalu
        /// 0831 - Ucrania
        /// 0833 - Uganda
        /// 0840 - Uniao Das Republicas Socialistas Sovieticas
        /// 0845 - Uruguai
        /// 0847 - Uzbequistao, Republica Do
        /// 0848 - Vaticano, Est.Da Cidade Do
        /// 0850 - Venezuela
        /// 0855 - Vietname Norte
        /// 0858 - Vietna
        /// 0863 - Virgens, Ilhas (BRITANICAS)
        /// 0866 - Virgens, Ilhas (E.U.A.)
        /// 0870 - Fiji
        /// 0873 - Wake, Ilha
        /// 0875 - Wallis E Futuna, Ilhas
        /// 0888 - Congo, Republica Democratica Do
        /// 0890 - Zambia
        /// </summary>
        [DefaultValue(0)]
        [Display(Name = "Código do País quando Residente no Exterior", Prompt = "Código do País quando Residente no Exterior")]
        public int exterior_paisResidencia { get; set; }

        [DefaultValue("")]
        [StringLength(80, ErrorMessage = "Máximo 80 caracteres.")]
        [MaxLength(80, ErrorMessage = "Máximo 80 caracteres.")]
        [Display(Name = "Endereço", Prompt = "Endereço")]
        public string exterior_descLogradouro { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [Display(Name = "Número", Prompt = "Número")]
        public string exterior_nrLogradouro { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Complemento", Prompt = "Complemento")]
        public string exterior_complemento { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Bairro", Prompt = "Bairro")]
        public string exterior_bairro { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Cidade", Prompt = "Cidade")]
        public string exterior_nomeCidade { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [Display(Name = "Código Postal", Prompt = "Código Postal")]
        public string exterior_codPostal { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Pai", Prompt = "Pai")]
        public string FiliacaoNomePai { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Mãe", Prompt = "Mãe")]
        public string FiliacaoNomeMae { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Banco", Prompt = "Banco")]
        public int CodigoBcoFolha { get; set; }

        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Máscara", Prompt = "Máscara")]
        public string TipoMskBanco { get; set; }

        [StringLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [Display(Name = "Agência", Prompt = "Agência")]
        public string Agencia { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Conta Corrente", Prompt = "Conta Corrente")]
        public string ContaCorrente { get; set; }

        [DefaultValue("")]
        [StringLength(60, ErrorMessage = "Nome Inválido para o e-Social! Ulrapassou o limite de 60 caracteres!")]
        [MaxLength(60, ErrorMessage = "Nome Inválido para o e-Social! Ulrapassou o limite de 60 caracteres!")]
        [Display(Name = "Nome", Prompt = "Nome")]
        // [Required(ErrorMessage = "Digite o Nome do Funcionário!")]
        public string NomeTitularConta { get; set; }

        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "CPF", Prompt = "CPF")]
        public decimal CPFTitularConta { get; set; }

        [Display(Name = "DT.Nascimento", Prompt = "DT.Nascimento")]
        public DateTime? DTNascimentoTitularConta { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Banco", Prompt = "Banco")]
        public int CodigoBcoReembolso { get; set; }

        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Máscara", Prompt = "Máscara")]
        public string TipoMskBancoReembolso { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [Display(Name = "Agência", Prompt = "Agência")]
        public string AgenciaReembolso { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Conta Corrente", Prompt = "Conta Corrente")]
        public string ContaCorrenteReembolso { get; set; }

        public short StatusPreCadastro { get; set; }

        #endregion

        #region Documentos

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Número", Prompt = "Número")]
        public string RG { get; set; }

        [DefaultValue("")]
        [StringLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [Display(Name = "Órgão", Prompt = "Órgão")]
        public string OrgaoRG { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Cidade", Prompt = "Cidade")]
        public string CidadeRG { get; set; }

        /// <summary>
        /// 
        /// AC
        /// AL
        /// AM
        /// AP
        /// BA
        /// CE
        /// DF
        /// ES
        /// GO
        /// MA
        /// MG
        /// MS
        /// MT
        /// PA
        /// PB
        /// PE
        /// PI
        /// PR
        /// RJ
        /// RN
        /// RO
        /// RR
        /// RS
        /// SC
        /// SE
        /// SP
        /// TO
        /// </summary>
        [DefaultValue("")]
        [StringLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [MaxLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [Display(Name = "UF", Prompt = "UF")]
        public string UFRG { get; set; }

        [Display(Name = "Data da Expedição", Prompt = "Data da Expedição")]
        public DateTime? DtExpedicaoRG { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Número", Prompt = "Número")]
        public decimal PIS { get; set; }

        [Display(Name = "Data de Cadastro", Prompt = "Data de Cadastro")]
        public DateTime? DataCadastroPIS { get; set; }

        [DefaultValue(false)]
        [Display(Name = "1º Emprego", Prompt = "1º Emprego")]
        public bool PrimeiroEmprego { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Número", Prompt = "Número")]
        public decimal CPF { get; set; }



        [Display(Name = "CPTS Digital", Prompt = "CPTS Digital")]
        public bool CTPSDigital { get; set; }

        [DefaultValue("00000000")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [Display(Name = "Número", Prompt = "Número")]
        public string CarteiraTrabalho { get; set; }

        [DefaultValue("00000")]
        [StringLength(7, ErrorMessage = "Máximo 7 caracteres.")]
        [MaxLength(7, ErrorMessage = "Máximo 7 caracteres.")]
        [Display(Name = "Série", Prompt = "Série")]
        public string Serie { get; set; }

        /// <summary>
        /// 
        /// AC
        /// AL
        /// AM
        /// AP
        /// BA
        /// CE
        /// DF
        /// ES
        /// GO
        /// MA
        /// MG
        /// MS
        /// MT
        /// PA
        /// PB
        /// PE
        /// PI
        /// PR
        /// RJ
        /// RN
        /// RO
        /// RR
        /// RS
        /// SC
        /// SE
        /// SP
        /// TO
        /// </summary>
        [DefaultValue("")]
        [StringLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [MaxLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [Display(Name = "UF", Prompt = "UF")]
        public string UFExpedicao { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Cidade", Prompt = "Cidade")]
        public string CidadeExpedicao { get; set; }

        [Display(Name = "Data da Expedição", Prompt = "Data da Expedição")]
        public DateTime? DtExpedicaoCTPS { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [MaxLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [Display(Name = "Número", Prompt = "Número")]
        public string TituloEleitor { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Zona", Prompt = "Zona")]
        public int TitEleZona { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Seção", Prompt = "Seção")]
        public int TitEleSecao { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [MaxLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [Display(Name = "Número", Prompt = "Número")]
        public string Reservista { get; set; }

        [Display(Name = "Data da Expedição", Prompt = "Data da Expedição")]
        public DateTime? DTExpedicaoReservista { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [MaxLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [Display(Name = "Número", Prompt = "Número")]
        public string Habilitacao { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Órgão", Prompt = "Órgão")]
        public string CNHorgaoemissor { get; set; }

        [DefaultValue("")]
        [StringLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [MaxLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [Display(Name = "Categoria", Prompt = "Categoria")]
        public string CNH_Modelo { get; set; }

        [Display(Name = "Data da Emissão", Prompt = "Data da Emissão")]
        public DateTime? CNHDataEmissao { get; set; }

        /// <summary>
        /// 
        /// AC
        /// AL
        /// AM
        /// AP
        /// BA
        /// CE
        /// DF
        /// ES
        /// GO
        /// MA
        /// MG
        /// MS
        /// MT
        /// PA
        /// PB
        /// PE
        /// PI
        /// PR
        /// RJ
        /// RN
        /// RO
        /// RR
        /// RS
        /// SC
        /// SE
        /// SP
        /// TO
        /// </summary>
        [DefaultValue("")]
        [StringLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [MaxLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [Display(Name = "UF", Prompt = "UF")]
        public string ufCnh { get; set; }

        [Display(Name = "Data 1ª Habilitação", Prompt = "Data 1ª Habilitação")]
        public DateTime? dtPriHab { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Pontos", Prompt = "Pontos")]
        public int CNH_Pontuacao { get; set; }

        [Display(Name = "Data Revisão", Prompt = "Data Revisão")]
        public DateTime? CNH_DataRevisao { get; set; }

        [Display(Name = "Data de Vencimento", Prompt = "Data de Vencimento")]
        public DateTime? DataVectoHabilitacao { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [MaxLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [Display(Name = "Observação CNH", Prompt = "Observação CNH")]
        public string CNH_Obs { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [MaxLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [Display(Name = "Número", Prompt = "Número")]
        public string Motorista_MOOP { get; set; }

        [Display(Name = "Data de Vencimento", Prompt = "Data de Vencimento")]
        public DateTime? Motorista_DataVectoMOOP { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Código Exame", Prompt = "Código Exame")]
        public string CodigoExameTox { get; set; }

        [Display(Name = "Data Exame", Prompt = "Data Exame")]
        public DateTime? DataExameTox { get; set; }

        /// <summary>
        /// 
        /// AC
        /// AL
        /// AM
        /// AP
        /// BA
        /// CE
        /// DF
        /// ES
        /// GO
        /// MA
        /// MG
        /// MS
        /// MT
        /// PA
        /// PB
        /// PE
        /// PI
        /// PR
        /// RJ
        /// RN
        /// RO
        /// RR
        /// RS
        /// SC
        /// SE
        /// SP
        /// TO
        /// </summary>
        [DefaultValue("")]
        [StringLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [MaxLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [Display(Name = "UF", Prompt = "UF")]
        public string UFCRMExameTox { get; set; }

        [DefaultValue("")]
        [StringLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [Display(Name = "CRM", Prompt = "CRM")]
        public string NrCRMExameTox { get; set; }

        [DefaultValue("00.000.000/0000-00")]
        [StringLength(18, ErrorMessage = "Máximo 18 caracteres.")]
        [MaxLength(18, ErrorMessage = "Máximo 18 caracteres.")]
        [Display(Name = "CNPJ Laboratório", Prompt = "CNPJ Laboratório")]
        public string CNPJLabExameTox { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Número", Prompt = "Número")]
        public decimal RICnr { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Órgão", Prompt = "Órgão")]
        public string RICorgaoemissor { get; set; }

        [Display(Name = "Data da Expedição", Prompt = "Data da Expedição")]
        public DateTime? RICDataEmissao { get; set; }

        [DefaultValue("")]
        [StringLength(14, ErrorMessage = "Máximo 14 caracteres.")]
        [MaxLength(14, ErrorMessage = "Máximo 14 caracteres.")]
        [Display(Name = "Número", Prompt = "Número")]
        public string RNEnr { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Órgão", Prompt = "Órgão")]
        public string RNEorgaoemissor { get; set; }

        [Display(Name = "Data da Expedição", Prompt = "Data da Expedição")]
        public DateTime? RNEDataEmissao { get; set; }

        [Display(Name = "Data de Vencimento", Prompt = "Data de Vencimento")]
        public DateTime? RNEDataVecto { get; set; }

        [DefaultValue("")]
        [StringLength(14, ErrorMessage = "Máximo 14 caracteres.")]
        [MaxLength(14, ErrorMessage = "Máximo 14 caracteres.")]
        [Display(Name = "Número", Prompt = "Número")]
        public string OCnr { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Órgão", Prompt = "Órgão")]
        public string Ocorgaoemissor { get; set; }

        [Display(Name = "Data da Expedição", Prompt = "Data da Expedição")]
        public DateTime? OCDataEmissao { get; set; }

        [Display(Name = "Data de Validade", Prompt = "Data de Validade")]
        public DateTime? OCDataValidade { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Locais sem filiais
        /// 2 - Estudo de mercado
        /// 3 - Contratação superior a 3 meses
        /// 4 - Prorrogação de contrato
        /// </summary>
        [DefaultValue(0)]
        [Display(Name = "Tipo Inclusão de Contrato", Prompt = "Tipo Inclusão de Contrato")]
        public int TipoAdmSIRETT { get; set; }

        [DefaultValue("")]
        [StringLength(500, ErrorMessage = "Máximo 500 caracteres.")]
        [MaxLength(500, ErrorMessage = "Máximo 500 caracteres.")]
        [Display(Name = "Motivo Justificador da Contratação", Prompt = "Motivo Justificador da Contratação")]
        public string MotivoProrrogacao { get; set; }

        [DefaultValue("")]
        [StringLength(500, ErrorMessage = "Máximo 500 caracteres.")]
        [MaxLength(500, ErrorMessage = "Máximo 500 caracteres.")]
        [Display(Name = "Motivo Justificador da Prorrogação", Prompt = "Motivo Justificador da Prorrogação")]
        public string JustificativaProrrogacao { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Nome Social Funcionário", Prompt = "Nome Social")]
        public string nmSoc { get; set; }

        [DefaultValue(false)]
        [Display(Name = "Trabalhador é Reabilitado ou Readaptado", Prompt = "Trabalhador é Reabilitado ou Readaptado")]
        public bool reabReadap { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Trabalhador preenche cota de pessoas com deficiência habilitadas ou de beneficiários reabilitados",
            Prompt = "Trabalhador preenche cota de pessoas com deficiência habilitadas ou de beneficiários reabilitados")]
        public bool infoCota { get; set; }

        #endregion

        #region Outros

        [DefaultValue("")]
        [StringLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [Display(Name = "Matrícula", Prompt = "Matrícula")]
        public string Matricula { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [Display(Name = "Chapa", Prompt = "Chapa")]
        public string Chapa { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [Display(Name = "Chapeira", Prompt = "Chapeira")]
        public string Chapera { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Ctr Web", Prompt = "Ctr Web")]
        public int TipoContratoWeb { get; set; }

        [Display(Name = "Último Exame", Prompt = "Último Exame")]
        public DateTime? DataUltimoExame { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Dias Vecto.", Prompt = "Dias Vecto.")]
        public int DiasVectoExame { get; set; }

        [Display(Name = "Vencimento", Prompt = "Vencimento")]
        public DateTime? DataVectoExame { get; set; }

        [DefaultValue(true)]
        [Display(Name = "Etiqueta", Prompt = "Etiqueta")]
        public bool EmissaoEtiqueta { get; set; }

        [DefaultValue(true)]
        [Display(Name = "Ficha Horária", Prompt = "Ficha Horária")]
        public bool EmissaoFichaHora { get; set; }

        [DefaultValue(true)]
        [Display(Name = "Cartão de Ponto", Prompt = "Cartão de Ponto")]
        public bool CartaoPonto { get; set; }

        [DefaultValue(true)]
        [Display(Name = "Descontar IRF", Prompt = "Descontar IRF")]
        public bool CalculaIRF { get; set; }

        [DefaultValue(true)]
        [Display(Name = "Descontar INSS", Prompt = "Descontar INSS")]
        public bool CalculaINSS { get; set; }

        [Display(Name = "Considerar Gratificação", Prompt = "Considerar Gratificação")]
        public bool CalculaGratificacao { get; set; }

        [Display(Name = "Considerar Anuênio", Prompt = "Considerar Anuênio")]
        public bool CalculaAnuenio { get; set; }

        [DefaultValue(false)]
        [Display(Name = "Considerar Biênio", Prompt = "Considerar Biênio")]
        public bool CalculaBienio { get; set; }

        [Display(Name = "Considerar Triênio", Prompt = "Considerar Triênio")]
        public bool CalculaTrienio { get; set; }

        [DefaultValue(false)]
        [Display(Name = "Considerar Quadriênio", Prompt = "Considerar Quadriênio")]
        public bool CalculaQuadrienio { get; set; }

        [DefaultValue(false)]
        [Display(Name = "Considerar Quinquênio", Prompt = "Considerar Quinquênio")]
        public bool CalculaQuinquenio { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Classe de Contribuição", Prompt = "Classe de Contribuição")]
        public int ClasseContrib { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Troco", Prompt = "Troco")]
        public decimal Acum_Troco { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Saldo Negativo", Prompt = "Saldo Negativo")]
        public decimal Acum_SaldoNeg { get; set; }

        [DefaultValue(0)]
        [Display(Name = "% Abono Liderança", Prompt = "% Abono Liderança")]
        public decimal AlqAbonoLider { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Fixo Adto", Prompt = "Valor Fixo Adto")]
        public decimal ValorAdtoFixo { get; set; }

        [Display(Name = "Limite Bloqueio Pagto", Prompt = "Limite Bloqueio Pagto")]
        public DateTime? DataLimitePagto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Adiantamento", Prompt = "Adiantamento")]
        public decimal TaxaAdt { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Insalubridade", Prompt = "Insalubridade")]
        public decimal PercentInsalub { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Periculosidade", Prompt = "Periculosidade")]
        public decimal PercentPericul { get; set; }

        [Display(Name = "Centro de Custo", Prompt = "Centro de Custo")]
        public int CentroCustoContab { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Banco", Prompt = "Banco")]
        public int CodigoBcoPagar { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Sindicato", Prompt = "Sindicato")]
        public int CodigoSindicato { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Centro de Resultado", Prompt = "Centro de Resultado")]
        public int CodigoCR { get; set; }

        [DefaultValue("")]
        [StringLength(6, ErrorMessage = "Máximo 6 caracteres.")]
        [MaxLength(6, ErrorMessage = "Máximo 6 caracteres.")]
        [Display(Name = "Transferência", Prompt = "Transferência")]
        public string AnoMesTransferencia { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Emp", Prompt = "Emp")]
        public int CodigoEmpresaOrigem { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Filial", Prompt = "Filial")]
        public int CodigoFilialOrigem { get; set; }

        [Display(Name = "Código", Prompt = "Código")]
        public int CodigoFuncionarioOrigem { get; set; }

        [DefaultValue("")]
        [StringLength(18, ErrorMessage = "Máximo 18 caracteres.")]
        [MaxLength(18, ErrorMessage = "Máximo 18 caracteres.")]
        [Display(Name = "CNPJ Empresa Anterior", Prompt = "CNPJ Empresa Anterior")]
        public string CNPJEmpresaAnterior { get; set; }

        [DefaultValue("")]
        [StringLength(200, ErrorMessage = "Máximo 200 caracteres.")]
        [MaxLength(200, ErrorMessage = "Máximo 200 caracteres.")]
        [Display(Name = "Local de Trabalho", Prompt = "Local de Trabalho")]
        public string LocalTrabalho { get; set; }

        /// <summary>
        /// 0 - Em todos os cálculos s/ rendimentos
        /// 1 - Em todos os cálculos s/ rendimentos após o 15º dia(1º pgto.)
        /// 2 - Todo mês s/ rendimentos
        /// 3 - No final do contrato s/ rendimentos
        /// 4 - Em todos os cálculos s/ salário
        /// 5 - Em todos os cálculos s/ salário após o 15º dia(1º pgto.)
        /// 6 - Todo mês sobre salário
        /// 7 - No final do contrato s/ salário
        /// </summary>
        [DefaultValue(7)]
        [Display(Name = "Tipo de 13º", Prompt = "Tipo de 13º")]
        public int Tipo13o { get; set; }

        /// <summary>
        /// 0 - Em todos os cálculos s/ rendimentos
        /// 1 - Em todos os cálculos s/ rendimentos após o 15º dia(1º pgto.)
        /// 2 - Todo mês s/ rendimentos
        /// 3 - No final do contrato s/ rendimentos
        /// 4 - Em todos os cálculos s/ salário
        /// 5 - Em todos os cálculos s/ salário após o 15º dia(1º pgto.)
        /// 6 - Todo mês sobre salário
        /// 7 - No final do contrato s/ salário
        /// </summary>
        [DefaultValue(7)]
        [Display(Name = "Tipo de Férias", Prompt = "Tipo de Férias")]
        public int TipoFer { get; set; }

        /// <summary>
        /// 1 - Demanda Complementar de Serviços.
        /// 2 - Substituição Transitória de Pessoal Permanente.
        /// </summary>
        [DefaultValue(1)]
        [Display(Name = "Motivo da Contratação", Prompt = "Motivo da Contratação")]
        public int MotivoContrato { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Nome do Funcionário a Substituir", Prompt = "Nome do Funcionário a Substituir")]
        public string NomeSubstituto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "CPF", Prompt = "CPF")]
        public decimal CPFSubstituto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Emp", Prompt = "Emp")]
        public int CodigoEmpresaSubstituto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Filial", Prompt = "Filial")]
        public int CodigoFilialSubstituto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Código", Prompt = "Código")]
        public int CodigoFuncionarioSubstituto { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Motivo da Substituição/Acréscimo", Prompt = "Motivo da Substituição/Acréscimo")]
        public string MotivoSubstituicao { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Motivo da Substituição/Acréscimo", Prompt = "Motivo da Substituição/Acréscimo")]
        public string MotivoSubstituicao2 { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Motivo da Substituição/Acréscimo", Prompt = "Motivo da Substituição/Acréscimo")]
        public string MotivoSubstituicao3 { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Motivo da Substituição/Acréscimo", Prompt = "Motivo da Substituição/Acréscimo")]
        public string MotivoSubstituicao4 { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Motivo da Substituição/Acréscimo", Prompt = "Motivo da Substituição/Acréscimo")]
        public string MotivoSubstituicao5 { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Motivo da Substituição/Acréscimo", Prompt = "Motivo da Substituição/Acréscimo")]
        public string MotivoSubstituicao6 { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Fixo 01", Prompt = "Valor Fixo 01")]
        public decimal ValorFixo01 { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Fixo 02", Prompt = "Valor Fixo 02")]
        public decimal ValorFixo02 { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Fixo 03", Prompt = "Valor Fixo 03")]
        public decimal ValorFixo03 { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Fixo 04", Prompt = "Valor Fixo 04")]
        public decimal ValorFixo04 { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Fixo 05", Prompt = "Valor Fixo 05")]
        public decimal ValorFixo05 { get; set; }

        [Display(Name = "Qtde Anuênio", Prompt = "Qtde Anuênio")]
        public int QtdeAnuenio { get; set; }

        [DefaultValue("")]
        [StringLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [Display(Name = "ID Vaga", Prompt = "ID Vaga")]
        public string IdVaga { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Funcionário Recebendo Seguro Desemprego", Prompt = "Funcionário Recebendo Seguro Desemprego")]
        public bool RecebendoSD { get; set; }

        #endregion

        #region Fgts/Fat/Pensão

        [DefaultValue("")]
        [StringLength(6, ErrorMessage = "Máximo 6 caracteres.")]
        [MaxLength(6, ErrorMessage = "Máximo 6 caracteres.")]
        [Display(Name = "Mês/Ano", Prompt = "Mês/Ano")]
        public string CptFGTS { get; set; }

        /// <summary>
        /// 
        /// 1 -  (apenas 1 vínculo empregatício) Não Exposição a Agente Nocivo
        /// 2 -  (apenas 1 vínculo empregatício) Exposição a Agente Nocivo(Aposentadoria com 15 anos de Serviço)
        /// 3 -  (apenas 1 vínculo empregatício) Exposição a Agente Nocivo(Aposentadoria com 20 anos de Serviço)
        /// 4 -  (apenas 1 vínculo empregatício) Exposição a Agente Nocivo(Aposentadoria com 25 anos de Serviço)
        /// 5 -  (mais de 1 vínculo empregatício) Não Exposição a Agente Nocivo
        /// 6 -  (mais de 1 vínculo empregatício)  Exposição a Agente Nocivo(Aposentadoria com 15 anos de Serviço)
        /// 7 -  (mais de 1 vínculo empregatício) Exposição a Agente Nocivo(Aposentadoria com 20 anos de Serviço)
        /// 8 -  (mais de 1 vínculo empregatício) Exposição a Agente Nocivo(Aposentadoria com 25 anos de Serviço)
        /// </summary>
        [DefaultValue(0)]
        [Display(Name = "Ocorrência", Prompt = "Ocorrência")]
        public int OcorrenciaFGTS { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Saldo", Prompt = "Saldo")]
        public decimal SaldoFGTS { get; set; }

        [DefaultValue(0)]
        [Display(Name = "JAM", Prompt = "JAM")]
        public decimal JamFGTS { get; set; }

        [Display(Name = "DT.Opção", Prompt = "DT.Opção")]
        public DateTime? DataOpcaoFGTS { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [Display(Name = "Agência", Prompt = "Agência")]
        public string AgenciaFGTS { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Conta", Prompt = "Conta")]
        public string ContaFGTS { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Chave GRRF", Prompt = "Chave GRRF")]
        public string ChaveGRRF { get; set; }

        [Display(Name = "Prev.Pagto", Prompt = "Prev.Pagto")]
        public DateTime? DataPrevPgtoGRRF { get; set; }

        [Display(Name = "Data Importação", Prompt = "Data Importação")]
        public DateTime? DataImpGRRF { get; set; }

        /// <summary>
        /// 0 - Não Informado
        ///1 - Contribuição descontada pelo primeiro empregador(Soma Bases para Calcular Percentual sem abater o desconto anterior)
        ///2 - Contribuição descontada por outra(s) empresa(s) sobre valor inferior ao limite máximo do salário de contribuição(Soma Bases para Calculo e Desconto)
        ///3 - Contribuição sobre o limite máximo de salário de contribuição já descontada em outra(s) empresa(s)  (Sem Desconto Ginfor )
        /// </summary>
        [DefaultValue(0)]
        [Display(Name = "Indicador de desconto da Contribuição Previdenciária do Trabalhador",
            Prompt = "Indicador de desconto da Contribuição Previdenciária do Trabalhador")]
        public int IndMV { get; set; }

        /// <summary>
        /// 
        /// Indicação
        /// Seleção
        /// </summary>
        [DefaultValue("S")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Tipo de Taxa", Prompt = "Tipo de Taxa")]
        public string TipoFatu { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Taxa", Prompt = "Taxa")]
        public decimal PercentFatu { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Observação (Faturamento)", Prompt = "Observação (Faturamento)")]
        public string ObsFaturamento { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Mensal Mínimo Garantido (Vendedor)", Prompt = "Valor Mensal Mínimo Garantido (Vendedor)")]
        public decimal SalarioMesGarantido { get; set; }


        [DefaultValue(0)]
        [Display(Name = "Selecionador", Prompt = "Selecionador")]
        public int CodigoSelecionador { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Vendedor", Prompt = "Vendedor")]
        public int CodigoVendedor { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Recrutador", Prompt = "Recrutador")]
        public int CodigoRecrutador { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Representante", Prompt = "Representante")]
        public int CodigoRepresentante { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Nro. Pedido", Prompt = "Nro. Pedido")]
        public decimal IdFatPedido { get; set; }

        [DefaultValue("")]
        [StringLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [Display(Name = "Nro. Requisição", Prompt = "Nro. Requisição")]
        public string NroReqPed { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Fat. Pedido Requisição", Prompt = "Valor Fat. Pedido Requisição")]
        public decimal ValHoraFatReqPed { get; set; }

        [Display(Name = "Salário Mês", Prompt = "Salário Mês")]
        public decimal SalarioFat { get; set; }

        [Display(Name = "Valor Hora Extra Faturado", Prompt = "Valor Hora Extra Faturado")]
        public decimal ValorHorExtFat { get; set; }

        [Display(Name = "Valor Adicional Noturno Faturado", Prompt = "Valor Adicional Noturno Faturado")]
        public decimal ValorAdcNotFat { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Falta Faturado", Prompt = "Valor Falta Faturado")]
        public decimal ValorFaltaDiaFat { get; set; }

        #endregion

        #region Benefícios

        [DefaultValue(0)]
        [Display(Name = "% Desconto VT", Prompt = "% Desconto VT")]
        public decimal PercentualVT { get; set; }

        [Display(Name = "Limite p/ Pagto de Bnf", Prompt = "Limite p/ Pagto de Bnf")]
        public DateTime? DataLimiteBNF { get; set; }

        [Display(Name = "Vale Alimentação Diário", Prompt = "Vale Alimentação Diário")]
        public bool VA_Diario { get; set; }

        /// <summary>
        /// 
        /// A - Ambos
        /// D - Dinheiro
        /// E - Espécie
        /// </summary>
        [DefaultValue("E")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Tipo VT", Prompt = "Tipo VT")]
        public string TipoVT { get; set; }

        /// <summary>
        /// 
        /// D - Dinheiro
        /// E - Espécie
        /// </summary>
        [DefaultValue("E")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Tipo VR", Prompt = "Tipo VR")]
        public string TipoVR { get; set; }

        [Display(Name = "SPTrans", Prompt = "SPTrans")]
        public decimal NroCartaoSPTrans { get; set; }

        [Display(Name = "RioCard", Prompt = "RioCard")]
        public decimal NroCartaoRioCard { get; set; }

        [Display(Name = "Urbs", Prompt = "Urbs")]
        public decimal NroCartaoURBS { get; set; }

        [Display(Name = "TransUrb", Prompt = "TransUrb")]
        public decimal NroCartaoTransURB { get; set; }

        [Display(Name = "Sodexho RH", Prompt = "Sodexho RH")]
        public decimal NroCartaoSodexhoRH { get; set; }

        [DefaultValue(0)]
        [Display(Name = "VTC", Prompt = "VTC")]
        public decimal NroCartaoVTC { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "S.U.S/Convênio", Prompt = "S.U.S/Convênio")]
        public string CartaoSUS { get; set; }

        [DefaultValue("")]
        [StringLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [Display(Name = "TransLitoral", Prompt = "TransLitoral")]
        public string TransLitoral { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Ótimo", Prompt = "Ótimo")]
        public decimal NroCartaoOtimo { get; set; }

        [DefaultValue(0)]
        [Display(Name = "BHBus", Prompt = "BHBus")]
        public decimal NroCartaoBHBus { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Transbetim", Prompt = "Transbetim")]
        public decimal NroCartaoTransBetim { get; set; }

        [DefaultValue(0)]
        [Display(Name = "GuaruPas/Ticket Rh", Prompt = "GuaruPas/Ticket Rh")]
        public decimal NroCartaoGuaruPas { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [MaxLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [Display(Name = "Assist. Médica", Prompt = "Assist. Médica")]
        public string NroCarteiraBnfAM { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [MaxLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [Display(Name = "Assist.Odontológica", Prompt = "Assist.Odontológica")]
        public string NroCarteiraBnfAO { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "MetroCard", Prompt = "MetroCard")]
        public string CartaoMetroCard { get; set; }

        [DefaultValue("")]
        [StringLength(13, ErrorMessage = "Máximo 13 caracteres.")]
        [MaxLength(13, ErrorMessage = "Máximo 13 caracteres.")]
        [Display(Name = "Cartão Benefício", Prompt = "Cartão Benefício")]
        public string CartaoPrePago { get; set; }

        #endregion

        #region Eventos/C.Custo

        [Display(Name = "Período1 de Férias Programada de", Prompt = "Período1 de Férias Programada de")]
        public DateTime? DataIniFeriasProg { get; set; }

        [Display(Name = "Até", Prompt = "Até")]
        public DateTime? DataFimFeriasProg { get; set; }

        [Display(Name = "Período2 de Férias Programada de", Prompt = "Período2 de Férias Programada de")]
        public DateTime? DataIniFeriasProg2 { get; set; }

        [Display(Name = "Até", Prompt = "Até")]
        public DateTime? DataFimFeriasProg2 { get; set; }

        [Display(Name = "Período3 de Férias Programada de", Prompt = "Período3 de Férias Programada de")]
        public DateTime? DataIniFeriasProg3 { get; set; }

        [Display(Name = "Até", Prompt = "Até")]
        public DateTime? DataFimFeriasProg3 { get; set; }

        [DefaultValue(false)]
        [Display(Name = "Abono", Prompt = "Abono")]
        public bool ProgFer_Abono { get; set; }

        [DefaultValue(false)]
        [Display(Name = "Antecipação 1ª Parcela 13º Salário", Prompt = "Antecipação 1ª Parcela 13º Salário")]
        public bool ProgFer_1P13o { get; set; }

        #endregion

        #region Observações

        [DefaultValue("")]
        [StringLength(3000, ErrorMessage = "Máximo 3000 caracteres.")]
        [MaxLength(3000, ErrorMessage = "Máximo 3000 caracteres.")]
        public string Observacao { get; set; }

        #endregion

        #region Inst. / Funções

        [Display(Name = "Instituição", Prompt = "Instituição")]
        public int CodigoInstituicao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Curso", Prompt = "Curso")]
        public int CodigoCurso { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Nome do Curso", Prompt = "Nome do Curso")]
        public string NomeCurso { get; set; }

        [DefaultValue("")]
        [StringLength(200, ErrorMessage = "Máximo 200 caracteres.")]
        [MaxLength(200, ErrorMessage = "Máximo 200 caracteres.")]
        [Display(Name = "Nível do Curso", Prompt = "Nível do Curso")]
        public string NivelCurso { get; set; }

        [DefaultValue("")]
        [StringLength(600, ErrorMessage = "Máximo 600 caracteres.")]
        [MaxLength(600, ErrorMessage = "Máximo 600 caracteres.")]
        [Display(Name = "Atividade do Curso", Prompt = "Atividade do Curso")]
        public string AtividadeCurso { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Código Supervisor", Prompt = "Código Supervisor")]
        public int CodigoSupervisor { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Código Coordenador", Prompt = "Código Coordenador")]
        public int CodigoCoordenador { get; set; }

        [DefaultValue("")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        [Display(Name = "Email Gestor", Prompt = "Email Gestor")]
        public string EmailGestor { get; set; }

        [DefaultValue("")]
        [StringLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [Display(Name = "Última Matrícula", Prompt = "Última Matrícula")]
        public string Curso_UltMatricula { get; set; }

        [Display(Name = "Data Última Matrícula", Prompt = "Data Última Matrícula")]
        public DateTime? Curso_DataUltMatricula { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Dias Vencimento", Prompt = "Dias Vencimento")]
        public int Curso_DiasVcto { get; set; }

        [Display(Name = "Vencimento", Prompt = "Vencimento")]
        public DateTime? Curso_DataVcto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "2ª Função", Prompt = "2ª Função")]
        public int CodigoFuncao2 { get; set; }

        [DefaultValue(0)]
        [Display(Name = "3ª Função", Prompt = "3ª Função")]
        public int CodigoFuncao3 { get; set; }

        [DefaultValue(0)]
        [Display(Name = "4ª Função", Prompt = "4ª Função")]
        public int CodigoFuncao4 { get; set; }

        [DefaultValue(0)]
        [Display(Name = "5ª Função", Prompt = "5ª Função")]
        public int CodigoFuncao5 { get; set; }

        #endregion

        #region Livres

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 01", Prompt = "Livre 01")]
        public string CampoLivre_01 { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 02", Prompt = "Livre 02")]
        public string CampoLivre_02 { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 03", Prompt = "Livre 03")]
        public string CampoLivre_03 { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 04", Prompt = "Livre 04")]
        public string CampoLivre_04 { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 05", Prompt = "Livre 05")]
        public string CampoLivre_05 { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 06", Prompt = "Livre 06")]
        public string CampoLivre_06 { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 07", Prompt = "Livre 07")]
        public string CampoLivre_07 { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 08", Prompt = "Livre 08")]
        public string CampoLivre_08 { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 09", Prompt = "Livre 09")]
        public string CampoLivre_09 { get; set; }


        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 10", Prompt = "Livre 10")]
        public string CampoLivre_10 { get; set; }

        //[DefaultValue("")]
        //[StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        //[MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        //[Display(Name = "Livre 11", Prompt = "Livre 11")]
        //public string CampoLivre_11 { get; set; }
        //
        //[DefaultValue("")]
        //[StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        //[MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        //[Display(Name = "Livre 12", Prompt = "Livre 12")]
        //public string CampoLivre_12 { get; set; }
        //
        //[DefaultValue("")]
        //[StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        //[MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        //[Display(Name = "Livre 13", Prompt = "Livre 13")]
        //public string CampoLivre_13 { get; set; }

        #endregion

        #region Escalas

        /// <summary>
        /// Normal
        /// Sábado
        /// Domingo
        /// Sexta - Feira
        /// </summary>
        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Tipo Escala", Prompt = "Tipo Escala")]
        public string EscalaTipo { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Escala", Prompt = "Escala")]
        public int EscalaDiasTrabalho { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Escala", Prompt = "Escala")]
        public int EscalaDiasDescanso { get; set; }

        [Display(Name = "Início", Prompt = "Início")]
        public DateTime? EscalaDataInicio { get; set; }

        [Display(Name = "Fim", Prompt = "Fim")]
        public DateTime? EscalaDataFim { get; set; }

        [Display(Name = "Tipo Chave PIX", Prompt = "Tipo Chave PIX")]
        public int TipoChavePixFun { get; set; }

        [Display(Name = "Chave Pix", Prompt = "Chave Pix")]
        public string ChavePixFun { get; set; }

        #endregion

        public int ID_GiSelecao { get; set; }
        public string ObsRecrutador { get; set; }

        public string StatusGIAdmDigital { get; set; }
        public int IdAdmDigital { get; set; }



    }

    public class TB_FuncionarioSelecaoAPI : BaseTB
    {

        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Empresa", Prompt = "Empresa")]
        public short CodigoEmpresa { get; set; }

        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Filial", Prompt = "Filial")]
        public short CodigoFilial { get; set; }

        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Código", Prompt = "Código")]
        public int CodigoFuncionario { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Cliente", Prompt = "Cliente")]
        ////[Required(ErrorMessage = "Selecione um Cliente!")]
        public int? CodigoCliente { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Contrato", Prompt = "Contrato")]
        ////[Required(ErrorMessage = "Digite o Contrato / Tipo!")]
        public short? CodigoContrato { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Tipo de Faturamento", Prompt = "Tipo de Faturamento")]
        //[Required(ErrorMessage = "Digite o Contrato / Tipo!")]
        public short? TipoFat { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Centro de Custo", Prompt = "Centro de Custo")]
        public int? CodigoCentroCusto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Vendedor", Prompt = "Vendedor")]
        public short? CodigoVendedor { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Selecionador", Prompt = "Selecionador")]
        public short? CodigoSelecionador { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Recrutador", Prompt = "Recrutador")]
        public short? CodigoRecrutador { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Função", Prompt = "Função")]
        //[Required(ErrorMessage = "Selecione uma Função!")]
        public int? CodigoFuncao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Sindicato", Prompt = "Sindicato")]
        public short? CodigoSindicato { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Horário", Prompt = "Horário")]
        //[Required(ErrorMessage = "Selecione um Horário!")]
        public int? CodigoHorario { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Banco", Prompt = "Banco")]
        public short? CodigoBcoFolha { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Banco", Prompt = "Banco")]
        public short? CodigoBcoPagar { get; set; }

        [DefaultValue("")]
        [StringLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [Display(Name = "Matrícula", Prompt = "Matrícula")]
        public string? Matricula { get; set; }

        [DefaultValue("")]
        [StringLength(60, ErrorMessage = "Nome Inválido para o e - Social! Ulrapassou o limite de 60 caracteres!")]
        [MaxLength(60, ErrorMessage = "Nome Inválido para o e - Social! Ulrapassou o limite de 60 caracteres!")]
        [Display(Name = "Nome", Prompt = "Nome")]
        public string? Nome { get; set; }

        [DefaultValue("00000000")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [Display(Name = "Número", Prompt = "Número")]
        public string? CarteiraTrabalho { get; set; }

        [DefaultValue("00000")]
        [StringLength(7, ErrorMessage = "Máximo 7 caracteres.")]
        [MaxLength(7, ErrorMessage = "Máximo 7 caracteres.")]
        [Display(Name = "Série", Prompt = "Série")]
        public string? Serie { get; set; }

        [Display(Name = "Data da Expedição", Prompt = "Data da Expedição")]
        public DateTime? DtExpedicaoCTPS { get; set; }

        /// <summary>
        /// 
        /// AC
        /// AL
        /// AM
        /// AP
        /// BA
        /// CE
        /// DF
        /// ES
        /// GO
        /// MA
        /// MG
        /// MS
        /// MT
        /// PA
        /// PB
        /// PE
        /// PI
        /// PR
        /// RJ
        /// RN
        /// RO
        /// RR
        /// RS
        /// SC
        /// SE
        /// SP
        /// TO
        /// </summary>
        [DefaultValue("")]
        [StringLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [MaxLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [Display(Name = "UF", Prompt = "UF")]
        public string? UFExpedicao { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Cidade", Prompt = "Cidade")]
        public string? CidadeExpedicao { get; set; }

        [Display(Name = "Nascimento", Prompt = "Nascimento")]
        public DateTime? DataNascimento { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Cidade de Nascimento", Prompt = "Cidade de Nascimento")]
        public string? CidadeNascimento { get; set; }

        /// <summary>
        /// F - Feminino
        /// M - Masculino
        /// </summary>
        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Sexo", Prompt = "Sexo")]
        public string? Sexo { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Mãe", Prompt = "Mãe")]
        public string? FiliacaoNomeMae { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Pai", Prompt = "Pai")]
        public string? FiliacaoNomePai { get; set; }

        [DefaultValue("4")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Instrução", Prompt = "Instrução")]
        public string? GrauInstrucao { get; set; }

        [Display(Name = "Admissão", Prompt = "Admissão")]
        public DateTime? DataAdmissao { get; set; }

        /// <summary>
        /// D - Direta
        /// I - Indireta
        /// </summary>
        [DefaultValue("D")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Tipo", Prompt = "Tipo")]
        public string? TipoAdmissao { get; set; }

        /// <summary>
        /// 1 - Contrato CLT
        /// 2 - Estagiário(Lei Antiga)
        /// 3 - Avulso
        /// 4 - Temporário
        /// 5 - Diretor sem FGTS
        /// 6 - Serviço não Efetivo
        /// 7 - CLT Prazo Determinado
        /// 8 - Diretor com FGTS
        /// 9 - Outros
        /// C - Agente Público
        /// D - Autônomo que Contribui com Remuneração
        /// E - Autônomo que Contribui com Salário Base
        /// F - Transportador Autônomo que Contribui com Remuneração
        /// G - Transportador Autônomo que Contribui com Salário Base
        /// H - Menor Aprendiz(Lei 10.097/2000)
        /// I - Doméstico(a)
        /// J - Estagiário(Nova Lei 11.788 09/2008)
        /// K - Contrato Intermitente
        /// </summary>
        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Vínculo", Prompt = "Vínculo")]
        public string? Vinculo { get; set; }

        /// <summary>
        /// D - Determinado
        /// I - Indeterminado
        /// </summary>
        [DefaultValue("I")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Contrato", Prompt = "Contrato")]
        public string? TipoContrato { get; set; }

        [Display(Name = "Contrato", Prompt = "Contrato")]
        public DateTime? DtVectoContrato { get; set; }

        [Display(Name = "Prorrogação", Prompt = "Prorrogação")]
        public DateTime? DtVectoProrrogacao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Contrato", Prompt = "Contrato")]
        public int? DiasContrato { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Prorrogação", Prompt = "Prorrogação")]
        public int? DiasProrrogacao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Número", Prompt = "Número")]
        [Column(TypeName = "DECIMAL(18,0)")]
        public decimal? CPF { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [MaxLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [Display(Name = "Número", Prompt = "Número")]
        public string? TituloEleitor { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Número", Prompt = "Número")]
        [Column(TypeName = "DECIMAL(18,0)")]
        public decimal? PIS { get; set; }

        [Display(Name = "DT.Opção", Prompt = "DT.Opção")]
        public DateTime? DataOpcaoFGTS { get; set; }

        /// <summary>
        /// 1 - Analfabeto
        /// 2 - Até 5º Ano Incompleto
        /// 3 - 5º Ano Completo
        /// 4 - 6º ao 9º Ano Incompleto
        /// 5 - Fundamental Completo
        /// 6 - Ensino Médio Incompleto
        /// 7 - Ensino Médio Completo
        /// 8 - Superior Incompleto
        /// 9 - Superior Completo
        /// A - Pós-Graduação Completa
        /// B - Mestrado Completo
        /// C - Doutorado Completo
        /// D - Pós-Doutorado Completo
        /// </summary>
        [DefaultValue("S")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Estado Civil", Prompt = "Estado Civil")]
        public string? EstadoCivil { get; set; }

        /// <summary>
        /// 
        /// AC
        /// AL
        /// AM
        /// AP
        /// BA
        /// CE
        /// DF
        /// ES
        /// GO
        /// MA
        /// MG
        /// MS
        /// MT
        /// PA
        /// PB
        /// PE
        /// PI
        /// PR
        /// RJ
        /// RN
        /// RO
        /// RR
        /// RS
        /// SC
        /// SE
        /// SP
        /// TO
        /// </summary>
        [DefaultValue("")]
        [StringLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [MaxLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [Display(Name = "Naturalidade", Prompt = "Naturalidade")]
        public string? Naturalidade { get; set; }

        /// <summary>
        /// 010 - Brasileiro
        /// 013 - Afeganistao
        /// 017 - Albania, Republica Da
        /// 020 - Naturalizado
        /// 021 - Argentino
        /// 022 - Boliviano
        /// 023 - Chileno
        /// 024 - Paraguaio
        /// 025 - Uruguaio
        /// 026 - Venezuelano
        /// 027 - Colombiano
        /// 028 - Peruano
        /// 029 - Equatoriano
        /// 030 - Alemão
        /// 031 - Belga
        /// 032 - Britanico
        /// 034 - Canadense
        /// 035 - Espanhol
        /// 036 - EUA
        /// 037 - Francês
        /// 038 - Suíço
        /// 039 - Italiano
        /// 040 - Haitiano
        /// 041 - Japonês
        /// 042 - Chinês
        /// 043 - Coreano
        /// 044 - Russo
        /// 045 - Português
        /// 046 - Paquistanês
        /// 047 - Indiano
        /// 048 - Outros Latinos
        /// 049 - Outros Asiáticos
        /// 050 - Outros
        /// 051 - Outros Europeus
        /// 053 - Arabia Saudita
        /// 059 - Argelia
        /// 060 - Angolano
        /// 061 - Congolês
        /// 062 - Sul - Africano
        /// 064 - Armenia, Republica Da
        /// 065 - Aruba
        /// 069 - Australia
        /// 070 - Outros Africanos
        /// 072 - Austria
        /// 073 - Azerbaijao, Republica Do
        /// 076 - Burkina Faso
        /// 077 - Bahamas, Ilhas
        /// 078 - Belarus, Republica Da
        /// 079 - Belize
        /// 080 - República Tcheca
        /// 081 - Palestina
        /// 082 - Guiné - Bissau
        /// 083 - Cubano
        /// 084 - Marrocos
        /// 085 - Gana
        /// 086 - México
        /// 087 - Senegal
        /// 088 - Filipinas
        /// 089 - Zambia
        /// 090 - Bermudas
        /// 091 - Andorra
        /// 092 - Anguilla
        /// 093 - Mianmar(BIRMANIA)
        /// 094 - Antigua E Barbuda
        /// 095 - Antilhas Holandesas
        /// 096 - Bahrein, Ilhas
        /// 097 - Bangladesh
        /// 098 - Bosnia-Herzegovina(REPUBLICA Da)
        /// 099 - Barbados
        /// 101 - Botsuana
        /// 108 - Brunei
        /// 111 - Bulgaria, Republica Da
        /// 115 - Burundi
        /// 119 - Butao
        /// 127 - Cabo Verde, Republica De
        /// 137 - Cayan, Ilhas
        /// 141 - Camboja
        /// 145 - Camaroes
        /// 150 - Jersey, Ilha Do Canal
        /// 151 - Canarias, Ilhas
        /// 153 - Cazaquistao, Republica Do
        /// 154 - Catar
        /// 161 - Formosa(TAIWAN)
        /// 163 - Chipre
        /// 165 - Cocos(Keeling),Ilhas
        /// 173 - Comores, Ilhas
        /// 183 - Cook, Ilhas
        /// 187 - Coreia(DO Norte), Rep.Pop.Democratica
        /// 193 - Costa Do Marfim
        /// 195 - Croacia(REPUBLICA Da)
        /// 196 - Costa Rica
        /// 198 - Coveite
        /// 229 - Benin
        /// 232 - Dinamarca
        /// 235 - Dominica,Ilha
        /// 240 - Egito
        /// 243 - Eritreia
        /// 244 - Emirados Arabes Unidos
        /// 246 - Eslovenia, Republica Da
        /// 247 - Eslovaca, Republica
        /// 251 - Estonia, Republica Da
        /// 253 - Etiopia
        /// 255 - Falkland(ILHAS Malvinas)
        /// 259 - Feroe, Ilhas
        /// 271 - Finlandia
        /// 281 - Gabao
        /// 285 - Gambia
        /// 291 - Georgia, Republica Da
        /// 293 - Gibraltar
        /// 297 - Granada
        /// 301 - Grecia
        /// 305 - Groenlandia
        /// 309 - Guadalupe
        /// 313 - Guam
        /// 317 - Guatemala
        /// 325 - Guiana Francesa
        /// 329 - Guine
        /// 331 - Guine-Equatorial
        /// 337 - Guiana
        /// 345 - Honduras
        /// 351 - Hong Kong
        /// 355 - Hungria, Republica Da
        /// 357 - Iemen
        /// 359 - Man, Ilha De
        /// 365 - Indonesia
        /// 369 - Iraque
        /// 372 - Ira, Republica Islamica Do
        /// 375 - Irlanda
        /// 379 - Islandia
        /// 383 - Israel
        /// 388 - Servia E Montenegro
        /// 391 - Jamaica
        /// 396 - Johston, Ilhas
        /// 403 - Jordania
        /// 411 - Kiribati
        /// 420 - Laos, Rep.Pop.Democr.Do
        /// 423 - Lebuan,Ilhas
        /// 426 - Lesoto
        /// 427 - Letonia, Republica Da
        /// 431 - Libano
        /// 434 - Liberia
        /// 438 - Libia
        /// 440 - Liechtenstein
        /// 442 - Lituania, Republica Da
        /// 445 - Luxemburgo
        /// 447 - Macau
        /// 449 - Macedonia, Ant.Rep.Iugoslava
        /// 450 - Madagascar
        /// 452 - Ilha Da Madeira
        /// 455 - Malasia
        /// 458 - Malavi
        /// 461 - Maldivas
        /// 464 - Mali
        /// 467 - Malta
        /// 472 - Marianas Do Norte
        /// 476 - Marshall,Ilhas
        /// 477 - Martinica
        /// 485 - Mauricio
        /// 488 - Mauritania
        /// 490 - Midway, Ilhas
        /// 494 - Moldavia, Republica Da
        /// 495 - Monaco
        /// 497 - Mongolia
        /// 499 - Micronesia
        /// 501 - Montserrat,Ilhas
        /// 505 - Mocambique
        /// 507 - Namibia
        /// 508 - Nauru
        /// 511 - Christmas,Ilha(NAVIDAD)
        /// 517 - Nepal
        /// 521 - Nicaragua
        /// 525 - Niger
        /// 528 - Nigeria
        /// 531 - Niue,Ilha
        /// 535 - Norfolk,Ilha
        /// 538 - Noruega
        /// 542 - Nova Caledonia
        /// 545 - Papua Nova Guine
        /// 548 - Nova Zelandia
        /// 551 - Vanuatu
        /// 556 - Oma
        /// 566 - Pacifico,Ilhas Do(POSSESSAO Dos Eua)
        /// 573 - Paises Baixos(HOLANDA)
        /// 575 - Palau
        /// 580 - Panama
        /// 593 - Pitcairn,Ilha
        /// 599 - Polinesia Francesa
        /// 603 - Polonia, Republica Da
        /// 611 - Porto Rico
        /// 623 - Quenia
        /// 625 - Quirguiz, Republica
        /// 628 - Reino Unido
        /// 640 - Republica Centro-Africana
        /// 647 - Republica Dominicana
        /// 660 - Reuniao, Ilha
        /// 665 - Zimbabue
        /// 670 - Romenia
        /// 675 - Ruanda
        /// 677 - Salomao, Ilhas
        /// 678 - Saint Kitts E Nevis
        /// 685 - Saara Ocidental
        /// 687 - El Salvador
        /// 690 - Samoa
        /// 691 - Samoa Americana
        /// 695 - Sao Cristovao E Neves, Ilhas
        /// 697 - San Marino
        /// 700 - Sao Pedro E Miquelon
        /// 705 - Sao Vicente E Granadinas
        /// 710 - Santa Helena
        /// 715 - Santa Lucia
        /// 720 - Sao Tome E Principe, Ilhas
        /// 731 - Seychelles
        /// 735 - Serra Leoa
        /// 738 - Sikkim
        /// 741 - Cingapura
        /// 744 - Siria, Republica Arabe Da
        /// 748 - Somalia
        /// 750 - Sri Lanka
        /// 754 - Suazilandia
        /// 756 - Africa Do Sul
        /// 759 - Sudao
        /// 764 - Suecia
        /// 770 - Suriname
        /// 772 - Tadjiquistao, Republica Do
        /// 776 - Tailandia
        /// 780 - Tanzania, Rep.Unida Da
        /// 782 - Territorio Brit.Oc.Indico
        /// 783 - Djibuti
        /// 785 - Territorio da Alta Comissao do Pacifico Ocidental
        /// 788 - Chade
        /// 790 - Tchecoslovaquia
        /// 795 - Timor Leste
        /// 800 - Togo
        /// 805 - Toquelau, Ilhas
        /// 810 - Tonga
        /// 815 - Trinidad E Tobago
        /// 820 - Tunisia
        /// 823 - Turcas E Caicos, Ilhas
        /// 824 - Turcomenistao, Republica Do
        /// 827 - Turquia
        /// 828 - Tuvalu
        /// 831 - Ucrania
        /// 833 - Uganda
        /// 840 - Uniao Das Republicas Socialistas Sovieticas
        /// 847 - Uzbequistao, Republica Do
        /// 848 - Vaticano, Est.Da Cidade Do
        /// 855 - Vietname Norte
        /// 858 - Vietna
        /// 863 - Virgens, Ilhas (BRITANICAS)
        /// 866 - Virgens, Ilhas (E.U.A.)
        /// 870 - Fiji
        /// 873 - Wake, Ilha
        /// 875 - Wallis E Futuna, Ilhas
        /// 888 - Congo, Republica Democratica Do
        /// </summary>
        [DefaultValue("010")]
        [StringLength(3, ErrorMessage = "Máximo 3 caracteres.")]
        [MaxLength(3, ErrorMessage = "Máximo 3 caracteres.")]
        [Display(Name = "Nacionalidade", Prompt = "Nacionalidade")]
        public string? Nacionalidade { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Cód.Cid.Nascimento", Prompt = "Cód.Cid.Nascimento")]
        public int? AnoChegada { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Casado com Brasileiro", Prompt = "Casado com Brasileiro")]
        public bool? CasadoBrasileiro { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Tem filhos Brasileiros", Prompt = "Tem filhos Brasileiros")]
        public bool? FilhosBrasileiros { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Endereço", Prompt = "Endereço")]
        public string? EnderecoResid { get; set; }

        [DefaultValue("")]
        [StringLength(60, ErrorMessage = "Máximo 60 caracteres.")]
        [MaxLength(60, ErrorMessage = "Máximo 60 caracteres.")]
        [Display(Name = "Bairro", Prompt = "Bairro")]
        public string? BairroResid { get; set; }

        [DefaultValue("00000-000")]
        [StringLength(9, ErrorMessage = "Máximo 9 caracteres.")]
        [MaxLength(9, ErrorMessage = "Máximo 9 caracteres.")]
        [Display(Name = "CEP", Prompt = "CEP")]
        public string? CepResid { get; set; }

        [DefaultValue("")]
        [StringLength(60, ErrorMessage = "Máximo 60 caracteres.")]
        [MaxLength(60, ErrorMessage = "Máximo 60 caracteres.")]
        [Display(Name = "Cidade", Prompt = "Cidade")]
        public string? CidadeResid { get; set; }

        /// <summary>
        /// 
        /// AC
        /// AL
        /// AM
        /// AP
        /// BA
        /// CE
        /// DF
        /// ES
        /// GO
        /// MA
        /// MG
        /// MS
        /// MT
        /// PA
        /// PB
        /// PE
        /// PI
        /// PR
        /// RJ
        /// RN
        /// RO
        /// RR
        /// RS
        /// SC
        /// SE
        /// SP
        /// TO
        /// </summary>
        [DefaultValue("")]
        [StringLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [MaxLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [Display(Name = "UF", Prompt = "UF")]
        public string? UFResid { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Telefone", Prompt = "Telefone")]
        public string? TelefoneResid { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Email", Prompt = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email Inválido!")]
        public string? Email { get; set; }

        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Máscara", Prompt = "Máscara")]
        public string? TipoMskBanco { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [Display(Name = "Agência", Prompt = "Agência")]
        public string? Agencia { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Conta Corrente", Prompt = "Conta Corrente")]
        public string? ContaCorrente { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [Display(Name = "Agência", Prompt = "Agência")]
        public string? AgenciaFGTS { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Conta", Prompt = "Conta")]
        public string? ContaFGTS { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Saldo", Prompt = "Saldo")]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? SaldoFGTS { get; set; }

        [DefaultValue(0)]
        [Display(Name = "JAM", Prompt = "JAM")]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? JamFGTS { get; set; }

        [DefaultValue("")]
        [StringLength(6, ErrorMessage = "Máximo 6 caracteres.")]
        [MaxLength(6, ErrorMessage = "Máximo 6 caracteres.")]
        [Display(Name = "Mês / Ano", Prompt = "Mês / Ano")]
        public string? CptFGTS { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [MaxLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [Display(Name = "Número", Prompt = "Número")]
        public string? Habilitacao { get; set; }

        [Display(Name = "Data de Vencimento", Prompt = "Data de Vencimento")]
        public DateTime? DataVectoHabilitacao { get; set; }

        [DefaultValue("")]
        [StringLength(200, ErrorMessage = "Máximo 200 caracteres.")]
        [MaxLength(200, ErrorMessage = "Máximo 200 caracteres.")]
        [Display(Name = "Local de Trabalho", Prompt = "Local de Trabalho")]
        public string? LocalTrabalho { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Mês", Prompt = "Mês")]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? Salario { get; set; }

        /// <summary>
        /// M - Mensal
        /// Q - Quinzenal
        /// S - Semanal
        /// </summary>
        [DefaultValue("M")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Salário", Prompt = "Salário")]
        public string? TipoSalario { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [Display(Name = "Chapa", Prompt = "Chapa")]
        public string? Chapa { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [Display(Name = "Chapeira", Prompt = "Chapeira")]
        public string? Chapera { get; set; }

        [DefaultValue(1)]
        [Display(Name = "Cartão de Ponto", Prompt = "Cartão de Ponto")]
        public bool? CartaoPonto { get; set; }

        [DefaultValue(1)]
        [Display(Name = "Etiqueta", Prompt = "Etiqueta")]
        public bool? EmissaoEtiqueta { get; set; }

        [DefaultValue(1)]
        [Display(Name = "Ficha Horária", Prompt = "Ficha Horária")]
        public bool? EmissaoFichaHora { get; set; }

        /// <summary>
        /// 
        /// I - Indicação
        /// S - Seleção
        /// </summary>
        [DefaultValue("S")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Tipo de Taxa", Prompt = "Tipo de Taxa")]
        public string? TipoFatu { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Taxa", Prompt = "Taxa")]
        [Column(TypeName = "DECIMAL(7,4)")]
        public decimal? PercentFatu { get; set; }

        [Display(Name = "Último Exame", Prompt = "Último Exame")]
        public DateTime? DataUltimoExame { get; set; }

        [Display(Name = "Vencimento", Prompt = "Vencimento")]
        public DateTime? DataVectoExame { get; set; }

        [Display(Name = "Demissão", Prompt = "Demissão")]
        public DateTime? DataDemissao { get; set; }

        /// <summary>
        /// 
        /// 1 - Pela Empresa com Justa Causa
        /// 2 - Pela Empresa sem Justa Causa
        /// 3 - Pelo Empregado com Justa Causa
        /// 4 - Pelo Empregado sem Justa Causa
        /// 5 - Término de Contrato
        /// 6 - Transferência com Ônus
        /// 7 - Aposentadoria
        /// 8 - Morte
        /// 9 - Término de Contrato Antecipado pela Empresa
        /// 10 - Outros
        /// 11 - Término de Contrato Antecipado pelo Empregado
        /// 12 - Aposentadoria por Invalidez
        /// 13 - Término de Contrato Por Motivo de Acordo
        /// 14 - Motivo de Acordo(Contrato Intermitente)
        /// </summary>
        [DefaultValue(0)]
        [Display(Name = "Código Rescisão(Motivo)", Prompt = "Código Rescisão(Motivo)")]
        public byte? CodigoRescisao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Centro de Custo", Prompt = "Centro de Custo")]
        public short CentroCustoContab { get; set; }

        public DateTime? DataUltAtuTurnovo { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Número", Prompt = "Número")]
        public string? RG { get; set; }

        [DefaultValue("")]
        [StringLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [Display(Name = "Órgão", Prompt = "Órgão")]
        public string? OrgaoRG { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Cidade", Prompt = "Cidade")]
        public string? CidadeRG { get; set; }

        /// <summary>
        /// 
        /// AC
        /// AL
        /// AM
        /// AP
        /// BA
        /// CE
        /// DF
        /// ES
        /// GO
        /// MA
        /// MG
        /// MS
        /// MT
        /// PA
        /// PB
        /// PE
        /// PI
        /// PR
        /// RJ
        /// RN
        /// RO
        /// RR
        /// RS
        /// SC
        /// SE
        /// SP
        /// TO
        /// </summary>
        [DefaultValue("")]
        [StringLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [MaxLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [Display(Name = "UF", Prompt = "UF")]
        public string? UFRG { get; set; }

        [Display(Name = "Data da Expedição", Prompt = "Data da Expedição")]
        public DateTime? DtExpedicaoRG { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Hora", Prompt = "Hora")]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? SalarioHora { get; set; }

        [DefaultValue(0)]
        [Display(Name = "SF", Prompt = "SF")]
        public byte? DepSF { get; set; }

        [DefaultValue(0)]
        [Display(Name = "IRF", Prompt = "IRF")]
        public byte? DepIRF { get; set; }

        public DateTime? DataInclusao { get; set; }

        public DateTime? Dataalteracao { get; set; }

        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        public string? CodigoAfastamento { get; set; }

        [DefaultValue(0)]
        [Display(Name = "1º Emprego", Prompt = "1º Emprego")]
        public bool? PrimeiroEmprego { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Semanais", Prompt = "Semanais")]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? QtdeHorasSem { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Mensais", Prompt = "Mensais")]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? QtdeHorasMes { get; set; }

        public byte? Situacao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Insalubridade", Prompt = "Insalubridade")]
        [Column(TypeName = "DECIMAL(7,4)")]
        public decimal? PercentInsalub { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Periculosidade", Prompt = "Periculosidade")]
        [Column(TypeName = "DECIMAL(7,4)")]
        public decimal? PercentPericul { get; set; }

        /// <summary>
        /// 
        /// A - Ambos
        /// D - Dinheiro
        /// E - Espécie
        /// </summary>
        [DefaultValue("E")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Tipo VT", Prompt = "Tipo VT")]
        public string? TipoVT { get; set; }

        /// <summary>
        /// 
        /// D - Dinheiro
        /// E - Espécie
        /// </summary>
        [DefaultValue("E")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Tipo VR", Prompt = "Tipo VR")]
        public string? TipoVR { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Emp", Prompt = "Emp")]
        public short? CodigoEmpresaOrigem { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Filial", Prompt = "Filial")]
        public short? CodigoFilialOrigem { get; set; }

        [DefaultValue("")]
        [StringLength(6, ErrorMessage = "Máximo 6 caracteres.")]
        [MaxLength(6, ErrorMessage = "Máximo 6 caracteres.")]
        [Display(Name = "Transferência", Prompt = "Transferência")]
        public string? AnoMesTransferencia { get; set; }

        /// <summary>
        /// 
        /// 1 -  (apenas 1 vínculo empregatício) Não Exposição a Agente Nocivo
        /// 2 -  (apenas 1 vínculo empregatício) Exposição a Agente Nocivo(Aposentadoria com 15 anos de Serviço)
        /// 3 -  (apenas 1 vínculo empregatício) Exposição a Agente Nocivo(Aposentadoria com 20 anos de Serviço)
        /// 4 -  (apenas 1 vínculo empregatício) Exposição a Agente Nocivo(Aposentadoria com 25 anos de Serviço)
        /// 5 -  (mais de 1 vínculo empregatício) Não Exposição a Agente Nocivo
        /// 6 -  (mais de 1 vínculo empregatício)  Exposição a Agente Nocivo(Aposentadoria com 15 anos de Serviço)
        /// 7 -  (mais de 1 vínculo empregatício) Exposição a Agente Nocivo(Aposentadoria com 20 anos de Serviço)
        /// 8 -  (mais de 1 vínculo empregatício) Exposição a Agente Nocivo(Aposentadoria com 25 anos de Serviço)
        /// </summary>
        [DefaultValue(0)]
        [Display(Name = "Ocorrência", Prompt = "Ocorrência")]
        public byte? OcorrenciaFGTS { get; set; }

        /// <summary>
        /// 1 - Branca
        /// 2 - Preta
        /// 3 - Amarela
        /// 4 - Parda
        /// 5 - Indígena
        /// </summary>
        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Raça", Prompt = "Raça")]
        public string? Raca { get; set; }

        [DefaultValue("")]
        [StringLength(300, ErrorMessage = "Máximo 300 caracteres.")]
        [MaxLength(300, ErrorMessage = "Máximo 300 caracteres.")]
        public string? Foto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Região", Prompt = "Região")]
        ////[Required(ErrorMessage = "Selecione uma Regiao!")]
        public short? Regiao { get; set; }

        [DefaultValue("M")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Pagamento", Prompt = "Pagamento")]
        public string? TipoPgto { get; set; }

        [DefaultValue(1)]
        [Display(Name = "Descontar INSS", Prompt = "Descontar INSS")]
        public bool? CalculaINSS { get; set; }

        [DefaultValue(1)]
        [Display(Name = "Descontar IRF", Prompt = "Descontar IRF")]
        public bool? CalculaIRF { get; set; }

        [DefaultValue(0)]
        public bool? DeficienteFisico { get; set; }

        /// <summary>
        /// 0 - Em todos os cálculos s/ rendimentos
        /// 1 - Em todos os cálculos s/ rendimentos após o 15º dia(1º pgto.)
        /// 2 - Todo mês s/ rendimentos
        /// 3 - No final do contrato s/ rendimentos
        /// 4 - Em todos os cálculos s/ salário
        /// 5 - Em todos os cálculos s/ salário após o 15º dia(1º pgto.)
        /// 6 - Todo mês sobre salário
        /// 7 - No final do contrato s/ salário
        /// </summary>
        [DefaultValue(7)]
        [Display(Name = "Tipo de 13º", Prompt = "Tipo de 13º")]
        public byte? Tipo13o { get; set; }

        /// <summary>
        /// 1 - Demanda Complementar de Serviços.
        /// 2 - Substituição Transitória de Pessoal Permanente.
        /// </summary>
        [DefaultValue(7)]
        [Display(Name = "Tipo de Férias", Prompt = "Tipo de Férias")]
        public byte? TipoFer { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        public string? PortadorCheque { get; set; }

        [DefaultValue(0)]
        public bool? DescontaCS { get; set; }

        [DefaultValue(0)]
        public bool? DescontaCC { get; set; }

        [DefaultValue(0)]
        public bool? DescontaMS { get; set; }

        [DefaultValue(0)]
        public bool? DescontaCA { get; set; }

        [DefaultValue(0)]
        public bool? DescontaTA { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Adiantamento", Prompt = "Adiantamento")]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? TaxaAdt { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Classe de Contribuição", Prompt = "Classe de Contribuição")]
        public byte? ClasseContrib { get; set; }

        [DefaultValue(0)]
        [Display(Name = " % Desconto VT", Prompt = " % Desconto VT")]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? PercentualVT { get; set; }

        [DefaultValue("")]
        [StringLength(3000, ErrorMessage = "Máximo 3000 caracteres.")]
        [MaxLength(3000, ErrorMessage = "Máximo 3000 caracteres.")]
        public string? Observacao { get; set; }

        [DefaultValue(1)]
        [Display(Name = "Motivo da Contratação", Prompt = "Motivo da Contratação")]
        public byte? MotivoContrato { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Troco", Prompt = "Troco")]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? Acum_Troco { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Saldo Negativo", Prompt = "Saldo Negativo")]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? Acum_SaldoNeg { get; set; }

        [DefaultValue(30)]
        [Display(Name = "Pgto", Prompt = "Pgto")]
        public byte? DiaPgto { get; set; }

        [DefaultValue(20)]
        [Display(Name = "Adto", Prompt = "Adto")]
        public byte? DiaAdto { get; set; }

        [DefaultValue(0)]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        public bool InclusaoOK { get; set; }

        [Display(Name = "Data de Cadastro", Prompt = "Data de Cadastro")]
        public DateTime? DataCadastroPIS { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Instituição", Prompt = "Instituição")]
        public int CodigoInstituicao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Considerar Gratificação", Prompt = "Considerar Gratificação")]
        public bool CalculaGratificacao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Considerar Anuênio", Prompt = "Considerar Anuênio")]
        public bool CalculaAnuenio { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Considerar Triênio", Prompt = "Considerar Triênio")]
        public bool CalculaTrienio { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Qtde Anuênio", Prompt = "Qtde Anuênio")]
        public byte QtdeAnuenio { get; set; }

        [DefaultValue(0)]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal ValorUltimoBnfInformado { get; set; }

        [DefaultValue(0)]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        public bool TransferenciaOnus { get; set; }

        [DefaultValue(0)]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Dias Vecto.", Prompt = "Dias Vecto.")]
        public short DiasVectoExame { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [MaxLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [Display(Name = "Número", Prompt = "Número")]
        public string Reservista { get; set; }

        [Display(Name = "Data da Expedição", Prompt = "Data da Expedição")]
        public DateTime? DTExpedicaoReservista { get; set; }

        [DefaultValue(0)]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Número", Prompt = "Número")]
        public int NroEndereco { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Complemento", Prompt = "Complemento")]
        public string CplEndereco { get; set; }

        /// <summary>
        /// 
        /// Dispensa
        /// Efetivaçao
        /// Renovação
        /// </summary>
        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Tipo de Demissão", Prompt = "Tipo de Demissão")]
        public string TipoDemissao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Código", Prompt = "Código")]
        public int CodigoFuncionarioOrigem { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Nome do Curso", Prompt = "Nome do Curso")]
        public string NomeCurso { get; set; }

        [DefaultValue("")]
        [StringLength(200, ErrorMessage = "Máximo 200 caracteres.")]
        [MaxLength(200, ErrorMessage = "Máximo 200 caracteres.")]
        [Display(Name = "Nível do Curso", Prompt = "Nível do Curso")]
        public string NivelCurso { get; set; }

        [DefaultValue("")]
        [StringLength(600, ErrorMessage = "Máximo 600 caracteres.")]
        [MaxLength(600, ErrorMessage = "Máximo 600 caracteres.")]
        [Display(Name = "Atividade do Curso", Prompt = "Atividade do Curso")]
        public string AtividadeCurso { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Nome do Funcionário a Substituir", Prompt = "Nome do Funcionário a Substituir")]
        public string NomeSubstituto { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        public string IDSistemaAnterior { get; set; }

        /// <summary>
        /// D - Dias
        /// M - Meses
        /// </summary>
        [DefaultValue("D")]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Tipo Vcto.Contrato / Prorrogação", Prompt = "Tipo Vcto.Contrato / Prorrogação")]
        public string TipoVctoContrato { get; set; }

        /// <summary>
        /// D - Dias
        /// M - Meses
        /// </summary>
        [DefaultValue("D")]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Tipo Vcto.Contrato / Prorrogação", Prompt = "Tipo Vcto.Contrato / Prorrogação")]
        public string TipoVctoContratoProrr { get; set; }

        [DefaultValue("")]
        [StringLength(60, ErrorMessage = "Nome Inválido para o e - Social! Ulrapassou o limite de 60 caracteres!")]
        [MaxLength(60, ErrorMessage = "Nome Inválido para o e - Social! Ulrapassou o limite de 60 caracteres!")]
        [Display(Name = "Nome", Prompt = "Nome")]
        public string NomeTitularConta { get; set; }

        [DefaultValue(0)]
        [Display(Name = "CPF", Prompt = "CPF")]
        [Column(TypeName = "DECIMAL(18,0)")]
        public decimal CPFTitularConta { get; set; }

        [Display(Name = "DT.Nascimento", Prompt = "DT.Nascimento")]
        public DateTime? DTNascimentoTitularConta { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Salário Mês", Prompt = "Salário Mês")]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal SalarioFat { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Motivo da Substituição / Acréscimo", Prompt = "Motivo da Substituição / Acréscimo")]
        public string MotivoSubstituicao { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Avaliação de Comportamento", Prompt = "Avaliação de Comportamento")]
        public string AvaliacaoComportamento { get; set; }

        [DefaultValue(0)]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        public short EventoPensao13o { get; set; }

        [DefaultValue(0)]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        public short EventoPensaoFer { get; set; }

        [DefaultValue(0)]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        public byte BasePensao13o { get; set; }

        [DefaultValue(0)]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        public byte BasePensaoFer { get; set; }

        [DefaultValue(0)]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        [Column(TypeName = "DECIMAL(5,2)")]
        public decimal AliqPensao13o { get; set; }

        [DefaultValue(0)]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        [Column(TypeName = "DECIMAL(5,2)")]
        public decimal AliqPensaoFer { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 01", Prompt = "Livre 01")]
        public string? CampoLivre_01 { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 02", Prompt = "Livre 02")]
        public string? CampoLivre_02 { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 03", Prompt = "Livre 03")]
        public string? CampoLivre_03 { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 04", Prompt = "Livre 04")]
        public string? CampoLivre_04 { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 05", Prompt = "Livre 05")]
        public string? CampoLivre_05 { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 06", Prompt = "Livre 06")]
        public string? CampoLivre_06 { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 07", Prompt = "Livre 07")]
        public string? CampoLivre_07 { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 08", Prompt = "Livre 08")]
        public string? CampoLivre_08 { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 09", Prompt = "Livre 09")]
        public string? CampoLivre_09 { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Livre 10", Prompt = "Livre 10")]
        public string? CampoLivre_10 { get; set; }

        [DefaultValue(0)]
        [Display(Name = "SPTrans", Prompt = "SPTrans")]
        [Column(TypeName = "DECIMAL(14,0)")]
        public decimal NroCartaoSPTrans { get; set; }

        [DefaultValue("")]
        [StringLength(120, ErrorMessage = "Máximo 120 caracteres.")]
        [MaxLength(120, ErrorMessage = "Máximo 120 caracteres.")]
        public string? UsuarioInclusao { get; set; }

        /// <summary>
        /// 0 - Não é Portador de Deficiência
        /// 1 - Física
        /// 2 - Auditiva
        /// 3 - Visual
        /// 4 - Mental
        /// 5 - Múltipla
        /// 6 - Reabilitado
        /// 7 - Intelectual
        /// </summary>
        [DefaultValue(0)]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Tipo de Deficiência", Prompt = "Tipo de Deficiência")]
        public byte TipoDeficiencia { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Chave GRRF", Prompt = "Chave GRRF")]
        public string? ChaveGRRF { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        public string? SenhaCaixinha { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Hora Extra Faturado", Prompt = "Valor Hora Extra Faturado")]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal ValorHorExtFat { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Adicional Noturno Faturado", Prompt = "Valor Adicional Noturno Faturado")]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal ValorAdcNotFat { get; set; }

        [DefaultValue(0)]
        [Display(Name = "RioCard", Prompt = "RioCard")]
        [Column(TypeName = "DECIMAL(14,0)")]
        public decimal NroCartaoRioCard { get; set; }

        [DefaultValue("")]
        [Display(Name = "Urbs", Prompt = "Urbs")]
        public string? NroCartaoURBS { get; set; }

        [DefaultValue(0)]
        [Display(Name = "TransUrb", Prompt = "TransUrb")]
        [Column(TypeName = "DECIMAL(14,0)")]
        public decimal NroCartaoTransURB { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Sodexho RH", Prompt = "Sodexho RH")]
        [Column(TypeName = "DECIMAL(14,0)")]
        public decimal NroCartaoSodexhoRH { get; set; }

        [DefaultValue(0)]
        [Display(Name = "VTC", Prompt = "VTC")]
        [Column(TypeName = "DECIMAL(14,0)")]
        public decimal? NroCartaoVTC { get; set; }

        [DefaultValue(0)]
        [Display(Name = "GuaruPas / Ticket Rh", Prompt = "GuaruPas / Ticket Rh")]
        [Column(TypeName = "DECIMAL(14,0)")]
        public decimal? NroCartaoGuaruPas { get; set; }

        [Display(Name = "Limite p / Pagto de Bnf", Prompt = "Limite p / Pagto de Bnf")]
        public DateTime? DataLimiteBNF { get; set; }

        [DefaultValue(0)]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        public bool NovoBnf { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(8,0)")]
        public decimal? SAP_Id { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        public string? SAP_Area { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [Display(Name = "Observação(Faturamento)", Prompt = "Observação(Faturamento)")]
        public string? ObsFaturamento { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Vale Alimentação Diário", Prompt = "Vale Alimentação Diário")]
        public bool VA_Diario { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(10,0)")]
        public decimal? CodigoFuncionarioWEB { get; set; }

        [DefaultValue(0)]
        public int? IdUsuarioGI { get; set; }


        [DefaultValue(0)]
        [Display(Name = "Ctr Web", Prompt = "Ctr Web")]
        public int? TipoContratoWeb { get; set; }

        [DefaultValue(0)]
        public int? QtdeBnfInformado { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Mensal Mínimo Garantido(Vendedor)", Prompt = "Valor Mensal Mínimo Garantido(Vendedor)")]
        [Column(TypeName = "DECIMAL(11,2)")]
        public decimal? SalarioMesGarantido { get; set; }

        [DefaultValue(0)]
        [Display(Name = " % Abono Liderança", Prompt = " % Abono Liderança")]
        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal? AlqAbonoLider { get; set; }

        [DefaultValue(0)]
        [Display(Name = "2ª Função", Prompt = "2ª Função")]
        public int? CodigoFuncao2 { get; set; }

        [DefaultValue(0)]
        [Display(Name = "3ª Função", Prompt = "3ª Função")]
        public int? CodigoFuncao3 { get; set; }

        [DefaultValue(0)]
        [Display(Name = "4ª Função", Prompt = "4ª Função")]
        public int? CodigoFuncao4 { get; set; }

        [DefaultValue(0)]
        [Display(Name = "5ª Função", Prompt = "5ª Função")]
        public int? CodigoFuncao5 { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Representante", Prompt = "Representante")]
        public short? CodigoRepresentante { get; set; }

        [Display(Name = "Período1 de Férias Programada de", Prompt = "Período1 de Férias Programada de")]
        public DateTime? DataIniFeriasProg { get; set; }

        [Display(Name = "Até", Prompt = "Até")]
        public DateTime? DataFimFeriasProg { get; set; }

        [DefaultValue("")]
        [StringLength(500, ErrorMessage = "Máximo 500 caracteres.")]
        [MaxLength(500, ErrorMessage = "Máximo 500 caracteres.")]
        [Display(Name = "Motivo Justificador da Prorrogação", Prompt = "Motivo Justificador da Prorrogação")]
        public string? JustificativaProrrogacao { get; set; }

        [DefaultValue("")]
        [StringLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [MaxLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [Display(Name = "Categoria", Prompt = "Categoria")]
        public string? CNH_Modelo { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Pontos", Prompt = "Pontos")]
        public int? CNH_Pontuacao { get; set; }

        [Display(Name = "Data Revisão", Prompt = "Data Revisão")]
        public DateTime? CNH_DataRevisao { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [MaxLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [Display(Name = "Observação CNH", Prompt = "Observação CNH")]
        public string? CNH_Obs { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [MaxLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [Display(Name = "Número", Prompt = "Número")]
        public string? Motorista_MOOP { get; set; }

        [Display(Name = "Data de Vencimento", Prompt = "Data de Vencimento")]
        public DateTime? Motorista_DataVectoMOOP { get; set; }

        [DefaultValue(0)]
        public int? PercentFatu2 { get; set; }

        [DefaultValue("")]
        [StringLength(6, ErrorMessage = "Máximo 6 caracteres.")]
        [MaxLength(6, ErrorMessage = "Máximo 6 caracteres.")]
        public string? PercentFatu3 { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Código Supervisor", Prompt = "Código Supervisor")]
        public int? CodigoSupervisor { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Código Coordenador", Prompt = "Código Coordenador")]
        public int? CodigoCoordenador { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Curso", Prompt = "Curso")]
        public int? CodigoCurso { get; set; }

        [DefaultValue("")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        [Display(Name = "Email Gestor", Prompt = "Email Gestor")]
        public string? EmailGestor { get; set; }

        [DefaultValue("")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string? ObsWeb { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Escala", Prompt = "Escala")]
        public short? EscalaDiasTrabalho { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Escala", Prompt = "Escala")]
        public short? EscalaDiasDescanso { get; set; }

        /// <summary>
        /// N - Normal
        /// S - Sábado
        /// D - Domingo
        /// S - Sexta - Feira
        /// </summary>
        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Tipo Escala", Prompt = "Tipo Escala")]
        public string? EscalaTipo { get; set; }

        [Display(Name = "Início", Prompt = "Início")]
        public DateTime? EscalaDataInicio { get; set; }

        [Display(Name = "Fim", Prompt = "Fim")]
        public DateTime? EscalaDataFim { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        public string? CartaApresentacao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Fixo 01", Prompt = "Valor Fixo 01")]
        [Column(TypeName = "DECIMAL(12,5)")]
        public decimal? ValorFixo01 { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Fixo 02", Prompt = "Valor Fixo 02")]
        [Column(TypeName = "DECIMAL(12,5)")]
        public decimal? ValorFixo02 { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Fixo 03", Prompt = "Valor Fixo 03")]
        [Column(TypeName = "DECIMAL(12,5)")]
        public decimal? ValorFixo03 { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Fixo 04", Prompt = "Valor Fixo 04")]
        [Column(TypeName = "DECIMAL(12,5)")]
        public decimal? ValorFixo04 { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Fixo 05", Prompt = "Valor Fixo 05")]
        [Column(TypeName = "DECIMAL(12,5)")]
        public decimal? ValorFixo05 { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "S.U.S / Convênio", Prompt = "S.U.S / Convênio")]
        public string? CartaoSUS { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Fixo Adto", Prompt = "Valor Fixo Adto")]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal? ValorAdtoFixo { get; set; }

        [DefaultValue(0)]
        [Display(Name = "DDD - Celular(Envio SMS)")]
        public byte? SMSDDDCel { get; set; }

        [DefaultValue(0)]
        [Display(Name = "DDD - Celular(Envio SMS)")]
        [Column(TypeName = "DECIMAL(10,0)")]
        public decimal? SMSNroCel { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Seção", Prompt = "Seção")]
        public short? TitEleSecao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Zona", Prompt = "Zona")]
        public short? TitEleZona { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Considerar Biênio", Prompt = "Considerar Biênio")]
        public bool? CalculaBienio { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Considerar Quadriênio", Prompt = "Considerar Quadriênio")]
        public bool? CalculaQuadrienio { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Considerar Quinquênio", Prompt = "Considerar Quinquênio")]
        public bool? CalculaQuinquenio { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Cód.Cid.Nascimento", Prompt = "Cód.Cid.Nascimento")]
        public int? codMunicipioNascto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Número", Prompt = "Número")]
        [Column(TypeName = "DECIMAL(15,0)")]
        public decimal? RICnr { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Órgão", Prompt = "Órgão")]
        public string? RICorgaoemissor { get; set; }

        [Display(Name = "Data da Expedição", Prompt = "Data da Expedição")]
        public DateTime? RICDataEmissao { get; set; }

        [DefaultValue("")]
        [StringLength(14, ErrorMessage = "Máximo 14 caracteres.")]
        [MaxLength(14, ErrorMessage = "Máximo 14 caracteres.")]
        [Display(Name = "Número", Prompt = "Número")]
        public string? RNEnr { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Órgão", Prompt = "Órgão")]
        public string? RNEorgaoemissor { get; set; }

        [Display(Name = "Data da Expedição", Prompt = "Data da Expedição")]
        public DateTime? RNEDataEmissao { get; set; }

        [DefaultValue("")]
        [StringLength(14, ErrorMessage = "Máximo 14 caracteres.")]
        [MaxLength(14, ErrorMessage = "Máximo 14 caracteres.")]
        [Display(Name = "Número", Prompt = "Número")]
        public string? OCnr { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Órgão", Prompt = "Órgão")]
        public string? Ocorgaoemissor { get; set; }

        [Display(Name = "Data da Expedição", Prompt = "Data da Expedição")]
        public DateTime? OCDataEmissao { get; set; }

        [Display(Name = "Data de Validade", Prompt = "Data de Validade")]
        public DateTime? OCDataValidade { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Órgão", Prompt = "Órgão")]
        public string? CNHorgaoemissor { get; set; }

        [Display(Name = "Data da Emissão", Prompt = "Data da Emissão")]
        public DateTime? CNHDataEmissao { get; set; }

        /// <summary>
        /// Nao Informado
        /// Area
        /// Acesso
        /// Acampamento
        /// Acesso Local
        /// Adro
        /// Area Especial
        /// Aeroporto
        /// Alameda
        /// Avenida Marginal Direita
        /// Avenida Marginal Esquerda
        /// Anel Viario
        /// Antiga Estrada
        /// Arteria
        /// Alto
        /// Atalho
        /// Area Verde
        /// Avenida
        /// Avenida Contorno
        /// Avenida Marginal
        /// Avenida Velha
        /// Balneario
        /// Beco
        /// Buraco
        /// Belvedere
        /// Bloco
        /// Balao
        /// Blocos
        /// Bulevar
        /// Bosque
        /// Boulevard
        /// Baixa
        /// Cais
        /// Calcada
        /// Caminho
        /// Canal
        /// Chacara
        /// Chapadao
        /// Ciclovia
        /// Circular
        /// Conjunto
        /// Conjunto Mutirao
        /// Complexo Viario
        /// Colonia
        /// Comunidade
        /// Condominio
        /// Corredor
        /// Campo
        /// Corrego
        /// Contorno
        /// Descida
        /// Desvio
        /// Distrito
        /// Entre Bloco
        /// Estrada Intermunicipal
        /// Enseada
        /// Entrada Particular
        /// Entre Quadra
        /// Escada
        /// Escadaria
        /// Estrada Estadual
        /// Estrada Vicinal
        /// Estrada de Ligacao
        /// Estrada Municipal
        /// Esplanada
        /// Estrada de Servidao
        /// Estrada
        /// Estrada Velha
        /// Estrada Antiga
        /// Estacao
        /// Estadio
        /// Estancia
        /// Estrada Particular
        /// Estacionamento
        /// Evangelica
        /// Elevada
        /// Eixo Industrial
        /// Favela
        /// Fazenda
        /// Ferrovia
        /// Fonte
        /// Feira
        /// Forte
        /// Galeria
        /// Granja
        /// Nucleo Habitacional
        /// Ilha
        /// Indeterminado
        /// Ilhota
        /// Jardim
        /// Jardinete
        /// Ladeira
        /// Lagoa
        /// Lago
        /// Loteamento
        /// Largo
        /// Lote
        /// Mercado
        /// Marina
        /// Modulo
        /// Projecao
        /// Morro
        /// Monte
        /// Nucleo
        /// Nucleo Rural
        /// Outeiro
        /// Paralela
        /// Passeio
        /// Patio
        /// Praca
        /// Praca de Esportes
        /// Parada
        /// Paradouro
        /// Ponta
        /// Praia
        /// Prolongamento
        /// Parque Municipal
        /// Parque
        /// Parque Residencial
        /// Passarela
        /// Passagem
        /// Passagem de Pedestre
        /// Passagem Subterranea
        /// Ponte
        /// Porto
        /// Quadra
        /// Quinta
        /// Quintas
        /// Rua
        /// Rua Integracao
        /// Rua de Ligacao
        /// Rua Particular
        /// Rua Velha
        /// Ramal
        /// Recreio
        /// Recanto
        /// Retiro
        /// Residencial
        /// Reta
        /// Ruela
        /// Rampa
        /// Rodo Anel
        /// Rodovia
        /// Rotula
        /// Rua de Pedestre
        /// Margem
        /// Retorno
        /// Rotatoria
        /// Segunda Avenida
        /// Sitio
        /// Servidao
        /// Setor
        /// Subida
        /// Trincheira
        /// Terminal
        /// Trecho
        /// Trevo
        /// Tunel
        /// Travessa
        /// Travessa Particular
        /// Travessa Velha
        /// Unidade
        /// Via
        /// Via Coletora
        /// Via Local
        /// Via de Acesso
        /// Vala
        /// Via Costeira
        /// Viaduto
        /// Via Expressa
        /// Vereda
        /// Via Elevado
        /// Vila
        /// Viela
        /// Vale
        /// Via Litoranea
        /// Via de Pedestre
        /// Variante
        /// Zigue-Zague
        /// </summary>
        [DefaultValue("Nao Informado")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Tipo", Prompt = "Tipo")]
        public string? tipoEndereco { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Cód.Cid", Prompt = "Cód.Cid")]
        public int? CodigoCidadeResid { get; set; }

        /// <summary>
        /// 0000 - Brasil
        /// 0008 - Abu Dhabi
        /// 0009 - Dirce
        /// 0013 - Afeganistao
        /// 0017 - Albania, Republica Da
        /// 0020 - Alboran-Perejil,Ilhas
        /// 0023 - Alemanha
        /// 0025 - Alemanha, Republica Democratica
        /// 0031 - Burkina Faso
        /// 0037 - Andorra
        /// 0040 - Angola
        /// 0041 - Anguilla
        /// 0043 - Antigua E Barbuda
        /// 0047 - Antilhas Holandesas
        /// 0053 - Arabia Saudita
        /// 0059 - Argelia
        /// 0063 - Argentina
        /// 0064 - Armenia, Republica Da
        /// 0065 - Aruba
        /// 0069 - Australia
        /// 0072 - Austria
        /// 0073 - Azerbaijao, Republica Do
        /// 0077 - Bahamas, Ilhas
        /// 0080 - Bahrein, Ilhas
        /// 0081 - Bangladesh
        /// 0083 - Barbados
        /// 0085 - Belarus, Republica Da
        /// 0087 - Belgica
        /// 0088 - Belize
        /// 0090 - Bermudas
        /// 0093 - Mianmar(BIRMANIA)
        /// 0097 - Bolivia, Estado Plurinacional Da
        /// 0098 - Bosnia-Herzegovina(REPUBLICA Da)
        /// 0100 - Int.Z.F.Manaus
        /// 0101 - Botsuana
        /// 0105 - Brasil
        /// 0106 - Fretado P/Brasil
        /// 0108 - Brunei
        /// 0111 - Bulgaria, Republica Da
        /// 0115 - Burundi
        /// 0119 - Butao
        /// 0127 - Cabo Verde, Republica De
        /// 0131 - Cachemira
        /// 0137 - Cayman, Ilhas
        /// 0141 - Camboja
        /// 0145 - Camaroes
        /// 0149 - Canada
        /// 0150 - Jersey, Ilha Do Canal
        /// 0151 - Canarias, Ilhas
        /// 0152 - Canal,Ilhas
        /// 0153 - Cazaquistao, Republica Do
        /// 0154 - Catar
        /// 0158 - Chile
        /// 0160 - China, Republica Popular
        /// 0161 - Formosa(TAIWAN)
        /// 0163 - Chipre
        /// 0165 - Cocos(Keeling),Ilhas
        /// 0169 - Colombia
        /// 0173 - Comores, Ilhas
        /// 0177 - Congo
        /// 0183 - Cook, Ilhas
        /// 0187 - Coreia(DO Norte), Rep.Pop.Democratica
        /// 0190 - Coreia(DO Sul), Republica Da
        /// 0193 - Costa Do Marfim
        /// 0195 - Croacia(REPUBLICA Da)
        /// 0196 - Costa Rica
        /// 0198 - Coveite
        /// 0199 - Cuba
        /// 0229 - Benin
        /// 0232 - Dinamarca
        /// 0235 - Dominica,Ilha
        /// 0237 - Dubai
        /// 0239 - Equador
        /// 0240 - Egito
        /// 0243 - Eritreia
        /// 0244 - Emirados Arabes Unidos
        /// 0245 - Espanha
        /// 0246 - Eslovenia, Republica Da
        /// 0247 - Eslovaca, Republica
        /// 0249 - Estados Unidos
        /// 0251 - Estonia, Republica Da
        /// 0253 - Etiopia
        /// 0255 - Falkland(ILHAS Malvinas)
        /// 0259 - Feroe, Ilhas
        /// 0263 - Fezzan
        /// 0267 - Filipinas
        /// 0271 - Finlandia
        /// 0275 - Franca
        /// 0281 - Gabao
        /// 0285 - Gambia
        /// 0289 - Gana
        /// 0291 - Georgia, Republica Da
        /// 0293 - Gibraltar
        /// 0297 - Granada
        /// 0301 - Grecia
        /// 0305 - Groenlandia
        /// 0309 - Guadalupe
        /// 0313 - Guam
        /// 0317 - Guatemala
        /// 0325 - Guiana Francesa
        /// 0329 - Guine
        /// 0331 - Guine-Equatorial
        /// 0334 - Guine-Bissau
        /// 0337 - Guiana
        /// 0341 - Haiti
        /// 0345 - Honduras
        /// 0351 - Hong Kong
        /// 0355 - Hungria, Republica Da
        /// 0357 - Iemen
        /// 0358 - Iemem Do Sul
        /// 0359 - Man, Ilha De
        /// 0361 - India
        /// 0365 - Indonesia
        /// 0367 - Inglaterra
        /// 0369 - Iraque
        /// 0372 - Ira, Republica Islamica Do
        /// 0375 - Irlanda
        /// 0379 - Islandia
        /// 0383 - Israel
        /// 0386 - Italia
        /// 0388 - Servia E Montenegro
        /// 0391 - Jamaica
        /// 0395 - Jammu
        /// 0396 - Johnston, Ilhas
        /// 0399 - Japao
        /// 0403 - Jordania
        /// 0411 - Kiribati
        /// 0420 - Laos, Rep.Pop.Democr.Do
        /// 0423 - Lebuan,Ilhas
        /// 0426 - Lesoto
        /// 0427 - Letonia, Republica Da
        /// 0431 - Libano
        /// 0434 - Liberia
        /// 0438 - Libia
        /// 0440 - Liechtenstein
        /// 0442 - Lituania, Republica Da
        /// 0445 - Luxemburgo
        /// 0447 - Macau
        /// 0449 - Macedonia, Ant.Rep.Iugoslava
        /// 0450 - Madagascar
        /// 0452 - Ilha Da Madeira
        /// 0455 - Malasia
        /// 0458 - Malavi
        /// 0461 - Maldivas
        /// 0464 - Mali
        /// 0467 - Malta
        /// 0472 - Marianas Do Norte
        /// 0474 - Marrocos
        /// 0476 - Marshall,Ilhas
        /// 0477 - Martinica
        /// 0485 - Mauricio
        /// 0488 - Mauritania
        /// 0490 - Midway, Ilhas
        /// 0493 - Mexico
        /// 0494 - Moldavia, Republica Da
        /// 0495 - Monaco
        /// 0497 - Mongolia
        /// 0499 - Micronesia
        /// 0501 - Montserrat,Ilhas
        /// 0505 - Mocambique
        /// 0507 - Namibia
        /// 0508 - Nauru
        /// 0511 - Christmas,Ilha(NAVIDAD)
        /// 0517 - Nepal
        /// 0521 - Nicaragua
        /// 0525 - Niger
        /// 0528 - Nigeria
        /// 0531 - Niue,Ilha
        /// 0535 - Norfolk,Ilha
        /// 0538 - Noruega
        /// 0542 - Nova Caledonia
        /// 0545 - Papua Nova Guine
        /// 0548 - Nova Zelandia
        /// 0551 - Vanuatu
        /// 0556 - Oma
        /// 0563 - Pacifico,Ilhas Do(ADMINISTRACAO Dos Eua)
        /// 0566 - Pacifico,Ilhas Do(POSSESSAO Dos Eua)
        /// 0569 - Pacifico,Ilhas Do(TERRITORIO Em Fideicomisso Dos
        /// 0573 - Paises Baixos (HOLANDA)
        /// 0575 - Palau
        /// 0576 - Paquistao
        /// 0578 - Palestina
        /// 0580 - Panama
        /// 0583 - Papua Nova Guiné
        /// 0586 - Paraguai
        /// 0589 - Peru
        /// 0593 - Pitcairn, Ilha
        /// 0599 - Polinesia Francesa
        /// 0603 - Polonia, Republica Da
        /// 0607 - Portugal
        /// 0611 - Porto Rico
        /// 0623 - Quenia
        /// 0625 - Quirguiz, Republica
        /// 0628 - Reino Unido
        /// 0640 - Republica Centro-Africana
        /// 0647 - Republica Dominicana
        /// 0660 - Reuniao, Ilha
        /// 0665 - Zimbabue
        /// 0670 - Romenia
        /// 0675 - Ruanda
        /// 0676 - Russia, Federacao Da
        /// 0677 - Salomao, Ilhas
        /// 0678 - Saint Kitts E Nevis
        /// 0685 - Saara Ocidental
        /// 0687 - El Salvador
        /// 0690 - Samoa
        /// 0691 - Samoa Americana
        /// 0695 - Sao Cristovao E Neves, Ilhas
        /// 0697 - San Marino
        /// 0700 - Sao Pedro E Miquelon
        /// 0705 - Sao Vicente E Granadinas
        /// 0710 - Santa Helena
        /// 0715 - Santa Lucia
        /// 0720 - Sao Tome E Principe, Ilhas
        /// 0728 - Senegal
        /// 0731 - Seychelles
        /// 0735 - Serra Leoa
        /// 0738 - Sikkim
        /// 0741 - Cingapura
        /// 0744 - Siria, Republica Arabe Da
        /// 0748 - Somalia
        /// 0750 - Sri Lanka
        /// 0754 - Suazilandia
        /// 0756 - Africa Do Sul
        /// 0759 - Sudao
        /// 0764 - Suecia
        /// 0767 - Suica
        /// 0770 - Suriname
        /// 0772 - Tadjiquistao, Republica Do
        /// 0776 - Tailandia
        /// 0780 - Tanzania, Rep.Unida Da
        /// 0782 - Territorio Brit.Oc.Indico
        /// 0783 - Djibuti
        /// 0785 - Territorio da Alta Comissao do Pacifico Ocidental
        /// 0788 - Chade
        /// 0790 - Tchecoslovaquia
        /// 0791 - Tcheca, Republica
        /// 0795 - Timor Leste
        /// 0800 - Togo
        /// 0805 - Toquelau, Ilhas
        /// 0810 - Tonga
        /// 0815 - Trinidad E Tobago
        /// 0820 - Tunisia
        /// 0823 - Turcas E Caicos, Ilhas
        /// 0824 - Turcomenistao, Republica Do
        /// 0827 - Turquia
        /// 0828 - Tuvalu
        /// 0831 - Ucrania
        /// 0833 - Uganda
        /// 0840 - Uniao Das Republicas Socialistas Sovieticas
        /// 0845 - Uruguai
        /// 0847 - Uzbequistao, Republica Do
        /// 0848 - Vaticano, Est.Da Cidade Do
        /// 0850 - Venezuela
        /// 0855 - Vietname Norte
        /// 0858 - Vietna
        /// 0863 - Virgens, Ilhas (BRITANICAS)
        /// 0866 - Virgens, Ilhas (E.U.A.)
        /// 0870 - Fiji
        /// 0873 - Wake, Ilha
        /// 0875 - Wallis E Futuna, Ilhas
        /// 0888 - Congo, Republica Democratica Do
        /// 0890 - Zambia
        /// </summary>
        [DefaultValue(0)]
        [Display(Name = "Código do País quando Residente no Exterior", Prompt = "Código do País quando Residente no Exterior")]
        public int? exterior_paisResidencia { get; set; }

        [DefaultValue("")]
        [StringLength(80, ErrorMessage = "Máximo 80 caracteres.")]
        [MaxLength(80, ErrorMessage = "Máximo 80 caracteres.")]
        [Display(Name = "Endereço", Prompt = "Endereço")]
        public string? exterior_descLogradouro { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [Display(Name = "Número", Prompt = "Número")]
        public string? exterior_nrLogradouro { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Complemento", Prompt = "Complemento")]
        public string? exterior_complemento { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Bairro", Prompt = "Bairro")]
        public string? exterior_bairro { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Cidade", Prompt = "Cidade")]
        public string? exterior_nomeCidade { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [Display(Name = "Código Postal", Prompt = "Código Postal")]
        public string? exterior_codPostal { get; set; }

        [DefaultValue(1)]
        public bool? residenciaPropria { get; set; }

        [DefaultValue(0)]
        public bool? residenciarecursoFGTS { get; set; }

        [Display(Name = "Data de Naturalização Brasileira", Prompt = "Data de Naturalização Brasileira")]
        public DateTime? dtNaturalizacao { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Normal
        /// 2 - Decorrente de Ação Fiscal
        /// 3 - Decorrente de Decisão Judicial
        /// </summary>
        [DefaultValue(1)]
        [Display(Name = "Indicativo de Admissão", Prompt = "Indicativo de Admissão")]
        public byte? indAdmissao { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - CLT - Consolidação das Leis de Trabalho e legislações trabalhistas
        /// 2 - Estatutário
        /// </summary>
        [DefaultValue(1)]
        [Display(Name = "Tipo de Regime Trabalhista", Prompt = "Tipo de Regime Trabalhista")]
        public byte? tpRegimeTrab { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - RGPS - Regime Geral da Previdência Social
        /// 2 - RPPS - Regime Próprio de Previdência Social
        /// 3 - RPPE - Regime de Previdência Social no Exterior
        /// </summary>
        [DefaultValue(1)]
        [Display(Name = "Tipo de Regime Previdenciário", Prompt = "Tipo de Regime Previdenciário")]
        public byte? tpRegimePrev { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Trabalho Urbano
        /// 2 - Trabalho Rural
        /// </summary>
        [DefaultValue(1)]
        [Display(Name = "Natureza da Atividade", Prompt = "Natureza da Atividade")]
        public byte? natAtividade { get; set; }

        /// <summary>
        /// 000 - Não Informado
        /// 101 - Empregado - Geral, inclusive o empregado público da administração direta ou indireta contratado pela CLT
        /// 102 - Empregado - Trabalhador Rural por Pequeno Prazo da Lei 11.718/2008
        /// 103 - Empregado - Aprendiz
        /// 104 - Empregado - Doméstico
        /// 105 - Empregado - contrato a termo firmado nos termos da Lei 9601/98
        /// 106 - Empregado - contrato por prazo determinado nos termos da Lei 6019/74
        /// 111 - Empregado - contrato de trabalho intermitente
        /// 201 - Trabalhador Avulso Portuário
        /// 202 - Trabalhador Avulso Não Portuário
        /// 301 - Servidor Público Titular de Cargo Efetivo, Magistrado, Ministro de Tribunal de Contas, Conselheiro de Tribunal de Contas e Membro do Ministério Público
        /// 302 - Servidor Público Ocupante de Cargo exclusivo em comissão
        /// 303 - Agente Político
        /// 305 - Servidor Público indicado para conselho ou órgão representativo, na condição de representante do governo, órgão ou entidade da administração pública
        /// 306 - Servidor Público Temporário, sujeito a regime administrativo especial definido em lei própria
        /// 307 - Militar Efetivo
        /// 308 - Conscrito
        /// 309 - Agente Público - Outros
        /// 401 - Dirigente Sindical - informação prestada pelo Sindicato
        /// 410 - Trabalhador cedido - informação prestada pelo Cessionário
        /// 701 - Contribuinte individual - Autônomo em geral, exceto se enquadrado em uma das demais categorias de contribuinte individual
        /// 711 - Contribuinte individual - Transportador autônomo de passageiros
        /// 712 - Contribuinte individual - Transportador autônomo de carga
        /// 721 - Contribuinte individual - Diretor não empregado, com FGTS
        /// 722 - Contribuinte individual - Diretor não empregado, sem FGTS
        /// 723 - Contribuinte individual - empresários, sócios e membro de conselho de administração ou fiscal
        /// 731 - Contribuinte individual - Cooperado que presta serviços por intermédio de Cooperativa de Trabalho
        /// 734 - Contribuinte individual - Transportador Cooperado que presta serviços por intermédio de cooperativa de trabalho
        /// 738 - Contribuinte individual - Cooperado filiado a Cooperativa de Produção
        /// 741 - Contribuinte individual - Micro Empreendedor Individual
        /// 751 - Contribuinte individual - magistrado classista temporário da Justiça do Trabalho ou da Justiça Eleitoral que seja aposentado de qualquer regime prev.
        /// 761 - Contribuinte individual - Associado eleito para direção de Cooperativa, associação ou entidade de classe de qualquer natureza ou finalidade
        /// 771 - Contribuinte individual - Membro de conselho tutelar, nos termos da Lei nº 8.069, de 13 de julho de 1990
        /// 781 - Ministro de confissão religiosa ou membro de vida consagrada, de congregação ou de ordem religiosa
        /// 901 - Estagiário
        /// 902 - Médico Residente
        /// 903 - Bolsista, nos termos da lei 8958/1994
        /// </summary>
        [DefaultValue(0)]
        [Display(Name = "Categoria do Trabalhador", Prompt = "Categoria do Trabalhador")]
        public short? codCateg_eSocial { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? vlrSalVariavel { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Nro.Processo Judicial", Prompt = "Nro.Processo Judicial")]
        public string? nrProcJudAlvaraJudicial { get; set; }

        [DefaultValue("")]
        [StringLength(500, ErrorMessage = "Máximo 500 caracteres.")]
        [MaxLength(500, ErrorMessage = "Máximo 500 caracteres.")]
        [Display(Name = "Motivo Justificador da Contratação", Prompt = "Motivo Justificador da Contratação")]
        public string? MotivoProrrogacao { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Submetidos a Horário de Trabalho(Cap.II da CLT)
        /// 2 - Atividade Externa especificada no Inciso I do Art. 62 da CLT
        /// 3 - Funções específicadas no Inciso II do Art. 62 da CLT
        /// 4 - Teletrabalho, previsto no Inciso III do Art. 62 da CLT
        /// </summary>
        [DefaultValue(0)]
        [Display(Name = "Regime de Jornada do Empregado", Prompt = "Regime de Jornada do Empregado")]
        public byte? tpRegimeJor { get; set; }

        [DefaultValue("")]
        [StringLength(60, ErrorMessage = "Máximo 60 caracteres.")]
        [MaxLength(60, ErrorMessage = "Máximo 60 caracteres.")]
        [Display(Name = "Descrição Salário Variável", Prompt = "Descrição Salário Variável")]
        public string? descSalVariavel { get; set; }

        [DefaultValue(0)]
        [Display(Name = "CPF", Prompt = "CPF")]
        [Column(TypeName = "DECIMAL(11,0)")]
        public decimal? CPFSubstituto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Emp", Prompt = "Emp")]
        public short? CodigoEmpresaSubstituto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Filial", Prompt = "Filial")]
        public short? CodigoFilialSubstituto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Código", Prompt = "Código")]
        public int? CodigoFuncionarioSubstituto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Abono", Prompt = "Abono")]
        public bool? ProgFer_Abono { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Antecipação 1ª Parcela 13º Salário", Prompt = "Antecipação 1ª Parcela 13º Salário")]
        public bool? ProgFer_1P13o { get; set; }

        [DefaultValue("")]
        [StringLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [Display(Name = "ID Vaga", Prompt = "ID Vaga")]
        public string? IdVaga { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Locais sem filiais
        /// 2 - Estudo de mercado
        /// 3 - Contratação superior a 3 meses
        /// 4 - Prorrogação de contrato
        /// </summary>
        [DefaultValue(0)]
        [Display(Name = "Tipo Inclusão de Contrato", Prompt = "Tipo Inclusão de Contrato")]
        public byte? TipoAdmSIRETT { get; set; }

        [DefaultValue("")]
        [StringLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [Display(Name = "Última Matrícula", Prompt = "Última Matrícula")]
        public string? Curso_UltMatricula { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Dias Vencimento", Prompt = "Dias Vencimento")]
        public int? Curso_DiasVcto { get; set; }

        [Display(Name = "Vencimento", Prompt = "Vencimento")]
        public DateTime? Curso_DataVcto { get; set; }

        [Display(Name = "Data Importação", Prompt = "Data Importação")]
        public DateTime? DataImpGRRF { get; set; }

        [Display(Name = "Prev.Pagto", Prompt = "Prev.Pagto")]
        public DateTime? DataPrevPgtoGRRF { get; set; }

        [Display(Name = "Data Última Matrícula", Prompt = "Data Última Matrícula")]
        public DateTime? Curso_DataUltMatricula { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Funcionário Recebendo Seguro Desemprego", Prompt = "Funcionário Recebendo Seguro Desemprego")]
        public bool? RecebendoSD { get; set; }

        [DefaultValue("")]
        [StringLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [Display(Name = "TransLitoral", Prompt = "TransLitoral")]
        public string? TransLitoral { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Motivo da Substituição / Acréscimo", Prompt = "Motivo da Substituição / Acréscimo")]
        public string? MotivoSubstituicao2 { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Motivo da Substituição / Acréscimo", Prompt = "Motivo da Substituição / Acréscimo")]
        public string? MotivoSubstituicao3 { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Motivo da Substituição / Acréscimo", Prompt = "Motivo da Substituição / Acréscimo")]
        public string? MotivoSubstituicao4 { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Motivo da Substituição / Acréscimo", Prompt = "Motivo da Substituição / Acréscimo")]
        public string? MotivoSubstituicao5 { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Motivo da Substituição / Acréscimo", Prompt = "Motivo da Substituição / Acréscimo")]
        public string? MotivoSubstituicao6 { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Departamento", Prompt = "Departamento")]
        public string? CodigoDepto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Centro de Resultado", Prompt = "Centro de Resultado")]
        public short? CodigoCR { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Ótimo", Prompt = "Ótimo")]
        [Column(TypeName = "DECIMAL(15,0)")]
        public decimal? NroCartaoOtimo { get; set; }

        [DefaultValue(0)]
        [Display(Name = "BHBus", Prompt = "BHBus")]
        [Column(TypeName = "DECIMAL(15,0)")]
        public decimal? NroCartaoBHBus { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Transbetim", Prompt = "Transbetim")]
        [Column(TypeName = "DECIMAL(15,0)")]
        public decimal? NroCartaoTransBetim { get; set; }

        [Display(Name = "Data 1ª Habilitação", Prompt = "Data 1ª Habilitação")]
        public DateTime? dtPriHab { get; set; }

        /// <summary>
        /// 
        /// AC
        /// AL
        /// AM
        /// AP
        /// BA
        /// CE
        /// DF
        /// ES
        /// GO
        /// MA
        /// MG
        /// MS
        /// MT
        /// PA
        /// PB
        /// PE
        /// PI
        /// PR
        /// RJ
        /// RN
        /// RO
        /// RR
        /// RS
        /// SC
        /// SE
        /// SP
        /// TO
        /// </summary>
        [DefaultValue("")]
        [StringLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [MaxLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [Display(Name = "UF", Prompt = "UF")]
        public string? ufCnh { get; set; }

        /// <summary>
        /// 00 - Não Informado
        /// 01 - Visto permanente
        /// 02 - Visto temporário
        /// 03 - Asilado
        /// 04 - Refugiado
        /// 05 - Solicitante de Refúgio
        /// 06 - Residente fora do Brasil
        /// 07 - Deficiente físico e com mais de 51 anos
        /// 08 - Com residência provisória e anistiado, em situação irregular
        /// 09 - Permanência no Brasil em razão de filhos ou cônjuge brasileiros
        /// 10 - Beneficiado pelo acordo entre países do Mercosul
        /// 11 - Dependente de agente diplomático e/ou consular de países que mantém convênio de reciprocidade para o exercício de atividade remunerada no Brasil
        /// 12 - Beneficiado pelo Tratado de Amizade, Cooperação e Consulta entre a República Federativa do Brasil e a República Portuguesa
        /// </summary>
        [DefaultValue(0)]
        [Display(Name = "Condição do Trabalhador Estrangeiro no Brasil", Prompt = "Condição do Trabalhador Estrangeiro no Brasil")]
        public byte? classTrabEstrang { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Normal
        /// 2 - Decorrente de Decisão Judicial
        /// </summary>
        [DefaultValue(1)]
        [Display(Name = "Tipo Trabalhador Estatutário", Prompt = "Tipo Trabalhador Estatutário")]
        public byte? indProvim { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Jornada com horário diário e folga fixos
        /// 2 - Jornada 12 x 36 (12 horas de trabalho seguidas de 36 horas ininterruptas de descanso)
        /// 3 - Jornada com horário diário fixo e folga variável
        /// 9 - Demais tipos de jornada
        /// </summary>
        [DefaultValue(1)]
        [Display(Name = "", Prompt = "Tipo da Jornada")]
        public byte? tpJornada { get; set; }

        [DefaultValue("")]
        [StringLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [Display(Name = "Nro.Requisição", Prompt = "Nro.Requisição")]
        public string? NroReqPed { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Fat.Pedido Requisição", Prompt = "Valor Fat.Pedido Requisição")]
        [Column(TypeName = "DECIMAL(12,4)")]
        public decimal? ValHoraFatReqPed { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [MaxLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [Display(Name = "Assist.Médica", Prompt = "Assist.Médica")]
        public string? NroCarteiraBnfAM { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [MaxLength(40, ErrorMessage = "Máximo 40 caracteres.")]
        [Display(Name = "Assist.Odontológica", Prompt = "Assist.Odontológica")]
        public string? NroCarteiraBnfAO { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Nro.Pedido", Prompt = "Nro.Pedido")]
        [Column(TypeName = "DECIMAL(12,0)")]
        public decimal? IdFatPedido { get; set; }

        [DefaultValue(0)]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Qualificado no e - Social", Prompt = "Qualificado no e - Social")]
        public bool eSocialQualifCad { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor Falta Faturado", Prompt = "Valor Falta Faturado")]
        [Column(TypeName = "DECIMAL(7,2)")]
        public decimal? ValorFaltaDiaFat { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "MetroCard", Prompt = "MetroCard")]
        public string? CartaoMetroCard { get; set; }

        [Display(Name = "Data de Vencimento", Prompt = "Data de Vencimento")]
        public DateTime? RNEDataVecto { get; set; }

        [DefaultValue(0)]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Banco", Prompt = "Banco")]
        public short CodigoBcoReembolso { get; set; }

        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [Display(Name = "Máscara", Prompt = "Máscara")]
        public string? TipoMskBancoReembolso { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres.")]
        [Display(Name = "Agência", Prompt = "Agência")]
        public string? AgenciaReembolso { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Conta Corrente", Prompt = "Conta Corrente")]
        public string? ContaCorrenteReembolso { get; set; }

        [Display(Name = "Limite Bloqueio Pagto", Prompt = "Limite Bloqueio Pagto")]
        public DateTime? DataLimitePagto { get; set; }

        public DateTime? DataDemissaoAgenda { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [MaxLength(70, ErrorMessage = "Máximo 70 caracteres.")]
        [Display(Name = "Nome Social Funcionário", Prompt = "Nome Social")]
        public string? nmSoc { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Trabalhador é Reabilitado ou Readaptado", Prompt = "Trabalhador é Reabilitado ou Readaptado")]
        public bool? reabReadap { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Trabalhador preenche cota de pessoas com deficiência habilitadas ou de beneficiários reabilitados", Prompt = "Trabalhador preenche cota de pessoas com deficiência habilitadas ou de beneficiários reabilitados")]
        public bool? infoCota { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Admissão
        /// 2 - Transferência de empresa do mesmo grupo econômico
        /// 3 - Transferência de empresa consorciada ou de consórcio
        /// 4 - Transferência por motivo de sucessão, incorporação, cisão ou fusão 
        /// 5 - Transferência do empregado doméstico para outro representante da mesma unidade familiar
        /// </summary>
        [DefaultValue(1)]
        [Display(Name = "Tipo de Admissão do Trabalhador", Prompt = "Tipo de Admissão do Trabalhador")]
        public int? tpAdmissao { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [MaxLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        [Display(Name = "Código Exame", Prompt = "Código Exame")]
        public string CodigoExameTox { get; set; }

        [Display(Name = "Data Exame", Prompt = "Data Exame")]
        public DateTime? DataExameTox { get; set; }

        [DefaultValue("00.000.000/0000-00")]
        [StringLength(18, ErrorMessage = "Máximo 18 caracteres.")]
        [MaxLength(18, ErrorMessage = "Máximo 18 caracteres.")]
        [Display(Name = "CNPJ Laboratório", Prompt = "CNPJ Laboratório")]
        public string CNPJLabExameTox { get; set; }

        [DefaultValue("")]
        [StringLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres.")]
        [Display(Name = "CRM", Prompt = "CRM")]
        public string NrCRMExameTox { get; set; }

        /// <summary>
        /// 
        /// AC
        /// AL
        /// AM
        /// AP
        /// BA
        /// CE
        /// DF
        /// ES
        /// GO
        /// MA
        /// MG
        /// MS
        /// MT
        /// PA
        /// PB
        /// PE
        /// PI
        /// PR
        /// RJ
        /// RN
        /// RO
        /// RR
        /// RS
        /// SC
        /// SE
        /// SP
        /// TO
        /// </summary>
        [DefaultValue("")]
        [StringLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [MaxLength(2, ErrorMessage = "Máximo 2 caracteres.")]
        [Display(Name = "UF", Prompt = "UF")]
        public string UFCRMExameTox { get; set; }

        [DefaultValue(0)]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Teletrabalho", Prompt = "Teletrabalho")]
        public bool TeleTrabalho { get; set; }

        [DefaultValue(0)]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Trabalho Parcial", Prompt = "Trabalho Parcial")]
        public bool TrabalhoParcial { get; set; }

        [DefaultValue(0)]
        //[Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Trabalho Intermitente", Prompt = "Trabalho Intermitente")]
        public bool TrabalhoIntermitente { get; set; }

        [Display(Name = "Período2 de Férias Programada de", Prompt = "Período2 de Férias Programada de")]
        public DateTime? DataIniFeriasProg2 { get; set; }

        [Display(Name = "Até", Prompt = "Até")]
        public DateTime? DataFimFeriasProg2 { get; set; }

        [Display(Name = "Período3 de Férias Programada de", Prompt = "Período3 de Férias Programada de")]
        public DateTime? DataIniFeriasProg3 { get; set; }

        [Display(Name = "Até", Prompt = "Até")]
        public DateTime? DataFimFeriasProg3 { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        public string? codConv { get; set; }

        [DefaultValue("")]
        [StringLength(18, ErrorMessage = "Máximo 18 caracteres.")]
        [MaxLength(18, ErrorMessage = "Máximo 18 caracteres.")]
        [Display(Name = "CNPJ Empresa Anterior", Prompt = "CNPJ Empresa Anterior")]
        public string? CNPJEmpresaAnterior { get; set; }

        public DateTime? DataIniEdicaoPortal { get; set; }

        [DefaultValue("")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string? CertificadoSeguranca { get; set; }

        public DateTime? DTIniEdicaoPortal { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Display(Name = "Matrícula no e - Social", Prompt = "Matrícula no e - Social")]
        public string? eSocialMatricula { get; set; }

        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        [MaxLength(1, ErrorMessage = "Máximo 1 caracteres.")]
        public string? TipoOperacaoWeb { get; set; }

        /// <summary>
        ///0 - Não Informado
        ///1 - Contribuição descontada pelo primeiro empregador(Soma Bases para Calcular Percentual sem abater o desconto anterior)
        ///2 - Contribuição descontada por outra(s) empresa(s) sobre valor inferior ao limite máximo do salário de contribuição(Soma Bases para Calculo e Desconto)
        ///3 - Contribuição sobre o limite máximo de salário de contribuição já descontada em outra(s) empresa(s)  (Sem Desconto Ginfor )
        /// </summary>
        [DefaultValue(0)]
        [Display(Name = "Indicador de desconto da Contribuição Previdenciária do Trabalhador", Prompt = "Indicador de desconto da Contribuição Previdenciária do Trabalhador")]
        public byte? IndMV { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(14,0)")]
        public decimal? cpfAnt { get; set; }

        [DefaultValue("")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        public string? matricAnt { get; set; }

        public DateTime? dtAltCPF { get; set; }

        [DefaultValue("")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string? ObsAltCPF { get; set; }

        [DefaultValue("")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string? objDet { get; set; }

        [DefaultValue("")]
        [StringLength(13, ErrorMessage = "Máximo 13 caracteres.")]
        [MaxLength(13, ErrorMessage = "Máximo 13 caracteres.")]
        [Display(Name = "Cartão Benefício", Prompt = "Cartão Benefício")]
        public string CartaoPrePago { get; set; }

        [DefaultValue(0)]
        public bool CtpsDigital { get; set; }

        [DefaultValue(0)]
        public short TipoAdesaoBem { get; set; }

        public DateTime? DataAcordoBem { get; set; }

        [DefaultValue(0)]
        public short PercentRedCargHorBem { get; set; }

        [DefaultValue(0)]
        public short MesesDuracaoBem { get; set; }

        [DefaultValue("")]
        [Display(Name = "Chave Pix", Prompt = "Chave Pix")]
        public string ChavePixFun { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Tipo Chave PIX", Prompt = "Tipo Chave PIX")]
        public byte TipoChavePixFun { get; set; }

        [DefaultValue(0)]
        public bool FlagIndicacao { get; set; }

        [DefaultValue(0)]
        public bool FlagSelecao { get; set; }

        [DefaultValue(0)]
        public bool FlagRecontratacao { get; set; }

        public DateTime? DataVigenciaBnf { get; set; }

        [DefaultValue(0)]
        public long? IdGrupoGPS { get; set; }

        [DefaultValue("")]
        public string? GrupoGPSCodigoCC { get; set; }

        [DefaultValue(0)]
        public byte? StatusGrupoGPS { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? SalarioFat2 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? ValorHorExtFat2 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? ValorAdcNotFat2 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? ValorFaltaDiaFat2 { get; set; }

        [DefaultValue(0)]
        public int ID_GiSelecao { get; set; }

        [DefaultValue(2)]
        public byte StatusPreCadastro { get; set; }

        [DefaultValue("")]
        public string? ObsRecrutador { get; set; }

        [DefaultValue(0)]
        public bool? APISinc { get; set; }

        [DefaultValue("")]
        public string ObsCtpseSocial { get; set; }

        [DefaultValue(0)]
        public bool? FlagViajante { get; set; }

        [DefaultValue("")]
        public string statusgiselecty { get; set; }

        [DefaultValue(0)]
        public short? CodCom1 { get; set; }

        [DefaultValue(0)]
        public short? CodCom2 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(8,5)")]
        public decimal? TaxaVendedor { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(8,5)")]
        public decimal? TaxaSelecionador { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(8,5)")]
        public decimal? TaxaRepresentante { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(8,5)")]
        public decimal? TaxaRecrutador { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(8,5)")]
        public decimal? TaxaCom1 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(8,5)")]
        public decimal? TaxaCom2 { get; set; }

        [DefaultValue("")]
        public string StatusGIPandaPe { get; set; }

        [DefaultValue(0)]
        public short? indNIF { get; set; }

        [DefaultValue("")]
        public string nifBenef { get; set; }

        [DefaultValue("")]
        public string frmTribut { get; set; }

        [DefaultValue("")]
        public string StatusGIAdmDigital { get; set; }

        [DefaultValue(0)]
        public int IdAdmDigital { get; set; }

        [DefaultValue("")]
        public string ObsGIAdmDigital { get; set; }

        [DefaultValue("")]
        public string? NomeSubstituto2 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(11,0)")]
        public decimal? CPFSubstituto2 { get; set; }

        [DefaultValue(0)]
        public short? CodigoEmpresaSubstituto2 { get; set; }

        [DefaultValue(0)]
        public short? CodigoFilialSubstituto2 { get; set; }

        [DefaultValue(0)]
        public int? CodigoFuncionarioSubstituto2 { get; set; }

        [DefaultValue("")]
        public string? NomeSubstituto3 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(11,0)")]
        public decimal? CPFSubstituto3 { get; set; }

        [DefaultValue(0)]
        public short? CodigoEmpresaSubstituto3 { get; set; }

        [DefaultValue(0)]
        public short? CodigoFilialSubstituto3 { get; set; }

        [DefaultValue(0)]
        public int? CodigoFuncionarioSubstituto3 { get; set; }

        [DefaultValue("")]
        public string? NomeSubstituto4 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(11,0)")]
        public decimal? CPFSubstituto4 { get; set; }

        [DefaultValue(0)]
        public short? CodigoEmpresaSubstituto4 { get; set; }

        [DefaultValue(0)]
        public short? CodigoFilialSubstituto4 { get; set; }

        [DefaultValue(0)]
        public int? CodigoFuncionarioSubstituto4 { get; set; }

        [DefaultValue("")]
        public string? NomeSubstituto5 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(11,0)")]
        public decimal? CPFSubstituto5 { get; set; }

        [DefaultValue(0)]
        public short? CodigoEmpresaSubstituto5 { get; set; }

        [DefaultValue(0)]
        public short? CodigoFilialSubstituto5 { get; set; }

        [DefaultValue(0)]
        public int? CodigoFuncionarioSubstituto5 { get; set; }

        [DefaultValue(0)]
        public bool APISincExterno { get; set; }

        [DefaultValue(0)]
        public bool FlagAposentado { get; set; }

        /// <summary>
        /// true - Sincroniza com Admissao Digital, false - Sincroniza com GI 
        /// </summary>
        [DefaultValue(0)]
        public bool APISincAdmissaoDigital { get; set; }
    }
}
