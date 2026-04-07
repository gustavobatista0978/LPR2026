#include <iostream>
#include <iomanip>

using namespace std;

void exercicio1(int inicio, int fim) {
    int soma = 0;
    for (int i = inicio; i <= fim; i++) {
        soma += i;
    }
    cout << "\n[Ex 1] A soma dos numeros entre " << inicio << " e " << fim << " e: " << soma << endl;
}

void exercicio3(int n) {
    if (n < 0) {
        cout << "\n[Ex 3] Erro: Nao existe fatorial de numero negativo." << endl;
        return;
    }
    double fatorial = 1;
    for (int i = 1; i <= n; i++) {
        fatorial *= i;
    }
    cout << "\n[Ex 3] O fatorial de " << n << " e: " << fatorial << endl;
}

void exercicio4(int quantidade) {
    if (quantidade <= 0) {
        cout << "\n[Ex 4] Quantidade invalida." << endl;
        return;
    }
    float valor, soma = 0;
    for (int i = 1; i <= quantidade; i++) {
        cout << "Digite o " << i << "o valor: ";
        cin >> valor;
        soma += valor;
    }
    cout << "\n[Ex 4] A media dos " << quantidade << " valores e: " << fixed << setprecision(2) << (soma / quantidade) << endl;
}

int main() {
    int opcao, val1, val2;

    do {
        cout << "\n--- MENU DE EXERCICIOS ---" << endl;
        cout << "1 - Soma de intervalo (Ex 1)" << endl;
        cout << "3 - Calcular Fatorial (Ex 3)" << endl;
        cout << "4 - Calcular Media (Ex 4)" << endl;
        cout << "0 - Sair" << endl;
        cout << "Escolha uma opcao: ";
        cin >> opcao;

        switch (opcao) {
            case 1:
                cout << "Informe o inicio e o fim do intervalo: ";
                cin >> val1 >> val2;
                exercicio1(val1, val2);
                break;
            case 3:
                cout << "Digite o numero para calcular o fatorial: ";
                cin >> val1;
                exercicio3(val1);
                break;
            case 4:
                cout << "Quantos numeros deseja inserir para a media? ";
                cin >> val1;
                exercicio4(val1);
                break;
            case 0:
                cout << "Saindo do programa" << endl;
                break;
            default:
                cout << "Opcao invalida!" << endl;
        }
    } while (opcao != 0);

    return 0;
}