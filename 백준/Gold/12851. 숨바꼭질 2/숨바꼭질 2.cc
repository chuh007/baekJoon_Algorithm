#include <iostream>
#include <queue>
using namespace std;

bool isVisit[100001];
int timeArr[100001];

void BFS(int start, int end);

int main() {
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int n, k;
    cin >> n >> k;
    if (k < n)
    {
        cout << n - k << '\n';
        cout << 1;
    }
    else
    {
        BFS(n, k);
    }
    return 0;
}

void BFS(int start, int end)
{
    queue<pair<int,int>> q;
    int deep = 100000, answer = 0, count = 0;
    q.push({ start,0 });
    isVisit[start] = true;
    while (!q.empty())
    {
        int cur = q.front().first;
        int curdeep = q.front().second;
        q.pop();
        isVisit[cur] = true;
        if (cur == end)
        {
            if (deep > curdeep)
            {
                count = 1;
                answer = curdeep;
                deep = answer;
            }
            else if (deep == curdeep) count++;
        }
        else
        {
            if (cur + 1 <= 100000 && !isVisit[cur + 1])
            {
                timeArr[cur + 1] = timeArr[cur] + 1;
                q.push({cur + 1, curdeep + 1});
            }
            if (cur - 1 > 0 && !isVisit[cur - 1])
            {
                timeArr[cur - 1] = timeArr[cur] + 1;
                q.push({ cur - 1, curdeep + 1 });
            }
            if (cur * 2 <= 100000 &&!isVisit[cur * 2])
            {
                timeArr[cur * 2] = timeArr[cur] + 1;
                q.push({ cur * 2, curdeep + 1 });
            }
        }

    }
    cout << answer << '\n';
    cout << count;
}