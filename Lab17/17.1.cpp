﻿// 17.1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");
    cout << "1. Дан массив размера N и целые числа K и L (1 ≤ K ≤ L ≤ N). Найти среднее арифметическое элементов массива с номерами от K до L включительно" << "\n";
    cout << "Введите размер массива N" << "\n";
    int N, i, x, K, L;
    float count = 0;
    int arr[1000] = {};
    cin >> N;
    cout << "Введите все значения массива" << "\n";
    for (i = 0; i < N; i++)
    {
        cin >> x;
        arr[i] = x;
    }
    cout << "Введите K и L" << "\n";
    cin >> K;
    cin >> L;
    for (i = K; i <= L; i++)
    {
        count += arr[i];
    }
    cout << "Среднее арифметическое данного промежутка: " <<  (count / ((L - K) + 1)) << "\n";
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