#include <iostream>
#include <algorithm>
#include <queue>
#include <cstring>
using namespace std;

int n;
int dist[16][16];
int dp[1 << 16][16]; // 비트 연산

int Traveling(int bitMask, int cur)
{
	if (bitMask == (1 << n) - 1)
	{
		if (dist[cur][0] == 0) return 1000000000; // 시작으로 못가면 걍 실패
		return dist[cur][0];
	}
	if (dp[bitMask][cur] != -1) return dp[bitMask][cur]; // dp 처리
	dp[bitMask][cur] = 1000000000;

	for (int i = 0; i < n; ++i)
	{
		if (bitMask & (1 << i) || dist[cur][i] == 0) // & 로 방문에 있는지 확인하기
			continue;
		// | 로 추가해서 재귀 돌리기
		dp[bitMask][cur] = min(dp[bitMask][cur], Traveling(bitMask | (1 << i), i) + dist[cur][i]);
	}
	return dp[bitMask][cur];
}

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	// 외판원 순회
	// 비트마스킹을 여기서 쓰는구나... 진짜 오랜만이고 참신하네
	// 여기쯤 되는 것들은 혼자서 풀기는 너무 힘들다.
	memset(dp, -1, sizeof(dp));

	cin >> n;

	for (int i = 0; i < n; ++i)
	{
		for (int j = 0; j < n; ++j)
		{
			cin >> dist[i][j];
		}
	}
	cout << Traveling(1, 0);

	return 0;
}