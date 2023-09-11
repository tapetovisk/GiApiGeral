using GiApiGeral.Classe;
using GiApiGeral.Interface;

namespace TestGiApiGeral.Classe
{
    public class CBOApiTest
    {
        private CBOApi _cBOApi;

        [SetUp]
        public void Setup()
        {
            _cBOApi = new CBOApi(new Config());
        }

        [Test]
        public async Task Add()
        {
            var CBO = new Service.Domain.EntitiesGIWeb.TB_CBO() { };

            var Resp =  await _cBOApi.Add(CBO);

            if (Resp.Sucess)
                Assert.Pass(Resp.Mensage);
            else 
                Assert.Fail(Resp.Mensage, Resp);
        }


        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
