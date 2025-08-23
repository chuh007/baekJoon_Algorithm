#include <iostream>
#include <climits>

using namespace std;
int main()
{
	int n, a, b, ans = INT_MAX;
	cin >> n;
	for (int i = 0; i < n; ++i)
	{
		cin >> a >> b;
		if (a <= b)
		{
			if (ans > b) ans = b;
		}
	}
	cout << (ans == INT_MAX ? -1 : ans);
}
