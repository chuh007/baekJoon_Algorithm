#include <iostream>
#include <queue>
using namespace std;

struct Miro 
{
public:
    int x, y, time;
};

int map[100][100];
bool isVisited[100][100];

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.
    int n, m;
    string s;
    int dx[4] = { 1,-1,0,0 };
    int dy[4] = { 0,0,1,-1 };
    cin >> n >> m;
    for (int i = 0; i < n; i++) 
    {
        cin >> s;
        for (int j = 0; j < m; j++) 
        {
			if (s[j] == '0')
				map[i][j] = 0;
			else
				map[i][j] = 1;
        }
    }
    queue<Miro> q;
	q.push({ 0, 0, 1 });
    while (!q.empty()) {
        Miro miro = q.front();
        q.pop();
		if (miro.x == n - 1 && miro.y == m - 1) {
			cout << miro.time;
            break;
		}
        for (int dir = 0; dir < 4; dir++) {
            int nx = miro.x + dx[dir];
            int ny = miro.y + dy[dir];
            if (nx < 0 || ny < 0 || nx >= n || ny >= m) continue;
            if (isVisited[nx][ny]) continue;
            if (map[nx][ny] == 0) continue;
            isVisited[nx][ny] = true;
            q.push({nx, ny, miro.time + 1 });
        }
    }
    return 0;
}