# Activity: Payroll with Inheritance

### **Problem Description**

This project solves a payroll calculation problem for a company with two types of employees: **regular** and **outsourced**. 

The program must:
* Read the number `N` of employees to be registered.
* For each employee, request their name, hours worked, and value per hour.
* If the employee is outsourced, also request an additional charge.
* Calculate each employee's payment, considering a 110% bonus on the additional charge for outsourced employees.
* Finally, display the name and payment of all employees in the same order they were entered.

### **Solution and Project Structure**

The solution was developed using **Object-Oriented Programming (OOP)** concepts in C#, with a focus on **Inheritance**. The structure is as follows:

* **`Funcionario` (Base Class)**: Represents a general employee of the company. It contains basic properties like `Nome`, `Horas`, and `ValorPorHora`, and a `Pagamento()` method to calculate the salary.
* **`Terceirizado` (Derived Class)**: Inherits from `Funcionario` and represents an outsourced employee. It adds the `DespesasAdicionais` property and overrides the `Pagamento()` method to include the 110% bonus on the additional charge, as per the business rule.

This inheritance approach ensures code reuse and adherence to the polymorphism principle, as the payment calculation method behaves differently for each employee type.

### **Technologies and Tools**

* **C#**: Programming language.
* **Visual Studio / Visual Studio Code**: Development environment.
* **_.NET_**: Framework used.

### **How to Run the Project**

1.  Clone this repository to your local machine.
2.  Navigate to the project directory in your terminal.
3.  Run the command `dotnet run` to compile and execute the application.
4.  Follow the on-screen instructions, entering the employee data.

### **Key Learnings**

* **Inheritance**: How to model objects with hierarchies, allowing derived classes (subclasses) to reuse and extend the functionality of base classes (superclasses).
* **Polymorphism**: The ability of a method to have different implementations in different classes, which is essential for the payment calculation logic.
* **`virtual` and `override` Modifiers**: Deeper understanding of how to use these modifiers to enable and implement method overriding in derived classes.
* **Generic Lists (`List<T>`)**: Using collections to efficiently store and manipulate objects of different types (regular and outsourced employees).

---

# Atividade: Folha de Pagamento com Herança

### **Descrição do Problema**

Este projeto resolve um problema de cálculo de folha de pagamento para uma empresa que possui dois tipos de funcionários: **próprios** e **terceirizados**. 

O programa deve:
* Receber a quantidade `N` de funcionários a serem cadastrados.
* Para cada funcionário, solicitar o nome, o número de horas trabalhadas e o valor por hora.
* Se o funcionário for terceirizado, solicitar também uma despesa adicional.
* Calcular o pagamento de cada funcionário, considerando um bônus de 110% sobre a despesa adicional para os terceirizados.
* Ao final, exibir o nome e o pagamento de todos os funcionários na ordem em que foram cadastrados.

### **Solução e Estrutura do Projeto**

A solução foi desenvolvida utilizando os conceitos de **Programação Orientada a Objetos (POO)** em C#, com foco na **Herança**. A estrutura é a seguinte:

* **`Funcionario` (Classe Base)**: Representa o funcionário geral da empresa. Contém as propriedades básicas como `Nome`, `Horas` e `ValorPorHora`, e um método `Pagamento()` para calcular o pagamento.
* **`Terceirizado` (Classe Derivada)**: Herda de `Funcionario` e representa um funcionário terceirizado. Adiciona a propriedade `DespesasAdicionais` e sobrescreve o método `Pagamento()` para incluir o bônus de 110% sobre a despesa adicional, conforme a regra de negócio.

Essa abordagem de herança garante a reutilização de código e a aderência ao princípio do polimorfismo, já que o método de cálculo de pagamento se comporta de maneira diferente para cada tipo de funcionário.

### **Tecnologias e Ferramentas**

* **C#**: Linguagem de programação.
* **Visual Studio / Visual Studio Code**: Ambiente de desenvolvimento.
* **_.NET_**: Framework utilizado.

### **Como Rodar o Projeto**

1.  Clone este repositório para sua máquina local.
2.  Navegue até o diretório do projeto no seu terminal.
3.  Execute o comando `dotnet run` para compilar e rodar a aplicação.
4.  Siga as instruções na tela, inserindo os dados dos funcionários.

### **Principais Aprendizados**

* **Herança**: Como modelar objetos com hierarquias, permitindo que classes derivadas (subclasses) reutilizem e estendam a funcionalidade de classes base (superclasses).
* **Polimorfismo**: A capacidade de um método ter diferentes implementações em diferentes classes, essencial para a lógica de cálculo de pagamento.
* **Modificadores `virtual` e `override`**: Aprofundamento no uso desses modificadores para habilitar e implementar a sobrescrita de métodos em classes derivadas.
* **Listas Genéricas (`List<T>`)**: Utilização de coleções para armazenar e manipular objetos de diferentes tipos (funcionários próprios e terceirizados) de forma eficiente.

---