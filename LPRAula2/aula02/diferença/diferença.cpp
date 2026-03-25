#include <iostream>

int main() {
	std::cout << "Digite 4 valores inteiros: " << std::endl;    
	int a, b, c, d;
	std::cin >> a >> b >> c >> d;
	int diferenca = (a * b - c * d);
	std::cout << "DIFERENCA = " << diferenca << std::endl;
	return 0;
}