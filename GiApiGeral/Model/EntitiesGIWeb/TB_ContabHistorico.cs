using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_ContabHistorico : BaseTB
    {
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Código", Prompt = "Código")]
        public int CodigoHistContab { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Maximo de caracteria são de 70.")]
        [MaxLength(70, ErrorMessage = "Maximo de caracteria são de 70.")]
        [Display(Name = "Descrição do Histórico", Prompt = "Descrição do Histórico")]
        public string? Descricao { get; set; }

        [DefaultValue(0)]
        public bool InclusaoOK { get; set; }

        [DefaultValue(0)]
        public bool APISinc { get; set; }

        [DefaultValue(0)]
        public bool APISincExterno { get; set; }
    }

    public class TB_ContabHistorico_old : BaseTB
    {
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [Display(Name = "Código", Prompt = "Código")]
        public int CodigoHistContab { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Maximo de caracteria são de 70.")]
        [MaxLength(70, ErrorMessage = "Maximo de caracteria são de 70.")]
        [Display(Name = "Descrição do Histórico", Prompt = "Descrição do Histórico")]
        public string Descricao { get; set; }

        public bool InclusaoOK { get; set; }
    }
}
