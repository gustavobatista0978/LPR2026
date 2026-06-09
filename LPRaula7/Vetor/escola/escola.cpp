#include <iostream>
#include <vector>
#include <string>

std::string ClassificarAluno(int nota) {
    if (nota < 60) {
        return "Reprovado";
    } else if (nota >= 60 && nota <= 79) {
        return "Recuperacao";
    } else { // nota >= 80
        return "Aprovado";
    }
}

int main() {

    const int TOTAL_ALUNOS = 10;
    std::vector<std::string> nomes(TOTAL_ALUNOS);
    std::vector<int> notas(TOTAL_ALUNOS);

    // 1. Leitura dos dados dos 10 alunos
    std::cout << "--- Cadastro de Notas da Turma ---\n";
    for (int i = 0; i < TOTAL_ALUNOS; i++) {
        std::cout << "\nAluno numero " << i + 1 << ":\n";
        std::cout << "Nome: ";
        std::getline(std::cin >> std::ws, nomes[i]); 
        
        do {
            std::cout << "Nota (0 a 100): ";
            std::cin >> notas[i];
            if (notas[i] < 0 || notas[i] > 100) {
                std::cout << "Nota invalida! Digite um valor entre 0 e 100.\n";
            }
        } while (notas[i] < 0 || notas[i] > 100);
    }

    std::cout << "\n=============================================\n";
    std::cout << "             RELATORIO DA TURMA              \n";
    std::cout << "=============================================\n";
    std::cout << "Nome do Aluno         | Nota | Situacao\n";
    std::cout << "---------------------------------------------\n";

    for (int i = 0; i < TOTAL_ALUNOS; i++) {
        std::string situacao = ClassificarAluno(notas[i]);
        
        std::cout << nomes[i] << "\t\t| " << notas[i] << "   | " << situacao << "\n";
    }
    std::cout << "=============================================\n";

    return 0;
}