API Rest .NetFramework usable for storing movies in Database.

Technologies used:
.Net6.0
EntityFramework
MySql Workbench 8.0 

Atributos de Roteamento (Annotations)
[ApiController] - Define a classe como um controller da API

[Route] - Define o caminho base para as rotas do controller

[HttpPost] - Mapeia ações para requisições POST

[HttpGet] - Mapeia ações para requisições GET

[HttpPut] - Mapeia ações para requisições PUT

[HttpPatch] - Mapeia ações para requisições PATCH

[HttpDelete] - Mapeia ações para requisições DELETE

Padrões de Projeto e Arquitetura
Injeção de Dependência - Uso de construtor para injetar dependências

DTOs (Data Transfer Objects) - Para transferência de dados entre camadas

Separação de Responsabilidades - Controllers focados apenas no HTTP

Técnicas de API RESTful
Verbos HTTP Semânticos - Uso apropriado de POST, GET, PUT, PATCH, DELETE

Paginação - Para limitar quantidade de dados retornados

CRUD Completo - Create, Read, Update, Delete implementados

Atualização Parcial - Com PATCH para updates específicos

Integração com Banco de Dados
Entity Framework - ORM para comunicação com banco de dados

Configuração via appsettings.json - Configurações de runtime

Banco Local - Desenvolvimento com banco de dados local

Boas Práticas Implementadas
DTOs de Criação - Para operações de POST

DTOs de Leitura - Para operações de GET

Validação em Tempo de Execução - Processamento dinâmico de dados

Configuração Externa - Separação de configurações do código

Estrutura da Aplicação
Controllers - Camada de apresentação/API

Entities - Modelos de domínio

DTOs - Objetos de transferência de dados

Configurações - Arquivos de configuração externos.

Had a good time building it.
