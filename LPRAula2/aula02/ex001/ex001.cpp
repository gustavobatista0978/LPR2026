#include <iostream>
#include <iomanip>

int main() {
    std::cout << "Digite o valor da raio:" << std::endl;
    double raio;
	if (!(std::cin >> raio)) return 0;
	const double PI = 3.14159;
	double area = PI * raio * raio;
	std::cout << "A=" << std::fixed << std::setprecision(4) << area << std::endl;
	return 0;
}