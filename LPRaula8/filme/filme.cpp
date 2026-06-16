#include <iostream>
#include <string>
#include <vector>

using namespace std;

struct Filme {
    string Titulo;
    string Diretor;
    int Ano;
    int Minutos;
};

int main() {
    vector<Filme> listaFilmes(3);

    cout << "=== CADASTRO DE FILMES ===" << endl;

    for (int i = 0; i < 3; i++) {
        cout << "\nDigite os dados do filme " << i + 1 << ":" << endl;
        
        cout << "Titulo: ";
        cin >> listaFilmes[i].Titulo;
        
        cout << "Diretor: ";
        cin >> listaFilmes[i].Diretor;
        
        cout << "Ano de Lancamento: ";
        cin >> listaFilmes[i].Ano;
        
        cout << "Duracao (em minutos): ";
        cin >> listaFilmes[i].Minutos;
    }

    cout << "\n=== FILMES CADASTRADOS ===" << endl;
    for (int i = 0; i < 3; i++) {
        cout << "\nFilme " << i + 1 << ":" << endl;
        cout << "  Titulo: " << listaFilmes[i].Titulo << endl;
        cout << "  Diretor: " << listaFilmes[i].Diretor << endl;
        cout << "  Ano de Lancamento: " << listaFilmes[i].Ano << endl;
        cout << "  Duracao: " << listaFilmes[i].Minutos << " minutos" << endl;
    }

    int indiceMaisAntigo = 0;
    
    for (int i = 1; i < 3; i++) {
        if (listaFilmes[i].Ano < listaFilmes[indiceMaisAntigo].Ano) {
            indiceMaisAntigo = i;
        }
    }

    cout << "\n=== FILME MAIS ANTIGO ===" << endl;
    cout << "Titulo: " << listaFilmes[indiceMaisAntigo].Titulo << endl;
    cout << "Ano de Lancamento: " << listaFilmes[indiceMaisAntigo].Ano<< endl;

    return 0;
}