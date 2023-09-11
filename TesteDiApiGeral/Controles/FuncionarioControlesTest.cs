using Bogus;
using Bogus.Extensions;
using GiApiGeral.Classe;
using GiApiGeral.Controles;
using GiApiGeral.Model;
using Service.Domain.EntitiesGIWeb;

namespace TesteDiApiGeral.Controles
{
    public class FuncionarioControlesTest
    {
        public readonly FuncionarioControles _funcionarioControles;
        public List<FuncionarioSelecaoCompleto> _funcionarioSelecaoCompleto;

        public FuncionarioControlesTest()
        {
            _funcionarioControles = new FuncionarioControles(new FuncionarioSelecaoApi(new Config()), new FuncionarioDependenteSelecaoApi(new Config()));
            _funcionarioSelecaoCompleto = GeraModel(5);
        }

        public List<FuncionarioSelecaoCompleto> GeraModel(int quantidade)
        {
            var FuncionarioSelecaoCompletoFaker = new Faker<FuncionarioSelecaoCompleto>("pt_BR")
                .RuleFor(c => c.CodigoFuncao, f => f.Random.Int(0, 999))
                .RuleFor(c => c.CodigoEmpresa, f => f.Random.Short(0, 999))
                .RuleFor(c => c.CodigoFilial, f => f.Random.Short(0, 999))
                .RuleFor(c => c.CodigoCliente, f => f.Random.Int(0, 999))
                .RuleFor(c => c.Nome, f => f.Name.FullName())
                .RuleFor(c => c.CodigoFuncionario, f => f.Random.Int(0, 999))
                .RuleFor(c => c.APISincAdmissaoDigital, f => f.Random.Bool())
                .RuleFor(c => c.Email, f => f.Person.Email)
                .RuleFor(c => c.DataAdmissao, f => f.Date.Future(1))
                .RuleFor(c => c.CodigoHorario, f => f.Random.Int(0, 999))
                .RuleFor(c => c.Salario, f => f.Random.Decimal2())
                .RuleFor(c => c.SalarioHora, f => f.Random.Decimal2())
                ;

            List<FuncionarioSelecaoCompleto> model = FuncionarioSelecaoCompletoFaker.Generate(quantidade);

            foreach (var item in model)
            {
                item.Nome = $"Teste Packet - {item.CodigoFuncionario}";
                item.Vinculo = "1";
                item.FuncionarioDependenteSelecao = GeraModelDependente(quantidade, item.CodigoFuncionario);
            }

            return model;
        }

        public List<TB_FuncionarioDependenteSelecaoAPI> GeraModelDependente(int quantidade, int CodigoFuncionario)
        {
            var FuncionarioDependenteSelecaoFaker = new Faker<TB_FuncionarioDependenteSelecaoAPI>("pt_BR")
                .RuleFor(c => c.CodigoEmpresa, f => f.Random.Short(0, 999))
                .RuleFor(c => c.CodigoFilial, f => f.Random.Short(0, 999))
                .RuleFor(c => c.Nome, f => f.Name.FullName())
                ;

            List<TB_FuncionarioDependenteSelecaoAPI> model = FuncionarioDependenteSelecaoFaker.Generate(quantidade);

            foreach (var item in model)
            {
                item.CodigoFuncionario = CodigoFuncionario;
                item.Nome = $"Teste Packet - {CodigoFuncionario}";
            }
            return model;
        }

        [Fact]
        public async Task CadastroFuncionarioSelecaoCompletoLst()
        {
            var Resp = await _funcionarioControles.CadastroFuncionarioSelecaoCompleto(_funcionarioSelecaoCompleto);

            var Teste = true;
            var Msg = "";

            foreach (var item in Resp)
            {
                if (!item.Sucess)
                {
                    Teste = false;
                    Msg = $"{Msg} - {item.Mensage}";
                }
            }
            Assert.True(Teste, Msg);
        }

        [Fact]
        public async Task CadastroFuncionarioSelecaoCompleto()
        {
            var Resp = await _funcionarioControles.CadastroFuncionarioSelecaoCompleto(_funcionarioSelecaoCompleto[0]);

            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task BuscarFuncionarioSelecaoCompletoLst() {
            var Resp = await _funcionarioControles.BuscarFuncionarioSelecaoCompleto();
            Assert.True(Resp.Any());
        }

        [Fact]
        public async Task BuscarFuncionarioSelecaoCompleto() {

            await CadastroFuncionarioSelecaoCompletoLst();

            if (_funcionarioSelecaoCompleto.Any())
            {
                var Resp = await _funcionarioControles.BuscarFuncionarioSelecaoCompleto(
                _funcionarioSelecaoCompleto[0].CodigoEmpresa,
                _funcionarioSelecaoCompleto[0].CodigoFilial,
                _funcionarioSelecaoCompleto[0].CodigoFuncionario);
                Assert.True(Resp != null);
            }
        }
    }
}
