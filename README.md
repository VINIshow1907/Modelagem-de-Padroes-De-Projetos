Projeto de E-commerce com Aplicação de Padrões de Projeto
---

Sobre o Projeto: Este sistema tem como objetivo gerenciar os pedidos feitos em uma plataforma de e-commerce. Cada pedido possui um status que varia conforme o progresso da compra, respeitando regras de validação definidas. Além disso, cada pedido exige a seleção de um tipo de frete (aéreo ou terrestre), sendo necessário calcular o valor com base nessa escolha.

Para gerenciar a transição entre os diferentes status (Aguardando Pagamento, Pago, Enviado ou Cancelado), foi aplicado o padrão de projeto **State**, que permite alterar o comportamento do pedido com base em seu estado atual, de maneira clara e segura.

No cálculo do frete, que varia de acordo com o tipo de envio e pode ser expandido futuramente, foi utilizado o padrão **Strategy**, permitindo que cada lógica de cálculo fique encapsulada e independente, facilitando a manutenção e a escalabilidade do sistema.

---
Implementação dos Padrões de Projeto
-
**Padrão State**  
O padrão State possibilita que um objeto altere seu comportamento conforme seu estado interno.

Foi adotado para controlar as transições de status do pedido, evitando estruturas complexas com vários condicionais.

Cada estado é representado por uma classe que implementa uma interface comum, responsável por definir os métodos de transição.

---
**Padrão Strategy**
-
O padrão Strategy define um conjunto de algoritmos encapsulados em classes distintas, que podem ser utilizadas de forma intercambiável.

Aplicado ao cálculo de frete, permitindo que cada tipo (aéreo ou terrestre) tenha sua própria lógica.

Novas estratégias podem ser implementadas sem alterar o código existente, respeitando os princípios SOLID, especialmente o princípio aberto/fechado.

---
Estrutura da Classe Modelo
-
A classe `Pedido.cs`, localizada na pasta `Models`, representa um pedido no sistema. Seus atributos principais são:

- **Id**: Identificador único do pedido.  
- **Descrição**: Nome do produto.  
- **Valor**: Valor do frete.  
- **TotalGeral**: Valor do produto sem o frete.  
- **PedidoType**: Status atual do pedido.  
- **FreteType**: Tipo de frete selecionado (aéreo ou terrestre).  

Dois enums são utilizados:

- **StatusPedido**: AguardandoPagamento, Pago, Enviado, Cancelado  
- **TipoFrete**: Aereo, Terrestre  

**Diagrama Model**  
![image](https://github.com/user-attachments/assets/6cee50a1-ef81-4503-bc77-0c7407cf8a5b)

---
PedidoService – Regras de Negócio do Pedido
-
A classe `PedidoService`, que implementa a interface `IPedidoService`, concentra toda a lógica de negócio. Ela faz a ponte entre os controladores e o domínio da aplicação.

**Principais funcionalidades:**

1. **Listagem e Consulta**

   - `ListAll()`: Retorna todos os pedidos no formato `PedidoDTO`.
   - `GetById(int id)`: Retorna um pedido pelo ID ou lança exceção se não encontrado.

2. **Criação de Pedido**

   - `GerarPedido(PedidoDTO dto)`:
     - Converte o DTO em entidade.
     - Define o status inicial como AguardandoPagamento.
     - Calcula o frete usando a estratégia apropriada.
     - Salva e retorna o pedido como DTO.

3. **Atualização de Pedido**

   - `AtualizarEntidadeDTO(PedidoDTO dto, int id)`:
     - Permitida apenas se o status for AguardandoPagamento.
     - Recalcula o frete e atualiza os dados.

4. **Transições de Estado (State)**

   - `SucessoAoPagar(int id)`
   - `DespacharPedido(int id)`
   - `CancelarPedido(int id)`

   Esses métodos:
   - Localizam o pedido atual.
   - Aplicam a transição de estado com base na lógica da classe correspondente (`IEstadoPedido`).

5. **Cálculo de Frete (Strategy)**

   - `GerarFretePorTipo(TipoFrete tipo)`:
     - Define dinamicamente a estratégia: `FreteAereo` ou `FreteTerrestre`.

6. **Conversão de Dados**

   - `ConverterParaDTO(Pedido)`: Converte a entidade para DTO.  
   - `ConverterParaModel(PedidoDTO)`: Converte o DTO para entidade.

---
Padrões de Projeto Utilizados
-
**Strategy**
-
- **Interface**: `IFrete`  
- **Implementações**: `FreteTerrestre`, `FreteAereo`  
- Responsáveis por calcular o frete de maneira flexível.

**State**
-
- **Interface**: `IEstadoPedido`  
- **Estados**: `AguardandoPagamento`, `Pago`, `Cancelado`, `Enviado`  
- Controlam de forma segura o ciclo de vida dos pedidos.

---
Diagrama Service
-
![image](https://github.com/user-attachments/assets/4000bdbf-0560-48e7-8add-42d574b2280c)

Estrutura Geral do Projeto
-
O projeto foi desenvolvido em **.NET 6**, utilizando **C#**, e estruturado como uma API RESTful com **ASP.NET Core**. O **Entity Framework Core** é usado para persistência e gerenciamento de migrations.

**Principais diretórios:**

**Controllers**  
- `ControllerPedido.cs`: Contém os endpoints da API.

**Data**
-
- **Builders**: Configurações adicionais dos modelos.  
- **Interfaces**: Contratos dos repositórios.  
- **Repositories**: Implementações dos repositórios.  
- `AppDbContext.cs`: Gerencia conexão e mapeamento com o banco de dados.  
- **Migrations**: Histórico de versões do banco.

**Objects**
-
- **Dtos**: Classe `PedidoDTO` para transporte de dados.  
- **Mappings**: Mapeia entidade ↔ DTO.  
- **Enums**: `PedidoType`, `FreteType`.  
- **Models**: Contém `Pedido.cs`.

**Service**
-
- **Entities**: `PedidoService.cs`, com regras de negócio.  
- **Interfaces**: Interface `IPedidoService.cs`.  
- **States**: Implementações do padrão **State**.  
- **Strategies**: Implementações do padrão **Strategy**.

**Configuração**
-
- `Program.cs`  
- `appsettings.json`

---
Conclusão
-
Este projeto apresenta a aplicação prática dos padrões de projeto **State** e **Strategy** no gerenciamento de pedidos e no cálculo de frete de uma plataforma de e-commerce. A arquitetura adotada favorece organização, reutilização e crescimento da aplicação, permitindo novas implementações com facilidade e segurança.
