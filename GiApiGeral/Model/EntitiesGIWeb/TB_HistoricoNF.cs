using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_HistoricoNF : BaseTB
    {
        [Display(Name = "Codigo Historico", Prompt = "Codigo Historico")]
        public short CodigoHistorico { get; set; }

        [DefaultValue("")]
        [Display(Name = "Descrição", Prompt = "Descrição")]
        public string? Descricao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Impressão Zerado", Prompt = "Impressão Zerado")]
        public bool? ImpZerado { get; set; }

        [DefaultValue("")]
        [Display(Name = "Corpo", Prompt = "Corpo")]
        public string? Corpo { get; set; }

        [DefaultValue(1)]
        [Display(Name = "Qtde Valor", Prompt = "Qtde Valor")]
        public short? QtdeValor { get; set; }

        [DefaultValue("")]
        [Display(Name = "Incidencia", Prompt = "Incidencia")]
        public string? Incidencia { get; set; }

        [DefaultValue(0)]
        [Display(Name = "SubTotal", Prompt = "SubTotal")]
        public short? SubTotal { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Inclusão OK", Prompt = "Inclusão OK")]
        public bool InclusaoOK { get; set; }

        [DefaultValue('N')]
        [Display(Name = "Tipo", Prompt = "Tipo")]
        public string Tipo { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Sto Andre Participa Base ISS", Prompt = "Sto Andre Participa Base ISS")]
        public bool StoAndreParticipaBaseISS { get; set; }

        [DefaultValue(1)]
        [Display(Name = "Sto Andre Corpo NF", Prompt = "Sto Andre Corpo NF")]
        public byte StoAndreCorpoNF { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Deduz Comissão", Prompt = "Deduz Comissão")]
        public bool DeduzComissao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Codigo Historico SPED", Prompt = "Codigo Historico SPED")]
        public short CodigoHistoricoSPED { get; set; }

        [DefaultValue("")]
        [Display(Name = "Conta Contabil", Prompt = "Conta Contabil")]
        public string ContaContabil { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Cod HisGrupo GI", Prompt = "Cod HisGrupo GI")]
        public short CodHisGrupoGI { get; set; }

        [DefaultValue(0)]
        public bool APISinc { get; set; }

        [DefaultValue(0)]
        public bool APISincExterno { get; set; }
    }

    public class TB_HistoricoNF_old : BaseTB
    {
        [Display(Name = "Codigo Historico", Prompt = "Codigo Historico")]
        public short CodigoHistorico { get; set; }
        [Display(Name = "Descrição", Prompt = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Impressão Zerado", Prompt = "Impressão Zerado")]
        public bool ImpZerado { get; set; }
        [Display(Name = "Corpo", Prompt = "Corpo")]
        public string Corpo { get; set; }
        [Display(Name = "Qtde Valor", Prompt = "Qtde Valor")]
        public short? QtdeValor { get; set; }

        [Display(Name = "Incidencia", Prompt = "Incidencia")]
        public string Incidencia { get; set; }
        [Display(Name = "SubTotal", Prompt = "SubTotal")]
        public short? SubTotal { get; set; }
        [Display(Name = "Inclusão OK", Prompt = "Inclusão OK")]
        public bool InclusaoOK { get; set; }
        [Display(Name = "Tipo", Prompt = "Tipo")]
        public string Tipo { get; set; }
        [Display(Name = "Sto Andre Participa Base ISS", Prompt = "Sto Andre Participa Base ISS")]
        public bool StoAndreParticipaBaseISS { get; set; }
        [Display(Name = "Sto Andre Corpo NF", Prompt = "Sto Andre Corpo NF")]
        public byte StoAndreCorpoNF { get; set; }
        [Display(Name = "Deduz Comissão", Prompt = "Deduz Comissão")]
        public bool DeduzComissao { get; set; }
        [Display(Name = "Codigo Historico SPED", Prompt = "Codigo Historico SPED")]
        public short CodigoHistoricoSPED { get; set; }
        [Display(Name = "Conta Contabil", Prompt = "Conta Contabil")]
        public string ContaContabil { get; set; }
        [Display(Name = "Cod HisGrupo GI", Prompt = "Cod HisGrupo GI")]
        public short CodHisGrupoGI { get; set; }
    }
}
