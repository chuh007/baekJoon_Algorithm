#include <iostream>
#include <vector>

using namespace std;

int main()
{
	int a;
	cin >> a;
	for (int t = 0;t < a;t++)
	{
		int n, m, x, y, topx = -10000000, bottomx = 10000000, topy = -10000000, bottomy = 10000000, j, cnt = 0;
		vector<pair<int, int>> pv;
		cin >> n >> m;
		for (int i = 0;i < n;i++)
		{
			cin >> x >> y;
			pv.push_back({ x,y });
		}
		for (int i = 0;i < m;i++)
		{
			cin >> n;
			topx = topx > pv[n - 1].first ? topx : pv[n - 1].first;
			bottomx = bottomx < pv[n - 1].first ? bottomx : pv[n - 1].first;
			topy = topy > pv[n - 1].second ? topy : pv[n - 1].second;
			bottomy = bottomy < pv[n - 1].second ? bottomy : pv[n - 1].second;
		}
		for (auto xy : pv)
		{
			if (xy.first >= bottomx && xy.first <= topx
				&& xy.second >= bottomy && xy.second <= topy) cnt++;
		}
		cout << "Data Set " << t + 1 << ":\n" << cnt << "\n\n";
	}
}