using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Service.Domain.EntitiesGIWeb.Base;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_FuncionarioDependenteSelecao
    {

        [Display(Name = "Empresa", Prompt = "Empresa")]
        public short CodigoEmpresa { get; set; }

        [Display(Name = "Filial", Prompt = "Filial")]
        public short CodigoFilial { get; set; }

        [Display(Name = "Funcionário", Prompt = "Funcionário")]
        public int CodigoFuncionario { get; set; }

        [Display(Name = "Código", Prompt = "Código")]
        public short CodigoDependente { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Nome", Prompt = "Nome")]
        [Required(ErrorMessage = "Informe o nome!")]
        public string Nome { get; set; }

        [Display(Name = "Nascimento", Prompt = "Nascimento")]
        public DateTime? DataNascimento { get; set; }

        /// <summary>
        /// F - Feminino
        /// M - Masculino
        /// </summary>
        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Maximo de 1 Caracteres.")]
        [MaxLength(1, ErrorMessage = "Maximo de 1 Caracteres.")]
        [Display(Name = "Sexo", Prompt = "Sexo")]
        public string Sexo { get; set; }

        /// <summary>
        /// 01 - Esposo(a)
        /// 02 - Companheiro(a)
        /// 03 - Filho ou Enteado
        /// 04 - Filha ou Enteada
        /// 05 - Pais
        /// 06 - Avos
        /// 07 - Netos
        /// 08 - Bisnetos
        /// 09 - Irmão Inválido
        /// 10 - Outros...
        /// </summary>
        [DefaultValue(3)]
        [Display(Name = "Parentesco", Prompt = "Parentesco")]
        public short GrauParentesco { get; set; }

        /// <summary>
        /// 0 - Normal
        /// 1 - Sem limite de idade para Dedução de IRRF
        /// 2 - Sem limite de idade para Pagto de Salário Família
        /// 3 - Sem limite de idade para Ded.IRF e Pagto de Salário Família
        /// 4 - Não é dependente para IRRF
        /// 5 - Salário Família suspenso
        /// 6 - Salário Família suspenso e não é dependente para IRRF
        /// </summary>
        [DefaultValue(0)]
        [Display(Name = "Situação", Prompt = "Situação")]
        public short Situacao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Assistência Médica", Prompt = "Assistência Médica")]
        public short CodigoAssistMedica { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Assistência Odontológica", Prompt = "Assistência Odontológica")]
        public short CodigoAssistOdonto { get; set; }

        /// <summary>
        /// C - Casado
        /// D - Divorciado
        /// Q - Desquitado
        /// S - Solteiro
        /// V - Viúvo
        /// U - União Estável
        /// O - Outros
        /// </summary>
        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Maximo de 1 Caracteres.")]
        [MaxLength(1, ErrorMessage = "Maximo de 1 Caracteres.")]
        [Display(Name = "Estado Civil", Prompt = "Estado Civil")]
        public string EstadoCivil { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Local de Nascimento", Prompt = "Local de Nascimento")]
        public string LocalNascimento { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Cartório", Prompt = "Cartório")]
        public string Cartorio { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Maximo de 10 Caracteres.")]
        [MaxLength(10, ErrorMessage = "Maximo de 10 Caracteres.")]
        [Display(Name = "Livro", Prompt = "Licro")]
        public string NumeroLivro { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Maximo de 10 Caracteres.")]
        [MaxLength(10, ErrorMessage = "Maximo de 10 Caracteres.")]
        [Display(Name = "Folha", Prompt = "Folha")]
        public string NumeroFolha { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Maximo de 10 Caracteres.")]
        [MaxLength(10, ErrorMessage = "Maximo de 10 Caracteres.")]
        [Display(Name = "Registro", Prompt = "Registro")]
        public string NumeroRegistro { get; set; }

        [DefaultValue(0)]
        public decimal CodigoFuncionarioWEB { get; set; }

        [Display(Name = "DT. Entrega Docto", Prompt = "DT. Entrega Docto")]
        public DateTime? DataEntregaDocto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "CPF", Prompt = "CPF")]
        public decimal CPF { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [MaxLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [Display(Name = "Cartão SUS/Convênio", Prompt = "Cartão SUS/Convênio")]
        public string CartaoSUS { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [MaxLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [Display(Name = "Matricula", Prompt = "Matricula")]
        public string Matricula { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [MaxLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [Display(Name = "Dec. Nascimento Vivo", Prompt = "Dec. Nascimento Vivo")]
        public string Dnv { get; set; }

        [DefaultValue(false)]
        [Display(Name = "Universitário", Prompt = "Universitário")]
        public bool Universitario { get; set; }

        [DefaultValue(0)]
        [Display(Name = "CPF Mãe", Prompt = "CPF Mãe")]
        public decimal CPFMae { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Maximo de 70 Caracteres.")]
        [MaxLength(70, ErrorMessage = "Maximo de 70 Caracteres.")]
        [Display(Name = "Nome da Mãe", Prompt = "Nome da Mãe")]
        public string NomeMae { get; set; }

        [Display(Name = "Data Casamento", Prompt = "Data casamento")]
        public DateTime? DataCasamento { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [MaxLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [Display(Name = "Cód.Nascido Vivo", Prompt = "Cód.Nascido Vivo")]
        public string CodigoNascidoVivo { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [MaxLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [Display(Name = "Nº Cartão Assistência Médica", Prompt = "Nº Cartão Assistência Médica")]
        public string NroCarteiraBnfAM { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [MaxLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [Display(Name = "Nº Cartão Assistência Odontológica", Prompt = "Nº Cartão Assistência Odontológica")]
        public string NroCarteiraBnfAO { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Incapacidade Física ou Mental", Prompt = "Incapacidade Física ou Mental")]
        public bool IncTrab { get; set; }

    }


    public class TB_FuncionarioDependenteSelecaoAPI : BaseTB
    {
        [Display(Name = "Empresa", Prompt = "Empresa")]
        public short CodigoEmpresa { get; set; }

        [Display(Name = "Filial", Prompt = "Filial")]
        public short CodigoFilial { get; set; }

        [Display(Name = "Funcionário", Prompt = "Funcionário")]
        public int CodigoFuncionario { get; set; }

        [Display(Name = "Código", Prompt = "Código")]
        public short CodigoDependente { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Nome", Prompt = "Nome")]
        [Required(ErrorMessage = "Informe o nome!")]
        public string? Nome { get; set; }

        [Display(Name = "Nascimento", Prompt = "Nascimento")]
        public DateTime? DataNascimento { get; set; }

        /// <summary>
        /// F - Feminino
        /// M - Masculino
        /// </summary>
        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Maximo de 1 Caracteres.")]
        [MaxLength(1, ErrorMessage = "Maximo de 1 Caracteres.")]
        [Display(Name = "Sexo", Prompt = "Sexo")]
        public string? Sexo { get; set; }

        /// <summary>
        /// 01 - Esposo(a)
        /// 02 - Companheiro(a)
        /// 03 - Filho ou Enteado
        /// 04 - Filha ou Enteada
        /// 05 - Pais
        /// 06 - Avos
        /// 07 - Netos
        /// 08 - Bisnetos
        /// 09 - Irmão Inválido
        /// 10 - Outros...
        /// </summary>
        [DefaultValue(3)]
        [Display(Name = "Parentesco", Prompt = "Parentesco")]
        public short? GrauParentesco { get; set; }

        /// <summary>
        /// 0 - Normal
        /// 1 - Sem limite de idade para Dedução de IRRF
        /// 2 - Sem limite de idade para Pagto de Salário Família
        /// 3 - Sem limite de idade para Ded.IRF e Pagto de Salário Família
        /// 4 - Não é dependente para IRRF
        /// 5 - Salário Família suspenso
        /// 6 - Salário Família suspenso e não é dependente para IRRF
        /// </summary>
        [DefaultValue(0)]
        [Display(Name = "Situação", Prompt = "Situação")]
        public short? Situacao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Assistência Médica", Prompt = "Assistência Médica")]
        public short? CodigoAssistMedica { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Assistência Odontológica", Prompt = "Assistência Odontológica")]
        public short? CodigoAssistOdonto { get; set; }

        /// <summary>
        /// C - Casado
        /// D - Divorciado
        /// Q - Desquitado
        /// S - Solteiro
        /// V - Viúvo
        /// U - União Estável
        /// O - Outros
        /// </summary>
        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Maximo de 1 Caracteres.")]
        [MaxLength(1, ErrorMessage = "Maximo de 1 Caracteres.")]
        [Display(Name = "Estado Civil", Prompt = "Estado Civil")]
        public string? EstadoCivil { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Local de Nascimento", Prompt = "Local de Nascimento")]
        public string? LocalNascimento { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Cartório", Prompt = "Cartório")]
        public string? Cartorio { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Maximo de 10 Caracteres.")]
        [MaxLength(10, ErrorMessage = "Maximo de 10 Caracteres.")]
        [Display(Name = "Livro", Prompt = "Licro")]
        public string? NumeroLivro { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Maximo de 10 Caracteres.")]
        [MaxLength(10, ErrorMessage = "Maximo de 10 Caracteres.")]
        [Display(Name = "Folha", Prompt = "Folha")]
        public string? NumeroFolha { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Maximo de 10 Caracteres.")]
        [MaxLength(10, ErrorMessage = "Maximo de 10 Caracteres.")]
        [Display(Name = "Registro", Prompt = "Registro")]
        public string? NumeroRegistro { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "DECIMAL(10,0)")]
        public decimal? CodigoFuncionarioWEB { get; set; }

        [Display(Name = "DT.Entrega Docto", Prompt = "DT.Entrega Docto")]
        public DateTime? DataEntregaDocto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "CPF", Prompt = "CPF")]
        [Column(TypeName = "DECIMAL(14,0)")]
        public decimal? CPF { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [MaxLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [Display(Name = "Cartão SUS / Convênio", Prompt = "Cartão SUS / Convênio")]
        public string? CartaoSUS { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [MaxLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [Display(Name = "Matricula", Prompt = "Matricula")]
        public string? Matricula { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [MaxLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [Display(Name = "Dec.Nascimento Vivo", Prompt = "Dec.Nascimento Vivo")]
        public string? Dnv { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Universitário", Prompt = "Universitário")]
        public bool? Universitario { get; set; }

        [DefaultValue(0)]
        [Display(Name = "CPF Mãe", Prompt = "CPF Mãe")]
        [Column(TypeName = "DECIMAL(11,0)")]
        public decimal CPFMae { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Maximo de 70 Caracteres.")]
        [MaxLength(70, ErrorMessage = "Maximo de 70 Caracteres.")]
        [Display(Name = "Nome da Mãe", Prompt = "Nome da Mãe")]
        public string NomeMae { get; set; }

        [Display(Name = "Data Casamento", Prompt = "Data casamento")]
        public DateTime? DataCasamento { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [MaxLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [Display(Name = "Cód.Nascido Vivo", Prompt = "Cód.Nascido Vivo")]
        public string CodigoNascidoVivo { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [MaxLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [Display(Name = "Nº Cartão Assistência Médica", Prompt = "Nº Cartão Assistência Médica")]
        public string NroCarteiraBnfAM { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [MaxLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [Display(Name = "Nº Cartão Assistência Odontológica", Prompt = "Nº Cartão Assistência Odontológica")]
        public string NroCarteiraBnfAO { get; set; }

        [DefaultValue(0)]
        public bool? incTrab { get; set; }

        [DefaultValue(0)]
        public short CodigoOutrosBNF { get; set; }

        [DefaultValue("")]
        public string NroCartaoOutrosBNF { get; set; }

    }


    public class TB_FuncionarioDependenteSelecaoAPI_old:BaseTB
    {

        [Display(Name = "Empresa", Prompt = "Empresa")]
        public short CodigoEmpresa { get; set; }

        [Display(Name = "Filial", Prompt = "Filial")]
        public short CodigoFilial { get; set; }

        [Display(Name = "Funcionário", Prompt = "Funcionário")]
        public int CodigoFuncionario { get; set; }

        [Display(Name = "Código", Prompt = "Código")]
        public short CodigoDependente { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Nome", Prompt = "Nome")]
        [Required(ErrorMessage = "Informe o nome!")]
        public string Nome { get; set; }

        [Display(Name = "Nascimento", Prompt = "Nascimento")]
        public DateTime? DataNascimento { get; set; }

        /// <summary>
        /// F - Feminino
        /// M - Masculino
        /// </summary>
        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Maximo de 1 Caracteres.")]
        [MaxLength(1, ErrorMessage = "Maximo de 1 Caracteres.")]
        [Display(Name = "Sexo", Prompt = "Sexo")]
        public string Sexo { get; set; }

        /// <summary>
        /// 01 - Esposo(a)
        /// 02 - Companheiro(a)
        /// 03 - Filho ou Enteado
        /// 04 - Filha ou Enteada
        /// 05 - Pais
        /// 06 - Avos
        /// 07 - Netos
        /// 08 - Bisnetos
        /// 09 - Irmão Inválido
        /// 10 - Outros...
        /// </summary>
        [DefaultValue(3)]
        [Display(Name = "Parentesco", Prompt = "Parentesco")]
        public short GrauParentesco { get; set; }

        /// <summary>
        /// 0 - Normal
        /// 1 - Sem limite de idade para Dedução de IRRF
        /// 2 - Sem limite de idade para Pagto de Salário Família
        /// 3 - Sem limite de idade para Ded.IRF e Pagto de Salário Família
        /// 4 - Não é dependente para IRRF
        /// 5 - Salário Família suspenso
        /// 6 - Salário Família suspenso e não é dependente para IRRF
        /// </summary>
        [DefaultValue(0)]
        [Display(Name = "Situação", Prompt = "Situação")]
        public short Situacao { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Assistência Médica", Prompt = "Assistência Médica")]
        public short CodigoAssistMedica { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Assistência Odontológica", Prompt = "Assistência Odontológica")]
        public short CodigoAssistOdonto { get; set; }

        /// <summary>
        /// C - Casado
        /// D - Divorciado
        /// Q - Desquitado
        /// S - Solteiro
        /// V - Viúvo
        /// U - União Estável
        /// O - Outros
        /// </summary>
        [DefaultValue("")]
        [StringLength(1, ErrorMessage = "Maximo de 1 Caracteres.")]
        [MaxLength(1, ErrorMessage = "Maximo de 1 Caracteres.")]
        [Display(Name = "Estado Civil", Prompt = "Estado Civil")]
        public string EstadoCivil { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Local de Nascimento", Prompt = "Local de Nascimento")]
        public string LocalNascimento { get; set; }

        [DefaultValue("")]
        [StringLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [MaxLength(50, ErrorMessage = "Maximo de 50 Caracteres.")]
        [Display(Name = "Cartório", Prompt = "Cartório")]
        public string Cartorio { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Maximo de 10 Caracteres.")]
        [MaxLength(10, ErrorMessage = "Maximo de 10 Caracteres.")]
        [Display(Name = "Livro", Prompt = "Licro")]
        public string NumeroLivro { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Maximo de 10 Caracteres.")]
        [MaxLength(10, ErrorMessage = "Maximo de 10 Caracteres.")]
        [Display(Name = "Folha", Prompt = "Folha")]
        public string NumeroFolha { get; set; }

        [DefaultValue("")]
        [StringLength(10, ErrorMessage = "Maximo de 10 Caracteres.")]
        [MaxLength(10, ErrorMessage = "Maximo de 10 Caracteres.")]
        [Display(Name = "Registro", Prompt = "Registro")]
        public string NumeroRegistro { get; set; }

        [DefaultValue(0)]
        public decimal CodigoFuncionarioWEB { get; set; }

        [Display(Name = "DT. Entrega Docto", Prompt = "DT. Entrega Docto")]
        public DateTime? DataEntregaDocto { get; set; }

        [DefaultValue(0)]
        [Display(Name = "CPF", Prompt = "CPF")]
        public decimal CPF { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [MaxLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [Display(Name = "Cartão SUS/Convênio", Prompt = "Cartão SUS/Convênio")]
        public string CartaoSUS { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [MaxLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [Display(Name = "Matricula", Prompt = "Matricula")]
        public string Matricula { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [MaxLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [Display(Name = "Dec. Nascimento Vivo", Prompt = "Dec. Nascimento Vivo")]
        public string Dnv { get; set; }

        [DefaultValue(false)]
        [Display(Name = "Universitário", Prompt = "Universitário")]
        public bool Universitario { get; set; }

        [DefaultValue(0)]
        [Display(Name = "CPF Mãe", Prompt = "CPF Mãe")]
        public decimal CPFMae { get; set; }

        [DefaultValue("")]
        [StringLength(70, ErrorMessage = "Maximo de 70 Caracteres.")]
        [MaxLength(70, ErrorMessage = "Maximo de 70 Caracteres.")]
        [Display(Name = "Nome da Mãe", Prompt = "Nome da Mãe")]
        public string NomeMae { get; set; }

        [Display(Name = "Data Casamento", Prompt = "Data casamento")]
        public DateTime? DataCasamento { get; set; }

        [DefaultValue("")]
        [StringLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [MaxLength(20, ErrorMessage = "Maximo de 20 Caracteres.")]
        [Display(Name = "Cód.Nascido Vivo", Prompt = "Cód.Nascido Vivo")]
        public string CodigoNascidoVivo { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [MaxLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [Display(Name = "Nº Cartão Assistência Médica", Prompt = "Nº Cartão Assistência Médica")]
        public string NroCarteiraBnfAM { get; set; }

        [DefaultValue("")]
        [StringLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [MaxLength(40, ErrorMessage = "Maximo de 40 Caracteres.")]
        [Display(Name = "Nº Cartão Assistência Odontológica", Prompt = "Nº Cartão Assistência Odontológica")]
        public string NroCarteiraBnfAO { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Incapacidade Física ou Mental", Prompt = "Incapacidade Física ou Mental")]
        public bool IncTrab { get; set; }

    }
}
