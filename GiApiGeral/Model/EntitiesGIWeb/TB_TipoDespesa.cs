using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_TipoDespesa : BaseTB
    {
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [StringLength(6, ErrorMessage = "Maximo de caracteria são de 6.")]
        [MaxLength(6, ErrorMessage = "Maximo de caracteria são de 6.")]
        [Display(Name = "Código Despesa", Prompt = "Código Despesa")]
        public string CodigoDespesa { get; set; }

        [DefaultValue("")]
        [StringLength(13, ErrorMessage = "Maximo de caracteria são de 10.")]
        [MaxLength(13, ErrorMessage = "Maximo de caracteria são de 10.")]
        [Display(Name = "Conta Contábil", Prompt = "Conta Contábil")]
        public string? ContaContabil { get; set; }

        [DefaultValue(0)]
        [Display(Name = "HistoricoProvisao", Prompt = "Código")]
        public int? HistoricoProvisao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Grupo de Custo", Prompt = "Grupo de Custo")]
        public int? GrupoCusto { get; set; }

        [DefaultValue("")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [StringLength(50, ErrorMessage = "Maximo de caracteria são de 50.")]
        [MaxLength(50, ErrorMessage = "Maximo de caracteria são de 50.")]
        [Display(Name = "Descrição", Prompt = "Descrição")]
        public string? Descricao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "HistoricoBaixa", Prompt = "Código")]
        public int? HistoricoBaixa { get; set; }

        [DefaultValue(0)]
        [Display(Name = "HistoricoBanco", Prompt = "Código")]
        public int? HistoricoBanco { get; set; }

        [DefaultValue(0)]
        public bool InclusaoOK { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Consulta Rápida", Prompt = "Consulta Rápida")]
        public bool ConsultaRapida { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Grupo Despesa", Prompt = "Grupo Despesa")]
        public int CodigoGrupoDespesa { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Código Tributo", Prompt = "Código Tributo")]
        public int CodigoTributo { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Maximo de caracteria são de 70.")]
        [MaxLength(70, ErrorMessage = "Maximo de caracteria são de 70.")]
        public string IDSistemaAnterior { get; set; }

        [DefaultValue(1)]
        [Display(Name = "Ativa", Prompt = "Ativa")]
        public bool DespesaAtiva { get; set; }

        [DefaultValue("000-00000")]
        public string TipoNaturezaGrupoGPS { get; set; }

        [DefaultValue(0)]
        public int NaturezaRendDesp { get; set; }

        [DefaultValue(0)]
        public bool APISinc { get; set; }

        [DefaultValue(0)]
        public bool APISincExterno { get; set; }
    }

    public class TB_TipoDespesa_old : BaseTB
    {
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [StringLength(6, ErrorMessage = "Maximo de caracteria são de 6.")]
        [MaxLength(6, ErrorMessage = "Maximo de caracteria são de 6.")]
        [Display(Name = "Código Despesa", Prompt = "Código Despesa")]
        public string CodigoDespesa { get; set; }

        [StringLength(10, ErrorMessage = "Maximo de caracteria são de 10.")]
        [MaxLength(10, ErrorMessage = "Maximo de caracteria são de 10.")]
        [Display(Name = "Conta Contábil", Prompt = "Conta Contábil")]
        public string ContaContabil { get; set; }

        //[StringLength(4, ErrorMessage = "Maximo de caracteria são de 3.")]
        //[MaxLength(4, ErrorMessage = "Maximo de caracteria são de 3.")]
        [Display(Name = "Grupo de Custo", Prompt = "Grupo de Custo")]
        public int? GrupoCusto { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [StringLength(50, ErrorMessage = "Maximo de caracteria são de 50.")]
        [MaxLength(50, ErrorMessage = "Maximo de caracteria são de 50.")]
        [Display(Name = "Descrição", Prompt = "Descrição")]
        public string Descricao { get; set; }

        //[StringLength(3, ErrorMessage = "Maximo de caracteria são de 3.")]
        //[MaxLength(3, ErrorMessage = "Maximo de caracteria são de 3.")]
        [Display(Name = "HistoricoProvisao", Prompt = "Código")]
        public int? HistoricoProvisao { get; set; }

        //[StringLength(3, ErrorMessage = "Maximo de caracteria são de 3.")]
        //[MaxLength(3, ErrorMessage = "Maximo de caracteria são de 3.")]
        [Display(Name = "HistoricoBaixa", Prompt = "Código")]
        public int? HistoricoBaixa { get; set; }

        //[StringLength(3, ErrorMessage = "Maximo de caracteria são de 3.")]
        //[MaxLength(3, ErrorMessage = "Maximo de caracteria são de 3.")]
        [Display(Name = "HistoricoBanco", Prompt = "Código")]
        public int? HistoricoBanco { get; set; }

        //[StringLength(3, ErrorMessage = "Maximo de caracteria são de 3.")]
        //[MaxLength(3, ErrorMessage = "Maximo de caracteria são de 3.")]
        [Display(Name = "Grupo Despesa", Prompt = "Grupo Despesa")]
        public int CodigoGrupoDespesa { get; set; }

        [Display(Name = "Código Tributo", Prompt = "Código Tributo")]
        public int CodigoTributo { get; set; }

        [StringLength(70, ErrorMessage = "Maximo de caracteria são de 70.")]
        [MaxLength(70, ErrorMessage = "Maximo de caracteria são de 70.")]
        public string IDSistemaAnterior { get; set; }

        [Display(Name = "Ativa", Prompt = "Ativa")]
        public bool DespesaAtiva { get; set; }

        [Display(Name = "Consulta Rápida", Prompt = "Consulta Rápida")]
        public bool ConsultaRapida { get; set; }

        public bool InclusaoOK { get; set; }

        public string TipoNaturezaGrupoGPS { get; set; }
        public int NaturezaRendDesp { get; set; }
    }
}
