#include <iostream>
#include <queue>
using namespace std;

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.
    int n, m, a, b, inf = 10000;
    cin >> n >> m;
    int map[100][100];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            map[i][j] = (i == j) ? 0 : inf;
        }
    }
    for (int i = 0;i < m;i++)
    {
        cin >> a >> b;
        map[a - 1][b - 1] = 1;
        map[b - 1][a - 1] = 1;
    }
    for (int i = 0;i < n;i++)
    {
        for (int j = 0;j < n;j++)
        {
            for (int k = 0;k < n;k++)
            {
                if (map[j][i] + map[i][k] < map[j][k]) map[j][k] = map[j][i] + map[i][k];
            }
        }
    }
    int sum = 0, min = 1000000, answer = -1;
    for (int i = 0;i < n;i++)
    {
        sum = 0;
        for (int j = 0;j < n;j++)
        {
            sum += map[i][j];
        }
        if (sum < min) 
        {
            min = sum;
            answer = i;
        }
        answer = answer > sum ? i : answer;
    }
    cout << answer + 1;
    return 0;
}