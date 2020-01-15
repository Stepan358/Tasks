#include <iostream>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");
	int num1, num2, num3, otr = 0, pol = 0;

	cin >> num1 >> num2 >> num3;
	if (num1 < 0)
	{
		otr++;
	}
	else
	{
		pol++;
	}
	if (num2 < 0)
	{
		otr++;
	}
	else
	{
		pol++;
	}
	if (num3 < 0)
	{
		otr++;
	}
	else
	{
		pol++;
	}
	cout << "отрицательных чисел:" << otr << endl << "положительных чисел:" << pol;
	return 0;
}
