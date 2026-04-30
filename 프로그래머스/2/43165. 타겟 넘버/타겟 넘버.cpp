#include <string>
#include <vector>
#include <queue>

using namespace std;

struct a
{
    int idx;
    bool isPlus;
    int sum;
};

int BFS(vector<int> numbers, int target)
{
    int cnt = 0;
    queue<a> q;
    q.push({0, true, numbers[0]});
    q.push({0, false, -numbers[0]});
    
    while(!q.empty())
    {
        a cur = q.front();
        q.pop();
        
        if(cur.idx < numbers.size())
        {
            int next = cur.idx + 1;
            if(next == numbers.size())
            {
                if(cur.sum == target) cnt++;
                continue;
            }
            q.push({next, true, cur.sum + numbers[next]});
            q.push({next, false, cur.sum - numbers[next]});
        }
    }
    return cnt;
}

int solution(vector<int> numbers, int target) {
    int answer = BFS(numbers, target);
    return answer;
}