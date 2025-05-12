#include <iostream>
#include <queue>
using namespace std;

int main()
{
	queue<int> q;
	int n, k;
	cin >> n >> k;
	for (int i = 1; i <= n; i++) 
	{
		q.push(i);
	}
	int idx = 1, temp;
	cout << "<";
	while (!q.empty())
	{
		if (idx >= k)
		{
			cout << q.front();
			q.pop();
			if (!q.empty()) cout << ", ";
			idx = 1;
		}
		else
		{
			if (q.empty()) break;
			temp = q.front();
			q.pop();
			q.push(temp);
			idx++;
		}
	}
	cout << ">";
}
