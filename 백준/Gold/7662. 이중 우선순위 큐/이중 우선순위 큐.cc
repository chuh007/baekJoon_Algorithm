#include <iostream>
#include <map>
using namespace std;

int main()
{
	int T, k, n;
	char c;
	cin >> T;
	for (int t = 0; t < T; t++)
	{
		map<int, int> map;
		cin >> k;
		for (int i = 0;i < k;i++)
		{
			cin >> c >> n;
			if (c == 'I')
			{
				map[n]++;
			}
			else
			{
				if (map.size() == 0) continue;
				if (n == 1)
				{
					prev(map.end())->second--;
					if (prev(map.end())->second <= 0)
					{
						map.erase(prev(map.end()));
					}
	
				}
				else
				{
					map.begin()->second--;
					if (map.begin()->second <= 0)
					{
						map.erase(map.begin());
					}
				}
			}
		}
		if (map.size() == 0)
		{
			cout << "EMPTY\n";
		}
		else
		{
			cout << prev(map.end())->first << ' ' << map.begin()->first << '\n';
		}
	}
	return 0;
}