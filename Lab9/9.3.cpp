﻿// 9.3.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;
int main()
{
    string arr[] = { "воскресенье","понедельник", "вторник", "среда", "четверг", "пятница", "суббота" };
    string arr1[] = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота","воскресенье" };
    setlocale(LC_ALL, "Russian");
    cout << "3. Дни недели пронумерованы следующим образом: 1 — понедельник, 2 — вторник, . . . , 6 — суббота, 7 — воскресенье. Дано целое число K, лежащее в диапазоне 1–365, и целое число N, лежащее в диапазоне 1–7. Определить номер дня недели для K-го дня года, если известно, что в этом году 1 января было днем недели с номером N\n";
    cout << "Введите день" << "\n";
    int N;
    cout << "Введите день недели 1-ого января" << "\n";
    cin >> N;
    cout << "Пусть 1 января это " << arr1[N-1] <<  "\n";
    float K;
    cout << "Введите номер дня" << "\n";
    cin >> K;
    float N1 = 7 - (N - 1);
    int otvet = (K - N1) - 7 * floor((K - N1) / 7);
    cout << "В этот день " << arr[otvet];
    


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