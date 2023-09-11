using GiApiGeral.Classe.Base;
using GiApiGeral.Interface;
using Service.Apis.ApiGeral.Model;
using Service.Domain.EntitiesGIWeb;

namespace GiApiGeral.Classe
{
    public class FuncionarioDependenteSelecaoApi : BaseApi<TB_FuncionarioDependenteSelecaoAPI>, IFuncionarioDependenteSelecaoApi
    {
        public FuncionarioDependenteSelecaoApi(IConfiguracaoApiGeralModel conf) : base("FuncionarioDependenteSelecao", conf) { }

        public async Task<List<TB_FuncionarioDependenteSelecaoAPI>> GetAll(short CodigoEmpresa, short CodigoFilial, int CodigoFuncionario)
        {
            return await base.GetAllJson(new GetData()
            {
                where = new List<Where>() {
                new Where() { campo = "CodigoEmpresa", valor = CodigoEmpresa.ToString() },
                new Where() { campo = "CodigoFilial", valor = CodigoFilial.ToString() },
                new Where() { campo = "CodigoFuncionario", valor = CodigoFuncionario.ToString() }
            }
            });
        }

    }
}
