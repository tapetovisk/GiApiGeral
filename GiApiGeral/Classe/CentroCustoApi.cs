using GiApiGeral.Classe.Base;
using GiApiGeral.Interface;
using Service.Domain.EntitiesGIWeb;

namespace GiApiGeral.Classe
{
    public class CentroCustoApi : BaseApi<TB_CentroCusto>, ICentroCustoApi
    {
        public CentroCustoApi(IConfiguracaoApiGeralModel conf) : base("CentroCusto", conf) { }
    }
}
