using GiApiGeral.Interface;
using GiApiGeral.Model;
using Service.Apis.ApiGeral.Model;
using Service.Domain.EntitiesGIWeb;

namespace GiApiGeral.Controles
{
    public class FuncionarioControles : IFuncionarioControles
    {
        public readonly IFuncionarioSelecaoApi _iFuncionarioApi;
        public readonly IFuncionarioDependenteSelecaoApi _iFuncionarioDependenteSelecaoApi;

        public FuncionarioControles(IFuncionarioSelecaoApi funcionarioApi, IFuncionarioDependenteSelecaoApi funcionarioDependenteSelecaoApi)
        {
            _iFuncionarioApi = funcionarioApi;
            _iFuncionarioDependenteSelecaoApi = funcionarioDependenteSelecaoApi;
        }

        public async Task<List<MsgReturn>> CadastroFuncionarioSelecaoCompleto(List<FuncionarioSelecaoCompleto> model)
        {
            var Resp = new List<MsgReturn>();
            foreach (var item in model)
            {
                var RespSi = await CadastroFuncionarioSelecaoCompleto(item);
                RespSi.Mensage = $"{item.Nome} - {RespSi.Mensage}";
                Resp.Add(RespSi);
            }
            return Resp;
        }

        public async Task<MsgReturn> CadastroFuncionarioSelecaoCompleto(FuncionarioSelecaoCompleto model)
        {
            if (model.CodigoEmpresa == 0) return new MsgReturn() { Sucess = false, Mensage = "Campo CodigoEmpresa é Obrigatorio!" };
            if (model.CodigoFilial == 0) return new MsgReturn() { Sucess = false, Mensage = "Campo CodigoFilial é Obrigatorio!" };
            if (model.CodigoFuncionario == 0) return new MsgReturn() { Sucess = false, Mensage = "Campo CodigoFuncionario é Obrigatorio!" };
            if (string.IsNullOrEmpty(model.Nome)) return new MsgReturn() { Sucess = false, Mensage = "Campo Nome é Obrigatorio!" };

            if (model.APISincAdmissaoDigital)
            {
                if (string.IsNullOrEmpty(model.Email)) return new MsgReturn() { Sucess = false, Mensage = "Campo Email é Obrigatorio!" };
                if (model.CodigoCliente == null) return new MsgReturn() { Sucess = false, Mensage = "Campo CodigoCliente é Obrigatorio!" };
                if (model.CodigoFuncao == null) return new MsgReturn() { Sucess = false, Mensage = "Campo CodigoFuncao é Obrigatorio!" };
                if (model.DataAdmissao == null) return new MsgReturn() { Sucess = false, Mensage = "Campo DataAdmissao é Obrigatorio!" };
                if (model.Vinculo == null) return new MsgReturn() { Sucess = false, Mensage = "Campo Vinculo é Obrigatorio!" };
                if (model.CodigoHorario == null) return new MsgReturn() { Sucess = false, Mensage = "Campo CodigoHorario é Obrigatorio!" };
                if (model.Salario == null || model.Salario == 0) return new MsgReturn() { Sucess = false, Mensage = "Campo Salario é Obrigatorio!" };
                if (model.SalarioHora == null || model.SalarioHora == 0) return new MsgReturn() { Sucess = false, Mensage = "Campo SalarioHora é Obrigatorio!" };
            }

            var Resp = await CadastroFuncionarioSelecao(model);
            if (!Resp.Sucess) return Resp;

            foreach (var Dependente in model.FuncionarioDependenteSelecao)
            {
                Dependente.CodigoEmpresa = model.CodigoEmpresa;
                Dependente.CodigoFilial = model.CodigoFilial;
                Dependente.CodigoFuncionario = model.CodigoFuncionario;

                var RespDep = await CadastroFuncionarioDependenteSelecao(Dependente);
                if (!RespDep.Sucess) Resp.CampoErro = $"{Resp.CampoErro} ; {Dependente.Nome} - {RespDep.Mensage}";
            }

            return Resp;
        }

        public async Task<MsgReturn> CadastroFuncionarioSelecao(TB_FuncionarioSelecaoAPI model)
            => await _iFuncionarioApi.Add(model);

        public async Task<MsgReturn> CadastroFuncionarioDependenteSelecao(TB_FuncionarioDependenteSelecaoAPI model)
            => await _iFuncionarioDependenteSelecaoApi.Add(model);

        public async Task<List<FuncionarioSelecaoCompleto>> BuscarFuncionarioSelecaoCompleto()
        {
            var LstFunc = await _iFuncionarioApi.GetAllCompleto();
            var LstFuncCompleto = new List<FuncionarioSelecaoCompleto>();

            foreach (var func in LstFunc)
            {

                var LstDependenteSelecao = await _iFuncionarioDependenteSelecaoApi.GetAll(func.CodigoEmpresa, func.CodigoFilial, func.CodigoFuncionario);

                if (LstDependenteSelecao.Any())
                {
                    func.FuncionarioDependenteSelecao = LstDependenteSelecao;
                }
                LstFuncCompleto.Add(func);
            }
            return LstFuncCompleto;
        }

        public async Task<FuncionarioSelecaoCompleto> BuscarFuncionarioSelecaoCompleto(short CodigoEmpresa, short CodigoFilial, int CodigoFuncionario)
        {
            var Func = await _iFuncionarioApi.GetAllCompleto(CodigoEmpresa, CodigoFilial, CodigoFuncionario);

            FuncionarioSelecaoCompleto FuncCompleto = Func as FuncionarioSelecaoCompleto;

            FuncCompleto.FuncionarioDependenteSelecao = await _iFuncionarioDependenteSelecaoApi.GetAll(Func.CodigoEmpresa, Func.CodigoFilial, Func.CodigoFuncionario);

            return FuncCompleto;
        }
    }
}
