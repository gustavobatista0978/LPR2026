#include <iostream>
#include <vector>
#include <string>
#include <iomanip> 


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

    int aprovados = 0;
    int recuperacao = 0;
    int reprovados = 0;
    double somaNotas = 0;

    std::cout << "--- Cadastro de Notas da Turma ---\n";
    for (int i = 0; i < TOTAL_ALUNOS; i++) {
        std::cout << "\nAluno numero " << i + 1 << ":\n";
        std::cout << "Nome: ";
        std::getline(std::cin >> std::ws, nomes[i]); 
        
        do {
            std::cout << "Nota: ";
            std::cin >> notas[i];
            if (notas[i] < 0 || notas[i] > 100) {
                std::cout << "Nota inválida! Digite um valor entre 0 e 100.\n";
            }
        } while (notas[i] < 0 || notas[i] > 100);

        somaNotas += notas[i];
    }

    std::cout << "\n=============================================\n";
    std::cout << "             RELATÓRIO DA TURMA              \n";
    std::cout << "=============================================\n";

    for (int i = 0; i < TOTAL_ALUNOS; i++) {
        std::string situacao = ClassificarAluno(notas[i]);
        
        std::cout << nomes[i] << " - " << notas[i] << " - " << situacao << "\n";

        if (situacao == "Aprovado") {
            aprovados++;
        } else if (situacao == "Recuperacao") {
            recuperacao++;
        } else {
            reprovados++;
        }
    }

    double mediaTurma = somaNotas / TOTAL_ALUNOS;

    std::cout << "---------------------------------------------\n";
    std::cout << "Aprovados: " << aprovados << "\n";
    std::cout << "Recuperacao: " << recuperacao << "\n";
    std::cout << "Reprovados: " << reprovados << "\n";
    
    // Configura para exibir apenas 1 casa decimal na média, igual ao exemplo
    std::cout << std::fixed << std::setprecision(1);
    std::cout << "Media da turma: " << mediaTurma << "\n";
    std::cout << "=============================================\n";

    return 0;
}