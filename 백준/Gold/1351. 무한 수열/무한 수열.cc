#include <iostream>
#include <map>
using namespace std;

map<long, long> nodes;
long n, p, q;

static long A(long now) {
	if (nodes.count(now) > 0)
	{
		return nodes[now];
	}
	else
	{
		nodes[now] = A(now / p) + A(now / q);
		return nodes[now];
	}
}
int main()
{
	nodes[0] = 1;
	cin >> n >> p >> q;
	cout << A(n);
}
