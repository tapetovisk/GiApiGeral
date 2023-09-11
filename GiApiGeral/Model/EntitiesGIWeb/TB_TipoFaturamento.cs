using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_TipoFaturamento : BaseTB
    {
        [Display(Name = "Código")]
        public short TipoFat { get; set; }

        [DefaultValue("")]
        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }

        [DefaultValue(11)]
        [Display(Name = " % INSS")]
        [Column(TypeName = "DECIMAL(7,2)")]
        public decimal? TxINSS { get; set; }

        [DefaultValue(1)]
        [Display(Name = " % IRRF")]
        [Column(TypeName = "DECIMAL(7,2)")]
        public decimal? TxIRRF { get; set; }

        [DefaultValue(1)]
        [Display(Name = "Tipo de Serviço")]
        public short? Tabela { get; set; }

        [DefaultValue(0)]
        public bool InclusaoOK { get; set; }

        [DefaultValue("")]
        public string CodAtividade { get; set; }

        [DefaultValue(0)]
        public bool SacoPlastico { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Tipo de Coleta")]
        public byte TipoColeta { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Classificação de Serviços Prestados(eSocial)")]
        public byte tpServicoeSocial { get; set; }

        [DefaultValue(0)]
        [Display(Name = " % Encargos 13º")]
        [Column(TypeName = "DECIMAL(5,2)")]
        public decimal AlqProvisaoEnc13o { get; set; }

        [DefaultValue(0)]
        [Display(Name = " % Encargos Férias")]
        [Column(TypeName = "DECIMAL(5,2)")]
        public decimal AlqProvisaoEncFer { get; set; }

        [DefaultValue(1)]
        [Display(Name = "Incidência Tributária(SPED / PIS / COFINS)")]
        public short IncidenciaTributariaSPED { get; set; }

        [DefaultValue(0)]
        [Display(Name = "PIS")]
        [Column(TypeName = "DECIMAL(7,2)")]
        public decimal PercentPis { get; set; }

        [DefaultValue(0)]
        [Display(Name = "COFINS")]
        [Column(TypeName = "DECIMAL(7,2)")]
        public decimal PercentFimSocial { get; set; }

        [DefaultValue(0)]
        public bool APISinc { get; set; }

        [DefaultValue(0)]
        public bool APISincExterno { get; set; }
    }

    public class TB_TipoFaturamento_old : BaseTB
    {
        [Display(Name = "Código")]
        public int TipoFat { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "% INSS")]
        public decimal TxINSS { get; set; }
        [Display(Name = "% IRRF")]
        public decimal TxIRRF { get; set; }
        [Display(Name = "Tipo de Serviço")]
        public int Tabela { get; set; }
        public bool InclusaoOK { get; set; }
        public string CodAtividade { get; set; }
        public bool SacoPlastico { get; set; }
        [Display(Name = "Tipo de Coleta")]
        public int TipoColeta { get; set; }
        [Display(Name = "Classificação de Serviços Prestados (eSocial)")]
        public int tpServicoeSocial { get; set; }
        [Display(Name = "% Encargos 13º")]
        public decimal AlqProvisaoEnc13o { get; set; }
        [Display(Name = "% Encargos Férias")]
        public decimal AlqProvisaoEncFer { get; set; }
        [Display(Name = "Incidência Tributária (SPED/PIS/COFINS)")]
        public int IncidenciaTributariaSPED { get; set; }
        [Display(Name = "PIS")]
        public decimal PercentPis { get; set; }
        [Display(Name = "COFINS")]
        public decimal PercentFimSocial { get; set; }
    }
}
