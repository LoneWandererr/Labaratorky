// 17.3.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");
    cout << "3. Дан массив A размера N. Найти минимальный элемент из его элементов с четными номерами: A2, A4, A6," << "\n";
    cout << "Введите размер массива N" << "\n";
    int N, i, x, L = 0 , K = 10000;
    float count = 0;
    int arr[1000] = {};
    cin >> N;
    cout << "Введите числа массива" << "\n";
    for (i = 1; i <= N; i++)
    {
        cin >> x;
        arr[i] = x;
    }
    for (i = 1; i <= N; i++)
    {
        if (i % 2 == 0)
        {
            if (arr[i] < K)
            {
                K = arr[i];
            }
        }
    }

    cout << K << "\n";
}

// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
