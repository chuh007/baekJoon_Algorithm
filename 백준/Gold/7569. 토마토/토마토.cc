#include <iostream>
#include <queue>
using namespace std;

struct Tomato 
{
public:
    int h, x, y, day;
};

int box[100][100][100];
bool isVisited[100][100][100];

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.
    int n, m, h;
    int dh[6] = { 0,0,0,0,1,-1 };
    int dx[6] = { -1,0,1,0,0,0 };
    int dy[6] = { 0,1,0,-1,0,0 };
    cin >> n >> m >> h;
    queue<Tomato> q;
    int cnt = 0;
    int maxDay = 0;
    for (int a = 0; a < h;a++) {
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                cin >> box[a][i][j];
                if (box[a][i][j] == 1) {
                    q.push({a, i, j, 0 });
                    isVisited[a][i][j] = true;
                }
                else if (box[a][i][j] == 0) cnt++;
            }
        }
    }
    
    while (!q.empty()) {
		Tomato tomato = q.front();
        q.pop();
        maxDay = max(maxDay, tomato.day);

        for (int dir = 0; dir < 6; dir++) {
            int nh = tomato.h + dh[dir];
            int nx = tomato.x + dx[dir];
            int ny = tomato.y + dy[dir];
            if (nh < 0 || nx < 0 || ny < 0 || nh >= h || nx >= m || ny >= n) continue;
            if (isVisited[nh][nx][ny]) continue;
            if (box[nh][nx][ny] != 0) continue;
            isVisited[nh][nx][ny] = true;
            cnt--;
            q.push({nh, nx, ny, tomato.day + 1 });
        }
    }
    cout << (cnt == 0 ? maxDay : -1) << '\n';
    return 0;
}