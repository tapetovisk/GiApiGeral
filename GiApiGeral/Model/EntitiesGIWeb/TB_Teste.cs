using Service.Domain.EntitiesGIWeb.Base;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_Teste : BaseTB
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNacimento { get; set; }
        public bool Status { get; set; }
    }
}
