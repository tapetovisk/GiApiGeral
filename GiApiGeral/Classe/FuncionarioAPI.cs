using GiApiGeral.Classe.Base;
using GiApiGeral.Interface;
using Service.Domain.EntitiesGIWeb;

namespace GiApiGeral.Classe
{
    public class FuncionarioApi : BaseApi<TB_Funcionario>, IFuncionarioApi
    {
        public FuncionarioApi(IConfiguracaoApiGeralModel conf) : base("Funcionario", conf) { }
    }
}
