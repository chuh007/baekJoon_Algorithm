#include <string>
#include <vector>
#include <queue>
using namespace std;
vector<vector<int>> graph;

bool visit[200];

void BFS(int a)
{
    queue<int> q;
    q.push(a);
    visit[a] = true;
    while(!q.empty())
    {
        int cur = q.front();
        q.pop();
        for(int i = 0; i < graph[cur].size(); ++i)
        {
            if(graph[cur][i] == 1 && !visit[i])
            {
                q.push(i);
                visit[i] = true;
            }
        }
    }
}
int solution(int n, vector<vector<int>> computers) {
    int answer = 0;
    graph = computers;
    for(int i = 0; i < n; ++i)
    {
        if(!visit[i])
        {
            BFS(i);
            answer++;
        }
    }
    
    return answer;
}