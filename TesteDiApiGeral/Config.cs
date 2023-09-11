using GiApiGeral.Interface;

namespace TesteDiApiGeral
{
    public class Config : IConfiguracaoApiGeralModel
    {
        public string Url { get; set; } = "https://apigeral.gi.app.br";
        public string IdClienteWeb { get; set; } = "testegi";
        public string ChaveAcesso { get; set; } = "0d79b9f2-b2fc-4fba-96ea-9f1baa81e5c7";
        public string Login { get; set; } = "anderson";
        public string Senha { get; set; } = "andersonIRGIWEB";
    }
}
