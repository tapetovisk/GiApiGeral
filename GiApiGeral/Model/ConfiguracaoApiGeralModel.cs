using GiApiGeral.Interface;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Service.Apis.ApiGeral.Model
{
    public class ConfiguracaoApiGeralModel : IConfiguracaoApiGeralModel
    {
        [Display(Name = "Url")]
        public string Url { get; set; }

        [Display(Name = "IdClienteWeb")]
        public string IdClienteWeb { get; set; }

        [Display(Name = "Chave Acesso")]
        public string ChaveAcesso { get; set; }

        [Display(Name = "Login")]
        public string Login { get; set; }

        [Display(Name = "Senha")]
        public string Senha { get; set; }
        
    }

    public class Token
    {
        public DateTime validTo { get; set; }
        public string value { get; set; }
    }

    public class GetData
    {
        public List<Where> where { get; set; }
        public List<string> select { get; set; }
        public List<string> orderBy { get; set; }
    }

    public class Where
    {
        public string campo { get; set; }
        public string valor { get; set; }
    }

    public class MsgReturn
    {
        [JsonPropertyName("sucess")]
        public bool Sucess { get; set; }

        [JsonPropertyName("idRetorno")]
        public string IDRetorno { get; set; }

        [JsonPropertyName("mensage")]
        public string Mensage { get; set; }

        [JsonPropertyName("campoErro")]
        public string CampoErro { get; set; }

        [JsonPropertyName("obs")]
        public string Obs { get; set; }
    }

    }
