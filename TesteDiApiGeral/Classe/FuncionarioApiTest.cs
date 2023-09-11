using Bogus;
using GiApiGeral.Classe;
using Service.Apis.ApiGeral.Model;
using Service.Domain.EntitiesGIWeb;

namespace TesteDiApiGeral.Classe
{
    public class FuncionarioApiTest
    {
        private FuncionarioApi _funcionarioApi;
        private TB_Funcionario _funcionario;

        public FuncionarioApiTest()
        {
            _funcionarioApi = new FuncionarioApi(new Config());
            var _funcionarios = GeraModel(5);
            _funcionario = _funcionarios[1];
        }

        public List<TB_Funcionario> GeraModel(int quantidade)
        {
            var FuncionarioFaker = new Faker<TB_Funcionario>("pt_BR")
                .RuleFor(c => c.CodigoFuncao, f => f.Random.Int(0, 999))
                .RuleFor(c => c.CodigoEmpresa, f => f.Random.Int(0, 999))
                .RuleFor(c => c.CodigoFilial, f => f.Random.Int(0, 999))
                .RuleFor(c => c.CodigoCliente, f => f.Random.Int(0, 999))
                .RuleFor(c => c.Nome, f => f.Name.FullName())
                .RuleFor(c => c.TaxaCom1, f => f.Random.Decimal())
                .RuleFor(c => c.TaxaCom2, f => f.Random.Decimal())
                .RuleFor(c => c.NroCartaoURBS, f => f.Random.String2(1, 10))
                ;

            List<TB_Funcionario> model = FuncionarioFaker.Generate(quantidade);
            model[1].Nome = $"Teste Packet";

            return model;
        }

        [Fact]
        public async Task Add()
        {
            var _funcionarios = GeraModel(5);
            TB_Funcionario Funcionario = _funcionarios[1];

            var Resp = await _funcionarioApi.Add(Funcionario);
            if (Resp.Sucess)
            {
                _funcionarios[1].IDRegistroWeb = int.Parse(Resp.IDRetorno);
                _funcionario = _funcionarios[1];
            }

            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task GetAll()
        {
            var Resp = await _funcionarioApi.GetAll();
            Assert.True(Resp.Any());
        }

        [Fact]
        public async Task GetAllJson()
        {
            if (_funcionario == null || _funcionario.IDRegistroWeb == 0)
            {
                var Resp = await _funcionarioApi.GetAllJson(new GetData() { where = new List<Where>() { new Where() { campo = "Nome", valor = "Teste Packet" } } });
                _funcionario = Resp.FirstOrDefault();

                if (_funcionario == null) await Add();

                Assert.True(Resp.Any());
            }
        }

        [Fact]
        public async Task GetById()
        {
            await GetAllJson();
            var Resp = await _funcionarioApi.GetById(_funcionario.IDRegistroWeb);
            Assert.True(Resp != null);
        }

        [Fact]
        public async Task Update()
        {
            await GetAllJson();
            _funcionario.Nome = "Teste Upd";

            var Resp = await _funcionarioApi.Update(_funcionario);
            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task Delete()
        {
            await GetAllJson();
            var Resp = await _funcionarioApi.Delete(_funcionario);
            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task DeleteJson()
        {
            await GetAllJson();
            var Resp = await _funcionarioApi.DeleteJson(new GetData() { where = new List<Where>() { new Where() { campo = "Nome", valor = "Teste Packet" } } });
            Assert.True(string.IsNullOrEmpty(Resp), Resp);
        }

    }
}
