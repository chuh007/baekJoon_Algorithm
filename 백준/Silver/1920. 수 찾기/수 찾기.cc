#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

bool serach(vector<int>&v, int value)
{
	int top = v.size() - 1, bottom = 0, middle;
	while (bottom <= top)
	{
		middle = (top + bottom) / 2;
		if (value == v[middle]) return true;
		else if (value >= v[middle]) bottom = middle + 1;
		else top = middle - 1;
	}
	return false;
}

int main()
{
	ios::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);
	vector<int> v1;
	int a, b;
	cin >> a;
	for (int i = 0; i < a; i++)
	{
		cin >> b;
		v1.push_back(b);
	}
	sort(v1.begin(), v1.end());
	cin >> a;
	for (int i = 0; i < a; i++)
	{
		cin >> b;
		cout << serach(v1, b) << '\n';
	}
}
