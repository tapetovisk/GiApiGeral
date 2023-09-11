using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_DSEmitida : BaseTB
    {
        [DefaultValue(0)]
        public short CodigoEmpresaFat { get; set; }

        [DefaultValue(0)]
        public short CodigoFilialFat { get; set; }

        [DefaultValue(0)]
        public int CodigoDS { get; set; }

        [DefaultValue(0)]
        public int Sequencia { get; set; }

        [DefaultValue("")]
        public string? Linha { get; set; }
    }

    public class TB_DSEmitida_old : BaseTB
    {
        public long CodigoEmpresaFat { get; set; }
        public long CodigoFilialFat { get; set; }
        public int CodigoDS { get; set; }
        public int Sequencia { get; set; }
        public string Linha { get; set; }
    }
}
