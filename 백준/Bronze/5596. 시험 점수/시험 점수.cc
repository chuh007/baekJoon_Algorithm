
#include <iostream>
#include <string>
using namespace std;
int main()
{
	int a1, a2, a3, a4;
	int b1, b2, b3, b4;
	cin >> a1 >> a2 >> a3 >> a4;
	cin >> b1 >> b2 >> b3 >> b4;
	int a = a1 + a2 + a3 + a4;
	int b = b1 + b2 + b3 + b4;
	cout << (a > b ? a : b);
}
