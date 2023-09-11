using GiApiGeral.Model;
using Service.Apis.ApiGeral.Model;
using Service.Domain.EntitiesGIWeb;

namespace GiApiGeral.Interface
{
    public interface IFuncionarioControles
    {
        Task<List<MsgReturn>> CadastroFuncionarioSelecaoCompleto(List<FuncionarioSelecaoCompleto> model);
        Task<MsgReturn> CadastroFuncionarioSelecaoCompleto(FuncionarioSelecaoCompleto model);
        Task<MsgReturn> CadastroFuncionarioSelecao(TB_FuncionarioSelecaoAPI model);
        Task<MsgReturn> CadastroFuncionarioDependenteSelecao(TB_FuncionarioDependenteSelecaoAPI model);
        Task<List<FuncionarioSelecaoCompleto>> BuscarFuncionarioSelecaoCompleto();
        Task<FuncionarioSelecaoCompleto> BuscarFuncionarioSelecaoCompleto(short CodigoEmpresa, short CodigoFilial, int CodigoFuncionario);
    }
}
