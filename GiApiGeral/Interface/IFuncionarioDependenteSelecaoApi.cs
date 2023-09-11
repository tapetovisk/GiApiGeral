using GiApiGeral.Interface.Base;
using Service.Domain.EntitiesGIWeb;

namespace GiApiGeral.Interface
{
    public interface IFuncionarioDependenteSelecaoApi : IBaseApi<TB_FuncionarioDependenteSelecaoAPI>
    {
        Task<List<TB_FuncionarioDependenteSelecaoAPI>> GetAll(short CodigoEmpresa, short CodigoFilial, int CodigoFuncionario);
    }
}
