using Bogus;
using GiApiGeral.Classe;
using Service.Apis.ApiGeral.Model;
using Service.Domain.EntitiesGIWeb;

namespace TesteDiApiGeral.Classe
{
    public class FuncionarioSelecaoAPITest
    {
        private FuncionarioSelecaoApi _funcionarioSelecaoApi;
        private TB_FuncionarioSelecaoAPI _funcionarioSelecao;

        public FuncionarioSelecaoAPITest()
        {
            _funcionarioSelecaoApi = new FuncionarioSelecaoApi(new Config());
            var _funcionarioSelecaos = GeraModel(5);
            _funcionarioSelecao = _funcionarioSelecaos[1];
        }

        public List<TB_FuncionarioSelecaoAPI> GeraModel(int quantidade)
        {
            var FuncionarioSelecaoFaker = new Faker<TB_FuncionarioSelecaoAPI>("pt_BR")
                .RuleFor(c => c.CodigoFuncao, f => f.Random.Int(0, 999))
                .RuleFor(c => c.CodigoEmpresa, f => f.Random.Short(0, 999))
                .RuleFor(c => c.CodigoFilial, f => f.Random.Short(0, 999))
                .RuleFor(c => c.CodigoCliente, f => f.Random.Int(0, 999))
                .RuleFor(c => c.Nome, f => f.Name.FullName())
                ;

            List<TB_FuncionarioSelecaoAPI> model = FuncionarioSelecaoFaker.Generate(quantidade);
            model[1].Nome = $"Teste Packet";

            return model;
        }

        [Fact]
        public async Task Add()
        {
            var _funcionarioSelecaos = GeraModel(5);
            TB_FuncionarioSelecaoAPI FuncionarioSelecao = _funcionarioSelecaos[1];

            var Resp = await _funcionarioSelecaoApi.Add(FuncionarioSelecao);
            if (Resp.Sucess)
            {
                _funcionarioSelecaos[1].IDRegistroWeb = int.Parse(Resp.IDRetorno);
                _funcionarioSelecao = _funcionarioSelecaos[1];
            }

            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task GetAll()
        {
            var Resp = await _funcionarioSelecaoApi.GetAll();
            Assert.True(Resp.Any());
        }

        [Fact]
        public async Task GetAllJson()
        {
            if (_funcionarioSelecao == null || _funcionarioSelecao.IDRegistroWeb == 0)
            {
                var Resp = await _funcionarioSelecaoApi.GetAllJson(new GetData() { where = new List<Where>() { new Where() { campo = "Nome", valor = "Teste Packet" } } });
                _funcionarioSelecao = Resp.FirstOrDefault();

                if (_funcionarioSelecao == null) await Add();

                Assert.True(Resp.Any());
            }
        }

        [Fact]
        public async Task GetById()
        {
            await GetAllJson();
            var Resp = await _funcionarioSelecaoApi.GetById(_funcionarioSelecao.IDRegistroWeb);
            Assert.True(Resp != null);
        }

        [Fact]
        public async Task Update()
        {
            await GetAllJson();
            _funcionarioSelecao.Nome = "Teste Upd";

            var Resp = await _funcionarioSelecaoApi.Update(_funcionarioSelecao);
            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task Delete()
        {
            await GetAllJson();
            var Resp = await _funcionarioSelecaoApi.Delete(_funcionarioSelecao);
            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task DeleteJson()
        {
            await GetAllJson();
            var Resp = await _funcionarioSelecaoApi.DeleteJson(new GetData() { where = new List<Where>() { new Where() { campo = "Nome", valor = "Teste Packet" } } });
            Assert.True(string.IsNullOrEmpty(Resp), Resp);
        }
    }
}
