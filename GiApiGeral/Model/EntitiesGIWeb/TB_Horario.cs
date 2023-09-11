using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_Horario : BaseTB
    {
        [DefaultValue("000")]
        public int CodigoHorario { get; set; }

        [DefaultValue("")]
        public string? Descricao { get; set; }

        [DefaultValue("")]
        public string? HSegEntrada { get; set; }

        [DefaultValue("")]
        public string? HSegIntervIni { get; set; }

        [DefaultValue("")]
        public string? HSegIntervFin { get; set; }

        [DefaultValue("")]
        public string? HSegSaida { get; set; }

        [DefaultValue("")]
        public string? HTerEntrada { get; set; }

        [DefaultValue("")]
        public string? HTerIntervIni { get; set; }

        [DefaultValue("")]
        public string? HTerIntervFin { get; set; }

        [DefaultValue("")]
        public string? HTerSaida { get; set; }

        [DefaultValue("")]
        public string? HQuaEntrada { get; set; }

        [DefaultValue("")]
        public string? HQuaIntervIni { get; set; }

        [DefaultValue("")]
        public string? HQuaIntervFin { get; set; }

        [DefaultValue("")]
        public string? HQuaSaida { get; set; }

        [DefaultValue("")]
        public string? HQuiEntrada { get; set; }

        [DefaultValue("")]
        public string? HQuiIntervIni { get; set; }

        [DefaultValue("")]
        public string? HQuiIntervFin { get; set; }

        [DefaultValue("")]
        public string? HQuiSaida { get; set; }

        [DefaultValue("")]
        public string? HSexEntrada { get; set; }

        [DefaultValue("")]
        public string? HSexIntervIni { get; set; }

        [DefaultValue("")]
        public string? HSexIntervFin { get; set; }

        [DefaultValue("")]
        public string? HSexSaida { get; set; }

        [DefaultValue("")]
        public string? HSabEntrada { get; set; }

        [DefaultValue("")]
        public string? HSabIntervIni { get; set; }

        [DefaultValue("")]
        public string? HSabIntervFin { get; set; }

        [DefaultValue("")]
        public string? HSabSaida { get; set; }

        [DefaultValue("")]
        public string? HDomEntrada { get; set; }

        [DefaultValue("")]
        public string? HDomIntervIni { get; set; }

        [DefaultValue("")]
        public string? HDomIntervFin { get; set; }

        [DefaultValue("")]
        public string? HDomSaida { get; set; }

        [DefaultValue(0)]
        public int? EscalaDiasTrabalho { get; set; }

        [DefaultValue(0)]
        public int? EscalaDiasDescanco { get; set; }

        public DateTime? EscalaDataInicio { get; set; }

        public DateTime? EscalaDataFim { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(12,2)")]
        public decimal? QtdeHorasMes { get; set; }

        [DefaultValue(0)]
        public bool InclusaoOK { get; set; }

        [DefaultValue(1)]
        public bool PagarVR_Seg { get; set; }

        [DefaultValue(1)]
        public bool PagarVR_Ter { get; set; }

        [DefaultValue(1)]
        public bool PagarVR_Qua { get; set; }

        [DefaultValue(1)]
        public bool PagarVR_Qui { get; set; }

        [DefaultValue(1)]
        public bool PagarVR_Sex { get; set; }

        [DefaultValue(1)]
        public bool PagarVR_Sab { get; set; }

        [DefaultValue(1)]
        public bool PagarVR_Dom { get; set; }

        [DefaultValue(0)]
        public short CodigoEvento_ANDom { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(5,2)")]
        public decimal Qtde_ANDom { get; set; }

        [DefaultValue(0)]
        public short CodigoEvento_ANSeg { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(5,2)")]
        public decimal Qtde_ANSeg { get; set; }

        [DefaultValue(0)]
        public short CodigoEvento_ANTer { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(5,2)")]
        public decimal Qtde_ANTer { get; set; }

        [DefaultValue(0)]
        public short CodigoEvento_ANQua { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(5,2)")]
        public decimal Qtde_ANQua { get; set; }

        [DefaultValue(0)]
        public short CodigoEvento_ANQui { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(5,2)")]
        public decimal Qtde_ANQui { get; set; }

        [DefaultValue(0)]
        public short CodigoEvento_ANSex { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(5,2)")]
        public decimal Qtde_ANSex { get; set; }

        [DefaultValue(0)]
        public short CodigoEvento_ANSab { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(5,2)")]
        public decimal Qtde_ANSab { get; set; }

        [DefaultValue("N")]
        public string? TipoEscala { get; set; }

        [DefaultValue("")]
        public string IDSistemaAnterior { get; set; }

        [DefaultValue("")]
        public string Observacao { get; set; }

        [DefaultValue(0)]
        public bool EscalaPorFuncionario { get; set; }

        [DefaultValue(0)]
        public short deltaEntrada { get; set; }

        [DefaultValue(0)]
        public short deltaSaida { get; set; }

        [DefaultValue(0)]
        public bool perHorFlexivel { get; set; }

        [DefaultValue(0)]
        public bool Inativo { get; set; }

        [DefaultValue("")]
        public string? TurnoGPS { get; set; }

        [DefaultValue(0)]
        public bool? APISinc { get; set; }

        [DefaultValue(0)]
        public bool APISincExterno { get; set; }

        [DefaultValue(0)]
        public bool SabadoAlternado { get; set; }
    }

    public class TB_Horario_old : BaseTB
    {
        public int CodigoHorario { get; set; }

        public string Descricao { get; set; }

        public string HSegEntrada { get; set; }

        public string HSegIntervIni { get; set; }

        public string HSegIntervFin { get; set; }

        public string HSegSaida { get; set; }

        public string HTerEntrada { get; set; }

        public string HTerIntervIni { get; set; }

        public string HTerIntervFin { get; set; }

        public string HTerSaida { get; set; }

        public string HQuaEntrada { get; set; }

        public string HQuaIntervIni { get; set; }

        public string HQuaIntervFin { get; set; }

        public string HQuaSaida { get; set; }

        public string HQuiEntrada { get; set; }

        public string HQuiIntervIni { get; set; }

        public string HQuiIntervFin { get; set; }

        public string HQuiSaida { get; set; }

        public string HSexEntrada { get; set; }

        public string HSexIntervIni { get; set; }

        public string HSexIntervFin { get; set; }

        public string HSexSaida { get; set; }

        public string HSabEntrada { get; set; }

        public string HSabIntervIni { get; set; }

        public string HSabIntervFin { get; set; }

        public string HSabSaida { get; set; }

        public string HDomEntrada { get; set; }

        public string HDomIntervIni { get; set; }

        public string HDomIntervFin { get; set; }

        public string HDomSaida { get; set; }

        public int EscalaDiasTrabalho { get; set; }

        public int EscalaDiasDescanco { get; set; }

        public DateTime? EscalaDataInicio { get; set; }

        public DateTime? EscalaDataFim { get; set; }

        public decimal QtdeHorasMes { get; set; }

        public bool InclusaoOK { get; set; }

        public bool PagarVR_Seg { get; set; }

        public bool PagarVR_Ter { get; set; }

        public bool PagarVR_Qua { get; set; }

        public bool PagarVR_Qui { get; set; }

        public bool PagarVR_Sex { get; set; }

        public bool PagarVR_Sab { get; set; }

        public bool PagarVR_Dom { get; set; }

        public short CodigoEvento_ANDom { get; set; }

        public decimal Qtde_ANDom { get; set; }

        public short CodigoEvento_ANSeg { get; set; }

        public decimal Qtde_ANSeg { get; set; }

        public short CodigoEvento_ANTer { get; set; }

        public decimal Qtde_ANTer { get; set; }

        public short CodigoEvento_ANQua { get; set; }

        public decimal Qtde_ANQua { get; set; }

        public short CodigoEvento_ANQui { get; set; }

        public decimal Qtde_ANQui { get; set; }

        public short CodigoEvento_ANSex { get; set; }

        public decimal Qtde_ANSex { get; set; }

        public short CodigoEvento_ANSab { get; set; }

        public decimal Qtde_ANSab { get; set; }

        public string TipoEscala { get; set; }

        public string IDSistemaAnterior { get; set; }

        public string Observacao { get; set; }

        public bool EscalaPorFuncionario { get; set; }

        public short deltaEntrada { get; set; }

        public short deltaSaida { get; set; }

        public bool perHorFlexivel { get; set; }

        public bool Inativo { get; set; }

        public bool APISinc { get; set; }
    }
}
