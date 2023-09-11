using Bogus;
using GiApiGeral.Classe;
using Service.Apis.ApiGeral.Model;
using Service.Domain.EntitiesGIWeb;

namespace TesteDiApiGeral.Classe
{
    public class HorarioApiTeste
    {
        private HorarioApi _horarioApi;
        private TB_Horario _horario;

        public HorarioApiTeste()
        {
            _horarioApi = new HorarioApi(new Config());
            var _horarios = GeraModel(5);
            _horario = _horarios[1];
        }

        public List<TB_Horario> GeraModel(int quantidade)
        {
            var HorarioFaker = new Faker<TB_Horario>("pt_BR")
                .RuleFor(c => c.CodigoHorario, f => f.Random.Int(0, 999))
                .RuleFor(c => c.EscalaDiasTrabalho, f => f.Random.Int(0, 30))
                .RuleFor(c => c.EscalaDiasDescanco, f => f.Random.Int(0, 30))
                .RuleFor(c => c.InclusaoOK, f => f.Random.Bool(1))
                .RuleFor(c => c.PagarVR_Dom, f => f.Random.Bool(1))
                .RuleFor(c => c.PagarVR_Qua, f => f.Random.Bool(1))
                .RuleFor(c => c.PagarVR_Qui, f => f.Random.Bool(1))
                .RuleFor(c => c.PagarVR_Sab, f => f.Random.Bool(1))
                .RuleFor(c => c.PagarVR_Seg, f => f.Random.Bool(1))
                .RuleFor(c => c.PagarVR_Sex, f => f.Random.Bool(1))
                .RuleFor(c => c.PagarVR_Ter, f => f.Random.Bool(1))
                .RuleFor(c => c.CodigoEvento_ANDom, f => f.Random.Short(1))
                .RuleFor(c => c.CodigoEvento_ANQua, f => f.Random.Short(1))
                .RuleFor(c => c.CodigoEvento_ANQui, f => f.Random.Short(1))
                .RuleFor(c => c.CodigoEvento_ANSab, f => f.Random.Short(1))
                .RuleFor(c => c.CodigoEvento_ANSeg, f => f.Random.Short(1))
                .RuleFor(c => c.CodigoEvento_ANSex, f => f.Random.Short(1))
                .RuleFor(c => c.CodigoEvento_ANTer, f => f.Random.Short(1))
                .RuleFor(c => c.EscalaPorFuncionario , f => f.Random.Bool(1))
                .RuleFor(c => c.deltaEntrada, f => f.Random.Short(1))
                .RuleFor(c => c.deltaSaida, f => f.Random.Short(1))
                .RuleFor(c => c.perHorFlexivel , f => f.Random.Bool(1))
                .RuleFor(c => c.Inativo, f => f.Random.Bool(1))
                .RuleFor(c => c.APISinc, f => f.Random.Bool(1))
                ;

            List<TB_Horario> model = HorarioFaker.Generate(quantidade);
            model[1].Descricao = $"Teste Packet";

            return model;
        }

        [Fact]
        public async Task Add()
        {
            var _horarios = GeraModel(5);
            TB_Horario Horario = _horarios[1];

            var Resp = await _horarioApi.Add(Horario);
            if (Resp.Sucess)
            {
                _horarios[1].IDRegistroWeb = int.Parse(Resp.IDRetorno);
                _horario = _horarios[1];
            }

            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task GetAll()
        {
            var Resp = await _horarioApi.GetAll();
            Assert.True(Resp.Any());
        }

        [Fact]
        public async Task GetAllJson()
        {
            if (_horario == null || _horario.IDRegistroWeb == 0)
            {
                var Resp = await _horarioApi.GetAllJson(new GetData() { where = new List<Where>() { new Where() { campo = "Descricao", valor = "Teste Packet" } } });
                _horario = Resp.FirstOrDefault();

                if (_horario == null) await Add();

                Assert.True(Resp.Any());
            }
        }

        [Fact]
        public async Task GetById()
        {
            await GetAllJson();
            var Resp = await _horarioApi.GetById(_horario.IDRegistroWeb);
            Assert.True(Resp != null);
        }

        [Fact]
        public async Task Update()
        {
            await GetAllJson();
            _horario.Descricao = "Teste Upd";

            var Resp = await _horarioApi.Update(_horario);
            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task Delete()
        {
            await GetAllJson();
            var Resp = await _horarioApi.Delete(_horario);
            Assert.True(Resp.Sucess, Resp.Mensage);
        }

        [Fact]
        public async Task DeleteJson()
        {
            await GetAllJson();
            var Resp = await _horarioApi.DeleteJson(new GetData() { where = new List<Where>() { new Where() { campo = "Descricao", valor = "Teste Packet" } } });
            Assert.True(string.IsNullOrEmpty(Resp), Resp);
        }
    }
}
