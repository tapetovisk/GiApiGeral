using GiApiGeral.Interface.Base;
using GiApiGeral.Model;
using Service.Domain.EntitiesGIWeb;

namespace GiApiGeral.Interface
{
    public interface IFuncionarioSelecaoApi : IBaseApi<TB_FuncionarioSelecaoAPI>
    {
        Task<TB_FuncionarioSelecaoAPI> GetAll(short CodigoEmpresa, short CodigoFilial, int CodigoFuncionario);
        Task<FuncionarioSelecaoCompleto> GetAllCompleto(short CodigoEmpresa, short CodigoFilial, int CodigoFuncionario);
        Task<List<FuncionarioSelecaoCompleto>> GetAllCompleto();
    }
}
