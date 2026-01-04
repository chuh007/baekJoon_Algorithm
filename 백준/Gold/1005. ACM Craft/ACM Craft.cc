#include <iostream>
#include <queue>
using namespace std;

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	int T, N, K, x, y, w;
	int* dArr = new int[1001]();
	int* time = new int[1001];
	bool** list = new bool* [1001];
	for (int i = 0; i < 1001; i++)
	{
		list[i] = new bool[1001]();
	}
	bool isZero = true;
	queue<int> q;
	cin >> T;
	for (int t = 0;t < T; t++) // 테스트 케이스만큼 반복
	{
		cin >> N >> K;
		for (int i = 1; i <= N; i++)
		{
			cin >> dArr[i];
			time[i] = dArr[i];
		}
		for (int i = 0; i < K; i++)
		{
			cin >> x >> y;
			list[x][y] = 1;
		}
		// 여기까지 입력받기

		for (int i = 1; i <= N; i++) // 초기 진입차수 0인 애들 찾기
		{
			isZero = true;
			for (int j = 1; j <= N; j++)
			{
				if (list[j][i] == 1)
				{
					isZero = false;
					break;
				}
			}
			if (isZero == true)
			{
				q.push(i); // 찾은 애들 큐에 넣기
			}
		}
		cin >> w; // 건설할 건물
		while (!q.empty())
		{
			int v = q.front();
			q.pop();
			for (int i = 1;i <= N;i++) // 이 노드와 연결된 노드 진입차수 감소
			{
				if (list[v][i] == 1)
				{
					list[v][i] = 0;
					isZero = true;
					for (int j = 1; j <= N; j++)
					{
						if (list[j][i] == 1)
						{
							isZero = false;
							break;
						}
					}
					dArr[i] = max(dArr[i], dArr[v] + time[i]);
					if (isZero == true)
					{
						q.push(i);
					}
				}
			}
		}
		cout << dArr[w] << "\n";

	}
	delete[] dArr;
	delete[] time;
	for (int i = 0; i < 1001; i++)
	{
		delete[] list[i];
	}
	delete[] list;
}
