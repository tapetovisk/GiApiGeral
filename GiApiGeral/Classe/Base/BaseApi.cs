using GiApiGeral.Interface;
using GiApiGeral.Interface.Base;
using Service.Apis.ApiGeral.Classe.Base;
using Service.Apis.ApiGeral.Model;

namespace GiApiGeral.Classe.Base
{
    public class BaseApi<t> : CApiGeral, IBaseApi<t>
    {
        public readonly string _Uri;

        public BaseApi(string uri, IConfiguracaoApiGeralModel conf) : base(conf) 
        { 
            _Uri = uri;
            _ = base.GetToken().Result;
        }

        public async Task<List<t>> GetAll() => await Get<List<t>>($"/api/v1/{_Uri}/GetAll");
        public async Task<List<t>> GetAllJson(GetData data) => await Post<List<t>>($"/api/v1/{_Uri}/GetAllJson", data);
        public async Task<t> GetById(int id) => await Get<t>($"/api/v1/{_Uri}/Get?id=" + id);
        public async Task<MsgReturn> Add(t data) => await Post<MsgReturn>($"/api/v1/{_Uri}/Add", data);
        public async Task<MsgReturn> Update(t data) => await Post<MsgReturn>($"/api/v1/{_Uri}/Update", data);
        public async Task<MsgReturn> Delete(t data) => await Post<MsgReturn>($"/api/v1/{_Uri}/Delete", data);
        public async Task<string> DeleteJson(GetData data) => await Post<string>($"/api/v1/{_Uri}/DeleteJson", data);

    }
}
