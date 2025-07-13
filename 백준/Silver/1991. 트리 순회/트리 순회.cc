#include <iostream>
using namespace std;

int tree[26][2];
bool isVisit[26];

void PreorderTraversal(int cur)
{
	cout << (char)(cur + 'A');
	if (tree[cur][0] != -19) PreorderTraversal(tree[cur][0]);
	if (tree[cur][1] != -19) PreorderTraversal(tree[cur][1]);
}

void InorderTraversal(int cur)
{
	if (tree[cur][0] != -19) InorderTraversal(tree[cur][0]);
	cout << (char)(cur + 'A');
	if (tree[cur][1] != -19) InorderTraversal(tree[cur][1]);
}

void PostorderTraversal(int cur)
{
	if (tree[cur][0] != -19) PostorderTraversal(tree[cur][0]);
	if (tree[cur][1] != -19) PostorderTraversal(tree[cur][1]);
	cout << (char)(cur + 'A');
}

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.
	
	int n;
	char a, b, c;
	cin >> n;
	for (int i = 0; i < n; ++i)
	{
		cin >> a >> b >> c;
		tree[a - 'A'][0] = b - 'A';
		tree[a - 'A'][1] = c - 'A';
	}
	PreorderTraversal(0);
	cout << '\n';
	InorderTraversal(0);
	cout << '\n';
	PostorderTraversal(0);
	return 0;
}