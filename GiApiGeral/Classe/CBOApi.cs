using GiApiGeral.Classe.Base;
using GiApiGeral.Interface;
using Service.Domain.EntitiesGIWeb;

namespace GiApiGeral.Classe
{
    public class CBOApi : BaseApi<TB_CBO>, ICBOApi
    {
        public CBOApi(IConfiguracaoApiGeralModel conf) : base("CBO", conf) { }
    }
}
