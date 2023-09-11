using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_ContratoEventoSelecao : BaseTB
    {
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public int CodigoCliente { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public short CodigoContrato { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public short TipoFat { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public short CodigoEvento { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(7,4)")]
        public decimal? TaxaFat { get; set; }

        [DefaultValue(1)]
        public bool? CalculaIRF { get; set; }

        [DefaultValue(1)]
        public bool? CalculaINSS { get; set; }

        [DefaultValue(1)]
        public bool? CalculaISS { get; set; }

        [DefaultValue(1)]
        public bool? CalculaTrib { get; set; }

        [DefaultValue(0)]
        public bool? FinalDS { get; set; }

        [DefaultValue("")]
        [StringLength(3, ErrorMessage = "Maximo de caracteria são de 3.")]
        [MaxLength(3, ErrorMessage = "Maximo de caracteria são de 3.")]
        public string? FormulaNF { get; set; }

        [DefaultValue(0)]
        public byte? IncideEnc { get; set; }

        [DefaultValue(1)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public bool CalculaPIS { get; set; }

        [DefaultValue(1)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public bool CalculaCOF { get; set; }

        [DefaultValue(1)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public bool CalculaCSL { get; set; }

        [DefaultValue(1)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public byte CalculaISS2 { get; set; }

        [DefaultValue(0)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public bool CalculaCaucao { get; set; }

        [DefaultValue(1)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public byte CalculaPIS2 { get; set; }

        [DefaultValue(1)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public byte CalculaCOF2 { get; set; }

        [DefaultValue(1)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public byte CalculaCSL2 { get; set; }

        [DefaultValue(1)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public byte CalculaIRF2 { get; set; }

        [DefaultValue(1)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public byte CalculaINSS2 { get; set; }

        [DefaultValue(1)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public byte CalculaTrib2 { get; set; }

        [DefaultValue(0)]
        public int? TaxaFat2 { get; set; }

        [DefaultValue("000000")]
        [StringLength(6, ErrorMessage = "Maximo de caracteria são de 6.")]
        [MaxLength(6, ErrorMessage = "Maximo de caracteria são de 6.")]
        public string? TaxaFat3 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(11,8)")]
        public decimal? TaxaFatGrid { get; set; }

        [DefaultValue(0)]
        public bool UtilizaEncargosDiversos { get; set; }
    }

    public class TB_ContratoEventoSelecao_old : BaseTB
    {
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public int CodigoCliente { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public int CodigoContrato { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public int TipoFat { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public int CodigoEvento { get; set; }
        [DefaultValue(0)]
        public decimal TaxaFat { get; set; }
        [DefaultValue(true)]
        public bool CalculaIRF { get; set; }
        [DefaultValue(true)]
        public bool CalculaINSS { get; set; }
        [DefaultValue(true)]
        public bool CalculaISS { get; set; }
        [DefaultValue(true)]
        public bool CalculaTrib { get; set; }
        [DefaultValue(false)]
        public bool FinalDS { get; set; }

        [DefaultValue("")]
        [StringLength(3, ErrorMessage = "Maximo de caracteria são de 3.")]
        [MaxLength(3, ErrorMessage = "Maximo de caracteria são de 3.")]
        public string FormulaNF { get; set; }
        [DefaultValue(0)]
        public int IncideEnc { get; set; }

        [DefaultValue(true)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public bool CalculaPIS { get; set; }

        [DefaultValue(true)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public bool CalculaCOF { get; set; }

        [DefaultValue(true)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public bool CalculaCSL { get; set; }

        [DefaultValue(1)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public int CalculaISS2 { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public bool CalculaCaucao { get; set; }

        [DefaultValue(1)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public int CalculaPIS2 { get; set; }

        [DefaultValue(1)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public int CalculaCOF2 { get; set; }

        [DefaultValue(1)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public int CalculaCSL2 { get; set; }

        [DefaultValue(1)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public int CalculaIRF2 { get; set; }

        [DefaultValue(1)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public int CalculaINSS2 { get; set; }

        [DefaultValue(1)]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public int CalculaTrib2 { get; set; }

        [DefaultValue(0)]
        public int TaxaFat2 { get; set; }

        [DefaultValue("000000")]
        [StringLength(6, ErrorMessage = "Maximo de caracteria são de 6.")]
        [MaxLength(6, ErrorMessage = "Maximo de caracteria são de 6.")]
        public string TaxaFat3 { get; set; }
        [DefaultValue(0)]
        public decimal TaxaFatGrid { get; set; }
        public bool UtilizaEncargosDiversos { get; set; }
    }
}
