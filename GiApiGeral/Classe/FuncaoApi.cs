using GiApiGeral.Classe.Base;
using GiApiGeral.Interface;
using Service.Domain.EntitiesGIWeb;

namespace GiApiGeral.Classe
{
    public class FuncaoApi : BaseApi<TB_Funcao>, IFuncaoApi
    {
        public FuncaoApi(IConfiguracaoApiGeralModel conf) : base("Funcao", conf) { }
    }
}
