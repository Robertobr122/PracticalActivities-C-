# Atividade: Sistema de Folha de Pagamento com POO

### **Descrição do Problema**

Este projeto é um exercício prático para aplicar os conceitos de **Herança** e **Polimorfismo** em C#. O objetivo é criar um sistema de folha de pagamento simplificado que lida com diferentes tipos de funcionários — **Gerentes** e **Vendedores** — que herdam de uma classe base `Funcionario`. O programa também realiza validações de dados e aplica regras de negócio simples.

### **Solução e Estrutura do Projeto**

A solução foi construída usando **Programação Orientada a Objetos (POO)** para modelar a hierarquia de funcionários de forma eficiente:

* **Classe Base (`Funcionario`)**: Serve como a base para todos os tipos de funcionários. Contém atributos e métodos comuns, como `Nome` e `SalarioBase`, e um método `CalcularSalario()` que pode ser sobrescrito pelas classes filhas. Validações para `Nome` (não pode ser vazio) e `SalarioBase` (deve ser > 1200) são aplicadas aqui, garantindo a integridade dos dados desde o início.

* **Classes Derivadas (`Gerente` e `Vendedor`)**: Herdam da classe `Funcionario`. Cada uma adiciona um atributo específico (`Bonus` para o Gerente e `Comissao` para o Vendedor) e **sobrescrevem** o método `CalcularSalario()` para incluir a lógica de cálculo de salário específica para cada cargo. Essa abordagem demonstra o poder do **Polimorfismo**, permitindo que o programa trate todos os objetos da mesma forma, mesmo que o cálculo de salário seja diferente para cada um.

* **Programa Principal (`Main`)**: Interage com o usuário para coletar os dados, realiza as validações e, com base na escolha do usuário, cria a instância correta (Gerente ou Vendedor). O desafio extra de usar uma lista de funcionários mostra como o polimorfismo permite percorrer uma coleção de objetos de tipos diferentes e chamar o mesmo método (`CalcularSalario()`), obtendo o resultado correto para cada um.

### **Tecnologias e Ferramentas**

* **C#**: Linguagem de programação.
* **Visual Studio / Visual Studio Code**: Ambiente de desenvolvimento.
* **_.NET_**: Framework utilizado.

### **Como Rodar o Projeto**

1.  Clone este repositório para sua máquina local.
2.  Navegue até o diretório do projeto no seu terminal.
3.  Execute o comando `dotnet run` para compilar e rodar a aplicação.
4.  Siga as instruções na tela para cadastrar os funcionários.

### **Principais Aprendizados**

* **Herança**: Modelagem de hierarquias de classes para reutilizar código e estabelecer um relacionamento entre classes (é um tipo de).
* **Polimorfismo**: Capacidade de objetos de classes diferentes responderem ao mesmo método de formas distintas (`CalcularSalario()`).
* **Validações e Regras de Negócio**: Como implementar verificações básicas para garantir que os dados estejam em conformidade com as regras do sistema.
* **Abstração**: A classe base `Funcionario` abstrai os atributos e comportamentos comuns, simplificando a estrutura do código.

---

### **README - English Version**

# Activity: OOP Payroll System

### **Problem Description**

This project is a practical exercise to apply **Inheritance** and **Polymorphism** concepts in C#. The goal is to create a simplified payroll system that handles different types of employees — **Managers** and **Salespeople** — who inherit from a base `Employee` class. The program also performs data validation and applies simple business rules.

### **Solution and Project Structure**

The solution was built using **Object-Oriented Programming (OOP)** to model the employee hierarchy efficiently:

* **Base Class (`Employee`)**: Serves as the foundation for all employee types. It contains common attributes and methods, such as `Name` and `BaseSalary`, and a `CalculateSalary()` method that can be overridden by the child classes. Validations for `Name` (cannot be empty) and `BaseSalary` (must be > 1200) are applied here, ensuring data integrity from the start.

* **Derived Classes (`Manager` and `Salesperson`)**: These classes inherit from `Employee`. Each adds a specific attribute (`Bonus` for the Manager and `Commission` for the Salesperson) and **overrides** the `CalculateSalary()` method to include the specific salary calculation logic for each role. This approach demonstrates the power of **Polymorphism**, allowing the program to treat all objects the same way, even though the salary calculation is different for each.

* **Main Program (`Main`)**: Interacts with the user to collect data, performs validations, and, based on the user's choice, creates the correct instance (Manager or Salesperson). The extra challenge of using an employee list shows how polymorphism allows you to iterate through a collection of different object types and call the same method (`CalculateSalary()`), getting the correct result for each.

### **Technologies and Tools**

* **C#**: The programming language.
* **Visual Studio / Visual Studio Code**: The development environment.
* **_.NET_**: The framework used.

### **How to Run the Project**

1.  Clone this repository to your local machine.
2.  Navigate to the project directory in your terminal.
3.  Run the command `dotnet run` to compile and execute the application.
4.  Follow the on-screen instructions to register the employees.

### **Key Learnings**

* **Inheritance**: Modeling class hierarchies to reuse code and establish a relationship between classes (is-a-type-of).
* **Polymorphism**: The ability of objects from different classes to respond to the same method call in distinct ways (`CalculateSalary()`).
* **Validations and Business Rules**: How to implement basic checks to ensure that data conforms to the system's rules.
* **Abstraction**: The base `Employee` class abstracts common attributes and behaviors, simplifying the code structure.

---