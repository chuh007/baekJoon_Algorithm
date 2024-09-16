#include<iostream>
#include<string>
#include<sstream>
#include<stack>
using namespace std;



int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    std::cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    ostringstream oss;
    stack<int> stack1;
    int n;
    cin >> n;
    int nowNum = 1;
    bool no = false;
    for (int i = 0; i < n; i++) {
        int input;
        cin >> input;
        while (nowNum <= input) {
            stack1.push(nowNum);
            nowNum++;
            oss << "+\n";
        }
        if (!stack1.empty() && stack1.top() == input) {
            stack1.pop();
            oss << "-\n";
        }
        else {
            no = true;
            break;
        }
    }
    if (no) {
        cout << "NO\n";
    }
    else {
        cout << oss.str();
    }

    return 0;
}