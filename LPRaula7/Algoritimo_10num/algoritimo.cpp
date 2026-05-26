#include <Iostream>
using namespace std;

int main()
{
    int num[10];
    int pares[10], impares[10];
    int numpares = 0, numimpares = 0;

    for (int i = 0; i < 10; i++)
    {
        cout << "Digite o numero " << i + 1 << ": ";
        cin >> num[i];

        if (num[i] % 2 == 0)
        {
            pares[numpares] = num[i];
            numpares++;
        }
        else
        {
            impares[numimpares] = num[i];
            numimpares++;
        }
    }
    cout << "Numeros pares: ";
    for (int i = 0; i < numpares; i++)
    {
        cout << pares[i] << " ";
    }
    cout << "Numeros impares: ";
    for (int i = 0; i < numimpares; i++)
    {
        cout << impares[i] << " ";
    }
    return 0;
}