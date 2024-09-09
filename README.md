## Projeto UnityTest
### Introdução 

Este repositório contém uma coleção de projetos desenvolvidos com Test-Driven Development (TDD), que se concentram na implementação de vários tipos de testes unitários em C#. Os projetos demonstram como seguir os princípios de TDD para garantir um código limpo, confiável e bem estruturado.

O repositório inclui os seguintes subprojetos:
### Calculator: 

Este projeto contém operações matemáticas básicas que são completamente testadas usando testes unitários.

### Flight

Este projeto simula cenários de reserva de voos, onde o TDD é usado para evitar overbooking e garantir o tratamento correto de casos especiais, como o número restante de assentos e cancelamentos.

## Test-Driven Development (TDD)
![image](https://github.com/user-attachments/assets/7f65f715-7950-4df8-b277-57e7d25efcd9)

O Test-Driven Development (TDD) é uma metodologia de desenvolvimento de software que se baseia em escrever testes antes de escrever o código real. Ele segue um ciclo simples:

### 1. Escrever um teste:

Definir um teste que descreva a funcionalidade desejada de um determinado recurso ou componente. O teste vai falhar, pois a funcionalidade ainda não foi implementada.

### 2. Escrever o código:

Implementar a menor quantidade de código necessária para passar o teste.

#### 3. Refatorar:

Limpar o código, removendo duplicações, melhorando a estrutura e garantindo que a funcionalidade esteja implementada da maneira mais eficiente possível.

Este ciclo é frequentemente chamado de processo Red-Green-Refactor:
![image](https://github.com/user-attachments/assets/674ecaf4-d901-432e-bc2e-fef41129939e)

### Red

 Escreva um teste que falha inicialmente (o teste está vermelho).

 ### Green 

Escreva o código mais simples que faz o teste passar (o teste fica verde).

### Refactor

Otimize o código para melhorar sua estrutura, garantindo que todos os testes ainda passem.

## Por que usar TDD? 
### Qualidade do Código:
Como os testes são escritos antes do código real, os desenvolvedores são obrigados a pensar sobre o design e casos extremos desde o início.
### Redução de Bugs:
Escrever testes primeiro leva a uma compreensão mais detalhada dos requisitos, reduzindo a chance de bugs no futuro.
### Confiança ao Refatorar: 
Com uma suíte sólida de testes, os desenvolvedores podem refatorar e otimizar o código com confiança de que nada será quebrado inesperadamente.
## Tipos de Testes Utilizados
### Testes Unitários:
Esses testes focam em componentes ou métodos individuais. No projeto Calculator, por exemplo, cada função (adição, subtração, etc.) é testada isoladamente.
### Testes de Cenários: 
O projeto Flight utiliza testes baseados em cenários para lidar com lógicas de negócios complexas, como evitar overbooking, cancelamento de reservas e gerenciamento de assentos restantes.

## Conceitos Principais
