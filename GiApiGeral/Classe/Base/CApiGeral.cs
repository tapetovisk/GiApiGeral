using GiApiGeral.Interface;
using Newtonsoft.Json;
using Service.Apis.ApiGeral.Model;
using System.Net;
using System.Net.Http.Headers;
using System.Text;

namespace Service.Apis.ApiGeral.Classe.Base
{
    public class CApiGeral
    {
        private readonly HttpClient client = new HttpClient();
        private readonly IConfiguracaoApiGeralModel _ConfigApiGeral;
        private Token _Token { get; set; }
        public bool Auteticado { get; set; }

        public CApiGeral(IConfiguracaoApiGeralModel conf)
        {
            _ConfigApiGeral = conf;
            Auteticado = false;
        }

        public async Task<CApiGeral> GetToken()
        {
            if (_ConfigApiGeral != null)
            {
                client.BaseAddress = new Uri(_ConfigApiGeral.Url);

                Token TokenConexao = await Post<Token>("/api/v1/conexao/verificaconexao",
                    new { idClienteWeb = _ConfigApiGeral.IdClienteWeb, chaveAcesso = _ConfigApiGeral.ChaveAcesso });

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenConexao.value);

                _Token = await Post<Token>("/api/v1/login/login",
                    new { login = _ConfigApiGeral.Login, senha = _ConfigApiGeral.Senha });

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _Token.value);

            }
            return this;
        }

        #region Metodos

        protected async Task<t> Get<t>(string uri)
        {

            if (_Token != null && _Token.validTo < GetCurrentTime()) await GetToken();

            HttpResponseMessage Result = await client.GetAsync(uri);

            if (Result.StatusCode == HttpStatusCode.OK)
            {
                var Resp = Result.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<t>(Resp);
            }
            return default;
        }

        protected async Task<t> Post<t>(string uri, object data)
        {

            if (_Token != null && _Token.validTo < GetCurrentTime()) await GetToken();

            HttpResponseMessage Result = await client.PostAsync(uri, ConvertJson(data));

            if (Result.StatusCode == HttpStatusCode.OK)
            {
                var Resp = Result.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<t>(Resp);
            }
            return default;
        }

        private HttpContent ConvertJson<t>(t data)
        {
            string json = ConvertStringJson(data);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
        private string ConvertStringJson<t>(t data) => JsonConvert.SerializeObject(data);

        public static DateTime GetCurrentTime()
        {
            DateTime serverTime = DateTime.Now;
            DateTime _localTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(serverTime, TimeZoneInfo.Local.Id, "E. South America Standard Time");
            return _localTime;
        }

        #endregion
    }
}
