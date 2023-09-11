using Bogus;
using GiApiGeral.Classe;
using Service.Apis.ApiGeral.Model;
using Service.Domain.EntitiesGIWeb;

namespace TesteDiApiGeral.Classe
{
    public class CentroCustoApiTest
    {
        private CentroCustoApi _centroCustoApi;
        private TB_CentroCusto _centroCusto;

        public CentroCustoApiTest()
        {
            _centroCustoApi = new CentroCustoApi(new Config());
            var _centroCustos = GeraModel(5);
            _centroCusto = _centroCustos[1];
        }

        public List<TB_CentroCusto> GeraModel(int quantidade)
        {
            var CBOFaker = new Faker<TB_CentroCusto>("pt_BR")
                .RuleFor(c => c.CodigoEmpresa, f => f.Random.Short(0, 999))
                .RuleFor(c => c.CodigoFilial, f => f.Random.Short(0,999))
                .RuleFor(c => c.CodigoCliente, f => f.Random.Int(0, 999))
                .RuleFor(c => c.CodigoCentroCusto, f => f.Random.Int(0, 999))
                .RuleFor(c => c.NomeCentroCusto, f => f.Random.String2(1, 10))
                .RuleFor(c => c.Endereco, f => f.Address.StreetAddress())
                .RuleFor(c => c.NroEndereco, f => f.Random.Int());

            List<TB_CentroCusto> model = CBOFaker.Generate(quantidade);
            model[1].NomeCentroCusto = "Teste Packet";

            return model;
        }

        [Fact]
        public async Task Add()
        {
            var _centroCustos = GeraModel(5);
            TB_CentroCusto CBO = _centroCustos[1];

            var Resp = await _centroCustoApi.Add(CBO);
            if (Resp.Sucess)
            {
                _centroCustos[1].IDRegistroWeb = int.Parse(Resp.IDRetorno);
                _centroCusto = _centroCustos[1];
            }

            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task GetAll()
        {
            var Resp = await _centroCustoApi.GetAll();
            Assert.True(Resp.Any());
        }

        [Fact]
        public async Task GetAllJson()
        {
            if (_centroCusto == null || _centroCusto.IDRegistroWeb == 0)
            {
                var Resp = await _centroCustoApi.GetAllJson(new GetData() { where = new List<Where>() { new Where() { campo = "NomeCentroCusto", valor = "Teste Packet" } } });
                _centroCusto = Resp.FirstOrDefault();

                if (_centroCusto == null) await Add();

                Assert.True(Resp.Any());
            }
        }

        [Fact]
        public async Task GetById()
        {
            await GetAllJson();
            var Resp = await _centroCustoApi.GetById(_centroCusto.IDRegistroWeb);
            Assert.True(Resp != null);
        }

        [Fact]
        public async Task Update()
        {
            await GetAllJson();
            _centroCusto.NomeCentroCusto = "Teste Upd";

            var Resp = await _centroCustoApi.Update(_centroCusto);
            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task Delete()
        {
            await GetAllJson();
            var Resp = await _centroCustoApi.Delete(_centroCusto);
            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task DeleteJson()
        {
            await GetAllJson();
            var Resp = await _centroCustoApi.DeleteJson(new GetData() { where = new List<Where>() { new Where() { campo = "NomeCentroCusto", valor = "Teste Packet" } } });
            Assert.True(string.IsNullOrEmpty(Resp), Resp);
        }
    }
}
