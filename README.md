# RPA Challenge 🤖

Este projeto foi desenvolvido com o propósito de resolver o desafio proposto pelo site "https://rpachallenge.com/". Nele, é necessário criar um bot capaz de baixar um arquivo Excel, ler seu conteúdo, clicar no botão de Start e preencher dinamicamente o site. Isso ocorre porque a cada nova etapa de inserção dos dados, as colunas mudam de posição dinamicamente.

## Sumário

- [Visão Geral](#visão-geral)
- [Componentes](#componentes)
  - [WebFormService](#webformservice)
  - [ExcelService](#excelservice)
  - [Modelo ExcelData](#modelo-exceldata)
  - [Interfaces](#interfaces)
  - [Injeção de Dependência](#injeção-de-dependência)
- [Como Começar](#como-começar)
- [Uso](#uso)
- [Contribuições](#contribuições)
- [Licença](#licença)

## Visão Geral

O projeto é composto por diversos componentes que trabalham juntos para automatizar o preenchimento de formulários da web. Ele utiliza Selenium WebDriver para interagir com os elementos da web e extrai dados de uma planilha do Excel para preencher os formulários.

## Componentes do Projeto

### WebFormService

A classe `WebFormService` contém métodos para interagir com elementos da web e preencher formulários da web de forma dinâmica. Ele utiliza o Selenium WebDriver para navegar em páginas da web e interagir com campos de formulário.

### ExcelService

A classe `ExcelService` lê dados de uma planilha do Excel, fornecendo uma matriz de objetos `ExcelData` contendo as informações necessárias para preencher os campos do formulário da web.

### Modelo ExcelData

O modelo `ExcelData` representa a estrutura dos dados extraídos da planilha do Excel. Ele contém propriedades como FirstName, LastName, CompanyName, RoleInCompany, Address, Email e PhoneNumber.

### Interfaces

As interfaces (`IExcelService` e `IWebFormService`) definem contratos que os serviços devem implementar. Isso permite a troca mais fácil de implementações e facilita os testes unitários.

### Injeção de Dependência

A classe `DependencyInjection` configura o contêiner de injeção de dependência usando Microsoft.Extensions.DependencyInjection. Ela registra serviços como ChromeDriver (para Selenium WebDriver), `ExcelService` e `WebFormService` para serem injetados na aplicação.

## Como Começar

Para executar o projeto:

1. Certifique-se de ter as dependências necessárias instaladas, incluindo ChromeDriver e o WebDriver apropriado para seu navegador.
2. Atualize a variável `excelFilePath` no arquivo `Program.cs` com o caminho para sua planilha do Excel.
3. Compile e execute a aplicação.

## Uso

Ao executar a aplicação, ela lerá os dados da planilha do Excel especificada e preencherá o formulário da web localizado em https://rpachallenge.com/. O processo de preenchimento do formulário será automatizado com base nos dados fornecidos na planilha do Excel.

## Contribuições

Contribuições para este projeto são bem-vindas. Se você encontrar problemas ou tiver sugestões de melhorias, sinta-se à vontade para abrir um problema ou enviar uma solicitação pull.

## Autor
- Lucas Benediht Caldeira

## Licença

Este projeto está licenciado sob a Licença MIT.
