using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_DuplicataComplemento : BaseTB
    {
        [Display(Name = "Empresa", Prompt = "Empresa")]
        public short CodigoEmpresaFat { get; set; }

        [Display(Name = "Filial", Prompt = "Filial")]
        public short CodigoFilialFat { get; set; }

        [Display(Name = "Duplicata", Prompt = "Duplicata")]
        public int Duplicata { get; set; }

        [Display(Name = "Ordem", Prompt = "Ordem")]
        public string Ordem { get; set; }

        [Display(Name = "Sequencia", Prompt = "Sequencia")]
        public short Sequencia { get; set; }

        [Display(Name = "Baixa", Prompt = "Baixa")]
        public DateTime? DataMov { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor", Prompt = "Valor")]
        [Column(TypeName = "DECIMAL(15,2)")]
        public decimal? Valor { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(15,2)")]
        public decimal? ValorIRF { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(15,2)")]
        public decimal? ValorINSS { get; set; }

        [DefaultValue("")]
        [Display(Name = "Tipo", Prompt = "Tipo")]
        public string? Tipo { get; set; }

        [DefaultValue(0)]
        public int? ChaveMovBanco { get; set; }

        [Display(Name = "Crédito", Prompt = "Crédito")]
        public DateTime? DataCredito { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Banco", Prompt = "Banco")]
        public short? CodigoBanco { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(15,2)")]
        public decimal ValorISS { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(15,2)")]
        public decimal ValorTRI { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(15,2)")]
        public decimal ValorPIS { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(15,2)")]
        public decimal ValorCOFINS { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(15,2)")]
        public decimal ValorCSLL { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(15,2)")]
        public decimal BaseCaucao { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(15,2)")]
        public decimal ValorCaucao { get; set; }

        [DefaultValue(0)]
        public bool? BaixaIntegrada { get; set; }

        [DefaultValue("")]
        [Display(Name = "Observação", Prompt = "Observação")]
        public string? Observacao { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(15,2)")]
        public decimal? ValorVariacaoCambial { get; set; }

        [DefaultValue(0)]
        public short CodigoEmpresaRef { get; set; }

        [DefaultValue(0)]
        public short CodigoFilialRef { get; set; }

        [DefaultValue(0)]
        public int DuplicataRef { get; set; }

        [DefaultValue("")]
        public string OrdemRef { get; set; }

        [DefaultValue(0)]
        public bool APISinc { get; set; }

        [DefaultValue(0)]
        public bool APISincExterno { get; set; }
    }

    public class TB_DuplicataComplemento_old : BaseTB
    {
        [Display(Name = "Empresa", Prompt = "Empresa")]
        public int CodigoEmpresaFat { get; set; }

        [Display(Name = "Filial", Prompt = "Filial")]
        public int CodigoFilialFat { get; set; }

        [Display(Name = "Duplicata", Prompt = "Duplicata")]
        public int Duplicata { get; set; }

        [Display(Name = "Ordem", Prompt = "Ordem")]
        public string Ordem { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Valor", Prompt = "Valor")]
        public decimal Valor { get; set; }

        [DefaultValue(0)]
        public decimal ValorIrf { get; set; }
        [DefaultValue(0)]
        public decimal ValorInss { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Sequencia", Prompt = "Sequencia")]
        public int Sequencia { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Banco", Prompt = "Banco")]
        public int CodigoBanco { get; set; }

        public decimal ValorIss { get; set; }
        public decimal ValorTri { get; set; }
        public decimal ValorPis { get; set; }
        public decimal ValorCofins { get; set; }
        public decimal ValorCsll { get; set; }

        public decimal BaseCaucao { get; set; }
        public decimal ValorCaucao { get; set; }
        public bool BaixaIntegrada { get; set; }
        [DefaultValue(0)]
        public decimal ValorVariacaoCambial { get; set; }

        [DefaultValue("")]
        [Display(Name = "Tipo", Prompt = "Tipo")]
        public string Tipo { get; set; }

        [DefaultValue(0)]
        public int ChaveMovBanco { get; set; }

        [Display(Name = "Baixa", Prompt = "Baixa")]
        public DateTime? DataMov { get; set; }

        [Display(Name = "Crédito", Prompt = "Crédito")]
        public DateTime? DataCredito { get; set; }

        [DefaultValue("")]
        [Display(Name = "Observação", Prompt = "Observação")]
        public string Observacao { get; set; }
        public int CodigoEmpresaRef { get; set; }
        public int CodigoFilialRef { get; set; }
        public int DuplicataRef { get; set; }
        public string OrdemRef { get; set; }
    }
}
