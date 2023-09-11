using Bogus;
using GiApiGeral.Classe;
using Service.Apis.ApiGeral.Model;
using Service.Domain.EntitiesGIWeb;

namespace TesteDiApiGeral.Classe
{
    public class FuncionarioDependenteSelecaoAPITest
    {
        private FuncionarioDependenteSelecaoApi _funcionarioDependenteSelecaoApi;
        private TB_FuncionarioDependenteSelecaoAPI _funcionarioDependenteSelecao;

        public FuncionarioDependenteSelecaoAPITest()
        {
            _funcionarioDependenteSelecaoApi = new FuncionarioDependenteSelecaoApi(new Config());
            var _funcionarioDependenteSelecaos = GeraModel(5);
            _funcionarioDependenteSelecao = _funcionarioDependenteSelecaos[1];
        }

        public List<TB_FuncionarioDependenteSelecaoAPI> GeraModel(int quantidade)
        {
            var FuncionarioDependenteSelecaoFaker = new Faker<TB_FuncionarioDependenteSelecaoAPI>("pt_BR")
                .RuleFor(c => c.CodigoEmpresa, f => f.Random.Short(0, 999))
                .RuleFor(c => c.CodigoFilial, f => f.Random.Short(0, 999))
                .RuleFor(c => c.CodigoFuncionario, f => f.Random.Int(0, 999))
                .RuleFor(c => c.Nome, f => f.Name.FullName())
                ;

            List<TB_FuncionarioDependenteSelecaoAPI> model = FuncionarioDependenteSelecaoFaker.Generate(quantidade);
            model[1].Nome = $"Teste Packet";

            return model;
        }

        [Fact]
        public async Task Add()
        {
            var _funcionarioDependenteSelecaos = GeraModel(5);
            TB_FuncionarioDependenteSelecaoAPI FuncionarioDependenteSelecao = _funcionarioDependenteSelecaos[1];

            var Resp = await _funcionarioDependenteSelecaoApi.Add(FuncionarioDependenteSelecao);
            if (Resp.Sucess)
            {
                _funcionarioDependenteSelecaos[1].IDRegistroWeb = int.Parse(Resp.IDRetorno);
                _funcionarioDependenteSelecao = _funcionarioDependenteSelecaos[1];
            }

            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task GetAll()
        {
            var Resp = await _funcionarioDependenteSelecaoApi.GetAll();
            Assert.True(Resp.Any());
        }

        [Fact]
        public async Task GetAllJson()
        {
            if (_funcionarioDependenteSelecao == null || _funcionarioDependenteSelecao.IDRegistroWeb == 0)
            {
                var Resp = await _funcionarioDependenteSelecaoApi.GetAllJson(new GetData() { where = new List<Where>() { new Where() { campo = "Nome", valor = "Teste Packet" } } });
                _funcionarioDependenteSelecao = Resp.FirstOrDefault();

                if (_funcionarioDependenteSelecao == null) await Add();

                Assert.True(Resp.Any());
            }
        }

        [Fact]
        public async Task GetById()
        {
            await GetAllJson();
            var Resp = await _funcionarioDependenteSelecaoApi.GetById(_funcionarioDependenteSelecao.IDRegistroWeb);
            Assert.True(Resp != null);
        }

        [Fact]
        public async Task Update()
        {
            await GetAllJson();
            _funcionarioDependenteSelecao.Nome = "Teste Upd";

            var Resp = await _funcionarioDependenteSelecaoApi.Update(_funcionarioDependenteSelecao);
            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task Delete()
        {
            await GetAllJson();
            var Resp = await _funcionarioDependenteSelecaoApi.Delete(_funcionarioDependenteSelecao);
            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task DeleteJson()
        {
            await GetAllJson();
            var Resp = await _funcionarioDependenteSelecaoApi.DeleteJson(new GetData() { where = new List<Where>() { new Where() { campo = "Nome", valor = "Teste Packet" } } });
            Assert.True(string.IsNullOrEmpty(Resp), Resp);
        }
    }
}
