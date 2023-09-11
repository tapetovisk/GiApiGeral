using System.ComponentModel.DataAnnotations;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_FuncionarioImage
    {
        [Key]
        public int Id { get; set; }
        public int Id_GiSelecaoFuncionario { get; set; }
        public int CodigoEmpresa { get; set; }
        public int CodigoFilial { get; set; }
        public int CodigoFuncionario { get; set; }
        public string DescricaoDocumento { get; set; }
        public byte[] ImagemDocumento { get; set; }
        public string TipoExtensaoArquivo { get; set; }
        public bool ImagemGI { get; set; }
        public string URL { get; set; }
        public bool APISinc { get; set; }

    }

}
