using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_SolicitacaoDocumento
    {
        public int id_SolicitacaoDocumento { get; set; }
        public string ChaveFuncionario { get; set; }
        public string NomeFuncionario { get; set; }
        public string EmailFuncionario { get; set; }
        public int IdDocumentoImagem { get; set; }
        public string DescricaoDocumento { get; set; }
        public byte[] ImagemDocumento { get; set; }
        public string TipoExtensaoArquivo { get; set; }

        public string Observacao { get; set; }
        public bool FlagObrigatorio { get; set; }
        public bool FlagSolicitado { get; set; }
        public bool FlagAprovado { get; set; }

    }
}
