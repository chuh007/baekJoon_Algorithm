#include <iostream>
#include <set>
#include <unordered_map>

using namespace std;



int main()
{
	cin.tie(NULL);
	cout.tie(NULL);
	ios::sync_with_stdio(false);

	multiset<pair<int, int>> set;
	unordered_map<int, int> map;
	int n, p, l, m;
	string s;
	cin >> n;
	for (int i = 0; i < n; ++i)
	{
		cin >> p >> l;
		set.insert({ l,p });
		map[p] = l;
	}
	cin >> m;
	for (int i = 0; i < m; ++i)
	{
		cin >> s >> p;
		switch (s[0])
		{
			case 'r':
				if (p == 1) cout << prev(set.end())->second << '\n';
				else cout << set.begin()->second << '\n';
				break;
			case 'a':
				cin >> l;
				set.insert({ l,p });
				break;
			case 's':
				set.erase({ map[p], p});
				break;
		}
	}
}