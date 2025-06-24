#include <iostream>
#include <vector>
#include <queue>

using namespace std;

int main()
{
	priority_queue<int, vector<int>, greater<int>> minHeap;
	int n, a, sum = 0, temp;
	long answer = 0;
	cin >> n;
	for (int i = 0; i < n; i++)
	{
		cin >> a;
		minHeap.push(a);
	}
	if (n == 1)
	{
		cout << 0;
		return 0;
	}
	while (minHeap.size() > 1)
	{
		temp = minHeap.top();
		minHeap.pop();
		temp += minHeap.top();
		minHeap.pop();
		answer += temp;
		minHeap.push(temp);
	}
	cout << answer;
	return 0;
}