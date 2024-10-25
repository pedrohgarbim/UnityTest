## 🧪 Projeto UnityTest
### Exemplo de Projeto com varios testes

Para maior entendimento de como funciona um projeto com diversos testes, vizualize o projeto pets, com mais de 1850 linhas dedicadas para testes. Clique no link do
[Conexão Canina.](https://github.com/pedrohgarbim/conexao-canina-backend/tree/main)
### 📚 Introdução 

Este repositório contém uma coleção de projetos desenvolvidos com **Test-Driven Development (TDD)**, que se concentram na implementação de vários tipos de testes unitários em C#. Os projetos demonstram como seguir os princípios de TDD para garantir um código limpo, confiável e bem estruturado.

O repositório inclui os seguintes subprojetos:

### 🧮 Calculator: 

Este projeto contém operações matemáticas básicas que são completamente testadas usando testes unitários.

### ✈️ Flight:

Este projeto simula cenários de reserva de voos, onde o TDD é usado para evitar overbooking e garantir o tratamento correto de casos especiais, como o número restante de assentos e cancelamentos.

---

## 🛠️ Test-Driven Development (TDD)

![image](https://github.com/user-attachments/assets/7f65f715-7950-4df8-b277-57e7d25efcd9)

O **Test-Driven Development (TDD)** é uma metodologia de desenvolvimento de software que se baseia em escrever testes antes de escrever o código real. Ele segue um ciclo simples:

### 1️⃣ Escrever um teste:

Definir um teste que descreva a funcionalidade desejada de um determinado recurso ou componente. O teste vai falhar, pois a funcionalidade ainda não foi implementada.

### 2️⃣ Escrever o código:

Implementar a menor quantidade de código necessária para passar o teste.

### 3️⃣ Refatorar:

Limpar o código, removendo duplicações, melhorando a estrutura e garantindo que a funcionalidade esteja implementada da maneira mais eficiente possível.

---

Este ciclo é frequentemente chamado de processo **Red-Green-Refactor**:

![image](https://github.com/user-attachments/assets/674ecaf4-d901-432e-bc2e-fef41129939e)

### 🔴 Red

Escreva um teste que falha inicialmente (o teste está vermelho).

### 🟢 Green 

Escreva o código mais simples que faz o teste passar (o teste fica verde).

### 🔵 Refactor

Otimize o código para melhorar sua estrutura, garantindo que todos os testes ainda passem.

---

## 🧑‍💻 Por que usar TDD?

### ✅ Qualidade do Código:
Como os testes são escritos antes do código real, os desenvolvedores são obrigados a pensar sobre o design e casos extremos desde o início.

### 🐞 Redução de Bugs:
Escrever testes primeiro leva a uma compreensão mais detalhada dos requisitos, reduzindo a chance de bugs no futuro.

### 🔄 Confiança ao Refatorar: 
Com uma suíte sólida de testes, os desenvolvedores podem refatorar e otimizar o código com confiança de que nada será quebrado inesperadamente.

---

## 🔍 Tipos de Testes Utilizados

### 🔬 Testes Unitários:
Esses testes focam em componentes ou métodos individuais. No projeto **Calculator**, por exemplo, cada função (adição, subtração, etc.) é testada isoladamente.

### 🎯 Testes de Cenários: 
O projeto **Flight** utiliza testes baseados em cenários para lidar com lógicas de negócios complexas, como evitar overbooking, cancelamento de reservas e gerenciamento de assentos restantes.

---

## 📖 Conceitos Principais

### ✍️ Abordagem Test First:
No TDD, os testes são escritos primeiro para definir o comportamento de uma funcionalidade antes de a implementação começar. Essa abordagem garante que a implementação seja guiada pelos casos de teste, levando a uma melhor compreensão e cobertura dos requisitos.

### 🔄 Red-Green-Refactor:
Este projeto segue o processo tradicional Red-Green-Refactor:

- 🔴 **Red**: O teste é escrito e falha inicialmente.
- 🟢 **Green**: O código é escrito para passar no teste.
- 🔵 **Refactor**: O código é limpo sem quebrar o teste.

### ✈️ Cenários de Reserva de Voos:
No projeto **Flight**, os princípios do TDD são aplicados a cenários como:

- ✈️ Reservar um voo e garantir que o número correto de assentos esteja disponível.
- ❌ Lidar com cenários de overbooking.
- 🪑 Cancelar reservas e liberar assentos.
- ⚠️ Implementar casos extremos para reservas inválidas.

---

## 🏁 Conclusão

Este projeto serve como um exemplo abrangente de como o TDD pode ser aplicado a diferentes cenários, desde testes unitários simples para uma calculadora até testes de cenários mais complexos para reservas de voos. Seguindo o processo de **TDD**, o objetivo é melhorar a qualidade do código e garantir que todos os casos extremos sejam tratados desde o início.

---
