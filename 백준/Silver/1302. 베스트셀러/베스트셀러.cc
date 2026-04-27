#include <iostream>
#include <map>
using namespace std;

int main()
{
	map<string, int> map;
	int a;
	cin >> a;
	string s;
	for (int i = 0; i < a; i++)
	{
		cin >> s;
		map[s]++;
	}
	string answer;
	int max = 0;
	for (auto i : map)
	{
		if (max < i.second)
		{
			answer = i.first;
			max = i.second;
		}
	}
	cout << answer;
}
