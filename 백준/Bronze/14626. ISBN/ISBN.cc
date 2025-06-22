#include <iostream>
using namespace std;

int main()
{
	int sum = 0;
	int a = 0;
	char carr[13];
	int pos = 0;

	for (int i = 0; i < 13; i++)
	{
		cin >> carr[i];
		if (carr[i] == '*') pos = i;
	}

	for (int i = 0; i < 13; i++)
	{
		if (!(carr[i] == '*'))
		{
			sum += (carr[i] - '0') * (i % 2 == 0 ? 1 : 3);
		}
	}

	for (int i = 0; i < 10; i++)
	{
		if ((sum + i * (pos % 2 == 0 ? 1 : 3)) % 10 == 0)
			cout << i;
	}
}