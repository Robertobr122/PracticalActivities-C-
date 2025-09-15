# Atividade: Classe Pessoa - Revisão de POO

### **Descrição do Problema**

Este projeto é um exercício simples para consolidar os conceitos fundamentais de **Programação Orientada a Objetos (POO)** em C#. O objetivo é criar uma classe que represente uma pessoa, com seus atributos e comportamentos básicos, como calcular a idade e se apresentar.

O programa deve:
* Criar uma **classe** chamada `Pessoa`.
* Definir os atributos `nome` e `dataNascimento`.
* Implementar um método `Idade()` que calcula a idade com base no ano de nascimento.
* Implementar um método `Apresentar()` que exibe uma saudação formatada, incluindo o nome e a idade da pessoa.

### **Solução e Estrutura do Projeto**

A solução é focada na criação da classe `Pessoa` para encapsular todas as informações e a lógica relacionada a uma pessoa.
* **Classe e Objeto**: A `Pessoa` é a planta (classe) para criar objetos que representam pessoas, cada um com seus próprios dados (`nome`, `dataNascimento`).
* **Métodos**: Os comportamentos de uma pessoa, como "calcular a idade" e "se apresentar", são representados pelos métodos `Idade()` e `Apresentar()`, respectivamente. A lógica para calcular a idade, por exemplo, fica contida dentro do método, garantindo que o objeto seja responsável por sua própria funcionalidade.
* **Cálculo da Idade**: O método `Idade()` utiliza o ano atual para subtrair do ano de nascimento e retornar a idade, demonstrando a interação com dados externos (a data atual).

### **Tecnologias e Ferramentas**

* **C#**: Linguagem de programação.
* **Visual Studio / Visual Studio Code**: Ambiente de desenvolvimento.
* **_.NET_**: Framework utilizado.

### **Como Rodar o Projeto**

1. Clone este repositório para sua máquina local.
2. Navegue até o diretório do projeto no seu terminal.
3. Execute o comando `dotnet run` para compilar e rodar a aplicação. O programa irá instanciar a classe e exibir o resultado no console.

### **Principais Aprendizados**

* **Classes e Objetos**: Reforço da diferença entre a definição (classe) e a instância (objeto).
* **Atributos**: A forma de armazenar os dados de um objeto.
* **Métodos**: A maneira de adicionar comportamentos e lógica a um objeto.
* **Revisão de Fundamentos**: Um exercício prático e direto para solidificar a base de POO.

---

### **README - English Version**

# Activity: Person Class - OOP Review

### **Problem Description**

This project is a simple exercise to reinforce the fundamental concepts of **Object-Oriented Programming (OOP)** in C#. The goal is to create a class that represents a person, with their basic attributes and behaviors, such as calculating age and introducing themselves.

The program must:
* Create a **class** called `Pessoa` (Person).
* Define the attributes `nome` (name) and `dataNascimento` (birthYear).
* Implement an `Idade()` (Age) method that calculates the age based on the birth year.
* Implement an `Apresentar()` (Introduce) method that displays a formatted greeting, including the person's name and age.

### **Solution and Project Structure**

The solution is focused on creating the `Pessoa` class to encapsulate all information and logic related to a person.
* **Class and Object**: `Pessoa` is the blueprint (class) for creating objects that represent people, each with their own data (`nome`, `dataNascimento`).
* **Methods**: A person's behaviors, such as "calculating age" and "introducing themselves," are represented by the `Idade()` and `Apresentar()` methods, respectively. The logic for calculating age, for example, is contained within the method, ensuring the object is responsible for its own functionality.
* **Age Calculation**: The `Idade()` method uses the current year to subtract from the birth year and return the age, demonstrating the interaction with external data (the current date).

### **Technologies and Tools**

* **C#**: The programming language.
* **Visual Studio / Visual Studio Code**: The development environment.
* **_.NET_**: The framework used.

### **How to Run the Project**

1. Clone this repository to your local machine.
2. Navigate to the project directory in your terminal.
3. Run the command `dotnet run` to compile and execute the application. The program will instantiate the class and display the result in the console.

### **Key Learnings**

* **Classes and Objects**: Reinforcing the difference between the definition (class) and the instance (object).
* **Attributes**: The way to store an object's data.
* **Methods**: The way to add behaviors and logic to an object.
* **Fundamentals Review**: A straightforward, practical exercise to solidify the foundation of OOP.

---