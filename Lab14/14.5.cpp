// 14.5.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");
    cout << "5. Даны целые положительные числа A и B. Найти их наибольший общий делитель (НОД), используя алгоритм Евклида\n";
    int a, b, c, i;
    cout << "Введите число а и число b" << "\n";
    cin >> a;
    cin >> b;
    if (max(a,b) % min(a,b) == 0)
    {
        cout << "Наибольший общий делитель : " << min(a,b) << "\n";
        return 0;
    }

    else
    {
        int arr[1000] = { max(a,b), min(a,b) };
        for (i = 2; i < 1000; i++)
        {
            arr[i] = arr[i - 2] % arr[i - 1];
            if (arr[i] == 0)
            {
                cout << "Наибольший общий делитель этих чисел равен " << arr[i - 1] << "\n";
                return 0;
            }
        }


    }


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
