# Atividade: Sistema de Locação de Veículos

### **Descrição do Problema**

Este projeto é um exercício avançado de **Programação Orientada a Objetos (POO)** em C# que simula um sistema de locação de veículos. O objetivo principal é praticar a modelagem de classes, o uso de **herança** e **polimorfismo**, além de implementar regras de negócio complexas e validações robustas em cada etapa do processo.

O sistema foi estruturado para gerenciar clientes, veículos e reservas, com foco em:

* **Validação de Dados**: Garantir que cada objeto (`Cliente`, `Veiculo`, `Reserva`) seja criado com dados válidos, retornando mensagens de erro claras e padronizadas.
* **Herança e Polimorfismo**: Utilizar uma hierarquia de classes (`Veiculo` -> `Carro`, `Moto`, `Caminhao`) para lidar com as particularidades de cada tipo de veículo (regras de CNH, cálculo de diária e acréscimos/descontos).
* **Regras de Negócio**: Aplicar uma série de regras complexas, como idade mínima, categoria de CNH, tarifas diferenciadas, descontos progressivos e taxas de cancelamento.

### **Solução e Estrutura do Projeto**

A solução é baseada em uma arquitetura de classes bem definida, onde cada componente é responsável por um conjunto de funcionalidades, seguindo os princípios de POO:

* **Classe `Cliente`**: Responsável por armazenar e validar os dados do cliente, como nome, idade e categoria da CNH.
* **Hierarquia de Classes de Veículos**:
    * **`Veiculo` (classe base abstrata)**: Define as propriedades e métodos comuns a todos os veículos, como `Placa`, `Modelo` e `CalcularDiaria()`. A abstração evita a criação de instâncias de `Veiculo` genérico, forçando o uso de classes mais específicas.
    * **`Carro`, `Moto`, `Caminhao` (classes derivadas)**: Cada uma herda de `Veiculo` e sobrescreve o método `CalcularDiaria()` para aplicar suas regras de cálculo específicas (descontos progressivos para `Carro`, tarifa reduzida para `Moto` e acréscimo fixo para `Caminhao`).
* **Classe `Reserva`**: Encapsula toda a lógica de uma locação, incluindo o cliente e o veículo associados, datas, status e todos os cálculos de valor. Possui métodos para validar a reserva, confirmar, cancelar e finalizar, garantindo que as regras sejam aplicadas em cada transição de estado.
* **Validações Centralizadas**: As mensagens de validação são padronizadas e retornadas como uma `List<string>`, permitindo que o programa principal colete e exiba todos os erros de uma só vez.

### **Tecnologias e Ferramentas**

* **C#**: Linguagem de programação.
* **Visual Studio / Visual Studio Code**: Ambiente de desenvolvimento.
* **_.NET_**: Framework utilizado.

### **Como Rodar o Projeto**

1.  Clone este repositório para sua máquina local.
2.  Navegue até o diretório do projeto no seu terminal.
3.  Execute o comando `dotnet run` para compilar e rodar a aplicação.
4.  Siga as instruções interativas no console para criar e gerenciar uma reserva.

### **Principais Aprendizados**

* **POO Avançado**: Aplicação prática de classes abstratas, herança e polimorfismo em um cenário de negócios real.
* **Design de Código**: Modelagem de um sistema coeso com responsabilidades bem definidas para cada classe.
* **Validação de Dados**: Como construir sistemas robustos que lidam com dados inválidos de forma controlada, sem travar o programa.
* **Regras de Negócio Complexas**: Traduzir requisitos detalhados de um problema em código limpo e funcional.

---

### **README - English Version**

# Activity: Vehicle Rental System

### **Problem Description**

This project is an advanced exercise in **Object-Oriented Programming (OOP)** in C# that simulates a vehicle rental system. The main goal is to practice class modeling, **inheritance**, and **polymorphism**, while also implementing complex business rules and robust validations at every step of the process.

The system is structured to manage clients, vehicles, and reservations, with a focus on:

* **Data Validation**: Ensuring that each object (`Client`, `Vehicle`, `Reservation`) is created with valid data, returning clear and standardized error messages.
* **Inheritance and Polymorphism**: Using a class hierarchy (`Vehicle` -> `Car`, `Motorcycle`, `Truck`) to handle the specificities of each vehicle type (license category rules, daily rate calculation, and surcharges/discounts).
* **Business Rules**: Applying a series of complex rules, such as minimum age, license category, different rates, progressive discounts, and cancellation fees.

### **Solution and Project Structure**

The solution is based on a well-defined class architecture where each component is responsible for a set of functionalities, following OOP principles:

* **`Client` Class**: Responsible for storing and validating client data, such as name, age, and license category.
* **Vehicle Class Hierarchy**:
    * **`Vehicle` (abstract base class)**: Defines the common properties and methods for all vehicles, such as `LicensePlate`, `Model`, and `CalculateDailyRate()`. The abstraction prevents the creation of generic `Vehicle` instances, enforcing the use of more specific classes.
    * **`Car`, `Motorcycle`, `Truck` (derived classes)**: Each inherits from `Vehicle` and **overrides** the `CalculateDailyRate()` method to apply its specific calculation rules (progressive discounts for `Car`, a reduced rate for `Motorcycle`, and a fixed surcharge for `Truck`).
* **`Reservation` Class**: Encapsulates all the logic for a rental, including the associated client and vehicle, dates, status, and all value calculations. It has methods to validate the reservation, confirm, cancel, and finalize, ensuring that the rules are applied during each state transition.
* **Centralized Validations**: Validation messages are standardized and returned as a `List<string>`, allowing the main program to collect and display all errors at once.

### **Technologies and Tools**

* **C#**: The programming language.
* **Visual Studio / Visual Studio Code**: The development environment.
* **_.NET_**: The framework used.

### **How to Run the Project**

1.  Clone this repository to your local machine.
2.  Navigate to the project directory in your terminal.
3.  Run the command `dotnet run` to compile and execute the application.
4.  Follow the interactive instructions on the console to create and manage a reservation.

### **Key Learnings**

* **Advanced OOP**: Practical application of abstract classes, inheritance, and polymorphism in a real-world business scenario.
* **Code Design**: Modeling a cohesive system with well-defined responsibilities for each class.
* **Data Validation**: How to build robust systems that handle invalid data in a controlled manner, without crashing the program.
* **Complex Business Rules**: Translating detailed problem requirements into clean and functional code.