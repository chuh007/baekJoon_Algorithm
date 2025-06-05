#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int sum(vector<int>&v1, vector<int>& v2)
{
	int sum = 0;
	for (auto i : v2)
	{
		sum -= upper_bound(v1.begin(), v1.end(), i) - v1.end();
	}
	return sum;
}

int main()
{
	ios::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);
	int T;
	int a, b, c;
	cin >> T;
	for (int t = 0; t < T; t++)
	{
		vector<int> v1, v2;
		cin >> a >> b;
		for (int i = 0; i < a; i++)
		{
			cin >> c;
			v1.push_back(c);
		}
		for (int i = 0; i < b; i++)
		{
			cin >> c;
			v2.push_back(c);
		}
		sort(v1.begin(), v1.end());
		cout << sum(v1, v2) << '\n';
	}

}
