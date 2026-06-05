# Simulador de Treinamento Jedi

## Descrição

Este programa em C++ simula o tempo necessário para completar `1000 horas` de treinamento Jedi.

O usuário informa quantas horas ele treina por dia, e o programa calcula quantos dias, semanas e meses serão necessários para alcançar a meta, considerando treino apenas de segunda a sexta-feira.

Depois disso, os resultados são exibidos na tela.

---
## Como funciona

1. O programa pede ao usuário quantas horas ele treina por dia.

2. É criada uma variável para armazenar as horas acumuladas de treino.

3. O programa utiliza um laço `while` para repetir o processo até alcançar `1000 horas`.

4. É verificado o dia da semana:
   - Dias `1 a 5` → treino permitido (segunda a sexta)
   - Dias `6 e 7` → sem treino (fim de semana)

5. As horas de treino são acumuladas apenas nos dias úteis.

6. O programa calcula:
   - Total de horas alcançadas
   - Dias reais de treino
   - Tempo total corrido em dias
   - Aproximação em semanas
   - Aproximação em meses

7. O resultado é mostrado na tela.