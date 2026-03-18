# 🧱 Vertical Slice API (.NET)

Este projeto é uma API desenvolvida em .NET utilizando a abordagem de **Vertical Slice Architecture**, com foco em organização por funcionalidades, baixo acoplamento e alta coesão.

## 🚀 Tecnologias e conceitos aplicados

* .NET 6+
* Entity Framework Core
* MediatR (padrão Mediator)
* CQRS (Command and Query Responsibility Segregation)
* FluentValidation
* Minimal APIs

## 🧠 Arquitetura

O projeto segue o padrão **Vertical Slice**, onde cada funcionalidade é organizada de forma independente, contendo:

* Command/Query
* Handler
* Validator (quando necessário)

Isso elimina a necessidade de camadas tradicionais como Services e Repositories, utilizando diretamente o DbContext dentro dos handlers.

## 📂 Estrutura

```text
Features/
 ├── Pedidos/
 ├── Produtos/

Data/
Entities/
Common/
```

Cada feature encapsula toda a sua lógica, facilitando manutenção, testes e escalabilidade.

## 📌 Funcionalidades

* Criar pedidos
* Listar pedidos
* Buscar pedido por ID
* Criar produtos
* Listar produtos

## 🎯 Objetivo

Este projeto foi desenvolvido com fins de estudo para aprofundar conhecimentos em:

* Arquitetura moderna no .NET
* Padrões de projeto (Mediator, CQRS)
* Organização de código para sistemas escaláveis

## 🔥 Diferenciais

* Sem uso de Services ou Repositories
* Uso direto de DbContext nos handlers
* Separação clara entre comandos e consultas
* Código organizado por feature (Vertical Slice)

## 📈 Possíveis melhorias futuras

* Implementação de autenticação/autorização
* Logs e observabilidade
* Testes automatizados
* Pipeline behaviors mais avançados

---

Feito para fins educacionais 🚀
