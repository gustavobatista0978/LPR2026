#include <iostream>
#include <string>
using namespace std;

class Produto {
public:
    string nome;
    double preco;

    Produto(string n, double p) : nome(n), preco(p) {}
};

class Pedido {
public:
    Produto* produto;
    int quantidade;

    Pedido(Produto* prod, int qtd) : produto(prod), quantidade(qtd) {}

    double PrecoTotal() {
        return produto->preco * quantidade;
    }
};

int main() {
    Produto* notebook = new Produto("Notebook Gamer", 4500.00);
    Pedido pedido(notebook, 2);

    cout << "Produto: " << pedido.produto->nome << endl;
    cout << "Quantidade: " << pedido.quantidade << endl;
    cout << "Preço total: R$ " << pedido.PrecoTotal() << endl;

    delete notebook;
    return 0;
}