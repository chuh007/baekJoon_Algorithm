#include<iostream>
#include<string>
#include<algorithm>
#include<vector>
using namespace std;


int main()
{
    int N, M;
    string S;
    cin >> N >> M>>S;
    string wow = "I";
    for (int i = 0;i < N;i++) {
        wow += "OI";
    }
    int answer = 0;
    while (S.find(wow)!=string::npos)
    {
         S.erase(S.find(wow),2);
         answer++;
    }
    cout << answer;
    return 0;
}