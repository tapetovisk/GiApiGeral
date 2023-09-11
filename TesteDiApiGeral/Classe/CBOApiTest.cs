using Bogus;
using GiApiGeral.Classe;
using Service.Apis.ApiGeral.Model;
using Service.Domain.EntitiesGIWeb;

namespace TesteDiApiGeral.Classe
{
    public class CBOApiTest
    {
        private CBOApi _cBOApi;
        private List<TB_CBO> _cBOs;
        private TB_CBO _cBO;

        public CBOApiTest()
        {
            _cBOApi = new CBOApi(new Config());
            _cBOs = GeraModel(5);
            _cBO = _cBOs[1];
        }

        public List<TB_CBO> GeraModel(int quantidade)
        {
            var CBOFaker = new Faker<TB_CBO>("pt_BR")
                .RuleFor(c => c.CboNovo, f => f.Random.String2(1, 10))
                .RuleFor(c => c.DescricaoFuncao, f => f.Random.String2(1, 20));

            List<TB_CBO> model = CBOFaker.Generate(quantidade);
            model[1].CboNovo = "Teste Packet";

            return model;
        }

        [Fact]
        public async Task Add()
        {
            _cBOs = GeraModel(5);
            TB_CBO CBO = _cBOs[1];

            var Resp = await _cBOApi.Add(CBO);
            if (Resp.Sucess)
            {
                _cBOs[1].IDRegistroWeb = int.Parse(Resp.IDRetorno);
                _cBO = _cBOs[1];
            }

            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task GetAll()
        {
            var Resp = await _cBOApi.GetAll();
            Assert.True(Resp.Any());
        }

        [Fact]
        public async Task GetAllJson()
        {
            if (_cBO == null || _cBO.IDRegistroWeb == 0)
            {
                var Resp = await _cBOApi.GetAllJson(new GetData() { where = new List<Where>() { new Where() { campo = "CboNovo", valor = _cBOs[1].CboNovo } } });
                _cBO = Resp.FirstOrDefault();

                if (_cBO == null) await Add();

                Assert.True(Resp.Any());
            }
        }

        [Fact]
        public async Task GetById()
        {
            await GetAllJson();
            var Resp = await _cBOApi.GetById(_cBO.IDRegistroWeb);
            Assert.True(Resp != null);
        }

        [Fact]
        public async Task Update()
        {
            await GetAllJson();
            _cBO.DescricaoFuncao = "Teste Upd";

            var Resp = await _cBOApi.Update(_cBO);
            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task Delete()
        {
            await GetAllJson();
            var Resp = await _cBOApi.Delete(_cBO);
            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task DeleteJson()
        {
            await GetAllJson();
            var Resp = await _cBOApi.DeleteJson(new GetData() { where = new List<Where>() { new Where() { campo = "CboNovo", valor = _cBO.CboNovo } } });
            Assert.True(string.IsNullOrEmpty(Resp), Resp);
        }
    }
}
