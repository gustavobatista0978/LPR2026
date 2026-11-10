#include <iostream>
#include <string>
#include <vector>
using namespace std;

class Livro {
public:
    string titulo;
    string autor;
    double ano_de_publicacao;

    Livro(string t, string a, double ano) : titulo(t), autor(a), ano_de_publicacao(ano) {}
};

class biblioteca {
public:
    vector<Livro*> livros;

    void adicionarLivro(Livro* livro) {
        livros.push_back(livro);
    }

    void listarLivros() {
        for (const auto& livro : livros) {
            cout << "Titulo: " << livro->titulo << ", Autor: " << livro->autor << ", Ano de Publicacao: " << livro->ano_de_publicacao << endl;
        }
    }
};

int main() {
    biblioteca* minhaBiblioteca = new biblioteca();

    Livro* livro1 = new Livro("1984", "George Orwell", 1949);
    Livro* livro2 = new Livro("O Senhor dos Aneis", "J.R.R. Tolkien", 1954);

    minhaBiblioteca->adicionarLivro(livro1);
    minhaBiblioteca->adicionarLivro(livro2);

    cout << "Livros na biblioteca:" << endl;
    minhaBiblioteca->listarLivros();

    delete livro1;
    delete livro2;
    delete minhaBiblioteca;

    return 0;
}