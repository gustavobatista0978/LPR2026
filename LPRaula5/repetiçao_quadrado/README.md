# Soma dos Dígitos do Quadrado de um Número

## Descrição

Este programa em C# calcula o quadrado de um número inteiro informado pelo usuário, em seguida, realiza a soma dos dígitos desse resultado.

O usuário digita um número, e o programa eleva esse valor ao quadrado.

Depois disso, os dígitos do quadrado são separados e somados, exibindo o resultado final na tela.

---
## Como funciona

1. O programa pede ao usuário um número inteiro.

2. O valor digitado é armazenado na variável numero.

3. O programa calcula o quadrado do número.

4. É criada uma variável para armazenar a soma dos dígitos.

5. O programa utiliza um laço `while` para percorrer cada dígito do número ao quadrado.

6. Em cada repetição:
   - O último dígito é obtido utilizando o operador `%`.
   - O dígito é somado à variável `soma`.
   - O número é dividido por `10` para remover o último dígito.

7. Ao final, a soma dos dígitos é exibida na tela.