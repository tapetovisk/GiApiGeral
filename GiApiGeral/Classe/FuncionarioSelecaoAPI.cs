using GiApiGeral.Classe.Base;
using GiApiGeral.Interface;
using GiApiGeral.Model;
using Service.Apis.ApiGeral.Model;
using Service.Domain.EntitiesGIWeb;

namespace GiApiGeral.Classe
{
    public class FuncionarioSelecaoApi : BaseApi<TB_FuncionarioSelecaoAPI>, IFuncionarioSelecaoApi
    {
        public readonly IConfiguracaoApiGeralModel _conf;
        public FuncionarioSelecaoApi(IConfiguracaoApiGeralModel conf) : base("FuncionarioSelecao", conf) { _conf = conf; }

        public async Task<TB_FuncionarioSelecaoAPI> GetAll(short CodigoEmpresa, short CodigoFilial, int CodigoFuncionario)
        {
            var Resp = await GetAllJson(new GetData()
            {
                where = new List<Where>() {
                new Where() { campo = "CodigoEmpresa", valor = CodigoEmpresa.ToString() },
                new Where() { campo = "CodigoFilial", valor = CodigoFilial.ToString() },
                new Where() { campo = "CodigoFuncionario", valor = CodigoFuncionario.ToString() }
            }
            });

            return Resp.FirstOrDefault();
        }

        public async Task<List<FuncionarioSelecaoCompleto>> GetAllCompleto()
        {
            var BaseApi = new BaseApi<FuncionarioSelecaoCompleto>("FuncionarioSelecao", _conf);
            var Resp = await BaseApi.GetAll();
            return Resp;
        }

        public async Task<FuncionarioSelecaoCompleto> GetAllCompleto(short CodigoEmpresa, short CodigoFilial, int CodigoFuncionario)
        {
            var BaseApi = new BaseApi<FuncionarioSelecaoCompleto>("FuncionarioSelecao", _conf);

            var Resp = await BaseApi.GetAllJson(new GetData()
            {
                where = new List<Where>() {
                new Where() { campo = "CodigoEmpresa", valor = CodigoEmpresa.ToString() },
                new Where() { campo = "CodigoFilial", valor = CodigoFilial.ToString() },
                new Where() { campo = "CodigoFuncionario", valor = CodigoFuncionario.ToString() }
            }
            });

            return Resp.FirstOrDefault();
        }

    }
}
