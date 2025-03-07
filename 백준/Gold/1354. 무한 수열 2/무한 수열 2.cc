#include <iostream>
#include <unordered_map>
using namespace std;

unordered_map<long, long> nodes;
long n, p, q, x, y;

long A(long now) {
	if(now <= 0) return 1;
	else if (nodes.count(now) > 0) return nodes[now];
	nodes[now] = A(now / p - x) + A(now / q - y);
	return nodes[now];
}
int main()
{
	nodes[0] = 1;
	cin >> n >> p >> q >> x >> y;
	cout << A(n);
}