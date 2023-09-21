using GiApiGeral.Interface;

namespace TesteDiApiGeral
{
    public class Config : IConfiguracaoApiGeralModel
    {
        public string Url { get; set; } = "https://apigeral.gi.app.br";
        public string IdClienteWeb { get; set; } = "[IDCLIENTEWEB]";
        public string ChaveAcesso { get; set; } = "[CHAVEACESSO]";
        public string Login { get; set; } = "[SEULOGIN]";
        public string Senha { get; set; } = "[SUA SENHA]";
    }
}
