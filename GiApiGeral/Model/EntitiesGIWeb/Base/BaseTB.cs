using System.ComponentModel.DataAnnotations;

namespace Service.Domain.EntitiesGIWeb.Base
{
    public class BaseTB : BaseTBID
    {
        [Key]
        public int IDRegistroWeb { get; set; }


        public string CodigoUsuarioWeb { get; set; }

        public string FiltroUsuariosWeb { get; set; }


    }


    public interface IBaseTB : IBaseTBID {
        [Key]
        public int IDRegistroWeb { get; set; }


        public string CodigoUsuarioWeb { get; set; }

        public string FiltroUsuariosWeb { get; set; }
    }

    public class BaseTBID
    {
        [Key]
        public string IDClienteWeb { get; set; }
    }

    public interface IBaseTBID
    {
        [Key]
        public string IDClienteWeb { get; set; }
    }
}
