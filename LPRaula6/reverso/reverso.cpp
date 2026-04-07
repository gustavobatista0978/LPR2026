#include <iostream>

int inverterInteiro(int n) {
    long reverso = 0;

    while (n != 0) {
        int ultimoDigito = n % 10;
        reverso = (reverso * 10) + ultimoDigito;
        n /= 10;
    }

    return (int)reverso;
}

int main() {
    int numero = -1234;
    std::cout << "Original: " << numero << std::endl;
    std::cout << "Reverso: " << inverterInteiro(numero) << std::endl;

    return 0;
}