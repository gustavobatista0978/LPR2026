#include <iostream>

using namespace std;

int main() {
    float horasPorDia;
    float horasAcumuladas = 0;
    int diaAtual = 1; 
    int diasDeTreinoEfetivo = 0;

    cout << "--- Simulador de Treinamento Jedi ---" << endl;
    cout << "Quantas horas voce treina por dia? ";
    cin >> horasPorDia;

    while (horasAcumuladas < 1000) {
        int diaDaSemana = (diaAtual - 1) % 7 + 1; 

        if (diaDaSemana <= 5) { 
            horasAcumuladas += horasPorDia;
            diasDeTreinoEfetivo++;
        }

        if (horasAcumuladas < 1000) {
            diaAtual++;
        }
    }

    float semanas = diaAtual / 7.0;
    float meses = semanas / 4.5;

    cout << "\n--- Resultado do Treinamento ---" << endl;
    cout << "Total de horas alcancadas: " << horasAcumuladas << "h" << endl;
    cout << "Dias de treino real (sem FDS): " << diasDeTreinoEfetivo << " dias" << endl;
    cout << "Tempo total corrido: " << diaAtual << " dias" << endl;
    cout << "Equivale a aproximadamente:" << endl;
    cout << "* " << semanas << " semanas" << endl;
    cout << "* " << meses << " meses" << endl;

    return 0;
}