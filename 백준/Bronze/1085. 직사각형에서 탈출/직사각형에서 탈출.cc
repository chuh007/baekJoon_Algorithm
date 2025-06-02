#include<iostream>
using namespace std;

int main()
{
	int x, y, w, h;
	cin >> x >> y >> w >> h;
	int a = min(x, w - x);
	int b = min(y, h - y);
	cout << min(a, b);
}