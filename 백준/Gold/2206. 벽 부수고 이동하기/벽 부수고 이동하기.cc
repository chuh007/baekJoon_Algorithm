#include <iostream>
#include <queue>
using namespace std;

bool map[1000][1000];
bool isVisit1[1000][1000];
bool isVisit2[1000][1000];

int answer;

struct pos
{
    int y, x, time;
    bool canbreak;
};

void BFS(int n, int m)
{
    queue<pos> q;
    int dx[] = { -1,0,1,0 };
    int dy[] = { 0,1,0,-1 };
    q.push({ 0,0,1,true });
    isVisit1[0][0] = true;

    while (!q.empty())
    {
        pos cur = q.front();
        q.pop();
        if (cur.y == n - 1 && cur.x == m - 1)
        {
            answer = cur.time;
            return;
        }

        for (int i = 0; i < 4; ++i)
        {
            int ny = cur.y + dy[i];
            int nx = cur.x + dx[i];
            if (ny < 0 || ny >= n || nx < 0 || nx >= m) continue;
            if (map[ny][nx])
            {
                if (cur.canbreak && !isVisit1[ny][nx])
                {
                    q.push({ ny, nx, cur.time + 1, true });
                    isVisit1[ny][nx] = true;
                }
                else if (!cur.canbreak && !isVisit2[ny][nx])
                {
                    q.push({ ny, nx, cur.time + 1, false });
                    isVisit2[ny][nx] = true;
                }
            }
            else
            {
                if (cur.canbreak && !isVisit2[ny][nx])
                {
                    isVisit2[ny][nx] = true;
                    q.push({ ny, nx, cur.time + 1, false });
                }
            }
        }
    }
}

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int n, m;
    string s;
    answer = -1;
    cin >> n >> m;
    for (int i = 0; i < n; ++i)
    {
        cin >> s;
        for (int j = 0; j < m; ++j)
        {
            map[i][j] = s[j] == '0' ? true : false;
        }
    }
    BFS(n, m);
    cout << answer;
    return 0;
}