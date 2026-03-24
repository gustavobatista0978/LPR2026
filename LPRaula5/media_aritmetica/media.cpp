#include <iostream>
#include <iomanip>

using namespace std;
int main() {
    int n;
    double sum = 0.0;

    cout << "Digite a quantidade de numeros: ";
    cin >> n;

    for (int i = 0; i < n; ++i) {
        double num;
        cout << "Digite o numero " << (i + 1) << ": ";
        cin >> num;
        sum += num;
    }

    double media = sum / n;
    cout << fixed << setprecision(2);
    cout << "A media aritmetica e: " << media << endl;

    return 0;
}