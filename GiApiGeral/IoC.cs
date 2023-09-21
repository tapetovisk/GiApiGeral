using GiApiGeral.Classe;
using GiApiGeral.Controles;
using GiApiGeral.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace GiApiGeral
{
    public static class NativeInjectorConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<ICBOApi, CBOApi>();
            services.AddSingleton<ICentroCustoApi, CentroCustoApi>();
            services.AddSingleton<IFuncaoApi, FuncaoApi>();
            services.AddSingleton<IFuncionarioApi, FuncionarioApi>();
            services.AddSingleton<IFuncionarioDependenteSelecaoApi, FuncionarioDependenteSelecaoApi>();
            services.AddSingleton<IFuncionarioSelecaoApi, FuncionarioSelecaoApi>();
            services.AddSingleton<IHorarioApi, HorarioApi>();
            services.AddSingleton<IFuncionarioControles, FuncionarioControles>();
        }
    }
}
