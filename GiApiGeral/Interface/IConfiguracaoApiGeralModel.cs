using Service.Apis.ApiGeral.Model;

namespace GiApiGeral.Interface
{
    public interface IConfiguracaoApiGeralModel
    {
        public string Url { get; set; }
        public string IdClienteWeb { get; set; }
        public string ChaveAcesso { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
