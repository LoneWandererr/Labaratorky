// 16.1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");
    cout << "1. Дано целое число N (> 0). Сформировать и вывести целочисленный массив размера N, содержащий N первых положительных нечетных чисел: 1, 3, 5, . . . .\n";
    int N,i,count = 0;
    cin >> N;
    int arr[1000] = {};
    for (i = 1, N; count < N; i++)
    {
        if (i % 2 != 0)
        {            
            arr[count] = i;
            count += 1;

        }
    }

    for (i = 0; i < N; i++)
    {
        if (i + 1 == N)
        {
            cout << arr[i];
        }
        else
        {
            cout << arr[i] << ",";
        }
        
    }


}

