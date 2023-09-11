using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_Funcao : BaseTB
    {
        public int CodigoFuncao { get; set; }

        [DefaultValue("")]
        public string Descricao { get; set; }

        [DefaultValue("00000")]
        public string CBO { get; set; }

        [DefaultValue("D")]
        public string Area { get; set; }

        [DefaultValue(0)]
        public bool InclusaoOK { get; set; }

        [DefaultValue(0)]
        public int CBONovo { get; set; }

        [DefaultValue("1")]
        public string GrauInstrucaoMinimo { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal PisoSalarioMensal { get; set; }

        [DefaultValue(0)]
        public int OcupacaoIRF { get; set; }

        [DefaultValue("")]
        public string IDSistemaAnterior { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal ValorFixo1 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal ValorFixo2 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal ValorFixo3 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal ValorFixo4 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal ValorFixo5 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal ValorFixo6 { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(9,2)")]
        public decimal ValorFixo7 { get; set; }

        [DefaultValue("")]
        public string Nivel { get; set; }

        [DefaultValue(0)]
        public short CodigoEvento1 { get; set; }

        [DefaultValue(0)]
        public short CodigoEvento2 { get; set; }

        [DefaultValue(0)]
        public short CodigoEventoDif1 { get; set; }

        [DefaultValue(0)]
        public short CodigoEventoDif2 { get; set; }

        public DateTime? dtIniValidade { get; set; }

        public DateTime? dtFimValidade { get; set; }

        [DefaultValue(0)]
        public bool Inativo { get; set; }

        [DefaultValue("")]
        public string nrLei { get; set; }

        [DefaultValue(1)]
        public byte acumCargo { get; set; }

        [DefaultValue(1)]
        public byte contagemEsp { get; set; }

        [DefaultValue(0)]
        public bool dedicExcl { get; set; }

        public DateTime? dtLei { get; set; }

        [DefaultValue(1)]
        public byte sitCargo { get; set; }

        [DefaultValue("")]
        public string TipoServico { get; set; }

        [DefaultValue(0)]
        public bool? APISinc { get; set; }

        [DefaultValue(0)]
        public bool APISincExterno { get; set; }
    }

    public class TB_Funcao_old : BaseTB
    {
        public int CodigoFuncao { get; set; }
        public string Descricao { get; set; }
        public string CBO { get; set; }
        public string Area { get; set; }
        public bool InclusaoOK { get; set; }
        public int CBONovo { get; set; }
        public string GrauInstrucaoMinimo { get; set; }
        public decimal PisoSalarioMensal { get; set; }
        public int OcupacaoIRF { get; set; }
        public string IDSistemaAnterior { get; set; }
        public decimal ValorFixo1 { get; set; }
        public decimal ValorFixo2 { get; set; }
        public decimal ValorFixo3 { get; set; }
        public decimal ValorFixo4 { get; set; }
        public decimal ValorFixo5 { get; set; }
        public decimal ValorFixo6 { get; set; }
        public decimal ValorFixo7 { get; set; }
        public string Nivel { get; set; }
        public short CodigoEvento1 { get; set; }
        public short CodigoEvento2 { get; set; }
        public short CodigoEventoDif1 { get; set; }
        public short CodigoEventoDif2 { get; set; }
        public DateTime? dtIniValidade { get; set; }
        public DateTime? dtFimValidade { get; set; }
        public bool Inativo { get; set; }
        public string nrLei { get; set; }
        public int acumCargo { get; set; }
        public int contagemEsp { get; set; }
        public bool dedicExcl { get; set; }
        public DateTime? dtLei { get; set; }
        public int sitCargo { get; set; }
        public string TipoServico { get; set; }

        public bool APISinc { get; set; }
    }
}
