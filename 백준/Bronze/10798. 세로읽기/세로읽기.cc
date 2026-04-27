#include <iostream>
#include<vector>
using namespace std;

int main()
{
	vector<string> v(5);
	string s;
	for (int i = 0; i < 5; i++)
	{
		cin >> s;
		for (int j = 0; j < s.size(); j++)
		{
			v[i].push_back(s[j]);
		}
	}
	for (int i = 0; i < 15; i++)
	{
		for (int j = 0; j < 5; j++)
		{
			if (v[j].size() <= i) continue;
			cout << v[j][i];
		}
	}
}
