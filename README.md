<h1 align="center">IFound</h1>
<p align="center">🚀 API REST para prover dados a um site de achados e perdidos</p>
<a href="https://accurate.com.br/">
<img  src="https://img.shields.io/static/v1?label=API&message=Accurate&color=7159c1&style=for-the-badge&logo=ghost"/> 
</a>

##Sobre
O projeto IFound trata-se de uma API REST para um site de achados e perdidos

## Tabela de conteúdos
<!--ts-->
   * [Sobre](#Sobre)
   * [Tabela de Conteudo](#tabela-de-conteudo)
   * [Features](#features)
   * [Tecnologias](#tecnologias)
   * [Pré-Requisitos](#pre-requisitos)
   * [Rodadando a aplicação](#instalacao)  
   * [Testes](#testes)
<!--te-->

### Features

- [x] Cadastro de um “Achado”/”Perdido”
- [x] Atualização de histórico de um “Achado”/”Perdido”
- [x] Busca com opção de filtros
- [x] Relatório de cruzamento de informações “Achados”/”Perdidos”, dado um categoria e um raio

### 🛠 Tecnologias

Para a construção deste projeto, foram utilizadas as seguintes ferramentas:

- [.NET Core](https://dotnet.microsoft.com/)
- [Entity Framework Core](https://docs.microsoft.com/pt-br/ef/core/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server)
- [NUnit](https://nunit.org/)
- [OData](https://www.odata.org/)

### Pré-requisitos
Antes de começar, você vai precisar ter instalado em sua máquna as seguintes ferramentas:
* Git (https://git-scm.com/book/en/v2/Getting-Started-Installing-Git)
* SDK Do ASP.NET Core Versão 3.1 (https://dotnet.microsoft.com/download/dotnet-core/3.1)
* SQL Server LocalDB (https://docs.microsoft.com/pt-br/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver15) ou seu banco de dados de preferência

### Rodando a aplicação
Para instalar e rodar o projeto em sua máquina, siga os seguintes passos;
* Rode o comando "git clone 'url-do-repositorio'" na sua máquina local
* Para facilitar a criação das estruturas no banco, criei um script para o SQL Server (SetUpDB.sql), basta executá-lo
* Mude a string de conexão com o banco no arquivo 'appsettings.json' com os seus dados de conexão
* Mudar a string de conexão em 'appsettings.json' com os dados do seu banco
* Dentro da pasta "ifound-api", rode o projeto via comando "dotnet run ifound-api.csproj"

### Testes
