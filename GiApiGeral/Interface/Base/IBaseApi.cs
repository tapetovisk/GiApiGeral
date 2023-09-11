using Service.Apis.ApiGeral.Model;

namespace GiApiGeral.Interface.Base
{
    public interface IBaseApi<t>
    {
        Task<List<t>> GetAll();
        Task<List<t>> GetAllJson(GetData data);
        Task<t> GetById(int id);
        Task<MsgReturn> Add(t data);
        Task<MsgReturn> Update(t data);
        Task<MsgReturn> Delete(t data);
        Task<string> DeleteJson(GetData data);
    }
}
