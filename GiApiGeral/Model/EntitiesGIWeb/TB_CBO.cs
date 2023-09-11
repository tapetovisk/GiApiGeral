using Service.Domain.EntitiesGIWeb.Base;
using System.ComponentModel;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_CBO : BaseTB
    {
        [DefaultValue("0000-00")]
        public string CboNovo { get; set; }

        [DefaultValue("")]
        public string DescricaoFuncao { get; set; }

        [DefaultValue(0)]
        public bool? APISinc { get; set; }
    }


        public class TB_CBO_old : BaseTB
    {
        public string CboNovo { get; set; }
        public string DescricaoFuncao { get; set; }

        public bool APISinc { get; set; }
    }
}
