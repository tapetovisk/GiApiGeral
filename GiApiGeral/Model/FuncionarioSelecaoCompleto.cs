using Service.Domain.EntitiesGIWeb;

namespace GiApiGeral.Model
{
    public class FuncionarioSelecaoCompleto : TB_FuncionarioSelecaoAPI
    {
        public List<TB_FuncionarioDependenteSelecaoAPI> FuncionarioDependenteSelecao { get; set; }
    }
}
