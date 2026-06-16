#include <iostream>
#include <string>
#include <vector>

using namespace std;

struct Filme {
    string Nome;
    int Codigo;
    double Preco;
    int Quantidade;
};

int main() {
    vector<Filme> listaprodutos(3);
    cout << "=== CADASTRO DE PRODUTOS ===" << endl;

    for(int i = 0; i < 3; i++){
        cout << "/Digite os dados do produto " << i + 1 << ";" << endl;
        cout << "Nome: ";
        cin >> listaprodutos[i].Nome;
        cout << "Codigo: ";
        cin >> listaprodutos[i].Codigo;
        cout << "Preco: ";
        cin >> listaprodutos[i].Preco;
        cout << "Quantidade: ";
        cin >> listaprodutos[i].Quantidade;
    }
    cout << "\n=== PRODUTOS CADASTRADOS ===" << endl;
    for(int i = 0; i < 3; i++){
        cout << "\nProduto " << i + 1 << ":" << endl;
        cout << "  Nome: " << listaprodutos[i].Nome << endl;
        cout << "  Codigo: " << listaprodutos[i].Codigo << endl;
        cout << "  Preco: " << listaprodutos[i].Preco << endl;
        cout << "  Quantidade: " << listaprodutos[i].Quantidade << endl;
    }
    
    int ValorTotal = listaprodutos[0].Preco * listaprodutos[0].Quantidade + listaprodutos[1].Preco * listaprodutos[1].Quantidade + listaprodutos[2].Preco * listaprodutos[2].Quantidade;

    cout << "\n=== VALOR TOTAL DO ESTOQUE ===" << endl;
    cout << "Valor Total: " << ValorTotal << endl;
}