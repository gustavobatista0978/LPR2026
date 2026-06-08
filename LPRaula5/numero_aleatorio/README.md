# Jogo de Adivinhação de Número

## Descrição

Este programa em C# cria um jogo de adivinhação em que o usuário deve descobrir um número aleatório entre 0 e 100.

O programa gera um número aleatório e permite que o usuário faça várias tentativas até acertar.

Depois disso, o programa informa o número correto e a quantidade de tentativas realizadas.

---
## Como funciona

1. O programa gera um número aleatório entre `0` e `100`.

2. É criada uma variável para contar a quantidade de tentativas do usuário.

3. O programa exibe uma mensagem pedindo para o usuário adivinhar o número.

4. É utilizado um laço `while` para repetir as tentativas até o usuário acertar.

5. A cada tentativa:
   - O usuário digita um número.
   - O contador de tentativas aumenta.
   - O programa verifica se o número digitado é menor ou maior que o número secreto.

6. O programa fornece dicas:
   - Se o número digitado for menor, informa que o número correto é maior.
   - Se o número digitado for maior, informa que o número correto é menor.

7. Quando o usuário acerta, o programa exibe:
   - Uma mensagem de parabéns
   - O número aleatório correto
   - A quantidade de tentativas realizadas
