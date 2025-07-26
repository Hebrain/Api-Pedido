## 🧱 Api-Pedido

Este é um projeto exemplo de uma API REST moderna construída com:

- ✅ Clean Architecture (camadas bem definidas)
- ✅ CQRS (Command Query Responsibility Segregation)
- ✅ Vertical Slice (cada use case é isolado)
- ✅ MediatR (orquestração entre camadas)
- ✅ Entity Framework Core (InMemory para persistência)
- ✅ SOLID Principles

---

## 📐 Arquitetura

O projeto é estruturado em **camadas horizontais (Clean Architecture)**, e os casos de uso (`UseCases`) são implementados como **fatias verticais (Vertical Slices)**, seguindo o padrão **CQRS**:

---

## 🧠 Aplicação dos Princípios SOLID

Este projeto aplica os princípios SOLID em diversos pontos da arquitetura, garantindo um código limpo, desacoplado e testável:

✅ S — Single Responsibility Principle (SRP)
Cada classe tem uma única responsabilidade bem definida.

**Exemplos:**
CriarPedidoHandler.cs: responsável apenas por processar o caso de uso "Criar Pedido".
PedidoController.cs: apenas delega as requisições para os handlers via MediatR, sem conter lógica de negócio.
</br>

✅ O — Open/Closed Principle (OCP)
As funcionalidades podem ser estendidas sem alterar o código existente.

**Exemplos:**
Novos comandos/queries podem ser adicionados (ex: AtualizarPedidoCommand) sem modificar os handlers existentes.
</br>

✅ L — Liskov Substitution Principle (LSP)
Implementações podem ser substituídas por abstrações sem afetar o sistema.

**Exemplos:**
CriarPedidoHandler e ObterPedidosHandler dependem de IPedidoRepository — qualquer implementação concreta pode ser injetada (ex: fake para testes)
</br>

✅ I — Interface Segregation Principle (ISP)
Interfaces são enxutas e específicas para seu propósito.

**Exemplos:**
IPedidoRepository define apenas os métodos necessários (Criar, ObterTodos) — nenhuma classe é forçada a implementar métodos que não usa.
</br>

✅ D — Dependency Inversion Principle (DIP)
Camadas de alto nível não dependem de implementações, mas de abstrações.

**Exemplos:**
CriarPedidoHandler e ObterPedidosHandler dependem da interface IPedidoRepository, não da implementação concreta.
A injeção de dependência é feita no ServiceCollectionExtensions.cs, mantendo o acoplamento baixo.

---

## 🧰 Tecnologias Utilizadas
- .NET 8
- MediatR
- Entity Framework Core (InMemory)
- Swagger / Swashbuckle

---

## 📌 Futuras melhorias
- Autenticação e autorização com JWT
- Testes automatizados com xUnit + Moq
- Logs e métricas

---

## 📬 Contato
[Hebrain Lima – LinkedIn](https://www.linkedin.com/in/hebrain-lima/)

Projeto demonstrativo para fins educacionais e profissionais.
