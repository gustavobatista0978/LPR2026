# Menu de Exercícios Matemáticos

## Descrição

Este programa em C++ apresenta um menu interativo com diferentes exercícios matemáticos.

O usuário pode escolher entre calcular a soma de um intervalo de números, o fatorial de um número ou a média de vários valores digitados.

Depois disso, o programa exibe o resultado da operação escolhida e retorna ao menu até que o usuário decida sair.

---
## Como funciona

1. O programa exibe um menu com opções de exercícios disponíveis.

2. O usuário escolhe uma opção digitando um número.

3. Dependendo da escolha:
   - `1` → Calcula a soma de um intervalo de números.
   - `3` → Calcula o fatorial de um número.
   - `4` → Calcula a média de valores informados.
   - `0` → Encerra o programa.

4. O programa utiliza a estrutura `switch` para executar a função correspondente.

5. Cada exercício possui uma função própria:
   - `exercicio1()` → soma os números entre um início e um fim.
   - `exercicio3()` → calcula o fatorial de um número.
   - `exercicio4()` → calcula a média de vários números.

6. Após mostrar o resultado, o programa retorna ao menu principal.

7. O programa continua funcionando até que o usuário escolha a opção `0`.