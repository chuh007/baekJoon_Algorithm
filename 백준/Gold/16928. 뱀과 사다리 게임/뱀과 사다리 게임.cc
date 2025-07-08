#include <iostream>
#include <queue>
#include <algorithm>

using namespace std;

int arr[101];
bool isvisit[101] = {};

int BFS(int start)
{
	int cnt = 1;
	queue<pair<int, int>> q;
	q.push({ start, 0 });
	isvisit[start] = true;
	while (!q.empty())
	{
		int cur = q.front().first;
		int curcnt = q.front().second;
		q.pop();
		if (cur == 100) return curcnt;
		for (int i = 1; i <= 6; ++i)
		{
			int next = cur + i;
			if (next > 100) continue;
			if (arr[next] != 0) next = arr[next];
			if (!isvisit[next])
			{
				isvisit[next] = true;
				q.push({ next, curcnt + 1 });
			}
		}
	}
}

int main()
{
	fill(arr, arr + 101, 0);
	int n, m, x, y;
	cin >> n >> m;
	for (int i = 0; i < n + m; ++i)
	{
		cin >> x >> y;
		arr[x] = y;
	}
	cout << BFS(1);
	return 0;
}