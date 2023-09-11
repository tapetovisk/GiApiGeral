using GiApiGeral.Classe.Base;
using GiApiGeral.Interface;
using Service.Domain.EntitiesGIWeb;

namespace GiApiGeral.Classe
{
    public class HorarioApi : BaseApi<TB_Horario>, IHorarioApi
    {
        public HorarioApi(IConfiguracaoApiGeralModel conf) : base("Horario", conf) { }
    }
}
