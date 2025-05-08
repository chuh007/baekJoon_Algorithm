#include <iostream>
#include <queue>
using namespace std;

char map[1000][1000];
bool isVisited[1000][1000];

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.
    int n, m;
    int dx[4] = { 1, -1, 0, 0 };
    int dy[4] = { 0, 0, 1, -1 };
    cin >> n >> m;
    queue<pair<int, int>> q;
    int cnt = 0;
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            cin >> map[i][j];
            if (map[i][j] == 'I') {
                q.push({ i, j });
                isVisited[i][j] = true;
            }
        }
    }
    while (!q.empty()) {
        auto now = q.front();
        q.pop();
        if (map[now.first][now.second] == 'P') cnt++;
        for (int dir = 0; dir < 4; dir++)
        {
            int nx = now.first + dx[dir];
            int ny = now.second + dy[dir];
            if (nx < 0 || ny < 0 || nx >= n || ny >= m) continue;
            if (isVisited[nx][ny]) continue;
            if (map[nx][ny] == 'X') continue;
            isVisited[nx][ny] = true;
            q.push({ nx,ny });
        }
    }
    if (cnt == 0) cout << "TT";
    else cout << cnt;
    return 0;
}