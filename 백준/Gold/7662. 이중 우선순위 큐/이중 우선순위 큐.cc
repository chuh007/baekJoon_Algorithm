#include <iostream>
#include <map>
using namespace std;

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.
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