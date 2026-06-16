#include <iostream>
#include <string>
#include <vector>

using namespace std;

struct Livro {
    string Titulo;
    string Autor;
    int ano;
    int paginas;
    double preco;
};

int main() {
    vector<Livro> listaLivros(3);
    cout << "=== CADASTRO DE LIVROS ===" << endl;
    for(int i = 0; i < 3; i++){
        cout << "/Digite os dados do livro " << i + 1 << ";" << endl;
        cout << "Titulo: ";
        cin >> listaLivros[i].Titulo;
        cout << "Autor: ";
        cin >> listaLivros[i].Autor;
        cout << "Ano: ";
        cin >> listaLivros[i].ano;
        cout << "Paginas: ";
        cin >> listaLivros[i].paginas;
        cout << "Preco: ";
        cin >> listaLivros[i].preco;
    }
    cout << "\n=== LIVROS CADASTRADOS ===" << endl;
    for(int i = 0; i < 3; i++){
        cout << "\nLivro " << i + 1 << ":" << endl;
        cout << "  Titulo: " << listaLivros[i].Titulo << endl;
        cout << "  Autor: " << listaLivros[i].Autor << endl;
        cout << "  Ano: " << listaLivros[i].ano << endl;
        cout << "  Paginas: " << listaLivros[i].paginas << endl;
        cout << "  Preco: " << listaLivros[i].preco << endl;
    }
    double precototal = listaLivros[0].preco + listaLivros[1].preco + listaLivros[2].preco;
    double mediapaginas = (listaLivros[0].paginas + listaLivros[1].paginas + listaLivros[2].paginas) / 3;
    cout << "\n=== RESUMO DOS LIVROS ===" << endl;
    cout << "Preco total: " << precototal << endl;
    cout << "Media de paginas: " << mediapaginas << endl;
}
