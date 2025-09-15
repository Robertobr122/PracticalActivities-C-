

# Atividade: Sistema Básico de Conta Bancária

### **Descrição do Problema**

Este projeto é um exercício prático de **Programação Orientada a Objetos (POO)** em C# para criar um sistema de gerenciamento de uma conta bancária simples. O objetivo é aplicar conceitos como classes, atributos, métodos e, principalmente, validações e regras de negócio para garantir a integridade dos dados.

O programa deve:
* Criar uma classe `ContaBancaria` que representa uma conta.
* Gerar um número de conta único e automático.
* Validar a entrada do nome do titular, que não pode ser vazio.
* Validar o saldo inicial, que deve ser igual ou superior a 50.
* Implementar métodos de `Depositar` e `Sacar` com suas respectivas validações.
* Exibir os dados da conta formatados.
* No método `Main`, interagir com o usuário para criar a conta, realizar operações e exibir o resultado final.

### **Solução e Estrutura do Projeto**

A solução é construída em torno da classe `ContaBancaria`, que encapsula a lógica do negócio.

* **Encapsulamento**: Os atributos (`numeroConta`, `titular`, `saldo`) são privados e só podem ser acessados ou modificados através de métodos públicos.
* **Validações**: A validação de dados de entrada é tratada diretamente na classe, garantindo que o objeto `ContaBancaria` sempre esteja em um estado válido. Isso é visível nas verificações para o saldo inicial, o nome do titular, e nos métodos de `Depositar` e `Sacar`.
* **Regras de Negócio**: As regras como o saldo mínimo e a verificação de saldo suficiente para saque são aplicadas dentro dos métodos da classe, isolando a lógica do restante do programa.

### **Tecnologias e Ferramentas**

* **C#**: Linguagem de programação.
* **Visual Studio / Visual Studio Code**: Ambiente de desenvolvimento.
* **_.NET_**: Framework utilizado.

### **Como Rodar o Projeto**

1.  Clone este repositório para sua máquina local.
2.  Navegue até o diretório do projeto no seu terminal.
3.  Execute o comando `dotnet run` para compilar e rodar a aplicação.
4.  Siga as instruções na tela, inserindo os dados da conta.

### **Principais Aprendizados**

* **Classes e Objetos**: Compreensão de como modelar uma entidade do mundo real (`ContaBancaria`) em uma classe de software.
* **Encapsulamento**: A importância de proteger os dados de um objeto e controlar seu acesso através de métodos.
* **Tratamento de Exceções e Validações**: Como garantir que a entrada do usuário e as operações do programa sigam as regras de negócio definidas.
* **Métodos**: Como criar e utilizar métodos para representar ações e comportamentos de um objeto.

---

### **README - English Version**

# Activity: Basic Bank Account System

### **Problem Description**

This project is a practical exercise in **Object-Oriented Programming (OOP)** in C# to create a simple bank account management system. The goal is to apply concepts such as classes, attributes, methods, and, most importantly, data validation and simple business rules to ensure data integrity.

The program must:
* Create a `ContaBancaria` (Bank Account) class to represent an account.
* Generate a unique and automatic account number.
* Validate the account holder's name, which cannot be empty.
* Validate the initial balance, which must be 50 or greater.
* Implement `Deposit` and `Withdraw` methods with their respective validations.
* Display formatted account information.
* In the `Main` method, interact with the user to create the account, perform operations, and display the final result.

### **Solution and Project Structure**

The solution is built around the `ContaBancaria` class, which encapsulates the business logic.

* **Encapsulation**: The attributes (`numeroConta`, `titular`, `saldo`) are private and can only be accessed or modified through public methods.
* **Validations**: Input data validation is handled directly within the class, ensuring the `ContaBancaria` object is always in a valid state. This is evident in the checks for the initial balance, account holder's name, and within the `Deposit` and `Withdraw` methods.
* **Business Rules**: Rules like the minimum balance and sufficient funds for withdrawal are applied within the class's methods, isolating the logic from the rest of the program.

### **Technologies and Tools**

* **C#**: The programming language.
* **Visual Studio / Visual Studio Code**: The development environment.
* **_.NET_**: The framework used.

### **How to Run the Project**

1.  Clone this repository to your local machine.
2.  Navigate to the project directory in your terminal.
3.  Run the command `dotnet run` to compile and execute the application.
4.  Follow the on-screen instructions, entering the account data.

### **Key Learnings**

* **Classes and Objects**: Understanding how to model a real-world entity (`ContaBancaria`) into a software class.
* **Encapsulation**: The importance of protecting an object's data and controlling its access through methods.
* **Exception Handling and Validations**: How to ensure that user input and program operations follow the defined business rules.
* **Methods**: How to create and use methods to represent an object's actions and behaviors.

---