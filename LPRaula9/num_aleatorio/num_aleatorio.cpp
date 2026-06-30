#include <iostream>
#include <list>
#include <cstdlib>
#include <ctime>

using namespace std;

int main()
{
    list<int> numeros;
    list<int> impares;

    srand(time(0));

    for (int i = 0; i < 100; i++)
    {
        numeros.push_back(rand() % 100);
    }

    numeros.sort();

    cout << "Lista ordenada:\n";

    for (int num : numeros)
    {
        cout << num << " ";
    }

    cout << "\n\n";

    for (int num : numeros)
    {
        if (num % 2 != 0)
        {
            impares.push_back(num);
        }
    }

    cout << "Lista sem numeros pares:\n";

    for (int num : impares)
    {
        cout << num << " ";
    }

    cout << "\n\nNumeros repetidos:\n";

    bool repetido = false;

    for (int num : impares)
    {
        int contador = 0;

        for (int outro : impares)
        {
            if (num == outro)
            {
                contador++;
            }
        }

        if (contador > 1)
        {
            bool jaMostrado = false;

            for (int verificador : impares)
            {
                if (verificador == num)
                {
                    if (jaMostrado)
                    {
                        break;
                    }

                    if (verificador == num && verificador != *impares.begin())
                    {
                        jaMostrado = true;
                    }
                }
            }

            if (!jaMostrado)
            {
                cout << num << " ";
                repetido = true;
            }
        }
    }

    if (!repetido)
    {
        cout << "Nenhum numero repetido";
    }

    return 0;
}