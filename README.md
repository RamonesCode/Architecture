# 🧩 Order Management - Arquitetura Hexagonal (.NET 8)

Este projeto demonstra uma implementação prática da **Arquitetura Hexagonal** (também conhecida como Ports and Adapters) usando **.NET 8**. A aplicação simula um sistema básico de **gestão de pedidos**, com separação clara entre o núcleo do domínio e os adaptadores externos.

---

## 🧱 Estrutura do Projeto
   ```bash
OrderManagementHexagonal/
├── OrderManagement.Core # Entidades de domínio e interfaces (Ports) 
│ ├── Entities/Order.cs 
│ └── Ports/IOrderRepository.cs 
├── OrderManagement.Application # Casos de uso (Use Cases) 
│ └── UseCases/CreateOrder.cs 
├── OrderManagement.Infrastructure # Repositórios e dependências externas 
│ └── Repositories/OrderRepository.cs 
├── OrderManagement.API # Camada de apresentação (Controllers) 
│ ├── Controllers/OrdersController.cs 
│ └── Program.cs
   ```

---

## 🧠 Conceitos Aplicados

- **Hexagonal Architecture**: Define o domínio no centro da aplicação. Toda comunicação externa (como APIs, bancos de dados, etc) é feita através de **Ports (interfaces)** e **Adapters (implementações)**.
- **Baixo acoplamento** entre as camadas.
- **Alta testabilidade** devido à abstração por interfaces.

---

## 🚀 Como Rodar o Projeto

1. Abra a solução no Visual Studio ou VS Code.
2. Restaure os pacotes NuGet:
   ```bash
   dotnet restore
3. Compile e execute o projeto Web:
dotnet run --project OrderManagement.API
4. Use uma ferramenta como Postman ou Insomnia para testar os endpoints da API.

🧪 Exemplo de Requisição (POST)
   ```bash
      POST /api/orders
      Content-Type: application/json

      {
         "productName": "Mouse Gamer",
         "quantity": 3
      }
   ```
## 🙌 Contribuições

Sinta-se à vontade para abrir issues, enviar PRs ou sugerir melhorias!

## 🧑‍💻 Autor
Ramon | @RamonesCode
