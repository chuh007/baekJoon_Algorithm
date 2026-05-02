#include<vector>
#include <queue>
using namespace std;

int dx[] = {0,0,-1,1};
int dy[] = {-1,1,0,0};
int dist[100][100];
bool isVisited[100][100];

struct xyv
{
    int x, y, v;
};

void BFS(int n, int m, vector<vector<int>>& maps)
{
    queue<xyv> q;
    q.push({0, 0, 1});
    
    while(!q.empty())
    {
        xyv cur = q.front();
        q.pop();
        dist[cur.y][cur.x] = cur.v;
        
        for(int i = 0; i < 4; ++i)
        {
            int nx = cur.x + dx[i];
            int ny = cur.y + dy[i];
            
            if(isVisited[ny][nx] || nx < 0 || nx >= m || ny < 0 || ny >= n)
                continue;
            if(maps[ny][nx] != 0)
            {
                q.push({nx, ny, cur.v+1});
                isVisited[ny][nx] = true;
            }
        }
    }
}

int solution(vector<vector<int> > maps)
{
    int answer = 0;
    BFS(maps.size(), maps[0].size(), maps);
    answer = dist[maps.size() - 1][maps[0].size() - 1];
    if(answer == 0) answer = -1;
    return answer;
}