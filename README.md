# TesteCRUD_SPED
Projeto de Desenvolvimento de um CRUD para a tabela PARTICIPANTES, Registro 0150 do SPED - EDF ICMS/IPI

Foi utilizado o .Net Framework(5.6.1) MVC5, com o Entity Framework 6.2 e o Ninject.MVC3(3.2.0) para injeção de Dependências

O Script de Criação do Banco encontra-se na pasta Data da aplicação, sendo para o Banco Microsoft SQL Server.

A Criação da Tabela busca atender as espeificações descritas em http://sped.rfb.gov.br/estatico/0D/2DC4C346EDFCDFAFA26C391C7398D060594B50/GUIA%20PR%C3%81TICO%20DA%20EFD%20-%20Vers%C3%A3o%202.0.22.pdf
, na página 29.

Para a Conexão a um Banco de dados, que tenha sido criado com as regras descritas no Script de criação deste, é necessário mudar a string de conexão
que encontra-se no arquivo TesteCRUD_SPED/WebConfig, alterando a string colocada dentro de da tag <connectionString><add ...>.
Ao final do Arquivo há uma string de conexão a um banco já criado, mas necessita ser inserido no campo correto. Esta string aponta para um banco em um provedor em nuvem, específicamente para este teste, e ficará disponível até dia 30/03/2018.

Para a Criação do banco foram criadas 3 tabelas além da tabela PARTICIPANTE, sendo elas: ESTADOS_IBGE, MUNICIPIOS_IBGE E PAISES_IBGE. Para estas 3 tabelas
no próprio Script de criação do bando já há a carga de dados para elas, e esta não pode deixar de ser feita, pois seu conteúdo é necessários para validações. O conteúdo destas tabelas foi obttido a partir de(http://www.sped.fazenda.gov.br/spedtabelas/AppConsulta/publico/aspx/ConsultaTabelasExternas.aspx?CodSistema=SpedFiscal) na data de 26/03/2018


Descrição de Campos e respectivas validações
Apenas serão declarados aqui os campos que tenham algum tratamento especial

Campo 01 - REG: Por tratar-se de um campo de conteúdo estático para todos os registros, ele não consta na tela, e seu conteúdo é a ele atribuido na definição da Entidade a ele atribuída.

Campo 02 - COD_PART: Conforme a Especificação, neste é indserido algum código, podendo este ser oriundo de algum sistema legado, e devido a este motivo ele foi criado sem incrementação automática

Campo 03 = NOME: Campo Obrigatório

Campo 04 = COD_PAIS
Campo 08 = COD_MUN 
Conforme descrito na Especfificação, estes campos utilizam referências de tabelas do IBGE, e devido a isto, foram utilizadas estas tabelas, e foram disponibilizadas através de DropDownLists, minimizando a possibilidade de erro de digitação do usuário.

Campo 05 = CNPJ
Campo 06 = CPF
Para as validações destes campos foi utilizada a biblioteca docsbr:https://github.com/martinusso/docsbr.net por se tratar de uma biblioteca de fácil implementação e devido a sua confiabilidade

Campo 07 = IE: Foi feito o uso da mesma biblioteca utilizada para as verificações de CPF e CNPJ, porém também é necessário informar o código do estado(IBGE) ou sua sigla, para isto foi utilizada a tabela de Estados do IBGE, confome citada acima. Esta escolha foi disponibilizada por meio de DropDownList.

Campo 09 = SUFRAMA: Não foi encontrado a algorítmo para a verificação do código validador, descrito no documento, e devido a isso, esta validação ainda não foi implementada.

Campo 10 = END: Campo Obrigatório

Campo 11 = NUM
Campo 12 = COMPL
Campo 13 = BAIRRO


