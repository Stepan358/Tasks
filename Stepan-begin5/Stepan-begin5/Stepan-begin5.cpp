#include <iostream>

using namespace std;

int main()
{
	setlocale(LC_ALL, "RUSSIAN");
	int a;
	cin >> a;
	cout << "объём куба: " << a * a * a << endl << "площадь поверхности куба: " << a * a * 6;
 
	return 0;
}
