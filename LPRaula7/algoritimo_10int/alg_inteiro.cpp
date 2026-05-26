#include <iostream>
using namespace std;

int main() {
    int numeros[10];
    int pesquisa;
    int contador = 0;

    for(int i = 0; i < 10; i++) {
        cout << "Digite um numero: ";
        cin >> numeros[i];
    }

    cout << "Digite o numero que deseja pesquisar: ";
    cin >> pesquisa;

    for(int i = 0; i < 10; i++) {
        if(numeros[i] == pesquisa) {
            cout << "Encontrado na posicao: " << i << endl;
            contador++;
        }
    }

    if(contador > 0) {
        cout << "Quantidade de ocorrencias: " << contador;
    } else {
        cout << "Numero nao encontrado no vetor.";
    }

    return 0;
}