# Sistema de Cadastro e Seleção de Heróis

## Descrição

Este programa em C# simula um sistema de cadastro e gerenciamento de heróis.

O usuário pode cadastrar até `5 heróis`, selecionar uma equipe com `3 heróis`, calcular a pontuação total da equipe e visualizar os integrantes escolhidos.

Depois disso, o programa continua funcionando por meio de um menu principal até que o usuário escolha sair.

---
## Como funciona

1. O programa exibe uma mensagem de boas-vindas ao usuário.

2. É apresentado um menu principal com as seguintes opções:
   - `1` → Cadastrar heróis
   - `2` → Selecionar equipe
   - `3` → Calcular pontos da equipe
   - `4` → Exibir equipe selecionada
   - `0` → Sair do programa

3. Na opção **Cadastrar Heróis**:
   - O usuário cadastra `5 heróis`.
   - Para cada herói são informados:
     - Nome
     - Poder
     - Pontuação

4. Na opção **Selecionar Equipe**:
   - O programa exibe todos os heróis cadastrados.
   - O usuário escolhe `3 heróis` pelo número correspondente.
   - Os heróis escolhidos são adicionados à equipe.

5. Na opção **Calcular Pontos da Equipe**:
   - O programa soma os pontos dos heróis selecionados.
   - O total é exibido na tela.

6. Na opção **Exibir Equipe Selecionada**:
   - O programa mostra os `3 heróis escolhidos`.
   - São exibidos:
     - Nome
     - Poder
     - Pontuação de cada herói

7. O programa permanece em execução até que a opção `0` seja escolhida.