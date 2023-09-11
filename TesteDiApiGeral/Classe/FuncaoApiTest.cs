using Bogus;
using GiApiGeral.Classe;
using Service.Apis.ApiGeral.Model;
using Service.Domain.EntitiesGIWeb;

namespace TesteDiApiGeral.Classe
{
    public class FuncaoApiTest
    {
        private FuncaoApi _funcaoApi;
        private TB_Funcao _funcao;

        public FuncaoApiTest()
        {
            _funcaoApi = new FuncaoApi(new Config());
            var _funcaos = GeraModel(5);
            _funcao = _funcaos[1];
        }

        public List<TB_Funcao> GeraModel(int quantidade)
        {
            var CBOFaker = new Faker<TB_Funcao>("pt_BR")
                .RuleFor(c => c.CodigoFuncao, f => f.Random.Int(0, 999))
                .RuleFor(c => c.Descricao, f => f.Random.String2(1, 10))
                .RuleFor(c => c.CBO, f => f.Random.String2(1, 10))
                .RuleFor(c => c.InclusaoOK, f => f.Random.Bool(1))
                .RuleFor(c => c.CBONovo, f => f.Random.Int(0, 999))
                .RuleFor(c => c.OcupacaoIRF, f => f.Random.Int(0, 999))
                .RuleFor(c => c.CodigoEvento1, f => f.Random.Short(0, 999))
                .RuleFor(c => c.CodigoEvento2, f => f.Random.Short(0, 999))
                .RuleFor(c => c.CodigoEventoDif1, f => f.Random.Short(0, 999))
                .RuleFor(c => c.CodigoEventoDif2, f => f.Random.Short(0, 999))
                .RuleFor(c => c.Inativo, f => f.Random.Bool(1))
                .RuleFor(c => c.acumCargo, f => f.Random.Byte(1, 9))
                .RuleFor(c => c.contagemEsp, f => f.Random.Byte(1, 9))
                .RuleFor(c => c.dedicExcl, f => f.Random.Bool(1))
                .RuleFor(c => c.sitCargo, f => f.Random.Byte(1, 9))
                .RuleFor(c => c.APISinc, f => f.Random.Bool(1));

            List<TB_Funcao> model = CBOFaker.Generate(quantidade);
            model[1].Descricao = "Teste Packet";

            return model;
        }

        [Fact]
        public async Task Add()
        {
            var _funcaos = GeraModel(5);
            TB_Funcao CBO = _funcaos[1];

            var Resp = await _funcaoApi.Add(CBO);
            if (Resp.Sucess)
            {
                _funcaos[1].IDRegistroWeb = int.Parse(Resp.IDRetorno);
                _funcao = _funcaos[1];
            }

            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task GetAll()
        {
            var Resp = await _funcaoApi.GetAll();
            Assert.True(Resp.Any());
        }

        [Fact]
        public async Task GetAllJson()
        {
            if (_funcao == null || _funcao.IDRegistroWeb == 0)
            {
                var Resp = await _funcaoApi.GetAllJson(new GetData() { where = new List<Where>() { new Where() { campo = "Descricao", valor = "Teste Packet" } } });
                _funcao = Resp.FirstOrDefault();

                if (_funcao == null) await Add();

                Assert.True(Resp.Any());
            }
        }

        [Fact]
        public async Task GetById()
        {
            await GetAllJson();
            var Resp = await _funcaoApi.GetById(_funcao.IDRegistroWeb);
            Assert.True(Resp != null);
        }

        [Fact]
        public async Task Update()
        {
            await GetAllJson();
            _funcao.Descricao = "Teste Upd";

            var Resp = await _funcaoApi.Update(_funcao);
            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task Delete()
        {
            await GetAllJson();
            var Resp = await _funcaoApi.Delete(_funcao);
            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task DeleteJson()
        {
            await GetAllJson();
            var Resp = await _funcaoApi.DeleteJson(new GetData() { where = new List<Where>() { new Where() { campo = "Descricao", valor = _funcao.Descricao } } });
            Assert.True(string.IsNullOrEmpty(Resp), Resp);
        }



    }
}
