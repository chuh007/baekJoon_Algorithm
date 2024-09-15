#include<iostream>
#include<string>
using namespace std;


int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.
    
    int N, M;
    string S;
    cin >> N >> M >> S;
    int answer = 0;
    int count = 0;
    for (int i = 0; i < M - 1; i++) {
        if (S[i] == 'I' && S[i + 1] == 'O' && i + 2 < M && S[i + 2] == 'I') {
            count++;
            i += 1;
            if (count == N) {
                answer++;
                count--;
            }
        }
        else {
            count = 0;
        }
    }
    cout << answer;

    return 0;
}
