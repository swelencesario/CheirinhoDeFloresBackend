# CheirinhoDeFloresBackend

- Este projeto é o Back End do aplicativo “Cheirinho de Flores”, uma floricultura virtual. O link do repositório do Front End Mobile está aqui: [Link do Front End Mobile](https://github.com/swelencesario/CheirinhoDeFlores)

- O projeto Back End está sendo desenvolvido com a linguagem C# e os frameworks .Net e .AspNet Core.
- Bando de dados do tipo relacional, com MySQL Server.
- ORM para integração com o banco de dados, com EntityFrameworkCore.
- Padrão arquitetural: Clean Architecture com CQRS (MediatR)
 
### Foram implementados endpoints para as seguintes finalidades:

- Cadastrar um usuário
- Realizar login
- Buscar todos os produtos
- Buscar um produto por ID
- Adicionar produtos ao carrinho

### Para rodar a aplicação

- É necessário ter instalado o .Net 8
- É necessário ter instalado o AspNet Core (colocar a versão)
- É necessário ter uma IDE que rode projetos .Net, como Visual Studio ou Visual Studio Code (Para VS Code é necessário instalações de extensões da Microsoft).
 
- Clone este projeto e o abra com a IDE de sua escolha.
- Digite no terminal o comando dotnet Restore para instalar as dependências
- Rode a aplicação por meio do botão “Run”

- PS: Como o banco de dados está rodando em servidor local, não haverá conexão utilizando outras máquinas.


