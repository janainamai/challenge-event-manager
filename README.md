# EventManager
Gerenciador de eventos: este é o primeiro programa que eu fiz e foi utilizado para aplicar em uma vaga de desenvolvedora.

Seja bem vindo, segue abaixo as orientações sobre o funcionamento do programa:

**Requisitos para rodar o programa:**
IDE: Visual Studio 2019 (english)
Banco de dados: SQL Server

**PREPARANDO O BANCO DE DADOS**
1. Clonar o repositório para a sua máquina.
2. Abra a solution EventManager com o Visual Studio 2019.
3. Primeiramente iremos criar um banco de dados acessando a aba Server Explorer.
  Para visualizar a aba Server Explorer:
  a. Ctrl + W, L
  b. View -> Server Explorer

  Na janela Server Explorer, clique com o botão direito em "Data Connections", em seguida "Add connection".
  Em "Data Source" deve constar: Microsoft SQL Server Database File (SqlClient).
  Em "Database file name (new or existing)" insira o nome desejado.
  Em "Log on to the server" marque a opção "Use Windows Authentication".
  Clique em "ok", em seguida abrirá uma janela, clique em "yes".

  Nosso banco de dados está criado, agora vamos criar as tabelas do banco.
  Na pasta do EventManager você irá encontrar o arquivo "query_database.txt", nele estão as querys necessárias para o programa funcionar.
  Abra-o e copie tudo que há dentro.

  Agora continuamos no Visual Studio.
  Ainda no Server Explorer, dentro do Data Connections, localize o banco de dados com o nome que você inseriu. 
  Clique com o botão direito nele, depois clique em "New Query".
  Irá abrir uma nova aba, cole dentro dela o que copiamos do arquivo query_database.txt.
  Tecle Ctrl + Shift + E para executar todas as querys.
  
  Agora que o banco está criado, precisamos copiar o local onde ele se encontra.
  No Data Connections, clique novamente com o botão direito no banco de dados, depois em "Properties".
  Abrirá a janela Properties, localize o "Connection String", copie TODO o texto que existe ao lado.
  
  Abra o Solution Explorer 
     View -> Solution Explorer
     Ctrl + W, S
  Localize a camada "DataAcessLayer", clique nela e abra a pasta "References", nela haverá uma classe chamada "ConnectionHelper", dê dois cliques para abrir.
  Haverá um método chamado GetConnectionHelper, dentro dele cole o local do banco de dados onde diz "Insira aqui o local do banco de dados" SEM APAGAR O ARROBA E AS ÁSPAS.
  
4. Pronto, agora o programa está pronto para ser executado. Para executar clique em "Start" ou precione F5.

**UTILIZANDO O PROGRAMA/FUNCIONAMENTO**
  Abrirá a página de login, segue abaixo os dados para acesso:
  Usuário: admin
  Senha: admin

1. Siga os passos conforme orientações que apareceram na tela.
Passo um: insira todas as pessoas no banco de dados.
Passo dois: Cadastre as salas de treinamento (informe a sala menor, para inserir as demais basta informar o nome).
Passo três: Cadastre as duas salas de café.
Passo quatro: clique em finalizar para organizar o evento.

Para consultar as pessoas: clique na aba CONSULTA -> Pessoas
  Você também pode pesquisar as pessoas pelo nome.
Para consultar as salas: clique na aba CONSULTA -> Salas
  Selecione o tipo de sala para acessar as salas (treinamento ou café).
  Clique na sala para ver quais pessoas a utilizarão em cada etapa.

Para criar um novo evento, clique na aba EVENTO -> Novo Evento.
Todos os registros serão excluídos e você poderá repetir o processo novamente.

**CONHEÇA MAIS**
Existe um arquivo na pasta do projeto chamado "Conheça o programa.pdf".
Nele você encontra mais informações sobre diferenciais, camadas do programa e particularidades.
