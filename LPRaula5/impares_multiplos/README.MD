# Soma de Números Ímpares e Múltiplos de 3

## Descrição

Este programa em C# calcula a soma dos números ímpares que também são múltiplos de 3 no intervalo entre `50` e `500`.

O programa percorre todos os números dentro desse intervalo e verifica quais atendem às condições: ser ímpar e múltiplo de `3`.

Depois disso, a soma total desses números é exibida na tela.

---
## Como funciona

1. O programa exibe uma mensagem informando o objetivo da operação.

2. É criada uma variável chamada `soma`, iniciada com valor `0`.

3. O programa utiliza um laço `for` para percorrer os números de `50` até `500`.

4. Para cada número, é verificado:
   - Se ele é ímpar (`i % 2 != 0`)
   - Se ele é múltiplo de `3` (`i % 3 == 0`)

5. Caso as duas condições sejam verdadeiras, o número é adicionado à variável `soma`.

6. Ao final do laço, o resultado da soma é mostrado na tela.