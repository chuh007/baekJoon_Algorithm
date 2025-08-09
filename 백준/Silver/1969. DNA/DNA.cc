#include <iostream>
#include <vector>
#include <unordered_map>
using namespace std;


int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int n, m, dist = 0, maxcnt = 0;
    string s;
    vector<string> DNAs;
    vector<char> answer;
    cin >> n >> m;
    for (int i = 0; i < n; ++i)
    {
        cin >> s;
        DNAs.push_back(s);
    }
    for (int i = 0; i < m; ++i)
    {
        unordered_map<char, int> map;
        maxcnt = 0;
        char maxchar = 'Z';
        answer.push_back('A');
        for (int j = 0; j < n; ++j)
        {
            map[DNAs[j][i]]++;
            if (maxcnt == map[DNAs[j][i]] && maxchar > DNAs[j][i])
            {
                maxcnt = map[DNAs[j][i]];
                maxchar = DNAs[j][i];
                answer[i] = DNAs[j][i];
            }
            else if (maxcnt < map[DNAs[j][i]])
            {
                maxcnt = map[DNAs[j][i]];
                maxchar = DNAs[j][i];
                answer[i] = DNAs[j][i];
            }
        }
        dist += n - maxcnt;
    }
    for (int i = 0; i < m; ++i)
    {
        cout << answer[i];
    }
    cout << '\n' << dist;

    return 0;
}