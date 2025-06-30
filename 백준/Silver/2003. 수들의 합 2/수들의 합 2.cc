#include <iostream>
using namespace std;

int main()
{
	int n, m, j = 0, cnt = 0, temp;
	cin >> n >> m;

	int* arr = new int[n + 1];
	arr[0] = 0;
	for (int i = 1; i <= n; ++i)
	{
		cin >> arr[i];
		arr[i] += arr[i - 1];
	}
	for (int i = 1;i <= n;i++)
	{
		while (arr[i] - arr[j] > m)
		{
			j++;
		}
		if (arr[i] - arr[j] == m)
		{
			j++;
			cnt++;
		}
	}
	cout << cnt;
	return 0;
}