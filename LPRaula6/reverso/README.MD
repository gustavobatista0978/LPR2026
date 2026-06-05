# Inversão de Número Inteiro

## Descrição

Este programa em C++ inverte a ordem dos dígitos de um número inteiro.

O programa utiliza uma função chamada `inverterInteiro()` para separar os dígitos do número e reconstruí-los na ordem inversa.

Depois disso, o número original e o número invertido são exibidos na tela.

---
## Como funciona

1. O programa define um número inteiro para ser invertido.

2. É criada a função `inverterInteiro()` responsável pela inversão dos dígitos.

3. O programa utiliza um laço `while` para percorrer todos os dígitos do número.

4. Em cada repetição:
   - O último dígito é obtido utilizando `% 10`.
   - O dígito é adicionado ao número reverso.
   - O número original é dividido por `10` para remover o último dígito.

5. O processo continua até que todos os dígitos sejam invertidos.

6. O programa exibe o número original e o número invertido.
