using Service.Domain.EntitiesGIWeb.Base;

namespace Service.Domain.EntitiesGIWeb
{
    public class TB_Funcionario : BaseTB
    {
        public string FotoFuncionario { get; set; }

        public DateTime? DataUltAtuTurnovo { get; set; }

        public DateTime? DataInclusao { get; set; }

        public DateTime? Dataalteracao { get; set; }

        public string CodigoAfastamento { get; set; }

        public int Situacao { get; set; }

        public string Foto { get; set; }

        public bool DeficienteFisico { get; set; }

        public string PortadorCheque { get; set; }

        public bool? DescontaCS { get; set; }

        public bool DescontaCC { get; set; }

        public bool DescontaMS { get; set; }

        public bool DescontaCA { get; set; }

        public bool DescontaTA { get; set; }

        public bool InclusaoOK { get; set; }

        public decimal ValorUltimoBnfInformado { get; set; }

        public bool TransferenciaOnus { get; set; }

        public string IDSistemaAnterior { get; set; }

        public int EventoPensao13o { get; set; }
        public int EventoPensaoFer { get; set; }

        public int BasePensao13o { get; set; }

        public int BasePensaoFer { get; set; }

        public decimal AliqPensao13o { get; set; }

        public decimal AliqPensaoFer { get; set; }

        public string UsuarioInclusao { get; set; }

        public string SenhaCaixinha { get; set; }

        public bool NovoBnf { get; set; }

        public decimal SAP_Id { get; set; }

        public string SAP_Area { get; set; }

        public decimal CodigoFuncionarioWEB { get; set; }

        public int IdUsuarioGI { get; set; }

        public int QtdeBnfInformado { get; set; }

        public int PercentFatu2 { get; set; }

        public string PercentFatu3 { get; set; }

        public string ObsWeb { get; set; }

        public string CartaApresentacao { get; set; }

        public bool residenciaPropria { get; set; }

        public bool residenciarecursoFGTS { get; set; }

        public decimal vlrSalVariavel { get; set; }

        public DateTime? DataDemissaoAgenda { get; set; }

        public string codConv { get; set; }

        public DateTime? DataIniEdicaoPortal { get; set; }

        public string CertificadoSeguranca { get; set; }

        public DateTime? DTIniEdicaoPortal { get; set; }

        public string TipoOperacaoWeb { get; set; }

        public decimal cpfAnt { get; set; }

        public string matricAnt { get; set; }

        public DateTime? dtAltCPF { get; set; }

        public string ObsAltCPF { get; set; }

        public string objDet { get; set; }

        #region Geral

        public int CodigoEmpresa { get; set; }

        public int CodigoFilial { get; set; }

        public int CodigoFuncionario { get; set; }

        public string Nome { get; set; }

        public bool eSocialQualifCad { get; set; }

        public string eSocialMatricula { get; set; }

        public int CodigoCliente { get; set; }

        public int CodigoContrato { get; set; }

        public int TipoFat { get; set; }

        public int CodigoFuncao { get; set; }

        public int CodigoHorario { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Submetidos a Horário de Trabalho(Cap.II da CLT)
        /// 2 - Atividade Externa especificada no Inciso I do Art. 62 da CLT
        /// 3 - Funções específicadas no Inciso II do Art. 62 da CLT
        /// 4 - Teletrabalho, previsto no Inciso III do Art. 62 da CLT
        /// </summary>
        public int tpRegimeJor { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Jornada com horário diário e folga fixos
        /// 2 - Jornada 12 x 36 (12 horas de trabalho seguidas de 36 horas ininterruptas de descanso)
        /// 3 - Jornada com horário diário fixo e folga variável
        /// 9 - Demais tipos de jornada
        /// </summary>
        public int tpJornada { get; set; }

        public int Regiao { get; set; }

        public int CodigoCentroCusto { get; set; }

        public string CodigoDepto { get; set; }

        public DateTime? DataAdmissao { get; set; }

        /// <summary>
        /// 1 - Contrato CLT
        /// 2 - Estagiário(Lei Antiga)
        /// 3 - Avulso
        /// 4 - Temporário
        /// 5 - Diretor sem FGTS
        /// 6 - Serviço não Efetivo
        /// 7 - CLT Prazo Determinado
        /// 8 - Diretor com FGTS
        /// 9 - Outros
        /// C - Agente Público
        /// D - Autônomo que Contribui com Remuneração
        /// E - Autônomo que Contribui com Salário Base
        /// F - Transportador Autônomo que Contribui com Remuneração
        /// G - Transportador Autônomo que Contribui com Salário Base
        /// H - Menor Aprendiz(Lei 10.097/2000)
        /// I - Doméstico(a)
        /// J - Estagiário(Nova Lei 11.788 09/2008)
        /// K - Contrato Intermitente
        /// </summary>
        public string Vinculo { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Trabalho Urbano
        /// 2 - Trabalho Rural
        /// </summary>
        public int natAtividade { get; set; }

        /// <summary>
        /// 000 - Não Informado
        /// 101 - Empregado - Geral, inclusive o empregado público da administração direta ou indireta contratado pela CLT
        /// 102 - Empregado - Trabalhador Rural por Pequeno Prazo da Lei 11.718/2008
        /// 103 - Empregado - Aprendiz
        /// 104 - Empregado - Doméstico
        /// 105 - Empregado - contrato a termo firmado nos termos da Lei 9601/98
        /// 106 - Empregado - contrato por prazo determinado nos termos da Lei 6019/74
        /// 111 - Empregado - contrato de trabalho intermitente
        /// 201 - Trabalhador Avulso Portuário
        /// 202 - Trabalhador Avulso Não Portuário
        /// 301 - Servidor Público Titular de Cargo Efetivo, Magistrado, Ministro de Tribunal de Contas, Conselheiro de Tribunal de Contas e Membro do Ministério Público
        /// 302 - Servidor Público Ocupante de Cargo exclusivo em comissão
        /// 303 - Agente Político
        /// 305 - Servidor Público indicado para conselho ou órgão representativo, na condição de representante do governo, órgão ou entidade da administração pública
        /// 306 - Servidor Público Temporário, sujeito a regime administrativo especial definido em lei própria
        /// 307 - Militar Efetivo
        /// 308 - Conscrito
        /// 309 - Agente Público - Outros
        /// 401 - Dirigente Sindical - informação prestada pelo Sindicato
        /// 410 - Trabalhador cedido - informação prestada pelo Cessionário
        /// 701 - Contribuinte individual - Autônomo em geral, exceto se enquadrado em uma das demais categorias de contribuinte individual
        /// 711 - Contribuinte individual - Transportador autônomo de passageiros
        /// 712 - Contribuinte individual - Transportador autônomo de carga
        /// 721 - Contribuinte individual - Diretor não empregado, com FGTS
        /// 722 - Contribuinte individual - Diretor não empregado, sem FGTS
        /// 723 - Contribuinte individual - empresários, sócios e membro de conselho de administração ou fiscal
        /// 731 - Contribuinte individual - Cooperado que presta serviços por intermédio de Cooperativa de Trabalho
        /// 734 - Contribuinte individual - Transportador Cooperado que presta serviços por intermédio de cooperativa de trabalho
        /// 738 - Contribuinte individual - Cooperado filiado a Cooperativa de Produção
        /// 741 - Contribuinte individual - Micro Empreendedor Individual
        /// 751 - Contribuinte individual - magistrado classista temporário da Justiça do Trabalho ou da Justiça Eleitoral que seja aposentado de qualquer regime prev.
        /// 761 - Contribuinte individual - Associado eleito para direção de Cooperativa, associação ou entidade de classe de qualquer natureza ou finalidade
        /// 771 - Contribuinte individual - Membro de conselho tutelar, nos termos da Lei nº 8.069, de 13 de julho de 1990
        /// 781 - Ministro de confissão religiosa ou membro de vida consagrada, de congregação ou de ordem religiosa
        /// 901 - Estagiário
        /// 902 - Médico Residente
        /// 903 - Bolsista, nos termos da lei 8958/1994
        /// </summary>
        public int codCateg_eSocial { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Admissão
        /// 2 - Transferência de empresa do mesmo grupo econômico
        /// 3 - Transferência de empresa consorciada ou de consórcio
        /// 4 - Transferência por motivo de sucessão, incorporação, cisão ou fusão 
        /// 5 - Transferência do empregado doméstico para outro representante da mesma unidade familiar
        /// </summary>
        public int tpAdmissao { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - CLT - Consolidação das Leis de Trabalho e legislações trabalhistas
        /// 2 - Estatutário
        /// </summary>
        public int tpRegimeTrab { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - RGPS - Regime Geral da Previdência Social
        /// 2 - RPPS - Regime Próprio de Previdência Social
        /// 3 - RPPE - Regime de Previdência Social no Exterior
        /// </summary>
        public int tpRegimePrev { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Normal
        /// 2 - Decorrente de Ação Fiscal
        /// 3 - Decorrente de Decisão Judicial
        /// </summary>
        public int indAdmissao { get; set; }

        /// <summary>
        /// Direta
        /// Indireta
        /// </summary>
        public string TipoAdmissao { get; set; }

        public string nrProcJudAlvaraJudicial { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Normal
        /// 2 - Decorrente de Decisão Judicial
        /// </summary>
        public int indProvim { get; set; }

        public DateTime? DataDemissao { get; set; }

        /// <summary>
        /// 
        /// 1 - Pela Empresa com Justa Causa
        /// 2 - Pela Empresa sem Justa Causa
        /// 3 - Pelo Empregado com Justa Causa
        /// 4 - Pelo Empregado sem Justa Causa
        /// 5 - Término de Contrato
        /// 6 - Transferência com Ônus
        /// 7 - Aposentadoria
        /// 8 - Morte
        /// 9 - Término de Contrato Antecipado pela Empresa
        /// 10 - Outros
        /// 11 - Término de Contrato Antecipado pelo Empregado
        /// 12 - Aposentadoria por Invalidez
        /// 13 - Término de Contrato Por Motivo de Acordo
        /// 14 - Motivo de Acordo(Contrato Intermitente)
        /// </summary>
        public int CodigoRescisao { get; set; }

        /// <summary>
        /// 
        /// Dispensa
        /// Efetivaçao
        /// Renovação
        /// </summary>
        public string TipoDemissao { get; set; }

        public string AvaliacaoComportamento { get; set; }

        public bool TrabalhoParcial { get; set; }

        public bool TeleTrabalho { get; set; }

        public bool TrabalhoIntermitente { get; set; }

        /// <summary>
        /// Dias
        /// Meses
        /// </summary>
        public string TipoVctoContrato { get; set; }

        /// <summary>
        /// Dias
        /// Meses
        /// </summary>
        public string TipoVctoContratoProrr { get; set; }

        public int DiasContrato { get; set; }

        public int DiasProrrogacao { get; set; }

        public DateTime? DtVectoContrato { get; set; }

        public DateTime? DtVectoProrrogacao { get; set; }

        /// <summary>
        /// Determinado
        /// Indeterminado
        /// </summary>
        public string TipoContrato { get; set; }

        /// <summary>
        /// Comissao
        /// Dia
        /// Hora
        /// Mês
        /// Quinzenal
        ///Tarefa
        /// </summary>
        public string TipoSalario { get; set; }

        /// <summary>
        /// Mensal
        /// Quinzenal
        /// Semanal
        /// </summary>
        public string TipoPgto { get; set; }

        public decimal QtdeHorasMes { get; set; }

        public decimal QtdeHorasSem { get; set; }

        public decimal Salario { get; set; }

        public decimal SalarioHora { get; set; }

        public string descSalVariavel { get; set; }

        public int DiaPgto { get; set; }

        public int DiaAdto { get; set; }

        public int DepIRF { get; set; }

        public int DepSF { get; set; }

        #endregion

        #region Pessoal

        public string CepResid { get; set; }

        public string BairroResid { get; set; }

        public string CidadeResid { get; set; }

        public int CodigoCidadeResid { get; set; }

        /// <summary>
        /// 
        /// AC
        /// AL
        /// AM
        /// AP
        /// BA
        /// CE
        /// DF
        /// ES
        /// GO
        /// MA
        /// MG
        /// MS
        /// MT
        /// PA
        /// PB
        /// PE
        /// PI
        /// PR
        /// RJ
        /// RN
        /// RO
        /// RR
        /// RS
        /// SC
        /// SE
        /// SP
        /// TO
        /// </summary>
        public string UFResid { get; set; }

        /// <summary>
        /// Nao Informado
        /// Area
        /// Acesso
        /// Acampamento
        /// Acesso Local
        /// Adro
        /// Area Especial
        /// Aeroporto
        /// Alameda
        /// Avenida Marginal Direita
        /// Avenida Marginal Esquerda
        /// Anel Viario
        /// Antiga Estrada
        /// Arteria
        /// Alto
        /// Atalho
        /// Area Verde
        /// Avenida
        /// Avenida Contorno
        /// Avenida Marginal
        /// Avenida Velha
        /// Balneario
        /// Beco
        /// Buraco
        /// Belvedere
        /// Bloco
        /// Balao
        /// Blocos
        /// Bulevar
        /// Bosque
        /// Boulevard
        /// Baixa
        /// Cais
        /// Calcada
        /// Caminho
        /// Canal
        /// Chacara
        /// Chapadao
        /// Ciclovia
        /// Circular
        /// Conjunto
        /// Conjunto Mutirao
        /// Complexo Viario
        /// Colonia
        /// Comunidade
        /// Condominio
        /// Corredor
        /// Campo
        /// Corrego
        /// Contorno
        /// Descida
        /// Desvio
        /// Distrito
        /// Entre Bloco
        /// Estrada Intermunicipal
        /// Enseada
        /// Entrada Particular
        /// Entre Quadra
        /// Escada
        /// Escadaria
        /// Estrada Estadual
        /// Estrada Vicinal
        /// Estrada de Ligacao
        /// Estrada Municipal
        /// Esplanada
        /// Estrada de Servidao
        /// Estrada
        /// Estrada Velha
        /// Estrada Antiga
        /// Estacao
        /// Estadio
        /// Estancia
        /// Estrada Particular
        /// Estacionamento
        /// Evangelica
        /// Elevada
        /// Eixo Industrial
        /// Favela
        /// Fazenda
        /// Ferrovia
        /// Fonte
        /// Feira
        /// Forte
        /// Galeria
        /// Granja
        /// Nucleo Habitacional
        /// Ilha
        /// Indeterminado
        /// Ilhota
        /// Jardim
        /// Jardinete
        /// Ladeira
        /// Lagoa
        /// Lago
        /// Loteamento
        /// Largo
        /// Lote
        /// Mercado
        /// Marina
        /// Modulo
        /// Projecao
        /// Morro
        /// Monte
        /// Nucleo
        /// Nucleo Rural
        /// Outeiro
        /// Paralela
        /// Passeio
        /// Patio
        /// Praca
        /// Praca de Esportes
        /// Parada
        /// Paradouro
        /// Ponta
        /// Praia
        /// Prolongamento
        /// Parque Municipal
        /// Parque
        /// Parque Residencial
        /// Passarela
        /// Passagem
        /// Passagem de Pedestre
        /// Passagem Subterranea
        /// Ponte
        /// Porto
        /// Quadra
        /// Quinta
        /// Quintas
        /// Rua
        /// Rua Integracao
        /// Rua de Ligacao
        /// Rua Particular
        /// Rua Velha
        /// Ramal
        /// Recreio
        /// Recanto
        /// Retiro
        /// Residencial
        /// Reta
        /// Ruela
        /// Rampa
        /// Rodo Anel
        /// Rodovia
        /// Rotula
        /// Rua de Pedestre
        /// Margem
        /// Retorno
        /// Rotatoria
        /// Segunda Avenida
        /// Sitio
        /// Servidao
        /// Setor
        /// Subida
        /// Trincheira
        /// Terminal
        /// Trecho
        /// Trevo
        /// Tunel
        /// Travessa
        /// Travessa Particular
        /// Travessa Velha
        /// Unidade
        /// Via
        /// Via Coletora
        /// Via Local
        /// Via de Acesso
        /// Vala
        /// Via Costeira
        /// Viaduto
        /// Via Expressa
        /// Vereda
        /// Via Elevado
        /// Vila
        /// Viela
        /// Vale
        /// Via Litoranea
        /// Via de Pedestre
        /// Variante
        /// Zigue-Zague
        /// </summary>
        public string tipoEndereco { get; set; }

        public string EnderecoResid { get; set; }

        public int NroEndereco { get; set; }

        public string CplEndereco { get; set; }

        public string TelefoneResid { get; set; }

        public int SMSDDDCel { get; set; }

        public decimal SMSNroCel { get; set; }

        public string Email { get; set; }

        /// <summary>
        /// 0 - Não é Portador de Deficiência
        /// 1 - Física
        /// 2 - Auditiva
        /// 3 - Visual
        /// 4 - Mental
        /// 5 - Múltipla
        /// 6 - Reabilitado
        /// 7 - Intelectual
        /// </summary>
        public int TipoDeficiencia { get; set; }

        /// <summary>
        /// F - Feminino
        /// M - Masculino
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// 1 - Branca
        /// 2 - Preta
        /// 3 - Amarela
        /// 4 - Parda
        /// 5 - Indígena
        /// </summary>
        public string Raca { get; set; }

        /// <summary>
        /// C - Casado(a)
        /// D - Divorciado(a)
        /// Q - Desquitado(a)
        /// S - Solteiro(a)
        /// V - Viúvo(a)
        /// U - União Estável
        /// O - Outros
        /// </summary>
        public string EstadoCivil { get; set; }

        /// <summary>
        /// 1 - Analfabeto
        /// 2 - Até 5º Ano Incompleto
        /// 3 - 5º Ano Completo
        /// 4 - 6º ao 9º Ano Incompleto
        /// 5 - Fundamental Completo
        /// 6 - Ensino Médio Incompleto
        /// 7 - Ensino Médio Completo
        /// 8 - Superior Incompleto
        /// 9 - Superior Completo
        /// A - Pós-Graduação Completa
        /// B - Mestrado Completo
        /// C - Doutorado Completo
        /// D - Pós-Doutorado Completo
        /// </summary>
        public string GrauInstrucao { get; set; }

        public DateTime? DataNascimento { get; set; }

        /// <summary>
        /// 010 - Brasileiro
        /// 013 - Afeganistao
        /// 017 - Albania, Republica Da
        /// 020 - Naturalizado
        /// 021 - Argentino
        /// 022 - Boliviano
        /// 023 - Chileno
        /// 024 - Paraguaio
        /// 025 - Uruguaio
        /// 026 - Venezuelano
        /// 027 - Colombiano
        /// 028 - Peruano
        /// 029 - Equatoriano
        /// 030 - Alemão
        /// 031 - Belga
        /// 032 - Britanico
        /// 034 - Canadense
        /// 035 - Espanhol
        /// 036 - EUA
        /// 037 - Francês
        /// 038 - Suíço
        /// 039 - Italiano
        /// 040 - Haitiano
        /// 041 - Japonês
        /// 042 - Chinês
        /// 043 - Coreano
        /// 044 - Russo
        /// 045 - Português
        /// 046 - Paquistanês
        /// 047 - Indiano
        /// 048 - Outros Latinos
        /// 049 - Outros Asiáticos
        /// 050 - Outros
        /// 051 - Outros Europeus
        /// 053 - Arabia Saudita
        /// 059 - Argelia
        /// 060 - Angolano
        /// 061 - Congolês
        /// 062 - Sul - Africano
        /// 064 - Armenia, Republica Da
        /// 065 - Aruba
        /// 069 - Australia
        /// 070 - Outros Africanos
        /// 072 - Austria
        /// 073 - Azerbaijao, Republica Do
        /// 076 - Burkina Faso
        /// 077 - Bahamas, Ilhas
        /// 078 - Belarus, Republica Da
        /// 079 - Belize
        /// 080 - República Tcheca
        /// 081 - Palestina
        /// 082 - Guiné - Bissau
        /// 083 - Cubano
        /// 084 - Marrocos
        /// 085 - Gana
        /// 086 - México
        /// 087 - Senegal
        /// 088 - Filipinas
        /// 089 - Zambia
        /// 090 - Bermudas
        /// 091 - Andorra
        /// 092 - Anguilla
        /// 093 - Mianmar(BIRMANIA)
        /// 094 - Antigua E Barbuda
        /// 095 - Antilhas Holandesas
        /// 096 - Bahrein, Ilhas
        /// 097 - Bangladesh
        /// 098 - Bosnia-Herzegovina(REPUBLICA Da)
        /// 099 - Barbados
        /// 101 - Botsuana
        /// 108 - Brunei
        /// 111 - Bulgaria, Republica Da
        /// 115 - Burundi
        /// 119 - Butao
        /// 127 - Cabo Verde, Republica De
        /// 137 - Cayan, Ilhas
        /// 141 - Camboja
        /// 145 - Camaroes
        /// 150 - Jersey, Ilha Do Canal
        /// 151 - Canarias, Ilhas
        /// 153 - Cazaquistao, Republica Do
        /// 154 - Catar
        /// 161 - Formosa(TAIWAN)
        /// 163 - Chipre
        /// 165 - Cocos(Keeling),Ilhas
        /// 173 - Comores, Ilhas
        /// 183 - Cook, Ilhas
        /// 187 - Coreia(DO Norte), Rep.Pop.Democratica
        /// 193 - Costa Do Marfim
        /// 195 - Croacia(REPUBLICA Da)
        /// 196 - Costa Rica
        /// 198 - Coveite
        /// 229 - Benin
        /// 232 - Dinamarca
        /// 235 - Dominica,Ilha
        /// 240 - Egito
        /// 243 - Eritreia
        /// 244 - Emirados Arabes Unidos
        /// 246 - Eslovenia, Republica Da
        /// 247 - Eslovaca, Republica
        /// 251 - Estonia, Republica Da
        /// 253 - Etiopia
        /// 255 - Falkland(ILHAS Malvinas)
        /// 259 - Feroe, Ilhas
        /// 271 - Finlandia
        /// 281 - Gabao
        /// 285 - Gambia
        /// 291 - Georgia, Republica Da
        /// 293 - Gibraltar
        /// 297 - Granada
        /// 301 - Grecia
        /// 305 - Groenlandia
        /// 309 - Guadalupe
        /// 313 - Guam
        /// 317 - Guatemala
        /// 325 - Guiana Francesa
        /// 329 - Guine
        /// 331 - Guine-Equatorial
        /// 337 - Guiana
        /// 345 - Honduras
        /// 351 - Hong Kong
        /// 355 - Hungria, Republica Da
        /// 357 - Iemen
        /// 359 - Man, Ilha De
        /// 365 - Indonesia
        /// 369 - Iraque
        /// 372 - Ira, Republica Islamica Do
        /// 375 - Irlanda
        /// 379 - Islandia
        /// 383 - Israel
        /// 388 - Servia E Montenegro
        /// 391 - Jamaica
        /// 396 - Johston, Ilhas
        /// 403 - Jordania
        /// 411 - Kiribati
        /// 420 - Laos, Rep.Pop.Democr.Do
        /// 423 - Lebuan,Ilhas
        /// 426 - Lesoto
        /// 427 - Letonia, Republica Da
        /// 431 - Libano
        /// 434 - Liberia
        /// 438 - Libia
        /// 440 - Liechtenstein
        /// 442 - Lituania, Republica Da
        /// 445 - Luxemburgo
        /// 447 - Macau
        /// 449 - Macedonia, Ant.Rep.Iugoslava
        /// 450 - Madagascar
        /// 452 - Ilha Da Madeira
        /// 455 - Malasia
        /// 458 - Malavi
        /// 461 - Maldivas
        /// 464 - Mali
        /// 467 - Malta
        /// 472 - Marianas Do Norte
        /// 476 - Marshall,Ilhas
        /// 477 - Martinica
        /// 485 - Mauricio
        /// 488 - Mauritania
        /// 490 - Midway, Ilhas
        /// 494 - Moldavia, Republica Da
        /// 495 - Monaco
        /// 497 - Mongolia
        /// 499 - Micronesia
        /// 501 - Montserrat,Ilhas
        /// 505 - Mocambique
        /// 507 - Namibia
        /// 508 - Nauru
        /// 511 - Christmas,Ilha(NAVIDAD)
        /// 517 - Nepal
        /// 521 - Nicaragua
        /// 525 - Niger
        /// 528 - Nigeria
        /// 531 - Niue,Ilha
        /// 535 - Norfolk,Ilha
        /// 538 - Noruega
        /// 542 - Nova Caledonia
        /// 545 - Papua Nova Guine
        /// 548 - Nova Zelandia
        /// 551 - Vanuatu
        /// 556 - Oma
        /// 566 - Pacifico,Ilhas Do(POSSESSAO Dos Eua)
        /// 573 - Paises Baixos(HOLANDA)
        /// 575 - Palau
        /// 580 - Panama
        /// 593 - Pitcairn,Ilha
        /// 599 - Polinesia Francesa
        /// 603 - Polonia, Republica Da
        /// 611 - Porto Rico
        /// 623 - Quenia
        /// 625 - Quirguiz, Republica
        /// 628 - Reino Unido
        /// 640 - Republica Centro-Africana
        /// 647 - Republica Dominicana
        /// 660 - Reuniao, Ilha
        /// 665 - Zimbabue
        /// 670 - Romenia
        /// 675 - Ruanda
        /// 677 - Salomao, Ilhas
        /// 678 - Saint Kitts E Nevis
        /// 685 - Saara Ocidental
        /// 687 - El Salvador
        /// 690 - Samoa
        /// 691 - Samoa Americana
        /// 695 - Sao Cristovao E Neves, Ilhas
        /// 697 - San Marino
        /// 700 - Sao Pedro E Miquelon
        /// 705 - Sao Vicente E Granadinas
        /// 710 - Santa Helena
        /// 715 - Santa Lucia
        /// 720 - Sao Tome E Principe, Ilhas
        /// 731 - Seychelles
        /// 735 - Serra Leoa
        /// 738 - Sikkim
        /// 741 - Cingapura
        /// 744 - Siria, Republica Arabe Da
        /// 748 - Somalia
        /// 750 - Sri Lanka
        /// 754 - Suazilandia
        /// 756 - Africa Do Sul
        /// 759 - Sudao
        /// 764 - Suecia
        /// 770 - Suriname
        /// 772 - Tadjiquistao, Republica Do
        /// 776 - Tailandia
        /// 780 - Tanzania, Rep.Unida Da
        /// 782 - Territorio Brit.Oc.Indico
        /// 783 - Djibuti
        /// 785 - Territorio da Alta Comissao do Pacifico Ocidental
        /// 788 - Chade
        /// 790 - Tchecoslovaquia
        /// 795 - Timor Leste
        /// 800 - Togo
        /// 805 - Toquelau, Ilhas
        /// 810 - Tonga
        /// 815 - Trinidad E Tobago
        /// 820 - Tunisia
        /// 823 - Turcas E Caicos, Ilhas
        /// 824 - Turcomenistao, Republica Do
        /// 827 - Turquia
        /// 828 - Tuvalu
        /// 831 - Ucrania
        /// 833 - Uganda
        /// 840 - Uniao Das Republicas Socialistas Sovieticas
        /// 847 - Uzbequistao, Republica Do
        /// 848 - Vaticano, Est.Da Cidade Do
        /// 855 - Vietname Norte
        /// 858 - Vietna
        /// 863 - Virgens, Ilhas (BRITANICAS)
        /// 866 - Virgens, Ilhas (E.U.A.)
        /// 870 - Fiji
        /// 873 - Wake, Ilha
        /// 875 - Wallis E Futuna, Ilhas
        /// 888 - Congo, Republica Democratica Do
        /// </summary>
        public string Nacionalidade { get; set; }

        public int AnoChegada { get; set; }

        public int codMunicipioNascto { get; set; }

        /// <summary>
        /// 
        /// AC
        /// AL
        /// AM
        /// AP
        /// BA
        /// CE
        /// DF
        /// ES
        /// GO
        /// MA
        /// MG
        /// MS
        /// MT
        /// PA
        /// PB
        /// PE
        /// PI
        /// PR
        /// RJ
        /// RN
        /// RO
        /// RR
        /// RS
        /// SC
        /// SE
        /// SP
        /// TO
        /// </summary>
        public string Naturalidade { get; set; }

        public string CidadeNascimento { get; set; }

        public bool CasadoBrasileiro { get; set; }

        public bool FilhosBrasileiros { get; set; }

        public DateTime? dtNaturalizacao { get; set; }

        /// <summary>
        /// 00 - Não Informado
        /// 01 - Visto permanente
        /// 02 - Visto temporário
        /// 03 - Asilado
        /// 04 - Refugiado
        /// 05 - Solicitante de Refúgio
        /// 06 - Residente fora do Brasil
        /// 07 - Deficiente físico e com mais de 51 anos
        /// 08 - Com residência provisória e anistiado, em situação irregular
        /// 09 - Permanência no Brasil em razão de filhos ou cônjuge brasileiros
        /// 10 - Beneficiado pelo acordo entre países do Mercosul
        /// 11 - Dependente de agente diplomático e/ou consular de países que mantém convênio de reciprocidade para o exercício de atividade remunerada no Brasil
        /// 12 - Beneficiado pelo Tratado de Amizade, Cooperação e Consulta entre a República Federativa do Brasil e a República Portuguesa
        /// </summary>
        public int classTrabEstrang { get; set; }

        /// <summary>
        /// 0000 - Brasil
        /// 0008 - Abu Dhabi
        /// 0009 - Dirce
        /// 0013 - Afeganistao
        /// 0017 - Albania, Republica Da
        /// 0020 - Alboran-Perejil,Ilhas
        /// 0023 - Alemanha
        /// 0025 - Alemanha, Republica Democratica
        /// 0031 - Burkina Faso
        /// 0037 - Andorra
        /// 0040 - Angola
        /// 0041 - Anguilla
        /// 0043 - Antigua E Barbuda
        /// 0047 - Antilhas Holandesas
        /// 0053 - Arabia Saudita
        /// 0059 - Argelia
        /// 0063 - Argentina
        /// 0064 - Armenia, Republica Da
        /// 0065 - Aruba
        /// 0069 - Australia
        /// 0072 - Austria
        /// 0073 - Azerbaijao, Republica Do
        /// 0077 - Bahamas, Ilhas
        /// 0080 - Bahrein, Ilhas
        /// 0081 - Bangladesh
        /// 0083 - Barbados
        /// 0085 - Belarus, Republica Da
        /// 0087 - Belgica
        /// 0088 - Belize
        /// 0090 - Bermudas
        /// 0093 - Mianmar(BIRMANIA)
        /// 0097 - Bolivia, Estado Plurinacional Da
        /// 0098 - Bosnia-Herzegovina(REPUBLICA Da)
        /// 0100 - Int.Z.F.Manaus
        /// 0101 - Botsuana
        /// 0105 - Brasil
        /// 0106 - Fretado P/Brasil
        /// 0108 - Brunei
        /// 0111 - Bulgaria, Republica Da
        /// 0115 - Burundi
        /// 0119 - Butao
        /// 0127 - Cabo Verde, Republica De
        /// 0131 - Cachemira
        /// 0137 - Cayman, Ilhas
        /// 0141 - Camboja
        /// 0145 - Camaroes
        /// 0149 - Canada
        /// 0150 - Jersey, Ilha Do Canal
        /// 0151 - Canarias, Ilhas
        /// 0152 - Canal,Ilhas
        /// 0153 - Cazaquistao, Republica Do
        /// 0154 - Catar
        /// 0158 - Chile
        /// 0160 - China, Republica Popular
        /// 0161 - Formosa(TAIWAN)
        /// 0163 - Chipre
        /// 0165 - Cocos(Keeling),Ilhas
        /// 0169 - Colombia
        /// 0173 - Comores, Ilhas
        /// 0177 - Congo
        /// 0183 - Cook, Ilhas
        /// 0187 - Coreia(DO Norte), Rep.Pop.Democratica
        /// 0190 - Coreia(DO Sul), Republica Da
        /// 0193 - Costa Do Marfim
        /// 0195 - Croacia(REPUBLICA Da)
        /// 0196 - Costa Rica
        /// 0198 - Coveite
        /// 0199 - Cuba
        /// 0229 - Benin
        /// 0232 - Dinamarca
        /// 0235 - Dominica,Ilha
        /// 0237 - Dubai
        /// 0239 - Equador
        /// 0240 - Egito
        /// 0243 - Eritreia
        /// 0244 - Emirados Arabes Unidos
        /// 0245 - Espanha
        /// 0246 - Eslovenia, Republica Da
        /// 0247 - Eslovaca, Republica
        /// 0249 - Estados Unidos
        /// 0251 - Estonia, Republica Da
        /// 0253 - Etiopia
        /// 0255 - Falkland(ILHAS Malvinas)
        /// 0259 - Feroe, Ilhas
        /// 0263 - Fezzan
        /// 0267 - Filipinas
        /// 0271 - Finlandia
        /// 0275 - Franca
        /// 0281 - Gabao
        /// 0285 - Gambia
        /// 0289 - Gana
        /// 0291 - Georgia, Republica Da
        /// 0293 - Gibraltar
        /// 0297 - Granada
        /// 0301 - Grecia
        /// 0305 - Groenlandia
        /// 0309 - Guadalupe
        /// 0313 - Guam
        /// 0317 - Guatemala
        /// 0325 - Guiana Francesa
        /// 0329 - Guine
        /// 0331 - Guine-Equatorial
        /// 0334 - Guine-Bissau
        /// 0337 - Guiana
        /// 0341 - Haiti
        /// 0345 - Honduras
        /// 0351 - Hong Kong
        /// 0355 - Hungria, Republica Da
        /// 0357 - Iemen
        /// 0358 - Iemem Do Sul
        /// 0359 - Man, Ilha De
        /// 0361 - India
        /// 0365 - Indonesia
        /// 0367 - Inglaterra
        /// 0369 - Iraque
        /// 0372 - Ira, Republica Islamica Do
        /// 0375 - Irlanda
        /// 0379 - Islandia
        /// 0383 - Israel
        /// 0386 - Italia
        /// 0388 - Servia E Montenegro
        /// 0391 - Jamaica
        /// 0395 - Jammu
        /// 0396 - Johnston, Ilhas
        /// 0399 - Japao
        /// 0403 - Jordania
        /// 0411 - Kiribati
        /// 0420 - Laos, Rep.Pop.Democr.Do
        /// 0423 - Lebuan,Ilhas
        /// 0426 - Lesoto
        /// 0427 - Letonia, Republica Da
        /// 0431 - Libano
        /// 0434 - Liberia
        /// 0438 - Libia
        /// 0440 - Liechtenstein
        /// 0442 - Lituania, Republica Da
        /// 0445 - Luxemburgo
        /// 0447 - Macau
        /// 0449 - Macedonia, Ant.Rep.Iugoslava
        /// 0450 - Madagascar
        /// 0452 - Ilha Da Madeira
        /// 0455 - Malasia
        /// 0458 - Malavi
        /// 0461 - Maldivas
        /// 0464 - Mali
        /// 0467 - Malta
        /// 0472 - Marianas Do Norte
        /// 0474 - Marrocos
        /// 0476 - Marshall,Ilhas
        /// 0477 - Martinica
        /// 0485 - Mauricio
        /// 0488 - Mauritania
        /// 0490 - Midway, Ilhas
        /// 0493 - Mexico
        /// 0494 - Moldavia, Republica Da
        /// 0495 - Monaco
        /// 0497 - Mongolia
        /// 0499 - Micronesia
        /// 0501 - Montserrat,Ilhas
        /// 0505 - Mocambique
        /// 0507 - Namibia
        /// 0508 - Nauru
        /// 0511 - Christmas,Ilha(NAVIDAD)
        /// 0517 - Nepal
        /// 0521 - Nicaragua
        /// 0525 - Niger
        /// 0528 - Nigeria
        /// 0531 - Niue,Ilha
        /// 0535 - Norfolk,Ilha
        /// 0538 - Noruega
        /// 0542 - Nova Caledonia
        /// 0545 - Papua Nova Guine
        /// 0548 - Nova Zelandia
        /// 0551 - Vanuatu
        /// 0556 - Oma
        /// 0563 - Pacifico,Ilhas Do(ADMINISTRACAO Dos Eua)
        /// 0566 - Pacifico,Ilhas Do(POSSESSAO Dos Eua)
        /// 0569 - Pacifico,Ilhas Do(TERRITORIO Em Fideicomisso Dos
        /// 0573 - Paises Baixos (HOLANDA)
        /// 0575 - Palau
        /// 0576 - Paquistao
        /// 0578 - Palestina
        /// 0580 - Panama
        /// 0583 - Papua Nova Guiné
        /// 0586 - Paraguai
        /// 0589 - Peru
        /// 0593 - Pitcairn, Ilha
        /// 0599 - Polinesia Francesa
        /// 0603 - Polonia, Republica Da
        /// 0607 - Portugal
        /// 0611 - Porto Rico
        /// 0623 - Quenia
        /// 0625 - Quirguiz, Republica
        /// 0628 - Reino Unido
        /// 0640 - Republica Centro-Africana
        /// 0647 - Republica Dominicana
        /// 0660 - Reuniao, Ilha
        /// 0665 - Zimbabue
        /// 0670 - Romenia
        /// 0675 - Ruanda
        /// 0676 - Russia, Federacao Da
        /// 0677 - Salomao, Ilhas
        /// 0678 - Saint Kitts E Nevis
        /// 0685 - Saara Ocidental
        /// 0687 - El Salvador
        /// 0690 - Samoa
        /// 0691 - Samoa Americana
        /// 0695 - Sao Cristovao E Neves, Ilhas
        /// 0697 - San Marino
        /// 0700 - Sao Pedro E Miquelon
        /// 0705 - Sao Vicente E Granadinas
        /// 0710 - Santa Helena
        /// 0715 - Santa Lucia
        /// 0720 - Sao Tome E Principe, Ilhas
        /// 0728 - Senegal
        /// 0731 - Seychelles
        /// 0735 - Serra Leoa
        /// 0738 - Sikkim
        /// 0741 - Cingapura
        /// 0744 - Siria, Republica Arabe Da
        /// 0748 - Somalia
        /// 0750 - Sri Lanka
        /// 0754 - Suazilandia
        /// 0756 - Africa Do Sul
        /// 0759 - Sudao
        /// 0764 - Suecia
        /// 0767 - Suica
        /// 0770 - Suriname
        /// 0772 - Tadjiquistao, Republica Do
        /// 0776 - Tailandia
        /// 0780 - Tanzania, Rep.Unida Da
        /// 0782 - Territorio Brit.Oc.Indico
        /// 0783 - Djibuti
        /// 0785 - Territorio da Alta Comissao do Pacifico Ocidental
        /// 0788 - Chade
        /// 0790 - Tchecoslovaquia
        /// 0791 - Tcheca, Republica
        /// 0795 - Timor Leste
        /// 0800 - Togo
        /// 0805 - Toquelau, Ilhas
        /// 0810 - Tonga
        /// 0815 - Trinidad E Tobago
        /// 0820 - Tunisia
        /// 0823 - Turcas E Caicos, Ilhas
        /// 0824 - Turcomenistao, Republica Do
        /// 0827 - Turquia
        /// 0828 - Tuvalu
        /// 0831 - Ucrania
        /// 0833 - Uganda
        /// 0840 - Uniao Das Republicas Socialistas Sovieticas
        /// 0845 - Uruguai
        /// 0847 - Uzbequistao, Republica Do
        /// 0848 - Vaticano, Est.Da Cidade Do
        /// 0850 - Venezuela
        /// 0855 - Vietname Norte
        /// 0858 - Vietna
        /// 0863 - Virgens, Ilhas (BRITANICAS)
        /// 0866 - Virgens, Ilhas (E.U.A.)
        /// 0870 - Fiji
        /// 0873 - Wake, Ilha
        /// 0875 - Wallis E Futuna, Ilhas
        /// 0888 - Congo, Republica Democratica Do
        /// 0890 - Zambia
        /// </summary>
        public int exterior_paisResidencia { get; set; }

        public string exterior_descLogradouro { get; set; }

        public string exterior_nrLogradouro { get; set; }

        public string exterior_complemento { get; set; }

        public string exterior_bairro { get; set; }

        public string exterior_nomeCidade { get; set; }

        public string exterior_codPostal { get; set; }

        public string FiliacaoNomePai { get; set; }

        public string FiliacaoNomeMae { get; set; }

        public int CodigoBcoFolha { get; set; }

        public string TipoMskBanco { get; set; }

        public string Agencia { get; set; }

        public string ContaCorrente { get; set; }

        public string NomeTitularConta { get; set; }

        public decimal CPFTitularConta { get; set; }

        public DateTime? DTNascimentoTitularConta { get; set; }

        public int CodigoBcoReembolso { get; set; }

        public string TipoMskBancoReembolso { get; set; }

        public string AgenciaReembolso { get; set; }

        public string ContaCorrenteReembolso { get; set; }








        #endregion

        #region Documentos

        public string RG { get; set; }

        public string OrgaoRG { get; set; }

        public string CidadeRG { get; set; }

        /// <summary>
        /// 
        /// AC
        /// AL
        /// AM
        /// AP
        /// BA
        /// CE
        /// DF
        /// ES
        /// GO
        /// MA
        /// MG
        /// MS
        /// MT
        /// PA
        /// PB
        /// PE
        /// PI
        /// PR
        /// RJ
        /// RN
        /// RO
        /// RR
        /// RS
        /// SC
        /// SE
        /// SP
        /// TO
        /// </summary>
        public string UFRG { get; set; }

        public DateTime? DtExpedicaoRG { get; set; }

        public decimal PIS { get; set; }

        public DateTime? DataCadastroPIS { get; set; }

        public bool PrimeiroEmprego { get; set; }

        public decimal CPF { get; set; }

        public bool CTPSDigital { get; set; }

        public string CarteiraTrabalho { get; set; }

        public string Serie { get; set; }

        /// <summary>
        /// 
        /// AC
        /// AL
        /// AM
        /// AP
        /// BA
        /// CE
        /// DF
        /// ES
        /// GO
        /// MA
        /// MG
        /// MS
        /// MT
        /// PA
        /// PB
        /// PE
        /// PI
        /// PR
        /// RJ
        /// RN
        /// RO
        /// RR
        /// RS
        /// SC
        /// SE
        /// SP
        /// TO
        /// </summary>
        public string UFExpedicao { get; set; }

        public string CidadeExpedicao { get; set; }

        public DateTime? DtExpedicaoCTPS { get; set; }

        public string TituloEleitor { get; set; }

        public int TitEleZona { get; set; }

        public int TitEleSecao { get; set; }

        public string Reservista { get; set; }

        public DateTime? DTExpedicaoReservista { get; set; }

        public string Habilitacao { get; set; }

        public string CNHorgaoemissor { get; set; }

        public string CNH_Modelo { get; set; }

        public DateTime? CNHDataEmissao { get; set; }

        /// <summary>
        /// 
        /// AC
        /// AL
        /// AM
        /// AP
        /// BA
        /// CE
        /// DF
        /// ES
        /// GO
        /// MA
        /// MG
        /// MS
        /// MT
        /// PA
        /// PB
        /// PE
        /// PI
        /// PR
        /// RJ
        /// RN
        /// RO
        /// RR
        /// RS
        /// SC
        /// SE
        /// SP
        /// TO
        /// </summary>
        public string ufCnh { get; set; }

        public DateTime? dtPriHab { get; set; }

        public int CNH_Pontuacao { get; set; }

        public DateTime? CNH_DataRevisao { get; set; }

        public DateTime? DataVectoHabilitacao { get; set; }

        public string CNH_Obs { get; set; }

        public string Motorista_MOOP { get; set; }

        public DateTime? Motorista_DataVectoMOOP { get; set; }

        public string CodigoExameTox { get; set; }

        public DateTime? DataExameTox { get; set; }

        /// <summary>
        /// 
        /// AC
        /// AL
        /// AM
        /// AP
        /// BA
        /// CE
        /// DF
        /// ES
        /// GO
        /// MA
        /// MG
        /// MS
        /// MT
        /// PA
        /// PB
        /// PE
        /// PI
        /// PR
        /// RJ
        /// RN
        /// RO
        /// RR
        /// RS
        /// SC
        /// SE
        /// SP
        /// TO
        /// </summary>
        public string UFCRMExameTox { get; set; }

        public string NrCRMExameTox { get; set; }

        public string CNPJLabExameTox { get; set; }

        public decimal RICnr { get; set; }

        public string RICorgaoemissor { get; set; }

        public DateTime? RICDataEmissao { get; set; }

        public string RNEnr { get; set; }

        public string RNEorgaoemissor { get; set; }

        public DateTime? RNEDataEmissao { get; set; }

        public DateTime? RNEDataVecto { get; set; }

        public string OCnr { get; set; }

        public string Ocorgaoemissor { get; set; }

        public DateTime? OCDataEmissao { get; set; }

        public DateTime? OCDataValidade { get; set; }

        /// <summary>
        /// 0 - Não Informado
        /// 1 - Locais sem filiais
        /// 2 - Estudo de mercado
        /// 3 - Contratação superior a 3 meses
        /// 4 - Prorrogação de contrato
        /// </summary>
        public int TipoAdmSIRETT { get; set; }

        public string MotivoProrrogacao { get; set; }

        public string JustificativaProrrogacao { get; set; }

        public string nmSoc { get; set; }

        public bool reabReadap { get; set; }

        public bool infoCota { get; set; }


        #endregion

        #region Outros

        public string Matricula { get; set; }

        public string Chapa { get; set; }

        public string Chapera { get; set; }

        public int TipoContratoWeb { get; set; }

        public DateTime? DataUltimoExame { get; set; }

        public int DiasVectoExame { get; set; }

        public DateTime? DataVectoExame { get; set; }

        public bool EmissaoEtiqueta { get; set; }

        public bool EmissaoFichaHora { get; set; }

        public bool CartaoPonto { get; set; }

        public bool CalculaIRF { get; set; }

        public bool CalculaINSS { get; set; }

        public bool CalculaGratificacao { get; set; }

        public bool CalculaAnuenio { get; set; }

        public bool CalculaBienio { get; set; }

        public bool CalculaTrienio { get; set; }

        public bool CalculaQuadrienio { get; set; }

        public bool CalculaQuinquenio { get; set; }

        public int ClasseContrib { get; set; }

        public decimal Acum_Troco { get; set; }

        public decimal Acum_SaldoNeg { get; set; }

        public decimal AlqAbonoLider { get; set; }

        public decimal ValorAdtoFixo { get; set; }

        public DateTime? DataLimitePagto { get; set; }

        public decimal TaxaAdt { get; set; }

        public decimal PercentInsalub { get; set; }

        public decimal PercentPericul { get; set; }

        public int CentroCustoContab { get; set; }

        public int CodigoBcoPagar { get; set; }

        public int CodigoSindicato { get; set; }

        public int CodigoCR { get; set; }

        public string AnoMesTransferencia { get; set; }

        public int CodigoEmpresaOrigem { get; set; }

        public int CodigoFilialOrigem { get; set; }

        public int CodigoFuncionarioOrigem { get; set; }

        public string CNPJEmpresaAnterior { get; set; }

        public string LocalTrabalho { get; set; }

        /// <summary>
        /// 0 - Em todos os cálculos s/ rendimentos
        /// 1 - Em todos os cálculos s/ rendimentos após o 15º dia(1º pgto.)
        /// 2 - Todo mês s/ rendimentos
        /// 3 - No final do contrato s/ rendimentos
        /// 4 - Em todos os cálculos s/ salário
        /// 5 - Em todos os cálculos s/ salário após o 15º dia(1º pgto.)
        /// 6 - Todo mês sobre salário
        /// 7 - No final do contrato s/ salário
        /// </summary>
        public int Tipo13o { get; set; }

        /// <summary>
        /// 0 - Em todos os cálculos s/ rendimentos
        /// 1 - Em todos os cálculos s/ rendimentos após o 15º dia(1º pgto.)
        /// 2 - Todo mês s/ rendimentos
        /// 3 - No final do contrato s/ rendimentos
        /// 4 - Em todos os cálculos s/ salário
        /// 5 - Em todos os cálculos s/ salário após o 15º dia(1º pgto.)
        /// 6 - Todo mês sobre salário
        /// 7 - No final do contrato s/ salário
        /// </summary>
        public int TipoFer { get; set; }

        /// <summary>
        /// 1 - Demanda Complementar de Serviços.
        /// 2 - Substituição Transitória de Pessoal Permanente.
        /// </summary>
        public int MotivoContrato { get; set; }

        public string NomeSubstituto { get; set; }

        public decimal CPFSubstituto { get; set; }

        public int CodigoEmpresaSubstituto { get; set; }

        public int CodigoFilialSubstituto { get; set; }

        public int CodigoFuncionarioSubstituto { get; set; }

        public string MotivoSubstituicao { get; set; }

        public string MotivoSubstituicao2 { get; set; }

        public string MotivoSubstituicao3 { get; set; }

        public string MotivoSubstituicao4 { get; set; }

        public string MotivoSubstituicao5 { get; set; }

        public string MotivoSubstituicao6 { get; set; }

        public decimal ValorFixo01 { get; set; }

        public decimal ValorFixo02 { get; set; }

        public decimal ValorFixo03 { get; set; }

        public decimal ValorFixo04 { get; set; }

        public decimal ValorFixo05 { get; set; }

        public int QtdeAnuenio { get; set; }

        public string IdVaga { get; set; }

        public bool RecebendoSD { get; set; }

        #endregion

        #region Fgts/Fat/Pensão

        public string CptFGTS { get; set; }

        /// <summary>
        /// 
        /// 1 -  (apenas 1 vínculo empregatício) Não Exposição a Agente Nocivo
        /// 2 -  (apenas 1 vínculo empregatício) Exposição a Agente Nocivo(Aposentadoria com 15 anos de Serviço)
        /// 3 -  (apenas 1 vínculo empregatício) Exposição a Agente Nocivo(Aposentadoria com 20 anos de Serviço)
        /// 4 -  (apenas 1 vínculo empregatício) Exposição a Agente Nocivo(Aposentadoria com 25 anos de Serviço)
        /// 5 -  (mais de 1 vínculo empregatício) Não Exposição a Agente Nocivo
        /// 6 -  (mais de 1 vínculo empregatício)  Exposição a Agente Nocivo(Aposentadoria com 15 anos de Serviço)
        /// 7 -  (mais de 1 vínculo empregatício) Exposição a Agente Nocivo(Aposentadoria com 20 anos de Serviço)
        /// 8 -  (mais de 1 vínculo empregatício) Exposição a Agente Nocivo(Aposentadoria com 25 anos de Serviço)
        /// </summary>
        public int OcorrenciaFGTS { get; set; }

        public decimal SaldoFGTS { get; set; }

        public decimal JamFGTS { get; set; }

        public DateTime? DataOpcaoFGTS { get; set; }

        public string AgenciaFGTS { get; set; }

        public string ContaFGTS { get; set; }

        public string ChaveGRRF { get; set; }

        public DateTime? DataPrevPgtoGRRF { get; set; }

        public DateTime? DataImpGRRF { get; set; }

        /// <summary>
        /// 0 - Não Informado
        ///1 - Contribuição descontada pelo primeiro empregador(Soma Bases para Calcular Percentual sem abater o desconto anterior)
        ///2 - Contribuição descontada por outra(s) empresa(s) sobre valor inferior ao limite máximo do salário de contribuição(Soma Bases para Calculo e Desconto)
        ///3 - Contribuição sobre o limite máximo de salário de contribuição já descontada em outra(s) empresa(s)  (Sem Desconto Ginfor )
        /// </summary>
        public int IndMV { get; set; }

        /// <summary>
        /// 
        /// Indicação
        /// Seleção
        /// </summary>
        public string TipoFatu { get; set; }

        public decimal PercentFatu { get; set; }

        public string ObsFaturamento { get; set; }

        public decimal SalarioMesGarantido { get; set; }

        public int CodigoSelecionador { get; set; }

        public int CodigoVendedor { get; set; }

        public int CodigoRecrutador { get; set; }

        public int CodigoRepresentante { get; set; }

        public decimal IdFatPedido { get; set; }

        public string NroReqPed { get; set; }

        public decimal ValHoraFatReqPed { get; set; }

        public decimal SalarioFat { get; set; }

        public decimal ValorHorExtFat { get; set; }

        public decimal ValorAdcNotFat { get; set; }

        public decimal ValorFaltaDiaFat { get; set; }

        #endregion

        #region Benefícios

        public decimal PercentualVT { get; set; }

        public DateTime? DataLimiteBNF { get; set; }

        public bool VA_Diario { get; set; }

        /// <summary>
        /// 
        /// A - Ambos
        /// D - Dinheiro
        /// E - Espécie
        /// </summary>
        public string TipoVT { get; set; }

        /// <summary>
        /// 
        /// D - Dinheiro
        /// E - Espécie
        /// </summary>
        public string TipoVR { get; set; }

        public decimal NroCartaoSPTrans { get; set; }

        public decimal NroCartaoRioCard { get; set; }

        public string NroCartaoURBS { get; set; }

        public decimal NroCartaoTransURB { get; set; }

        public decimal NroCartaoSodexhoRH { get; set; }

        public decimal NroCartaoVTC { get; set; }

        public string CartaoSUS { get; set; }

        public string TransLitoral { get; set; }

        public decimal NroCartaoOtimo { get; set; }

        public decimal NroCartaoBHBus { get; set; }

        public decimal NroCartaoTransBetim { get; set; }

        public decimal NroCartaoGuaruPas { get; set; }

        public string NroCarteiraBnfAM { get; set; }

        public string NroCarteiraBnfAO { get; set; }

        public string CartaoMetroCard { get; set; }

        public string CartaoPrePago { get; set; }

        #endregion

        #region Eventos/C.Custo

        public DateTime? DataIniFeriasProg { get; set; }

        public DateTime? DataFimFeriasProg { get; set; }

        public DateTime? DataIniFeriasProg2 { get; set; }

        public DateTime? DataFimFeriasProg2 { get; set; }

        public DateTime? DataIniFeriasProg3 { get; set; }

        public DateTime? DataFimFeriasProg3 { get; set; }

        public bool ProgFer_Abono { get; set; }

        public bool ProgFer_1P13o { get; set; }

        #endregion

        #region Observações

        public string Observacao { get; set; }

        #endregion

        #region Inst. / Funções

        public int CodigoInstituicao { get; set; }

        public int CodigoCurso { get; set; }

        public string NomeCurso { get; set; }

        public string NivelCurso { get; set; }

        public string AtividadeCurso { get; set; }

        public int CodigoSupervisor { get; set; }

        public int CodigoCoordenador { get; set; }

        public string EmailGestor { get; set; }

        public string Curso_UltMatricula { get; set; }

        public DateTime? Curso_DataUltMatricula { get; set; }

        public int Curso_DiasVcto { get; set; }

        public DateTime? Curso_DataVcto { get; set; }

        public int CodigoFuncao2 { get; set; }

        public int CodigoFuncao3 { get; set; }

        public int CodigoFuncao4 { get; set; }

        public int CodigoFuncao5 { get; set; }

        #endregion

        #region Livres

        public string CampoLivre_01 { get; set; }

        public string CampoLivre_02 { get; set; }

        public string CampoLivre_03 { get; set; }

        public string CampoLivre_04 { get; set; }

        public string CampoLivre_05 { get; set; }

        public string CampoLivre_06 { get; set; }

        public string CampoLivre_07 { get; set; }

        public string CampoLivre_08 { get; set; }

        public string CampoLivre_09 { get; set; }

        public string CampoLivre_10 { get; set; }

        //public string CampoLivre_11 { get; set; }   
        //public string CampoLivre_12 { get; set; }
        //public string CampoLivre_13 { get; set; }

        #endregion

        #region Escalas

        /// <summary>
        /// Normal
        /// Sábado
        /// Domingo
        /// Sexta - Feira
        /// </summary>
        public string EscalaTipo { get; set; }

        public int EscalaDiasTrabalho { get; set; }

        public int EscalaDiasDescanso { get; set; }

        public DateTime? EscalaDataInicio { get; set; }

        public DateTime? EscalaDataFim { get; set; }

        #endregion



        #region Novos_Campos
        public int CodCom1 { get; set; }
        public int CodCom2 { get; set; }
        public decimal TaxaVendedor { get; set; }
        public decimal TaxaSelecionador { get; set; }
        public decimal TaxaRepresentante { get; set; }
        public decimal TaxaRecrutador { get; set; }
        public decimal TaxaCom1 { get; set; }
        public decimal TaxaCom2 { get; set; }
        #endregion

        public int ID_GiSelecao { get; set; }
        public string ObsRecrutador { get; set; }

        public bool APISinc { get; set; }


    }
}
