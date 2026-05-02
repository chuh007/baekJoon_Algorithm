#include <string>
#include <vector>
#include <unordered_map>
#include <queue>

using namespace std;

// 모르겠네
// 그래프 그릴때 단어에서 글자 하나만 차이난 것들을 인접으로 표시해야하나
// 어떻게?
// 표시한 후에는 걍 최단거리긴 함
// 원시적인 방법 시도 짜피 범위 적음

unordered_map<string, int> mapper; // 인덱스 매핑용
vector<vector<int>> graph; // 매핑 인덱스 기반 인접 리스트
bool visit[50];
int dist[50];

void SetUp(vector<string>& words)
{
    graph.resize(words.size());
    for (int i = 0; i < words.size(); ++i) // 모든 단어에 대해서
    {
        mapper[words[i]] = i;
        for (int j = 0; j < words.size(); ++j) // 모든 단어와 비교하며
        {
            if (i == j) continue;
            int cnt = 0;
            for (int k = 0; k < words[i].size(); ++k) // 각각의 글자가 같은지를 비교한다
            {
                if (words[i][k] != words[j][k]) cnt++;
            }
            if (cnt == 1) graph[i].push_back(j);
        }
    }
}

void BFS(int a)
{
    queue<int> q;
    q.push(a);
    visit[a] = true;
    while (!q.empty())
    {
        int cur = q.front();
        q.pop();

        for (int i : graph[cur])
        {
            if (!visit[i])
            {
                q.push(i);
                visit[i] = true;
                dist[i] = dist[cur] + 1;
            }
        }
    }
}

int solution(string begin, string target, vector<string> words) {
    int answer = 0;
    words.push_back(begin);
    SetUp(words);
    BFS(mapper[begin]);
    answer = dist[mapper[target]];
    for (auto s : words)
    {
        if (s == target) return answer;
    }

    return 0;
}
